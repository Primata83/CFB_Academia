using System;

class Chimpanze{
    private string nomeChimpanze;
    private int numGorila;
    public Chimpanze(string nomeChimpanze){
        this.nomeChimpanze=nomeChimpanze;
        numGorila=0;
    }

    public Gorila Primata(){
        return new Gorila();

        
    }
}

class Gorila{
    public Gorila(){
        Console.WriteLine("Gorila criado");
    }
}



class Aula46{
    static void Main(){

        Chimpanze g1=new Chimpanze("fumo1");
        Chimpanze g2=new Chimpanze("fumo2");
        Chimpanze g3=new Chimpanze("fumo3");

        g1.Primata();

    
    
    }
}