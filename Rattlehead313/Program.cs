using System;
using System.Security.Cryptography;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace Rattlehead313
{
    public class Program
    {
        public static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Black;

            int tiempoEspera = 250;
            Console.WriteLine("(0.0)\r\n" +
                "|||");
            Thread.Sleep(tiempoEspera);
            Console.Clear();
            Console.WriteLine("(-.-)\r\n" +
                " ||");
            Thread.Sleep(tiempoEspera);
            Console.Clear();
            Console.WriteLine("(0.0)\r\n" +
                "  |");
            Thread.Sleep(tiempoEspera);
            Console.Clear();
            Console.WriteLine("(-.-)\r\n" +
                " ");
            Thread.Sleep(tiempoEspera);
            Console.Clear();
            Console.WriteLine("(0.0)\r\n" + "|||");
            Thread.Sleep(tiempoEspera);
            Console.Clear();
            Console.WriteLine("(-.0)\r\n" + " ||");
            Thread.Sleep(tiempoEspera);
            Console.Clear();
            Console.WriteLine("(0.0)\r\n" +
                "  |");
            Thread.Sleep(tiempoEspera);
            Console.Clear();
            Console.WriteLine("(0.-)\r\n" +
                "  ");
            Thread.Sleep(tiempoEspera);
            Console.Clear();
            Console.WriteLine("(0.0)\r\n" +
                "|||");
            Thread.Sleep(tiempoEspera);
            Console.Clear();
            Console.WriteLine("Ingrese su nombre de usuario, y después presione 'Enter'\r\n");
            Console.WriteLine("                            .                                            .                            ");
            Console.WriteLine("     *   .                  .              .        .   *          .                                  ");
            Console.WriteLine("  .         .                     .       .           .      .        .                               ");
            Console.WriteLine("        o.                   .                                                                        ");
            Console.WriteLine("         .              .                  .           .                                              ");
            Console.WriteLine("          0.                                                                                          ");
            Console.WriteLine("                 .          .                 ,                ,    ,                                 ");
            Console.WriteLine(" .          \\          .                         .                                                   ");
            Console.WriteLine("      .      \\   ,                                                                                   ");
            Console.WriteLine("   .          o.                 .                   .            .                                   ");
            Console.WriteLine("     .         \\                 ,             .                .                                    ");
            Console.WriteLine("               #\\##\\#      .                              .        .                                ");
            Console.WriteLine("             #  #O##\\###                .                        .                                   ");
            Console.WriteLine("   .        #*#  #\\##\\###                       .                     ,                             ");
            Console.WriteLine("        .   ##*#  #\\##\\##               .                     .                                     ");
            Console.WriteLine("      .      ##*#  #o##\\#         .                             ,       .                            ");
            Console.WriteLine("          .     *#  #\\#     .                    .             .          ,                          ");
            Console.WriteLine("                      \\          .                         .                                         ");
            Console.WriteLine("____ ^\\\\\\___ ^ --____\\\\\\____O______________\\\\\\\\\\\\---\\\\\\___________-- - ______________  ");
            Console.WriteLine("   \\\\\\^^^^^^^*\\ ^^---                                                                             ");
            Console.WriteLine("         ------ ----__ ^                                                                              ");
            Console.WriteLine("   --__                      ___-- ^ ^--__                                                            ");
            String nombre;
            nombre = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingrese su contraseña");
            String contraseña = Console.ReadLine();
            while(nombre!="arnolchuaseneguer" && contraseña != "1234")
            {
                Console.WriteLine("Ingrese su nombre de usuario\r\n");
                nombre = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Ingrese su contraseña");
                contraseña = Console.ReadLine();
            }
            Console.WriteLine("¡Hola " + nombre+"!");

            Console.WriteLine("Escriba su edad en números");
            string pedirEdad;
            pedirEdad = Console.ReadLine();
            Int64 edad;
            while (_ = Int64.TryParse(pedirEdad, out edad)==false)
            {
                Console.WriteLine("Escriba su edad en números");
                pedirEdad = Console.ReadLine();
            }

            Console.WriteLine("Dijite su especie tal como se le muestra: can, felino, vulpino, ofidio, quiróptero, ornitorrinco, humano");
            String especie = Console.ReadLine();
            switch (especie)
            {
                case "can":
                    {
                        nombre += " can";
                        break;
                    }
                case "felino":
                    {
                        nombre += " felino";
                        break;
                    }
                case "vulpino":
                    {
                        nombre += " vulpino";
                        break;
                    }
                case "ofidio":
                    {
                        nombre += " ofidio";
                        break;
                    }
                case "quiróptero":
                    {
                        nombre += " quiróptero";
                        break;
                    }
                case "ornitorrinco":
                    {
                        nombre += " ornitorrinco";
                        break;
                    }
                case "humano":
                    {
                        nombre += " humano";
                        break;
                    }
                default:
                    {
                        nombre += " extraterrestre";
                        break;
                    }
            }
            Console.WriteLine("Dijite su altura en metros (1.89)");
            float Altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Dijite su peso");
            double Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su dirección:");
            String direccion = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Ingrese su planeta:");
            String[] planetas = new string[8];
            planetas[0] = "Mercurio";
            planetas[1] = "Venus";
            planetas[2] = "Tierra";
            planetas[3] = "Marte";
            planetas[4] = "Jupiter";
            planetas[5] = "Saturno";
            planetas[6] = "Urano";
            planetas[7] = "Neptuno";
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(planetas[i]);
            }
            string Planeta = Console.ReadLine();
            Planeta = Planeta.ToLower();
            float energiaP;
            switch (Planeta)
            {
                case "mercurio":
                    {
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.White;
                        direccion += ", Mercurio";
                        energiaP = (float)(Altura * Peso * 3.7);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ", tienes " + edad + " años . Estás en el planeta " + Planeta + ", vives en " + direccion + " y tu energía potencial es " + energiaP);
                        Console.ReadKey();
                        break;
                    }
                case "venus":
                    {
                        Console.Clear();
                        direccion += ", Venus";
                        energiaP = (float)(Altura * Peso * 8.87);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ", tienes " + edad + " años . Estás en el planeta " + Planeta + ", vives en " + direccion + " y tu energía potencial es " + energiaP); Console.ReadKey();
                        break;
                    }
                case "tierra":
                    {
                        Console.Clear();

                        direccion += ", Tierra";
                        energiaP = (float)(Altura * Peso * 9.8);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ", tienes " + edad + " años . Estás en el planeta " + Planeta + ", vives en " + direccion + " y tu energía potencial es " + energiaP); Console.ReadKey();
                        break;
                    }
                case "marte":
                    {
                        Console.Clear();
;
                        direccion += ", Marte";
                        energiaP = (float)(Altura * Peso * 3.721);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ", tienes " + edad + " años . Estás en el planeta " + Planeta + ", vives en " + direccion + " y tu energía potencial es " + energiaP); Console.ReadKey();
                        break;
                    }
                case "jupiter":
                    {
                        Console.Clear();

                        direccion += ", Jupiter";
                        energiaP = (float)(Altura * Peso * 24.79);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ", tienes " + edad + " años . Estás en el planeta " + Planeta + ", vives en " + direccion + " y tu energía potencial es " + energiaP); Console.ReadKey();
                        break;
                    }
                case "saturno":
                    {
                        Console.Clear();

                        direccion += ", Saturno";
                        energiaP = (float)(Altura * Peso * 10.44);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ", tienes " + edad + " años . Estás en el planeta " + Planeta + ", vives en " + direccion + " y tu energía potencial es " + energiaP); Console.ReadKey();
                        break;
                    }
                case "urano":
                    {
                        Console.Clear();

                        direccion += ", Urano";
                        energiaP = (float)(Altura * Peso * 8.87);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ", tienes " + edad + " años . Estás en el planeta " + Planeta + ", vives en " + direccion + " y tu energía potencial es " + energiaP); Console.ReadKey();
                        break;
                    }
                case "neptuno":
                    {
                        Console.Clear();

                        direccion += ", Neptuno";
                        energiaP = (float)(Altura * Peso * 11.15);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ", tienes " + edad + " años . Estás en el planeta " + Planeta + ", vives en " + direccion + " y tu energía potencial es " + energiaP); Console.ReadKey();
                        break;
                    }
            }

        }
    }
}