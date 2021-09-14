using System;

namespace ExercicioMedidas
{
    class Program
    {
        static void Main(string[] args)

        {
             double m,convcm,convkm;

            Console.Write("Entre com o valor em Metros:");
            m =double.Parse(Console.ReadLine());
            convcm = m  * 100;
            convkm = m  / 1000;        
            Console.BackgroundColor=ConsoleColor.DarkRed;
            Console.ForegroundColor=ConsoleColor.Black;
            Console.WriteLine("\n--- Equivalência ---");
            Console.ResetColor();
            Console.WriteLine($"{convcm} cm \n{m} m \n{convkm} km");
            
    
                 }    
            
            } 
    
          }






             
             
                  
             
            
            
            
            
            

        
    

