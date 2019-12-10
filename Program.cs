using System;

namespace robot {


   /*
    1) Application (Console)
    2) class contains all operators (+ - * / %)
    3
   */
  


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x");
            int x = int.Parse(Console.ReadLine());
             Console.WriteLine("enter y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter operator");
            char _operator = char.Parse(Console.ReadLine());

            if(_operator == '/') {
               Console.WriteLine("this is / operation");
                int result = division( x , y );
            }
            if (_operator == '+') {
              Console.WriteLine("this is + operation"); 
             int result = Plus( x , y );

            }
            if (_operator == '-') { 
              Console.WriteLine("this is - operation");
              int result = minus( x , y );

            }
          
           if ((_operator == '*') {
              Console.WriteLine("this is * operation");
              int result = multi( x , y);
           }  
         }

     static int Plus (int x, int y){
           var a =  x + y;
          
           return a;
      }  
          
    
     static int division(int x, int y){
           var a =  x / y;
          
           return a;
        
      }
     static int minus(int x , int y ){
            var a =  x - y;

            return a;
      }
     static int multi(int x, int y){
            var a = x * y;

            return a;
      }

    }
} 
  

     