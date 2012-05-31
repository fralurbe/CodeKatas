using System;
using System.Collections.Generic;
using System.Text;

namespace ListCodeKata
{
    class Program
    {
        static void Main(string[] args)
        {
            MiLista lista = new MiLista();

            for (int i = 0; i < 10; i++)
                lista.Add("elemento_" + i.ToString());            
            
            lista.Find("elemento_9");
            
            lista.Delete("elemento_7");
            Console.Read();
        }
    }
}
