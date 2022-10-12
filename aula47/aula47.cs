using System;

class Calc{

    public int soma(int n1, int n2){
        return n1+n2;
    }

    public int soma(int n1, int n2, int n3){
        return n1+n2+n3;
    }

}

class Aula47{
    static void Main(){

        int res;
        
        Calc calc=new Calc();

        res=calc.soma(10,5,5);

        Console.WriteLine(res);
    }
}