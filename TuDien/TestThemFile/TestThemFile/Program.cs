using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestThemFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            FileStream fi = new FileStream(@"C:\Users\HaNguyen\OneDrive\Desktop\TuDien\TestThemFile\TestThemFile\Dictionary_Source.txt", FileMode.Append, FileAccess.Write,FileShare.None);
            StreamWriter write = new StreamWriter(fi);
            string e = "animal";
            string v = "(n): dong vat";
            string result = e + "&" + v;
            write.WriteLine(result);
            write.WriteLine("human&(n): con nguoi");
            write.WriteLine("people&(n): dan toc");
            write.WriteLine("person&(n): ca nhan");
            write.Flush();
            write.Close();
            fi.Close();
        }
    }
}
