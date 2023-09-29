using System;
using System.Runtime.InteropServices;

namespace appTest1
{
    class Giallonardi_Luca
    {
        static void Main(string[] args)
        {
            //esto es tambien codigo extra
            Console.WriteLine("\n\n   :::::::PROYECTO DE CONSOLA HECHO CON C#:::::::\n\n   La función de este programa es calcular el valor de e^x.\n   El usuario ingresa el valor que desea para x y el programa devolverá el resultado.\n\n   Algunas indicaciones:\n   -> El valor de e^x se obtiene con una aproximación de un límite fijo = 10\n   -> Si desea ingresar un valor decimal para x debe ser declarado con ',' \n      ya que si se declara con '.' el programa no lo reconocerá.\n            _____\n        ,-:` \\;',`'-, \n      .'-;_,;  ':-;_,'.\n     /;   '/    ,  _`.-\\\n    | '`. (`     /` ` \\`|\n    |:.  `\\`-.   \\_   / |\n    |     (   `,  .`\\ ;'|\n     \\     | .'     `-'/\n      `.   ;/        .'\n        `'-._____.   \n\n    DESEA CONTINUAR? S/N");
            Console.WriteLine("");
            string cont = Console.ReadLine();
                if (cont == "S" || cont == "s")
            {
                Console.Clear();
                goto start;
            }
            else if (cont == "N" || cont == "n")
            {
                Console.Clear();
                goto end;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("EL COMANDO INGRESADO ES INVALIDO\n");
                goto preg;
            }

        start:
            //creo la variable x
            Console.WriteLine("       -''--.\n       _`>   `\\.-'<\n    _.'     _     '._\n  .'   _.='   '=._   '.\n  >_   / /_\\ /_\\ \\   _<\n    / (  \\o/\\\\o/  ) \\\n    >._\\ .-,_)-. /_.<\n        /__/ \\__\\         CALCULEMOS EL VALOR DE e^x\n          '---'           INGRESE EL VALOR QUE DESEA PARA x:");
            string strValorX = Console.ReadLine();
            decimal x;

            //aca chequeo que el valor ingresado en strValorX sea un numero
            if (decimal.TryParse(strValorX, out x))
            {
                Console.Clear();
                Console.WriteLine("\nEL NUMERO QUE ELEGISTE COMO VALOR DE x ES " + x + "\n");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nEL NUMERO INGRESADO ES INVALIDO\n");
                goto start;
            }

            //aca creo un array DivX que contendra los resultados de la x dividida por los factoriales de los exponentes
            decimal[] DivX = new decimal[11];

            //aca creo una variable que será el resultado final, en principio es 1
            decimal res = 1;

            //aca calculo el factorial del 1 al 10 y almaceno los resultados en el array Factorial[]
            int[] Factorial = new int[11];
            for (int i = 1; i<=10; i++)
            {
                int fact = 1;
                for(int f = 1; f <= i; f++)
                {
                    fact *= f;
                }
                Factorial[i] = fact;

                //aca creo el array DivX que almacena los resultados de x elevado a 1 dividido factorial de 1 y asi sucesivamente hasta el 10
                //la funcion CalcularExponente se declara mas abajo
                DivX[i] = ((decimal)CalcularExponente(x, i))/Factorial[i];//convierto la cuenta en decimal desde un principio

                //calculo el resultado final
                res += DivX[i];
            }

            Console.WriteLine("       _`>   `\\.-'<\n    _.'     _     '._        CUENTA:\n  .'   _.='   '=._   '.      e^" + x + " = 1 + (" + x + "/1!) + ((" + x + "^2)/2!) + ((" + x + "^3)/3!) + \n  >_   / /_\\ /_\\ \\   _<      ((" + x + "^4)/4!) + ((" + x + "^5)/5!) + ((" + x + "^6)/6!) + ((" + x + "^7)/7!) + \n    / (  \\o/\\\\o/  ) \\        ((" + x + "^8)/8!) + ((" + x + "^9)/9!) + ((" + x + "^10)/10!)\n    >._\\ .-,_)-. /_.<\n        /__/ \\__\\          RESULTADO:\n          '---'              e^"+x+" = " + res);
            
            
            
            
            

            //aca creo una la funcion CalcularExponente que lo unico que hace es calcular el exponente de x elevado a todos los numeros del 1 al 10
            //declaro el resultado y la funcion como decimal porque al calcular potencias grandes como elevado a 9 me daba error mal resultado final de e a la x porque el valor superaba el rango de int
            decimal CalcularExponente(decimal x, int i)
            {
                decimal resultado = 1;

                for (int r = 0; r < i; r++)
                {
                    resultado *= x;
                }

                return resultado;
            }


            //logica extra para volver a ingresar un valor 
            preg:
            Console.WriteLine("\nDESEA INGRESAR OTRO VALOR PARA X?: S/N");
            string ResSN = Console.ReadLine();
            if(ResSN == "S" || ResSN == "s")
            {
                Console.Clear();
                goto start;
            }else if(ResSN =="N" || ResSN == "n")
            {
                Console.Clear();
                goto end;
            }
            else
            {
                Console.WriteLine("EL COMANDO INGRESADO ES INVALIDO\n");
                goto preg;
            }
        end:
            Console.WriteLine("\n\nGRACIAS POR USAR EL PROGRAMA! \n\n\n             _____\n          .-'.  ':'-.\n        .''::: .:    '.\n       .   :::::'      .\n      ;.    ':' `       ;\n      |       '..       |\n      ; '      ::::.    ;\n       .       '::::   .\n        '.      :::  .'\n          '-.___'_.-'");



        }
    }    
}