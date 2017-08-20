using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            /*     string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                 string filename = Path.Combine(myDocuments, "myfile.txt");
                 File.WriteAllText(filename, "Hello, world!");
                 string contents = File.ReadAllText(filename);
                 File.WriteAllLines(filename, new[] { "alpha", "bravo", "charlie", "delta", "echo" });*/
            BogusFileEx();
        }
        static void DoAnotherFileThing(string filename)
        {
 StreamReader reader = null;
                try
                {
                    reader = new StreamReader(filename);
                    while (!reader.EndOfStream)
                    {
                        var line = reader.ReadLine();
                        Console.WriteLine(line);
                    }
                }
                catch
                {
                    throw;
                }
                finally
                {
                    if (reader != null)
                        reader.Close();
                }
        }

static void BogusFileEx()
{
            string bogusFile = @"C:\bougs.text";
            try
            {
                DoAnotherFileThing(bogusFile);

            }
            catch (FileNotFoundException ex)
            when (ex.FileName == bogusFile)
            {
                Console.WriteLine("outer handler");
            }
            finally
            {


            }
}













    }
}
