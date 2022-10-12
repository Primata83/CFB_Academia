using System;

static public class Jogador{ //classe static não pode ser istanciada por um objeto, logo nao pode ter construtores
    static public int energia; // todos os membros da classe precisam ser static caso a classe tbm seja
    static public bool vivo;
    static public string nome;
    static public void Iniciar(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }
    static public void info(){
        Console.WriteLine("\nNome jogador.:{0}", nome);
        Console.WriteLine("Energia jogador:{0}", energia);
        Console.WriteLine("Estado jogador.:{0}\n", vivo);
    }
}
class Inimigo{
    static public bool alerta; //quando é criado atributos statics, significa que todos os objetos da classe
    public string nome;         // apontam pro mesmo atributo.
    public Inimigo(string n){
        alerta=false;
        nome=n;
    }
    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("------------------------------");
    }
}
class Aula31{
    static void Main(){
    
    Jogador.Iniciar("Bruno");
    Jogador.info();
    
    Inimigo i1= new Inimigo("Doido"); // objetos da classe Inimigo
    Inimigo i2= new Inimigo("Maluco");
    Inimigo i3= new Inimigo("Pirado");

    Inimigo.alerta=true; // quando define o atributo "alerta", ela vai valer para toda a classe
                         // no programa feito todos os inimigos receberam o alerta TRUE e não separados
    i1.info();
    i2.info();
    i3.info();
    }
}