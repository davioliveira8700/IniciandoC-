using System;

namespace tipos_de_variaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            var x = 1;

            string d = "Davi";

            var d2 = "Oliveira";

            //var f = 1.5;

           // float v = 1.8f;

            //var a = 1.8;

            // double b = 1.9d;

            var v = true;

            bool f = false;

            bool boolean = bool.Parse("False");


            Animal a = new Animal();
            Leao l = new Leao();

           
            a = l;

          
            Console.WriteLine(a);
            
        }
    }
    public class Animal
    {
    
    }
        public class Leao : Animal
    {

    }
    
}
