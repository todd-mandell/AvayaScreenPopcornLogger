using System;
using System.IO;



namespace TMAvayaScreenPopcorn2
{
    class Program
    {
        public static void Main(string[] args)
        {

            DateTime now = DateTime.Now;
            


            string path = @"c:\users\tmandell\Documents\TMCallLogs.txt";
            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Call Log File Begin");
                }
            }

            // This text is always added, making the file longer over time
            // if it is not deleted.
            using (StreamWriter sw = File.AppendText(path))
            {
                foreach (string s in args)
                {
                    sw.WriteLine(now + " - " + s);
                }
                sw.WriteLine("______________________________________________");

            }





            Console.WriteLine("Incoming Call -- {0}", args.Length);

            foreach (string s in args)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Press Enter To Close this window, call logged to root folder");
            Console.ReadLine();
        }
    }
}
