using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoulsFormats;

namespace SFExtractor
{
    internal static class Converter
    {
        public static void Convert(string path)
        {
            if (TPF.Is(path)) ConvertTPF(path);
        }

        public static void ConvertTPF(string path)
        {
            TPF tpf = TPF.Read(path);
            foreach (TPF.Texture texture in tpf.Textures)
            {
                byte[] dds = texture.Headerize();
                File.WriteAllBytes($"{Path.GetDirectoryName(path)}/{texture.Name}.dds", dds);
            }
        }
    }
}
