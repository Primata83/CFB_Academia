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


        
        if(res > 60){
            if(res >=90){
                if(res >=99){
                    resultado="aprovado até o talo";
                }else{
                    resultado="aprovado baliscamente";
                }
                
            }else{
                if(res >= 40){
                    resultado="recuperação";
                }else{
                    resultado="reprovado";     
                }
            }
            Console.WriteLine("Nota: {0} - resultado: {1}",res,resultado);
        }
    }
}