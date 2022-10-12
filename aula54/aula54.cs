using System;

namespace Calc1{
    class Area{
         public static float Quad(float bas, float alt){
            if(bas==0 || alt==0){
                throw new Exception("Base ou altura não pode ser igual a 0");
            }
            return bas*alt;
        }
    }   
}

namespace Calc2{

class Area{
        public static float Quad(float bas, float alt){
            if(bas==0 || alt==0){
            throw new Exception("Base ou altura não pode ser igual a 0");
        }
            return bas*alt;
        }
    }
}
class Aula54{
    static void Main(){

       float area=0;
    
        try{
            area=Calc2.Area.Quad(0,5F);
            Console.WriteLine("Area do quad.:{0}",area);
        }catch(Exception e){
            Console.WriteLine("esta zuado.:{0}",e.Message);
        }finally{
            Console.WriteLine("Fim do processo");
        }
    }    
}
