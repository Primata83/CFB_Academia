using System;

class Veiculo{ // CLASSE BASE
    public int VelAtual;
    private int VelMax;
    protected bool Ligado;
    public Veiculo(int VelMax){
        VelAtual=0;
        this.VelMax=VelMax;
        Ligado=false;
    }
    public bool getLigado(){
        return Ligado;
    }
    public int getVelMax(){
        return VelMax;
    }
}
class Carro:Veiculo{ //DERIVADA DE VEICULO
    public string nome;
    public Carro(string nome, int vm):base(vm){
       this.nome=nome; 
       Ligado=false;
    }
}
class Aula36{
    static void Main(){

    Carro Carro=new Carro("fumo",180);

    Console.WriteLine("Nome.......:{0}",Carro.nome);
    Console.WriteLine("Vel.Máxima.:{0}",Carro.getVelMax());
    Console.WriteLine("Ligado.....:{0}",Carro.getLigado());
    
    }
}