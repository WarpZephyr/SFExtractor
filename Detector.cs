using SoulsFormats;
using SoulsFormats.AC4;
using SoulsFormats.ACE3;
using SoulsFormats.Other;

namespace SFExtractor
{
    internal static class Detector
    {
        /// <summary>
        /// Detects the correct type for a single file and sends it to the correct extraction or conversion method
        /// </summary>
        /// <param name="path">A string containing the path to a file to be extracted or converted</param>
        public static void DetectExtract(string path)
        {
            if (BND3.Is(path)) Extractor.ExtractBND3(path);
            else if (BND4.Is(path)) Extractor.ExtractBND4(path);
            else if (DCX.Is(path)) Extractor.ExtractDCX(path);
            else if (Zero3.Is(path)) Extractor.ExtractZero3(path);
            else if (BND0.Is(path)) Extractor.ExtractBND0(path);
            //else if (TPF.Is(path)) Converter.ConvertTPF(path);
        }

        public static string Detect(string path)
        {
            if (DCX.Is(path)) return "DCX";
            else if (BND3.Is(path)) return "BND3";
            else if (BND4.Is(path)) return "BND4";
            else if (FLVER0.Is(path)) return "FLVER0";
            else if (FLVER2.Is(path)) return "FLVER2";
            else if (BXF3.IsBHD(path)) return "BXF3 BHD";
            else if (BXF3.IsBDT(path)) return "BXF3 BDT";
            else if (BXF4.IsBHD(path)) return "BXF4 BHD";
            else if (BXF4.IsBDT(path)) return "BXF4 BDT";
            else if (BHD5.IsBHD(path)) return "BHD5 BHD";
            else if (BHD5.IsBDT(path)) return "BHD5 BDT";
            else if (Zero3.Is(path)) return "Zero3";
            else if (BND0.Is(path)) return "BND0";
            else if (TPF.Is(path)) return "TPF";
            else if (DRB.Is(path)) return "DRB";
            else if (MDL4.Is(path)) return "MDL4";
            //else if (MDL.Is(path)) return "MDL";
            else if (TAE3.Is(path)) return "TAE";
            else if (MQB.Is(path)) return "MQB";
            else if (FFXDLSE.Is(path)) return "FFXDLSE";
            else if (ACB.Is(path)) return "ACB";
            else if (CLM2.Is(path)) return "CLM2";
            else if (EMELD.Is(path)) return "EMELD";
            else if (ENFL.Is(path)) return "ENFL";
            else if (ESD.Is(path)) return "ESD";
            else if (F2TR.Is(path)) return "F2TR";
            else if (FXR3.Is(path)) return "FXR3";
            else if (GPARAM.Is(path)) return "GPARAM";
            else if (GRASS.Is(path)) return "GRASS";
            else if (LUAINFO.Is(path)) return "LUAINFO";
            else if (MTD.Is(path)) return "MTD";
            else if (NGP.Is(path)) return "NGP";
            else if (NVA.Is(path)) return "NVA";
            else return "unknown";
        }

        public static string DetectDCX(string path)
        {
            if (BND3.Is(path)) return "BND3";
            else if (BND4.Is(path)) return "BND4";
            else if (FLVER0.Is(path)) return "FLVER0";
            else if (FLVER2.Is(path)) return "FLVER2";
            else if (BXF3.IsBHD(path)) return "BXF3 BHD";
            else if (BXF3.IsBDT(path)) return "BXF3 BDT";
            else if (BXF4.IsBHD(path)) return "BXF4 BHD";
            else if (BXF4.IsBDT(path)) return "BXF4 BDT";
            else if (BHD5.IsBHD(path)) return "BHD5 BHD";
            else if (BHD5.IsBDT(path)) return "BHD5 BDT";
            else if (Zero3.Is(path)) return "Zero3";
            else if (BND0.Is(path)) return "BND0";
            else if (TPF.Is(path)) return "TPF";
            else if (DRB.Is(path)) return "DRB";
            else if (MDL4.Is(path)) return "MDL4";
            //else if (MDL.Is(path)) return "MDL";
            else if (TAE3.Is(path)) return "TAE";
            else if (MQB.Is(path)) return "MQB";
            else if (FFXDLSE.Is(path)) return "FFXDLSE";
            else if (ACB.Is(path)) return "ACB";
            else if (CLM2.Is(path)) return "CLM2";
            else if (EMELD.Is(path)) return "EMELD";
            else if (ENFL.Is(path)) return "ENFL";
            else if (ESD.Is(path)) return "ESD";
            else if (F2TR.Is(path)) return "F2TR";
            else if (FXR3.Is(path)) return "FXR3";
            else if (GPARAM.Is(path)) return "GPARAM";
            else if (GRASS.Is(path)) return "GRASS";
            else if (LUAINFO.Is(path)) return "LUAINFO";
            else if (MTD.Is(path)) return "MTD";
            else if (NGP.Is(path)) return "NGP";
            else if (NVA.Is(path)) return "NVA";
            else return "unknown";
        }
    }
}
