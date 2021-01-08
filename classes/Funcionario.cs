using System;

namespace AulaPOO_Polimorfismo_Sobrecarga.classes
{
    public class Funcionario
    {
        public string[] lista = {"Juninho", "Silvia", "Kleber", "Karen"};

        public void Mostrar()              
        {
            foreach (var item in lista)
            {   
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(item); 
                Console.ResetColor();
            }
        }

        public void Mostrar(int indice)    
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (indice < lista.Length)
            {
                Console.WriteLine(lista[indice]); 
            }else{
                System.Console.WriteLine("Funcionário não encontrado.");
            }
            Console.ResetColor();
        }

        public void Mostrar(string busca) 
        {
            foreach (var item in lista)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                if (item == busca)
                {
                    Console.WriteLine(item);
                }
                Console.ResetColor();
                
            }
        }
    }
} 