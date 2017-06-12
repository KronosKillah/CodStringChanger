using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS3Lib;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace StringChangerV4Fuckit
{
    public class FuncDank
    {

        static byte[] clearmem = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                                   0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00};
        public static class PS3Setting
        {
            public static uint ProcessID;
            public static uint[] processIDs;
            public static string snresult;
            private static string usage;
            public static string Info;
            public static string Status;
            public static string MemStatus;
            public static PS3API PS3 = new PS3API();
            public static Random rand = new Random();
            public static CCAPI PS31 = new CCAPI();
            public static CCAPI CCAPI = new CCAPI();
        }
        public static void SetMeme(uint Offset, byte[] value)
        {
            PS3Setting.PS3.SetMemory(Offset, value);
        }
        public static void WriteString(uint Offset, string Input)
        {
            PS3Setting.PS3.Extension.WriteString(Offset, Input);
        }
        public static void WriteByte(uint Offset, byte Input)
        {
            PS3Setting.PS3.Extension.WriteByte(Offset, Input);
        }

        public static void ChangeString(uint freemem, byte[] value, string inputBox, uint pointer)
        {
            FuncDank.SetMeme(freemem, clearmem);
            FuncDank.WriteString(freemem, inputBox);
            FuncDank.SetMeme(pointer, value);
        }
        public class Setting
        {
            public string name { get; set; }
            public string value { get; set; }
            public Setting(string Name, string Value)
            {
                name = Name;
                value = Value;
            }
        }       

        
    }




}
