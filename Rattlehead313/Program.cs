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
            int tiempoEspera =150;
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
            Console.WriteLine("Escriba su nombre, y después presione 'Enter'\r\n");
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
            Console.WriteLine("Hola " + nombre);
            Console.WriteLine("Dijite su altura en centímetros (176)");
            String entrada;
            entrada = Console.ReadLine();
            int Altura = int.Parse(entrada);
            Console.WriteLine("Dijite su peso");
            String entrada2 = Console.ReadLine();
            Console.WriteLine("Dijite su especie");
            String especie = Console.ReadLine();
            int Peso = int.Parse(entrada2);
            Console.WriteLine("Ingrese su planeta tal como se le muestra a continuación");
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
            float energiaP;
            switch (Planeta)
            {
                case "Mercurio":
                    {
                        energiaP = (float)(Altura * Peso * 3.7);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ". Estás en el planeta " +Planeta + " y tu energía potencial es " + energiaP);
                        Console.ReadKey();
                        break;
                    }
                case "Venus":
                    {
                        energiaP = (float)(Altura * Peso * 8.87);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ". Estás en el planeta " + Planeta + " y tu energía potencial es " + energiaP);
                        Console.ReadKey();
                        break;
                    }
                case "Tierra":
                    {
                        energiaP = (float)(Altura * Peso * 9.8);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ". Estás en el planeta " + Planeta + " y tu energía potencial es " + energiaP);
                        Console.ReadKey();
                        break;
                    }
                case "Marte":
                    {
                        energiaP = (float)(Altura * Peso * 3.721);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ". Estás en el planeta " + Planeta + " y tu energía potencial es " + energiaP);
                        Console.ReadKey();
                        break;
                    }
                case "Jupiter":
                    {
                        energiaP = (float)(Altura * Peso * 24.79);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ". Estás en el planeta " + Planeta + " y tu energía potencial es " + energiaP);
                        Console.ReadKey();
                        break;
                    }
                case "Saturno":
                    {
                        energiaP = (float)(Altura * Peso * 10.44);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ". Estás en el planeta " + Planeta + " y tu energía potencial es " + energiaP);
                        Console.ReadKey();
                        break;
                    }
                case "Urano":
                    {
                        energiaP = (float)(Altura * Peso * 8.87);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ". Estás en el planeta " + Planeta + " y tu energía potencial es " + energiaP);
                        Console.ReadKey();
                        break;
                    }
                case "Neptuno":
                    {
                        energiaP = (float)(Altura * Peso * 11.15);
                        Console.WriteLine("Hola " + nombre + ", eres " + especie + ". Estás en el planeta " + Planeta + " y tu energía potencial es " + energiaP);
                        Console.ReadKey();
                        break;
                    }
            }
            
        }
    }
}
