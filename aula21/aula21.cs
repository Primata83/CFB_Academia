using System;
class Aula21{
    static void Main(){

        string senha="123";
        string senhauser;
        int tentativas=0;
        
        do{
            Console.Clear();
            Console.WriteLine("osso de cabra");
            senhauser=Console.ReadLine();
            tentativas++;      
        }while(senha != senhauser);

        Console.Clear();
        Console.WriteLine("Senha Correta, tentativas:{0}",tentativas);  
    }
}