using System;

namespace Aula10Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mário : ");
            Mario mario = new Mario();
            mario.Correr();
            mario.Pular();
            
            Console.WriteLine("Luigi : ");
            Luigi luigi = new Luigi();
            luigi.Correr();
            luigi.Pular();
        }
    }
}
