using System;

class Aula51{
   static void Main(string[] args){
    
        int res=0;
        
        if(args.Length > 0){    
            Console.WriteLine("Qtde de argumentos {0}",args.Length);
            for (int i=0; i < args.Length; i++){
                res+=Int32.Parse(args[i]);
            Console.WriteLine("soma:{0}",res);
    }
        }else{
            Console.WriteLine("Nao foram passados argumento");
        }
    }   
}