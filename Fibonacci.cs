using System;
namespace recursividade
{
    public class Fibonacci
    {
        public void GerarFibonacci(int num1, int num2, int vezes){
            //quebrar a recursividade do metodo
            if(vezes > 0){
                Console.WriteLine(num1);
                GerarFibonacci(num2, num1 + num2, vezes - 1);
            }
        }
        //fatorial
        public int GerarFatorial(int _nume){
            //quebrando recursividade
           if(_nume == 1){
               return 1;
           }else{
               return _nume * GerarFatorial(_nume - 1);
           }
            
        }
    }
}