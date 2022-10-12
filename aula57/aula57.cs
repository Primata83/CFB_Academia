using System;
using System.Collections.Generic;
class Aula57{
    static void Main(){

        List<string> motos=new List<string>();
        string[] motos2=new string[10];

        motos.Add("R1");
        motos.Add("CBR");
        motos.Add("GRXR");
        motos.Add("RR");

        //motos2.AddRange(motos);

        
        if(motos.Contains("R1")){
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        motos.CopyTo(motos2,2);

        foreach(string c in motos){
            Console.WriteLine("Motos: {0}",c);
        }
    
    string mo="RR";
    int pos=0;
    pos=motos.IndexOf(mo);
    Console.WriteLine("Moto {0} esta na posição {1}",mo,pos);
    }
}