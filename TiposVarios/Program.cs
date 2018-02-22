using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Strings

            string verbatim = @"C:\Users\Ana\Documents";
            string normal = "dfsfdfsdfs";
            string verbaspas = @"""Pls Work""";
            string concatenada = "Uma " + "String " + "Concatenada";
            string concatenada2 = "Mood: " + normal + verbaspas;
            //concatenada += " texto";
            string sendhelp = $"{concatenada} mais {normal} e' igual a {concatenada + normal}";
            string verbinter = $@"Sou uma string verbatim interpolada, {verbaspas}";

            Console.WriteLine(verbatim);
            Console.WriteLine(normal);
            Console.WriteLine(verbaspas);
            Console.WriteLine(concatenada);
            Console.WriteLine(concatenada2);
            Console.WriteLine(sendhelp);
            Console.WriteLine(verbinter);
            
            

        }
    }
}