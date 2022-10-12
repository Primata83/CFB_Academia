using System;
using System.Collections.Generic;
class Aula59{
    static void Main(){

        Queue<string>veiculos=new Queue<string>();

        veiculos.Enqueue("Carro"); //adiciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");

        string v="veiculos";
        if(veiculos.Contains(v)){
        Console.WriteLine("Veiculos " + v + " encontrado");    
        }else{
            Console.WriteLine("veiculo " + v + " nao esta na fila");
        }
        //veiculos.Clear();
        //Console.WriteLine("primero Veiculo " + veiculos.Dequeue());
        //Console.WriteLine("primero Veiculo " + veiculos.Dequeue());
        Console.WriteLine("Primeiro Veiculo " + veiculos.Peek());
        Console.WriteLine("Tamanho fila: "+veiculos.Count);
        foreach(string veic in veiculos){
            Console.WriteLine("Veiculo " + v);

            
        
        }

        
    }   

}