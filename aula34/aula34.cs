using System;

class Veiculo{
    
    public int Rodas;
    public int VelMax;
    private bool ligado;
    public void ligar(){
        ligado=true;
    }
    public void desligar(){
        ligado=false;
    }
    public string getLigado(){
        if(ligado){
            return "sim";
        }else{
            return "não";
        }
    }
}

class Carro:Veiculo{
    public string Nome;
    public string Cor;
    public Carro(string Nome, string Cor){
       desligar();
       Rodas=4;
       VelMax=120;
       this.Nome=Nome;
       this.Cor=Cor;
    }
}

class Aula34{
    static void Main(){
        Carro c1=new Carro("foguete","amarelo");
    
        Console.WriteLine("Cor.........:{0}",c1.Cor);
        Console.WriteLine("Nome........:{0}",c1.Nome);
        Console.WriteLine("Rodas.......:{0}",c1.Rodas);
        Console.WriteLine("Vel.Maxima..:{0}",c1.VelMax);
        Console.WriteLine("Ligado:......{0}",c1.getLigado());
    }
}