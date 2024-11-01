using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MaPoProj
{
    internal class Program
    {
        [DllImport(@"C:\Users\krzys\source\repos\MaPoProj\x64\Debug\MaPoAsm.dll")]
        static extern uint MyProc1(byte[] a);
        static void Main(string[] args)
        {


            //            "C:\Users\krzys\source\repos\MaPoProj\16.wav"

            byte[] wavFile = File.ReadAllBytes("C:\\Users\\krzys\\source\\repos\\MaPoProj\\16l.wav");



            uint retVal = MyProc1(wavFile);

            File.WriteAllBytes("C:\\Users\\krzys\\source\\repos\\MaPoProj\\16mono.wav", wavFile);


            Console.WriteLine(retVal);
            Console.WriteLine(wavFile[40]);
            Console.ReadLine();

        }
    }
}
