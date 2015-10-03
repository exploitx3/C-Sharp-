using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace _4.Copy_Binary_File
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream reader = new FileStream("../../Wallpaper.jpg", FileMode.Open, FileAccess.Read);
            FileStream writer = new FileStream("../../WallpaperCopy.jpg", FileMode.Create, FileAccess.Write);
            try
            {
                
                int readerByte = reader.ReadByte();
                while (readerByte != -1)
                {
                    writer.WriteByte((byte)readerByte);
                    readerByte = reader.ReadByte();
                }
            }
            finally
            {
                writer.Flush();
                writer.Dispose();
                reader.Dispose();
            }
        }
    }
}
