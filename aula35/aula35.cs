using System;

namespace Aula35CadeiaHeranca
{

    class Veiculo
    {
      public int velMax;
      private int rodas;
      private bool ligado;

      public Veiculo(int rodas)
      {
          this.rodas = rodas;
      }

        public void ligar()
        {
            ligado = true;
        }

          public void desligar()
         {
             ligado = false;
         }

          public string getLigado()
          {
             return  (ligado?"sim":"nao");// operador ternario
            /*  if(ligado)
              {
                  return "sim";
              }
               else
               {
                   return "nao";
               }*/
          }

            public int getRodas()
            {
                return rodas;
            }

            public void setRodas(int rodas)
            {
               this.rodas = rodas;
            }
    } 
    class Carro:Veiculo
    {
      public string nome;
      public string cor;
      

      public Carro(String nome,string cor):base(4)
      {
          desligar();
          velMax = 120;
          this.nome = nome;
          this.cor = cor;

      }

    } 

     class CarroCombate:Carro
     {
        public int municao;


        public CarroCombate():base("tank de guerra","verde")
        {
           municao = 100;
           setRodas(6);
           velMax = 100;
        }

     }


    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("s10","prata");
            c1.ligar();
            Console.WriteLine("Cor do veiculo...................{0}",c1.cor);
            Console.WriteLine("Nome do veiculo..................{0}",c1.nome);
            Console.WriteLine("Quantidade de rodas do veiculo...{0}",c1.getRodas());
            Console.WriteLine("Velocidade maxima do veiculo.....{0}",c1.velMax);
            Console.WriteLine("O veiculo está ligado??..........{0}",c1.getLigado());

            Console.WriteLine("-------------------------------------------");

            CarroCombate c2 = new CarroCombate();
            Console.WriteLine("Cor do veiculo...................{0}",c2.cor);
            Console.WriteLine("Nome do veiculo..................{0}",c2.nome);
            Console.WriteLine("Quantidade de rodas do veiculo...{0}",c2.getRodas());
            Console.WriteLine("Velocidade maxima do veiculo.....{0}",c2.velMax);
            Console.WriteLine("O veiculo está ligado??..........{0}",c2.getLigado());
      
            
        }
    }
}
