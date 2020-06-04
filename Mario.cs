using System;

namespace Aula10Polimorfismo
{
    public class Mario : Player
    {
        //Métodos

        //sobreposição de métodos --> Override nas classes filhas =D

        public override void Correr(){
            Console.WriteLine("O Mario está correndo mais rápido agora!");
        }
    }
}