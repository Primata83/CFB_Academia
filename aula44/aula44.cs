using System;

struct Moto{
    public string marca;
    public string modelo;
    public string cor;

    public Moto(string marca, string modelo, string cor){
        this.marca=marca;
        this.modelo=modelo;
        this.cor=cor;
    }


    public void info(){
        Console.WriteLine("Marca..:{0}",this.marca);
        Console.WriteLine("Modelo.:{0}",this.modelo);
        Console.WriteLine("Cor....:{0}",this.cor); 
    }
}
class Aula44{
    static void Main(){

        Moto c1=new Moto("Suzuki","Bandit","Preta");
        Moto c2=new Moto("Ducati","Monster","Vermelha");

        //c1.marca="Yamaha";
        //c1.modelo="R1";
        //c1.cor="Azul";

        c1.info();
        c2.info();  
    

    }
}