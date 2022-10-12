using System;
class Aula15{
    static void Main(){

        int tempo=0;
        char escolha;

        inicio:

        Console.Clear();
        
        Console.WriteLine("Belo Horizonte/ES");
        Console.WriteLine("Escolh a transporte: [a]Avião | [c]Carro | [o]Onibus ");

        escolha=char.Parse(Console.ReadLine());

        switch(escolha){
            case 'a':
            case 'A':    
                tempo=50;
                break;
            case 'c':
            case 'C':    
                tempo=480;
                break;
            case 'o':
            case 'O':    
                tempo=660;
                break;
            default:
                tempo=-1;
                break;

        }
        
        if(tempo<0){
            Console.WriteLine("Transporte indisponivel");
        }else{
            Console.WriteLine("Para o transporte escolhido o tempo é: {0} minutos",tempo);
    
        }

        Console.Write("Calcular outro transporte?[s/n]: ");
        escolha=char.Parse(Console.ReadLine());
        if(escolha=='s' || escolha=='S'){
            goto inicio;
        }else{
            Console.Clear();
            Console.WriteLine("fim do programa");
        }
    }
}