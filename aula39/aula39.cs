using System;

namespace Aula39ClassesMetodosAbstratos
{

    abstract class Veiculo
   { 
       protected int velMax;
       protected int velAtual;
       protected bool ligado;


      public Veiculo(){
          ligado = false;
          velAtual = 0;
      }

      public void setLigado(bool ligado)
      {
          this.ligado = ligado;
      }

      public int getVelAtual()
      {
        return velAtual;
      }

       abstract public void aceleracao(int mult);
    
   }


     class Carro:Veiculo
     {

       
        public Carro()
        {
            velMax = 120;
        }

       override  public void aceleracao(int multi)
       {
           velAtual += 10*multi;
       }

     }

    class Program
    {
        static void Main(string[] args)
        {
           Carro c1 = new Carro();
           c1.aceleracao(2);
           c1.aceleracao(-1);
          Console.WriteLine(" e vel atual é:{0}",c1.getVelAtual());
        }
    }
}