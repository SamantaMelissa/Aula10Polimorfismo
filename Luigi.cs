using System;

namespace Aula10Polimorfismo
{
    public class Luigi : Player
    {
         public override void Pular(){
            Console.WriteLine("O Luigi está pulando mais alto agora!");

            //Aproveitar ações da classe pai (Player) 

            base.Pular();

            //EEEE adicionar novas ações: 

            Console.WriteLine("O Luigi também pode pular 30% mais alto!!");
        }
    }
}