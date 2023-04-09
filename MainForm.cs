using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using SoulsFormats;
using SoulsFormats.AC4;

namespace SFExtractor
{
    public partial class MainForm : Form
    {
        // MainForm Constructor
        public MainForm()
        {
            InitializeComponent();
            // Use override to change colors of selected Strip items to dark mode and disable shadows
            OverrideToolStripRenderer toolStripOverrideRenderer = new();
            MainFormMenuStrip.Renderer = toolStripOverrideRenderer;

            // Disable Shadows on Dropdowns
            FileMS.DropDown.DropShadowEnabled = false; // TODO: Fix random location changing when shadow is disabled
            HelpMS.DropDown.DropShadowEnabled = false;

            // Disable image beside menu strip sub items
            ((ToolStripDropDownMenu)FileMS.DropDown).ShowImageMargin = false;
            ((ToolStripDropDownMenu)HelpMS.DropDown).ShowImageMargin = false;

            Logger.CreateLog();
        }

        private void UnpackMS_Click(object sender, EventArgs e)
        {
            string[] paths = Util.GetFilePaths("compressed SoulsFormats file to extract",
                "BND3 file (*.bnd)|*.bnd|" +
                "BND3 file (*.bin)|*.bin|" +
                "BND4 file (*.bnd)|*.bnd|" +
                "BND4 file (*.bin)|*.bin|" +
                "DCX file (*.dcx)|*.dcx|" +
                "BXF3 file (*.bhd)|*.bhd|" +
                "BXF4 file (*.bhd)|*.bhd|" +
                "BHD5 file (*.bhd)|*.bhd|" +
                "BHD5 file (*.bhd5)|*.bhd5|" +
                "Zero3 file (*.000)|*.000|" +
                "All files (*.*)|*.*"
            );

            if (paths == null) return;
            IterateFilesExtract(paths);
        }

        // Help the user discover file type by using SoulsFile.Is() methods
        private void DetectTypeFMS_Click(object sender, EventArgs e)
        {
            string[] paths = Util.GetFilePaths("Select files you wish to detect the type of");
            if (paths == null) return;
            IterateFilesDetect(paths);
        }

        // TODO: Show About form message
        private void AboutHMS_Click(object sender, EventArgs e)
        {

        }

        // When someone attempts to drag a file into the window get the data from the dragged in files
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        // Check drag and dropped files
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (DetectionModeOMS.Checked) IterateFilesDetect(paths);
            else IterateFilesExtract(paths);
        }

        // Iterate files for detection
        // This happens in the detect type button and in drag and drop so I made a method here for it
        private void IterateFilesDetect(string[] paths)
        {
            string results = "";
            foreach (string path in paths)
            {
                // Get all the files in directories and add them to the paths to check
                if (Directory.Exists(path))
                {
                    string[] dirPaths = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                    IterateFilesDetect(dirPaths);
                }

                string filetype = Detector.Detect(path);
                if (filetype == "DCX")
                {
                    string compressedFileType = Detector.DetectDCX(path);
                    results += $"\n{Path.GetFileName(path)} is {compressedFileType} compressed with DCX";
                    continue;
                }

                results += $"\n {Path.GetFileName(path)} is {filetype}";
            }

            MessageBox.Show(results);
        }

        // Iterate files for extraction
        // This happens in the extract button and in drag and drop so I made a method here for it
        private void IterateFilesExtract(string[] paths)
        {
            foreach (string path in paths)
            {
                // Get all the files in directories and add them to the paths to check
                if (Directory.Exists(path))
                {
                    string[] dirPaths = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                    paths.Concat(dirPaths);
                    continue;
                }

                // Check for file types that need more than one file or continue checking through file types that need only one file
                if (BXF3.IsBHD(path))
                {
                    string filefilter = "BDT file (*.bdt)|*.bdt|BDT file (*.bin)|*.bin|All files (*.*)|*.*";
                    string bdtPath = Util.GetFilePath($"Select matching BDT file to open with {Path.GetFileName(path)}", filefilter);
                    Extractor.ExtractBXF3(path, bdtPath);
                }
                else if (BXF4.IsBHD(path))
                {
                    string filefilter = "BDT file (*.bdt)|*.bdt|BDT file (*.bin)|*.bin|All files (*.*)|*.*";
                    string bdtPath = Util.GetFilePath($"Select matching BDT file to open with {Path.GetFileName(path)}", filefilter);
                    Extractor.ExtractBXF3(path, bdtPath);
                }
                else if (BHD5.IsBHD(path))
                {
                    string filefilter = "BDT file (*.bdt)|*.bdt|BDT file (*.bin)|*.bin|All files (*.*)|*.*";
                    string bdtPath = Util.GetFilePath($"Select matching BDT file to open with {Path.GetFileName(path)}", filefilter);
                    Extractor.ExtractBXF3(path, bdtPath);
                }
                else
                {
                    Detector.DetectExtract(path);
                }
            }
        }

        private void RepackFMS_Click(object sender, EventArgs e)
        {

        }
    }
}
