using System;

namespace Aula10Polimorfismo
{
    public class Player
    {
        //Métodos

    //Virtual ---> Abrindo uma super classe(pai), com "virtual" deixa que ele seja completado em outra parte do código.
        public virtual void Pular(){

            Console.WriteLine("O personagem está pulando normalmente.");
        }

        public virtual void Correr(){

            Console.WriteLine("O personagem está correndo normalmente.");
        }
    }
}