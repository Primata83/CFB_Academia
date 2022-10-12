using System;
using System.Collections.Generic;
class Aula58{
    static void Main(){

        List<string> motos=new List<string>();
        string[] motos2=new string[10];

        motos.Add("R1");
        motos.Add("CBR");
        motos.Add("GRXR");
        motos.Add("RR");
        motos.Add("R1");

        //motos2.AddRange(motos);

        
        if(motos.Contains("R1")){
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        motos.CopyTo(motos2,2);

        motos.Insert(1,"Z10");

        int pos2=motos.LastIndexOf("R1");

        /*motos.RemoveAt(3);
        
        if(motos.Remove("CBR")){
            Console.WriteLine("CBR removido");
        }else{
            Console.WriteLine("CBR nao removida");
        }
        */
        //motos.Reverse();
       
        
        int tamanho=motos.Count;
        motos.Capacity=15;
        int capa=motos.Capacity;

        Console.WriteLine("tamanho da lista {0}",tamanho);
        Console.WriteLine("Capacidade {0}",capa);
       
        motos.Sort();
        foreach(string c in motos)
            Console.WriteLine("Motos: {0}",c);
        
    string mo="RR";
    int pos=0;
    pos=motos.IndexOf(mo);
    Console.WriteLine("Moto {0} esta na posição {1}",mo,pos);
    Console.WriteLine("Ultima R1 esta na pos {0}",pos2);
    
    }
}
    

  
    
