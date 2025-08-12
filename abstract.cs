using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal miPerro = new Perro();
            miPerro.HacerSonido(); 
        }
        // Clase abstracta
        abstract class Animal
        {
            public abstract void HacerSonido();
        }

        // Clase concreta
        class Perro : Animal
        {
            public override void HacerSonido()
            {
                Console.WriteLine("Guau");
            }
        }

    }
}
