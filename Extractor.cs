using System;
using System.IO;
using SoulsFormats;
using SoulsFormats.AC4;

namespace SFExtractor
{
    internal static class Extractor
    {
        /// <summary>
        /// Extract a BND3 file from a given path
        /// </summary>
        /// <param name="path">A string containing the path to a BND3 file</param>
        public static void ExtractBND3(string path)
        {
            BND3 bnd3 = BND3.Read(path);
            string sourceDir = Path.GetDirectoryName(path);
            string filename = Path.GetFileName(path);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (BinderFile file in bnd3.Files)
            {
                string outPath = $@"{targetDir}\{file.Name.Replace('/', '\\')}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }

        /// <summary>
        /// Extract a BND4 file from a given path
        /// </summary>
        /// <param name="path">A string containing the path to a BND4 file</param>
        public static void ExtractBND4(string path)
        {
            BND4 bnd4 = BND4.Read(path);
            string sourceDir = Path.GetDirectoryName(path);
            string filename = Path.GetFileName(path);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (BinderFile file in bnd4.Files)
            {
                string outPath = $@"{targetDir}\{file.Name.Replace('/', '\\')}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }

        /// <summary>
        /// Decompress a DCX file from a given path
        /// </summary>
        /// <param name="path">A string containing the path to a DCX file</param>
        public static void ExtractDCX(string path)
        {
            byte[] dcx = DCX.Decompress(path);
            string sourceDir = Path.GetDirectoryName(path);
            string filename = Path.GetFileNameWithoutExtension(path);
            File.WriteAllBytes($"{sourceDir}\\{filename}-extracted-dcx", dcx);
        }

        /// <summary>
        /// Extract a BDT file with its BHD5 file from given paths
        /// </summary>
        /// <param name="bhd5Path">A string containing the path to a BHD5 file</param>
        /// <param name="bdtPath">A string containing the path to a BDT file to open with the chosen BHD5 file</param>
        /// <param name="version">The game version of the BHD5</param>
        public static void ExtractBHD5(string bhd5Path, string bdtPath, BHD5.Game version)
        {
            BHD5 bhd5 = BHD5.Read(bhd5Path, version);
            FileStream bdtStream = File.OpenRead(bdtPath);
            string sourceDir = Path.GetDirectoryName(bhd5Path);
            string filename = Path.GetFileName(bhd5Path);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (BHD5.Bucket bucket in bhd5.Buckets)
            {
                foreach (BHD5.FileHeader header in bucket)
                {
                    byte[] file = header.ReadFile(bdtStream);
                    string outPath = $@"{targetDir}\{header.FileNameHash}";
                    Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                    File.WriteAllBytes(outPath, file);
                }
            }
        }

        /// <summary>
        /// Extract a BDT file with its BXF3 file from given paths
        /// </summary>
        /// <param name="bxfPath">A string containing the path to a BXF3 file</param>
        /// <param name="bdtPath">A string containing the path to a BDT file to open with the chosen BXF3 file</param>
        public static void ExtractBXF3(string bxfPath, string bdtPath)
        {
            BXF3 bxf = BXF3.Read(bxfPath, bdtPath);
            string sourceDir = Path.GetDirectoryName(bxfPath);
            string filename = Path.GetFileName(bxfPath);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (BinderFile file in bxf.Files)
            {
                string outPath = $@"{targetDir}\{file.Name.Replace('/', '\\')}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }

        /// <summary>
        /// Extract a BDT file with its BXF4 file from given paths
        /// </summary>
        /// <param name="bxfPath">A string containing the path to a BXF3 file</param>
        /// <param name="bdtPath">A string containing the path to a BDT file to open with the chosen BXF4 file</param>
        public static void ExtractBXF4(string bxfPath, string bdtPath)
        {
            BXF4 bxf = BXF4.Read(bxfPath, bdtPath);
            string sourceDir = Path.GetDirectoryName(bxfPath);
            string filename = Path.GetFileName(bxfPath);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (BinderFile file in bxf.Files)
            {
                string outPath = $@"{targetDir}\{file.Name.Replace('/', '\\')}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }

        /// <summary>
        /// Extract a singular Zero3 file from a given path
        /// </summary>
        /// <param name="path">A string containing the path to a singular Zero3 file</param>
        public static void ExtractZero3(string path)
        {
            Zero3 zero3 = Zero3.Read(path);
            string sourceDir = Path.GetDirectoryName(path);
            string filename = Path.GetFileName(path);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (Zero3.File file in zero3.Files)
            {
                string outPath = $@"{targetDir}\{file.Name.Replace('/', '\\')}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }

        /// <summary>
        /// Attempt to extract a BND0 with many different BND0 types
        /// </summary>
        /// <param name="path">A string containing the path to a BND0 file</param>
        public static void ExtractBND0(string path)
        {
            try { ExtractBND0_ACE3(path); }
            catch
            {
                try { ExtractBND0_Kuon(path); }
                catch
                {
                    try { ExtractDVDBND0_Kuon(path); }
                    catch 
                    {
                        try { ExtractBND0_ACNB(path); }
                        catch{ throw; }
                    }
                }
            }
        }

        /// <summary>
        /// Extract a ACE3 BND0 file from a given path
        /// </summary>
        /// <param name="path">A string containing the path to a ACE3 BN0 file</param>
        public static void ExtractBND0_ACE3(string path)
        {
            var bnd0 = SoulsFormats.ACE3.BND0.Read(path);
            string sourceDir = Path.GetDirectoryName(path);
            string filename = Path.GetFileName(path);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (var file in bnd0.Files)
            {
                string outPath = $@"{targetDir}\{file.ID}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }

        /// <summary>
        /// Extract a Kuon BND0 file from a given path
        /// </summary>
        /// <param name="path">A string containing the path to a Kuon BND4 file</param>
        public static void ExtractBND0_Kuon(string path)
        {
            var bnd0 = SoulsFormats.Kuon.BND0.Read(path);
            string sourceDir = Path.GetDirectoryName(path);
            string filename = Path.GetFileName(path);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (var file in bnd0.Files)
            {
                string outPath = $@"{targetDir}\{file.ID}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }

        /// <summary>
        /// Extract a AC3 BND0 file from a given path
        /// </summary>
        /// <param name="path">A string containing the path to a AC3 BND4 file</param>
        public static void ExtractBND0_ACNB(string path)
        {
            var bnd0 = SoulsFormats.AC3.BND0.Read(path);
            string sourceDir = Path.GetDirectoryName(path);
            string filename = Path.GetFileName(path);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (var file in bnd0.Files)
            {
                string name = file.Name;
                name ??= $"{file.ID}";
                string outPath = $@"{targetDir}-bnd0\{name}";
                Console.WriteLine(outPath);
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }

        /// <summary>
        /// Extract a Kuon DVDBND0 file from a given path
        /// </summary>
        /// <param name="path">A string containing the path to a Kuon DVDBND0 file</param>
        public static void ExtractDVDBND0_Kuon(string path)
        {
            var bnd0 = SoulsFormats.Kuon.DVDBND0.Read(path);
            string sourceDir = Path.GetDirectoryName(path);
            string filename = Path.GetFileName(path);
            string targetDir = $"{sourceDir}\\{filename.Replace('.', '-')}";
            foreach (var file in bnd0.Files)
            {
                string outPath = $@"{targetDir}\{file.ID}";
                Directory.CreateDirectory(Path.GetDirectoryName(outPath));
                File.WriteAllBytes(outPath, file.Bytes);
            }
        }
    }
}
