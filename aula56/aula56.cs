 using System;
 using System.Collections.Generic;
 class Aula56{
    static void Main(){

        LinkedList<string> transp = new LinkedList<string>();

        transp.AddFirst("Carro");
        transp.AddFirst("Aviao");
        transp.AddFirst("Navio");
        transp.AddFirst("Motocicleta"); // No Inicio

        transp.AddLast("Bicicleta");

        LinkedListNode<string>no;
        no=transp.FindLast("Navio"); // No Fim
        transp.AddAfter(no,"Patinete"); // Após
        no=transp.FindLast("Carro"); // Antes
        transp.AddBefore(no,"Patins");

        //transp.Clear(); (para limpar tudo)

        if(transp.Find("Carro")==null){
            Console.WriteLine("Não encontrado");
        }else{
            Console.WriteLine("Elemento encontrado");
        

        //transp.Remove("Navio");
        transp.RemoveFirst(); //Remove o primeiro
        transp.RemoveLast(); //Remove o último

        }
    
        foreach(string t in transp){
            Console.WriteLine("Transporte: {0}",t);

        }
    }
 }    
