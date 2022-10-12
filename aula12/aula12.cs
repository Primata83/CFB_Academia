using System;
class Aula12{
    static void Main(){
        
        int n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0;
        string resultado="Reprovado";
        
        Console.Write("Digite as Nota 1: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite as Nota 2: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite as Nota 3: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite as Nota 4: ");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;
        
        if(res >= 60){
            resultado="Aprovado";
        }
    
        Console.WriteLine("resultado: {0}",resultado);
    
    }
}