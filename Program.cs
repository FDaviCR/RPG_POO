using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG___POO.src.Entities;

namespace RPG___POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Gojo",99,"Feiticeiro");
            Console.WriteLine(hero);

            Console.ReadLine();
        }
    }
}
