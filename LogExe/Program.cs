using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogExe
{
    class Program
    {
        static void Main(string[] args)
        {
            var csv = new StringBuilder();
            var text = new StringBuilder();
            DateTime datetime = DateTime.Now;
            string filePath = "C:\\LogsData\\" + DateTime.Now.ToString("yyyy_MM") + "\\LogExe.csv";

            //in your loop
            int lenght = args.Length;
            for (int i = 0; i < lenght; i++)
            {
                csv.Append(args[i] + ",");
            }
            csv.AppendLine("");

            //after your loop
            File.AppendAllText(filePath, csv.ToString());
        }
    }
}
