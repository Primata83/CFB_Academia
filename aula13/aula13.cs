using System;
class Aula13{
    static void Main(){
        
        int n1,n2,n3,n4,res;
        res=n1=n2=n3=n4=0;
        string resultado;
        
        Console.Write("Digite as Nota 1: ");
        n1=int.Parse(Console.ReadLine());

        Console.Write("Digite as Nota 2: ");
        n2=int.Parse(Console.ReadLine());

        Console.Write("Digite as Nota 3: ");
        n3=int.Parse(Console.ReadLine());

        Console.Write("Digite as Nota 4: ");
        n4=int.Parse(Console.ReadLine());

        res=n1+n2+n3+n4;


        
        if(res < 40){
            resultado="reprovado";
        }else if(res < 60){
            resultado="recuperação";
        }else{
            resultado="aprovado";
        }
    
        Console.WriteLine("Nota: {0} - resultado: {1}",res,resultado);
    
    }
}