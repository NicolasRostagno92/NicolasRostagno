using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoTresDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int select;
            int apuesta;
            int monedasJugador = 5000;
            int monedasSistema = 15000;
            int monedasApuesta;
            int reiniciar;
            
            do
            {
                Console.Clear();
                Console.WriteLine("BIENVENIDOS A SUPER TRES:\n");
                Console.WriteLine("1 - Jugar");
                Console.WriteLine("2 - Reglas");
                Console.WriteLine("3 - Acerca de");
                Console.WriteLine("4 - Salir");

                Console.WriteLine("\nElija número y oprima enter:\n");
                
                select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.Clear();
                     

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine($"MONEDAS: {monedasJugador}\n");

                            Console.WriteLine("¿CUÁNTAS MONEDAS DESEA APOSTAR?");
                         
                            // Verificar si la entrada del usuario es un número válido
                            while (!int.TryParse(Console.ReadLine(), out apuesta) || apuesta <= 0 || apuesta > monedasJugador)
                            {
                                Console.WriteLine("Por favor, ingrese un número válido de monedas para apostar.");
                            }

                            monedasJugador -= apuesta;
                            Console.Clear();
                            Console.WriteLine($"MONEDAS: {monedasJugador}\n");
                            Console.WriteLine($"Su apuesta es de: {apuesta}\n");

                            // Solicitar confirmación al jugador antes de lanzar los dados
                            Console.WriteLine("¿Está listo para lanzar los dados? (s/n)");
                            string respuesta = Console.ReadLine();
                            if (respuesta.ToLower() != "s")
                            {
                                // Si el jugador no está listo para lanzar los dados, se sale del bucle
                                break;
                            }

                            Console.WriteLine("\nLANZANDO LOS DADOS...\n");

                            // Usamos una única instancia de Random para generar los valores de los tres dados
                            Random random = new Random();

                            int dado1 = random.Next(1, 7); // Rango cambiado a 1-6 para incluir el 6
                            int dado2 = random.Next(1, 7);
                            int dado3 = random.Next(1, 7);

                            // Mostrar los resultados de los dados
                            Console.WriteLine("DADO1\tDADO2\tDADO3");
                            Console.WriteLine($"{dado1}\t{dado2}\t{dado3}");

                            // Verificar el resultado del lanzamiento
                            if (dado1 == dado2 && dado2 == dado3)
                            {
                                // Si los tres dados son iguales, el jugador gana
                                Console.WriteLine("¡FELICIDADES! ¡Has ganado x2!");
                                monedasJugador += apuesta * 3; // El jugador recibe el triple de la apuesta
                            }
                            else if (dado1 == dado2 || dado1 == dado3 || dado2 == dado3)
                            {
                                // Si los tres dados son iguales, el jugador gana
                                Console.WriteLine("¡FELICIDADES! ¡Has ganado!");
                                monedasJugador += apuesta * 2; // El jugador recibe eldoble de la apuesta

                            }
                            else
                            {
                                Console.WriteLine("\nLo siento, no has ganado esta vez.");
                            }

                            if (monedasJugador >= monedasSistema)
                            {
                                Console.WriteLine($"FELICITACIONES SUPERASTE LOS {monedasSistema} HAS GANADO EL JUEGO! :)");
                                break;
                            }
                            if (monedasJugador <= 0)
                            {
                                
                                Console.WriteLine("\nLO SIENTO MUCHO TE QUEDASTE SIN MONEDAS, HAS PERDIDO EL JUEGO :(");
                            }

                            // Preguntar al jugador si desea continuar jugando
                            Console.WriteLine("¿Desea continuar jugando? (s/n)");
                            respuesta = Console.ReadLine();
                            if (respuesta.ToLower() != "s")
                            {
                                break; // Salir del bucle si la respuesta no es "s"
                            }
                        }

                        Console.WriteLine("Gracias por jugar. Hasta luego.");

                        Console.WriteLine("\n¿Desea volver atrás? (1/0)\n");
                        select = int.Parse(Console.ReadLine());

                   


                        break;



                    case 2:
                        Console.Clear();
                        Console.WriteLine("REGLAS DEL JUEGO:\n");
                        Console.WriteLine($"- Comienzas con {monedasJugador} monedas, y debes realizar una apuesta.");
                        Console.WriteLine("- Luego de realizada la apuesta elije si lanzar los dados presionado la letra y, seguida de enter para dar un SÍ o ingresa la letra n para dar un NO.");
                        Console.WriteLine("- Si los tres dados dan números diferentes pierdes la apuesta.");
                        Console.WriteLine("- Si lo dados dan dos números iguales multiplicas la apuesta y la sumas a tus monedas.");
                        Console.WriteLine("- Si los tres dados son iguales triplicas la apuesta y la sumas a tus monedas. ");
                        Console.WriteLine($"- Si te quedas sin monedas pierdes, si alcanzas o superas las {monedasSistema} monedas ganas. ");
                        Console.WriteLine("\nIngrese 1 para volver atrás\n");
                        select = int.Parse(Console.ReadLine());

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("SUPER TRES\n");
                        Console.WriteLine("Desarollado por Nicolás Rostagno");
                        Console.WriteLine("Córdoba Argentina");
                        Console.WriteLine("CONTACTO: www.linkedin.com/in/nicoe-rostagno092");
                        Console.WriteLine("\nFebrero 2024.\n©Copyright - Todos lo derechos reservados.");
                        Console.WriteLine("\nIngrese 1 para volver atrás\n");
                        select = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR JUGAR, HASTA PRONTO :)");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        break;



                }




            } while (select == 1);

        }
    }
}
