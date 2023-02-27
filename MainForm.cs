using System;
using System.IO;
using System.Windows.Forms;
using SoulsFormats;

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

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        // Decompresses multiple file types
        private void ExtractFileMS_Click(object sender, EventArgs e)
        {
            string path = Util.GetFilePath("compressed SoulsFormats file to extract",
                "BND0/3/4 file (*.bnd)|*.bnd|" +
                "BND0/3/4 file (*.bin)|*.bin|" +
                "BXF3/4 file (*.bhd)|*.bhd|" +
                "BHD5 file (*.bhd)|*.bhd|" +
                "BHD5 file (*.bhd5)|*.bhd5|" +
                "Zero3 file (*.000)|*.000|" +
                "All files (*.*)|*.*"
            );

            if (path == null) return;
            Extractor.Extract(path);
            MainFormStatus.Text = $"Extraction completed, check {Path.GetFileName(Util.log)}";
        }

        // When someone attempts to drag a file into the window
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        // Check the dropped item
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] paths = (string[])e.Data.GetData(DataFormats.FileDrop);
            MainFormStatus.Text = "Extracting....";
            foreach (string path in paths)
            {
                if (Directory.Exists(path))
                {
                    MainFormStatus.Text = "Cannot recurse through folders yet or repack, skipping";
                    Logger.LogWithDate("Cannot recurse through folders yet or repack, skipping");
                    continue;
                }

                if (BHD5.IsBDT(path) || BXF3.IsBDT(path) || BXF4.IsBDT(path))
                {
                    MainFormStatus.Text = $"Cannot read BDT file {Path.GetFileName(path)} directly, provide BHD5/BXF3/BXF4 first, skipping";
                    Logger.LogWithDate($"Cannot read BDT file {Path.GetFileName(path)} directly, provide BHD5/BXF3/BXF4 first, skipping");
                    continue;
                }

                MainFormStatus.Text = $"Extracting {Path.GetFileName(path)}";
                Extractor.Extract(path);
            }
            MainFormStatus.Text = $"Extraction for all files dropped finished, check {Util.log} for results and errors";
            Logger.LogWithDate("Extraction for all files dropped finished");
        }

        // TODO: Show About form message
        private void AboutHMS_Click(object sender, EventArgs e)
        {

        }
    }
}
