using System;

class Calc{

    public int soma(int n1, int n2){
        int s=0;
        for(int i=0;i<n1.Lenght;i++){
            s+=n1[i];
        }
        return s;
    }

    public int fat(int n){
        int res;
        if(n<=1){
            res=1;
    }else{
    
    }

}

class Aula48{
    static void Main(){

        int res;
        
        Calc calc=new Calc();

        res=calc.soma(10,5,5);

        Console.WriteLine(res);
    }
}