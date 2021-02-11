using System;

namespace Practica_3
{
    class Program
    {
        static void Main(string[] args)
        {
                //Aqui se encuentra el Menu & el Switch
                #region menu&switch
            int valor = 1;
            while (valor!=5)       
            {
            Console.Write("Elige una opcion\n" + 
            "\n1.- Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero)." + 
            "\n2.- Crea un programa que escriba en pantalla los números del 1 al 10, usando do..while" + 
            "\n3.- Crear un programa que muestre los primeros 10 números pares a partir del producto de (10 x 10)" +
            "\n4.- Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo)"  +
            "\n5.- Salir :");
            
    
            valor = int.Parse(Console.ReadLine());
            switch (valor) 
            { 
            #endregion
                //Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero).//
                #region ejercicio1
                
                case 1:
                // Variables
                int numero = 1;
                int contador = 0;
                int suma = 0;        
                // Variables
                
                while (numero!=0 && numero>=0)
                {
                Console.WriteLine("Ingresa el numero: ");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero ;
                contador++;
                }
       
                System.Console.WriteLine("La suma de todos los numeros es: " +suma);
                break;
                #endregion
                //Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while"//
                #region ejercicio2
                
                case 2: int contadorr = 1;
                        do 
                        {
                        Console.Write(contadorr++);
                        }while (contadorr <= 10);
                        break;

                #endregion
                //Crear un programa que muestre los primeros 10 números pares a partir del producto de (10 x 10)//
                #region ejercicio3
                
                case 3: int a=0; 
                        for (a = 1; a < 100; a++)
                        {
                        if (a % 2 == 0)
                        {
                        Console.Write("{0}|", a);
                        a++;
                        }
                        }
                        break;
                #endregion
                //Crear un programa que muestre las letras de la Z (mayúscula) a la A (mayúscula, descendiendo)//
                #region ejercicio4
                case 4: char letra;
                        for (letra='Z'; letra>='A'; letra--)
                        Console.Write("{0} ", letra);
                        break;
                #endregion
                //Salir
                #region salir_programa
                case 5: Console.WriteLine("Salir");
                        break;
                default:
                        Console.Write("Se ingreso un valor fuera de rango");
                        break;
            }
            Console.ReadKey();
            
            }
            #endregion
        }
    }
}
