// See https://aka.ms/new-console-template for more information
using JowiTRUCO.Class;
using JowiTRUCO.TEEC;
using System;
class Program
{
    static void Main(string[] args)
    {
        int reglas = 0;
        int eliminarCarta = 0;
        bool repartido1 = true, repartido2 = true;

        Console.WriteLine("Bienvenido a truco jowi");
        Console.WriteLine("A continuacion estan las reglas");
        Console.WriteLine("Si deseas salteartelas o ya las leiste presiona 1, caso contrario presione cualquier cualquier tecla");
        reglas = int.Parse(Console.ReadLine());
        Console.Clear();
        if (reglas == 1)
        {
            Console.WriteLine("PROXIMAMENTE REGLAS");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        Console.WriteLine("Ingrese el nombre del jugador 1");
        Players jugadorUNO = new Players(Console.ReadLine());
        jugadorUNO.SetCards();
        Console.WriteLine("Ingrese el nombre del jugador 2");
        Players jugadorDOS = new Players((Console.ReadLine()));
        jugadorDOS.SetCards();
        Console.Clear();
        Console.WriteLine("Bienvenidos " + jugadorUNO.getName() + " Y " + jugadorDOS.getName());
        Console.WriteLine("ESTAMOS LISTO PARA EMPEZAR???");
        Console.WriteLine("Presione cualquier tecla para continuar");
        Console.ReadKey();
        Console.Clear();

        while (jugadorUNO.getScore() < 15 || jugadorDOS.getScore() < 15)
        {
            jugadorUNO.setHand(false);
            jugadorDOS.setHand(false);
            repartido1 = true;
            repartido2 = true;
            for (int i = 0; i < 3; i++)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(jugadorUNO.getName() + " ES MANO");
                    jugadorUNO.setHand(true);
                    Console.WriteLine(jugadorDOS.getName() + " Cierre los ojos es el turno de " + jugadorUNO.getName());
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Las cartas de " + jugadorUNO.getName() + " son: ");
                    if (repartido1 == true)
                    {
                        jugadorUNO.SetCards();
                        Console.WriteLine(valoresC(jugadorUNO.getCards()));
                    }
                    else
                    {
                        //Console.WriteLine("Que carta quieres tirar? seleccionalas con 1, 2 o 3");
                        //eliminarCarta = int.Parse(Console.ReadLine());
                        //if (eliminarCarta == 1)
                        //{

                        //}
                    }
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine(jugadorUNO.getName() + " Cierre los ojos es el turno de " + jugadorDOS.getName());
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Las cartas de " + jugadorDOS.getName() + " son: ");
                    if (repartido2 == true)
                    {
                        jugadorDOS.SetCards();
                        Console.WriteLine(valoresC(jugadorDOS.getCards()));
                    }
                    //Console.WriteLine("Que carta quieres tirar? seleccionalas con 1, 2 o 3");
                    //eliminarCarta = int.Parse(Console.ReadLine());
                    //if (eliminarCarta == 1)
                    //{

                    //}
                    Console.ReadKey();
                    Console.Clear();
                    repartido1 = false;
                }
                else
                {
                    jugadorUNO.setHand(false);
                    Console.WriteLine(jugadorDOS.getName() + " ES MANO");
                    jugadorDOS.setHand(true);
                    Console.WriteLine(jugadorUNO.getName() + " Cierre los ojos es el turno de " + jugadorDOS.getName());
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Las cartas de " + jugadorDOS.getName() + " son: ");
                    if (repartido2 == true)
                    {
                        jugadorDOS.SetCards();
                        Console.WriteLine(valoresC(jugadorDOS.getCards()));
                    }
                    else
                    {
                        //Console.WriteLine("Que carta quieres tirar? seleccionalas con 1, 2 o 3");
                        //eliminarCarta = int.Parse(Console.ReadLine());
                        //if (eliminarCarta == 1)
                        //{

                        //}
                    }
                    Console.ReadKey();
                    Console.Clear();

                    Console.WriteLine(jugadorDOS.getName() + " Cierre los ojos es el turno de " + jugadorUNO.getName());
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("Las cartas de " + jugadorUNO.getName() + " son: ");
                    if (repartido2 == true)
                    {
                        jugadorUNO.SetCards();
                        Console.WriteLine(valoresC(jugadorUNO.getCards()));
                    }
                    else
                    {
                        //Console.WriteLine("Que carta quieres tirar? seleccionalas con 1, 2 o 3");
                        //eliminarCarta = int.Parse(Console.ReadLine());
                        //if (eliminarCarta == 1)
                        //{

                        //}
                    }
                        Console.ReadKey();
                        Console.Clear();
                    repartido2 = false;
                }
            }
        }
    }

    static void escribirConsola(string word)
    {
        Console.WriteLine(word);
        Console.ReadKey();
        Console.Clear();
    }

    static string valoresC(int[] cartas)
    {
        string[] carta = new string[3];
        string verCarta = "";
        for (int i = 0; i < 3; i++)
        {
            switch (cartas[i])
            {
                case 0:
                    carta[i] = "";
                    cartas[i] = 0;
                    break;
                //CARTAS DE ORO.
                case 1:
                    carta[i] = "1 de oro";
                    cartas[i] = 8;
                    break;
                case 2:
                    carta[i] = "2 de oro";
                    cartas[i] = 9;
                    break;
                case 3:
                    carta[i] = "3 de oro";
                    cartas[i] = 10;
                    break;
                case 4:
                    carta[i] = "4 de oro";
                    cartas[i] = 1;
                    break;
                case 5:
                    carta[i] = "5 de oro";
                    cartas[i] = 2;
                    break;
                case 6:
                    carta[i] = "6 de oro";
                    cartas[i] = 3;
                    break;
                case 7:
                    carta[i] = "7 de oro";
                    cartas[i] = 11;
                    break;
                case 8:
                    carta[i] = "10 de oro";
                    cartas[i] = 5;
                    break;
                case 9:
                    carta[i] = "11 de oro";
                    cartas[i] = 6;
                    break;
                case 10:
                    carta[i] = "12 de oro";
                    cartas[i] = 7;
                    break;
                //CARTAS DE COPA.       
                case 11:
                    carta[i] = "1 de copa";
                    cartas[i] = 8;
                    break;
                case 12:
                    carta[i] = "2 de copa";
                    cartas[i] = 9;
                    break;
                case 13:
                    carta[i] = "3 de copa";
                    cartas[i] = 10;
                    break;
                case 14:
                    carta[i] = "4 de copa";
                    cartas[i] = 1;
                    break;
                case 15:
                    carta[i] = "5 de copa";
                    cartas[i] = 2;
                    break;
                case 16:
                    carta[i] = "6 de copa";
                    cartas[i] = 3;
                    break;
                case 17:
                    carta[i] = "7 de copa";
                    cartas[i] = 4;
                    break;
                case 18:
                    carta[i] = "10 de copa";
                    cartas[i] = 5;
                    break;
                case 19:
                    carta[i] = "11 de copa";
                    cartas[i] = 6;
                    break;
                case 20:
                    carta[i] = "12 de copa";
                    cartas[i] = 7;
                    break;
                //CARTAS DE ESPADA.
                case 21:
                    carta[i] = "1 de espada";
                    cartas[i] = 14;
                    break;
                case 22:
                    carta[i] = "2 de espada";
                    cartas[i] = 9;
                    break;
                case 23:
                    carta[i] = "3 de espada";
                    cartas[i] = 10;
                    break;
                case 24:
                    carta[i] = "4 de espada";
                    cartas[i] = 1;
                    break;
                case 25:
                    carta[i] = "5 de espada";
                    cartas[i] = 2;
                    break;
                case 26:
                    carta[i] = "6 de espada";
                    cartas[i] = 3;
                    break;
                case 27:
                    carta[i] = "7 de espada";
                    cartas[i] = 12;
                    break;
                case 28:
                    carta[i] = "10 de espada";
                    cartas[i] = 5;
                    break;
                case 29:
                    carta[i] = "11 de espada";
                    cartas[i] = 6;
                    break;
                case 30:
                    carta[i] = "12 de espada";
                    cartas[i] = 7;
                    break;
                //CARTAS DE BASTO.
                case 31:
                    carta[i] = "1 de basto";
                    cartas[i] = 13;
                    break;
                case 32:
                    carta[i] = "2 de basto";
                    cartas[i] = 9;
                    break;
                case 33:
                    carta[i] = "3 de basto";
                    cartas[i] = 10;
                    break;
                case 34:
                    carta[i] = "4 de basto";
                    cartas[i] = 1;
                    break;
                case 35:
                    carta[i] = "5 de basto";
                    cartas[i] = 2;
                    break;
                case 36:
                    carta[i] = "6 de basto";
                    cartas[i] = 3;
                    break;
                case 37:
                    carta[i] = "7 de basto";
                    cartas[i] = 4;
                    break;
                case 38:
                    carta[i] = "10 de basto";
                    cartas[i] = 5;
                    break;
                case 39:
                    carta[i] = "11 de basto";
                    cartas[i] = 6;
                    break;
                case 40:
                    carta[i] = "12 de basto";
                    cartas[i] = 7;
                    break;
                default:
                    carta[i] = "Error";
                    break;
            }
        }
        for(int i = 0; i < 3; i++)
        {
            verCarta += carta[i] + "\n";
        }
        return verCarta;

    }
}