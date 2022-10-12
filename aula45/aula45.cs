using System;

struct Moto{
    public string modelo;
    public string cor;

   public void info(){
        Console.WriteLine("Modelo.:{0}",this.modelo);
        Console.WriteLine("Cor....:{0}",this.cor); 
        Console.WriteLine("-----------------------"); 
    }
}
class Aula45{
    static void Main(){

        int[] numeros=new int[10];

        Moto[] motos=new Moto[4];
        
        motos[0].modelo="hayabusa";
        motos[0].cor="branca";

        motos[1].modelo="r1";
        motos[1].cor="preta";

        motos[2].modelo="h2r";
        motos[2].cor="carbono";
         
        motos[3].modelo="bmw";
        motos[3].cor="laranja";

        for(int i=0;i<carros.Lenght;i++){
            motos[i].info();
        }
        
        

    }
}