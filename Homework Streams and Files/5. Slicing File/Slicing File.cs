using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;

namespace _5.Slicing_File
{
    class Program
    {
/* INPUT 1:
../../Faded.mp4
../../
5
INPUT 2:
../../text.txt
../../
3 
 
 * * * */

        private static void Slice(string sourceFile, string destinationDirectory, int parts)
        {

            FileStream reader = new FileStream(sourceFile, FileMode.Open);
            FileInfo file = new FileInfo(sourceFile);
            long chunkSize = (long)(file.Length/parts);
            BigInteger counter = -1;
            if (file.Length%2 == 1)
            {
                counter = 0;
            }
            int fileCounter = 1;
            int readBytesVariable = reader.ReadByte();
            List<byte> lsBytes = new List<byte>();
            lsBytes.Add((byte)readBytesVariable);
            while (readBytesVariable != -1)
            {
                
                if ((counter%chunkSize == 0 && counter != 0) || counter == file.Length)
                {
                    string fileName = destinationDirectory + "Part-" + fileCounter + "." + sourceFile.Split(new char[]{'.'},StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
                    FileStream writer = new FileStream(fileName, FileMode.Create,FileAccess.Write);
                    writer.Write(lsBytes.ToArray(), 0,lsBytes.Count);
                    writer.Flush();
                    writer.Dispose();
                    lsBytes.Clear();
                    fileCounter++;
                }

                
                readBytesVariable = reader.ReadByte();
                lsBytes.Add((byte)readBytesVariable);
                counter++;
            }

        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            FileStream writer = new FileStream(destinationDirectory + "assembled" + "." + files[1].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault(), FileMode.Create);
            for (int i = 0; i < files.Count; i++)
            {
                FileStream reader = new FileStream(destinationDirectory + files[i],FileMode.Open,FileAccess.ReadWrite);
                int readBytesVariable = reader.ReadByte();
                while (readBytesVariable != -1)
                {
                    writer.WriteByte((byte)readBytesVariable);
                    readBytesVariable = reader.ReadByte();
                }
                reader.Dispose();
            }
            writer.Flush();
            writer.Dispose();
        }
      
        static void Main(string[] args)
        {
            string source = Console.ReadLine();
            string destination = Console.ReadLine();
            int parts = int.Parse(Console.ReadLine());
            List<string> lstFileParts = new List<string>();
            for (int i = 1; i <= parts; i++)
            {
                lstFileParts.Add("Part-" + i + "." + source.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).LastOrDefault());
            }
            Slice(source,destination,parts);
            Assemble(lstFileParts,destination);
        }
    }
}
