using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    static class Helper
    {
        public static List<string[]> GetCSVContent(string filePath, string splitter)
        {
            if (splitter.Trim() == "" || splitter.Length != 1)
                throw new Exception("Splitter must be one char.");

            List<string[]> data = new List<string[]>();

            try
            {
                StreamReader file = File.OpenText(filePath);

                while (!file.EndOfStream)
                {
                    string row = file.ReadLine();
                    if(row is not null)
                    {
                        string[] columns = row.Split(splitter);
                        data.Add(columns);
                    }
                }

            }catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
            return data;
        }
    }
}
