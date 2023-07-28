using System;
using System.Threading;
class Program
{
    static void LimpiarPantalla()
    {
        Console.Clear ();
    }

    static void Main()
    {
        string Ejercicio_1()

        {
            //Ejercicio if-else
           Console.WriteLine("Ingrese su edad actual");
            int edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18) 
            {
                return "Eres mayor de edad";
            }
            else
            {
                return "Erees menor de edad";
            }
        }
        string Ejercicio_2()
        {
            //Ejercicio if-else
            Console.WriteLine("Ingrese un número");
           int num = Convert.ToInt32(Console.ReadLine());

            if (num % 7 == 0)
            {
                return "El número" + num + "es multiplo de 7";
            }
            else
            {
                return "El número ingresado, no es multiplo de 7";
            }

        }
        string Ejercicio_3()
        {
            //Ejercicio if-else
            Console.WriteLine("Ingrese un número del 1 al 7");
            int Numero_Dia = Convert.ToInt32(Console.ReadLine());

            if (Numero_Dia == 1)
            {
                return "Lunes";
            }
            else if (Numero_Dia == 2)
            {
                return "Martes";
            }
            else if (Numero_Dia == 3)
            {
                return "Miércoles";
            }
            else if (Numero_Dia == 4)
            {
                return "Jueves";
            }
            else if (Numero_Dia == 5)
            {
                return "Viernes";
            }
            else if (Numero_Dia == 6)
            {
                return "Sábado";
            }
            else if (Numero_Dia == 7)
            {
                return "Domingo";
            }
            else
            {
                return "Número del día de la semana ingresado, está incorrecto";
            }
        }
        string Ejercicio_4()
        {
            //Ejercicio de while
            Console.WriteLine("Ingrese una cadena:");
            string Texto = Console.ReadLine();
            int contador = 0;
            int Inicial = 0;

            while (Inicial < Texto.Length)
            {
                if (char.IsWhiteSpace (Texto[Inicial]))
                    contador++;
                Inicial++;
            }

            return "El número de caracteres en la cadena es: " + contador;

        }
        string Ejercicio_5()
        {
            //Ejercicio de while
            Console.WriteLine("Ingrese la cantidad de elementos del arreglo");
            int Elementos = Convert.ToInt32 (Console.ReadLine());
            int[] arreglo = new int[Elementos];
            int Indice = 0;
            int Suma = 0;

            while (Indice < Elementos)
            {
                Console.WriteLine("Ingrese el elemento {0}:", Indice + 1);
                arreglo[Indice] = Convert.ToInt32 (Console.ReadLine());

                Suma = Suma + arreglo[Indice];
                Indice++;

            }
            return "La suma de los elementos del arreglo:"+ Suma;
        }
        string Ejercicio_6()
        {
            //Ejercicio de while
            Console.WriteLine("Ingrese una cadena de texto que ud desee ");
            string texto = Console.ReadLine();
            Console.WriteLine("Ingrese la palabra que desee buscar en la cadena");
            string palabra = Console.ReadLine();
            int Inicial = 0;

            while (Inicial <= texto.Length - palabra.Length)
            {
                if ( texto.Substring(Inicial, palabra.Length) == palabra)
                {
                    return "La palabra '{0}' fue encontrada en la cadena." + palabra;
                }
                Inicial++;
            }
            return "La palabra '{0}' fue encontrada en la cadena." + palabra;

        }
        string Ejercicio_7()
        {
            //Ejercicio de for
            Console.WriteLine ("Ingrese la cantidad de elementos del arreglo");
            int element= Convert.ToInt32 (Console.ReadLine());

            int [] arreglo = new int [element];
            
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine("Ingrese el elemento {0}:", i + 1);
                arreglo [i] = Convert.ToInt32(Console.ReadLine());
            }

            int Cont = 0;

            for (int i =0; i < arreglo.Length; i ++)
            {
                if (arreglo.Length % 2 == 0)
                {
                    Cont++;
                }

            }
            return ("La cantidad de elementos pares en el arreglo es: ") + Cont;
        }
        string Ejercicio_8()
        {
            //Ejercicio de for
           int [] arreglo = {50, 10, 71, 8, 15,4};
           Console.WriteLine ("Arreglo = {50, 10, 71, 8, 15,4}");
           Console.Write ("Ingrese el número que desee averiguar, si se encuentra en el arreglo");
           int NumeroBus = Convert.ToInt32(Console.ReadLine());

           for (int i = 0; i < arreglo.Length; i++)
           {
            if (arreglo[i]== NumeroBus)
            {
                return "El número que esta verificando se encuentra en el arreglo"+NumeroBus;
            }
           }
           return "El número ingresado, no se encuentra en el arreglo."+NumeroBus;
        }
        string Ejercicio_9()
        {
            //Ejercicio de for
            Console.WriteLine("Ingrese una cadena");
            string cadena = Console.ReadLine();

            int cont = 0;

            for (int i = 0; i < cadena.Length; i++)
            {
                cont++;
            }
            return "La cantidad de caracteres que hay en la cadena ingresada es:"+cont;
        }
        string Ejercicio_10()
        {
            //Ejercicio de for
            Console.WriteLine ("Ingrese una cadena: ");
            string cadena = Console.ReadLine();
            string revertida = "";

            for (int i = cadena.Length - 1; i >= 0; i--)
            {
                revertida += cadena[i];
            }
            return ("La cadena ingresada" +cadena + "en reversa, es:" +revertida);
        }
        string Ejercicio_11()
        {
            //Ejercicio de for
            Console.WriteLine ("Ingrese la altura de la piramide");
            int Altura = Convert.ToInt32(Console.ReadLine());
            string piramide = "";

            for (int i =1; i <= Altura; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    piramide +="*";
                }
                piramide+= "\n";
            }
            return piramide; 
        }
        string Ejercicio_12()
        {
            //Ejercicio de do-while
            string espa = "";
            int i = 1;
            do
            {
                espa+= i + "\n";
                i++;
            } while (i <= 20);
            return espa;
        }
        string Ejercicio_13()
        {
            //Ejercicio de do-while
            Random random = new Random();
            int numero;

            do
            {
                numero = random.Next(1,11);
                Console.Write ("Numero generado" +numero + "\n");
            }while (numero!= 7);

            return "¡Se ha obtenido un número igual a 7!";
        }
        string Ejercicio_14()
        {
            //Ejercicio de do-while
            int numero= 2;
            do
            {
                Console.WriteLine (numero);
                numero+=2;
            }while (numero <= 20);
            return "Los numeros pares fueron presentados";
        }
        string Ejercicio_15()
        {
            //Ejercicio de do-while
            string nombre = " ";
            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

            } while (string.IsNullOrEmpty(nombre));
            return "¡Hola," +nombre + "!";
        }
        while (true)
        {
            LimpiarPantalla();

            Console.WriteLine("1. Determinar si es mayor de edad o no");
            Console.WriteLine("2. Verificar si el valor ingresado es múltiplo de 7");
            Console.WriteLine("3. Ingresar un número del 1-7 que representa un día de la semana.");
            Console.WriteLine("4. Cuantas palabras tiene una frase ingresada");
            Console.WriteLine("5. Suma de elementos de un arreglo");
            Console.WriteLine("6. Buscar una palabra en una cadena");
            Console.WriteLine("7. Contar la cantidad de elementos pares en un arreglo ingresado por el usuario");
            Console.WriteLine("8. Determinar si un número ingresado por el usuario,se encuentra en el arreglo predefinido");
            Console.WriteLine("9. Cantidad de caracteres que contiene una cadena ingresada por el usuario.");
            Console.WriteLine("10. Revertir una Cadena");
            Console.WriteLine("11.Imprimir una pirámide de asteriscos con una altura ingresada por el usuario");
            Console.WriteLine("12.Imprimir los números del 1 al 20 ");
            Console.WriteLine("13. Generar números aleatorios entre 1 y 10 hasta que se obtenga un número igual a 7");
            Console.WriteLine("14. Imprimir los números pares del 2 al 20.");
            Console.WriteLine("15. Ingrese un nombre hasta que ingrese un nombre no vacío");
            Console.WriteLine("16. Salir");
            Console.WriteLine("Seleccione una opcion:");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 1");
                    Console.WriteLine(Ejercicio_1());
                    Thread.Sleep(5000);
                    break;
                case 2:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 2");
                    Console.WriteLine(Ejercicio_2());
                    Thread.Sleep(5000);
                    break;
                case 3:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 3");
                    Console.WriteLine(Ejercicio_3());
                    Thread.Sleep(5000);
                    break;
                case 4:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 4");
                    Console.WriteLine(Ejercicio_4());
                    Thread.Sleep(5000);
                    break;
                case 5:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 5");
                    Console.WriteLine(Ejercicio_5());
                    Thread.Sleep(5000);
                    break;
                case 6:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 6");
                    Console.WriteLine(Ejercicio_6());
                    Thread.Sleep(5000);
                    break;
                case 7:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 7");
                    Console.WriteLine(Ejercicio_7());
                    Thread.Sleep(5000);
                    break;
                case 8:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 8");
                    Console.WriteLine(Ejercicio_8());
                    Thread.Sleep(5000);
                    break;
                case 9:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 9");
                    Console.WriteLine(Ejercicio_9());
                    Thread.Sleep(5000);
                    break;
                case 10:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 10");
                    Console.WriteLine(Ejercicio_10());
                    Thread.Sleep(5000);
                    break;
                case 11:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 11");
                    Console.WriteLine(Ejercicio_11());
                    Thread.Sleep(5000);
                    break;
                case 12:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 12");
                    Console.WriteLine(Ejercicio_12());
                    Thread.Sleep(5000);
                    break;
                case 13:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 13");
                    Console.WriteLine(Ejercicio_13());
                    Thread.Sleep(5000);
                    break;
                case 14:
                    LimpiarPantalla();
                    Console.WriteLine("selecciono la opcion 14");
                    Console.WriteLine(Ejercicio_14());
                    Thread.Sleep(5000);
                    break;
                case 15:
                    LimpiarPantalla();
                    Console.WriteLine("Selecciono la opcion 15");
                    Console.WriteLine(Ejercicio_15());
                    Thread.Sleep(5000);
                    break;
                case 16:
                    Console.WriteLine("selecciono la opcion 4 salir");
                    Thread.Sleep(5000);
                    return;
                default:
                    LimpiarPantalla();
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    Thread.Sleep(3000);
                    break;

            }



        }

    }


}