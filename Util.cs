using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SFExtractor
{
    internal static class Util
    {
        public static string envFolderPath = $"{Environment.CurrentDirectory}/";
        public static string resFolderPath = $"{Environment.CurrentDirectory}/res/";
        public static string log = $"{envFolderPath}/sfextractor.log";
        public static string stacktraceLog = $"{envFolderPath}/stacktrace.log";

        /// <summary>
        /// Get a single file from the user.
        /// </summary>
        /// <param name="context">An optional argument of a string containing context of what file you want to ask the user to open</param>
        /// <param name="filters">The filetype filters to apply in the dialog box set to all files by default</param>
        /// <returns>A string containing the path to a file the user selects</returns>
        public static string GetFilePath(string context, string filters = "All files (*.*)|*.*")
        {
            OpenFileDialog filePathDialog = new()
            {
                InitialDirectory = "C:\\Users",
                Title = $"Select your {context}",
                Filter = filters
            };

            if (filePathDialog.ShowDialog() == DialogResult.OK)
            {
                return filePathDialog.FileName;
            }

            return null;
        }

        /// <summary>
        /// Get a single folder from the user.
        /// </summary>
        /// <param name="context">An optional argument of a string containing context of what folder you want to ask the user to open</param>
        /// <returns>A string containing the path to a folder the user selects</returns>
        public static string GetFolderPath(string context)
        {
            CommonOpenFileDialog filePathDialog = new()
            {
                InitialDirectory = "C:\\Users",
                IsFolderPicker = true,
                Title = $"Select your {context}",
            };

            if (filePathDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                return filePathDialog.FileName;
            }

            return null;
        }

        /// <summary>
        /// Get a multiple files from the user.
        /// </summary>
        /// <param name="context">An optional argument of a string containing context of what files you want to ask the user to open</param>
        /// <param name="filters">The filetype filters to apply in the dialog box set to all files by default</param>
        /// <returns>A string array containing all the paths the user selects</returns>
        public static List<string> GetFilePaths(string context, string filters = "All files (*.*)|*.*")
        {
            OpenFileDialog filePathDialog = new()
            {
                InitialDirectory = "C:\\Users",
                Multiselect = true,
                Title = $"Select your {context}",
                Filter = filters
            };

            if (filePathDialog.ShowDialog() == DialogResult.OK)
            {
                List<string> filePathList = new();
                foreach (string filePath in filePathDialog.FileNames)
                {
                    filePathList.Add(filePath);
                }
                return filePathList;
            }

            return null;
        }

        /// <summary>
        /// Get a save path from the user.
        /// </summary>
        /// <param name="context">An optional argument of a string containing context of what you want to ask the user to save</param>
        /// <returns>A string containing the path where the user wants to save a file</returns>
        public static string GetSavePath(string context)
        {
            SaveFileDialog saveFileDialog = new()
            {
                InitialDirectory = "C:\\Users",
                Title = $"Choose where to save {context}"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                return saveFileDialog.FileName;
            }

            return null;
        }
    }
}
