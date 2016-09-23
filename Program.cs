using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace rollercoaster
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new instances
            StreamReader reader = new StreamReader("..\\..\\rollercoaster.txt");
            List<string> lines = new List<string>();
            List<string> results = new List<string>();
            

            using (reader)
            {
                string line = reader.ReadLine();
                while(line != null)
                {
                    lines.Add(line);
                    line=reader.ReadLine();
                }
            }

            int length = lines.Count;
            for (int i = 0; i <length; i++)
            {
                results.Add(change(lines[i]));
            }
            foreach (var result in results)
            {
                Console.WriteLine(result);
            }
        }

        //Indexing every other letter to be capitalized.
        public static string change (string line)
        {
            int length = line.Length;
            int index = 0;
            string result = "";

            for (int i = 0; i< length; i++)
            {
                if(char.IsLetter(line[i]))
                {
                    if (index % 2==0)
                    {
                        result += line[i].ToString().ToUpper();
                    }

                    else
                    {
                        result += line[i].ToString().ToLower();
                    }
                    index++;
                }
                else
                {
                    result += line[i];
                }

            }
            return result;
        }
    }
}
