using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTarea1
{
    class Program
    {
        static string name = "";
        static int numero=0;
        static double numero1 = 0;
        static double numero2 = 0;
        static double numero3 = 0;
        static double numero4 = 0;
        static double numero5 = 0;
        static double numero6 = 0;
        static double numero7 = 0;
        static double numero8 = 0;
        static double numero9 = 0;
        static double numero10 = 0;
        static double cantidad = 0;
        static double comprar1;
        static double comprar2;
        static double comprar3;
        static double comprar4;
        static double comprar5;
        static double comprar6;
        static double comprar7;
        static double comprar8;
        static double comprar9;
        static double comprar10;
        static double resultado1;
        static double resultado2;
        static double resultado3;
        static double resultado4;
        static double resultado5;
        static double resultado6;
        static double resultado7;
        static double resultado8;
        static double resultado9;
        static double resultado10;
        static double orden = 0;
        static double descuento1 = 0;
        static double descuento2 = 0;
        static double descuento3 = 0;
        static double descuento4 = 0;
        static double descuento5 = 0;
        static double descuento6 = 0;
        static double descuento7 = 0;
        static double descuento8 = 0;
        static double descuento9 = 0;
        static double descuento10 = 0;
        static double descuentototal = 0;
        static double impuesto = 0.13;
        static double usuario = 0;
        static double total = 0;
        static double totalimpuesto = 0;
        static double neto = 0;
        static double final = 0;
        static void Main(string[] args
            )
        {
            Console.WriteLine("Ingrese la cantidad de libros que desea comprar por cada titulo");
            Console.WriteLine("El senor de los anillos, Las dos torres.(fantasia)");
            comprar1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Alicia en el pais de las Maravillas. (infantil)");
            comprar2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Cementerio de mascotas.(misterio)");
            comprar3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Quiero aprender (educativo)");
            comprar4 = int.Parse(Console.ReadLine());
            Console.WriteLine("El poder del pensamiento positivo (Superacion)");
            comprar5 = int.Parse(Console.ReadLine());
            Console.WriteLine("Mi primer libro de matematicas.(educativo)");
            comprar6 = int.Parse(Console.ReadLine());
            Console.WriteLine("Las aventuras de Tom Sawyer. (infantil)");
            comprar7 = int.Parse(Console.ReadLine());
            Console.WriteLine("El mago de OZ (fantasia");
            comprar8 = int.Parse(Console.ReadLine());
            Console.WriteLine("La zona muerta(misterio)");
            comprar9 = int.Parse(Console.ReadLine());
            Console.WriteLine("Viaje al centro de la tierra(ciencia ficcion)");
            comprar10 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el monto con el que va a pagar");
            usuario = int.Parse(Console.ReadLine());

            if (comprar1 >= 1)
            {
                numero1 = 2000;
                Console.WriteLine(" ");
                resultado1 = comprar1 * numero1;
                descuento1 = (resultado1 * 0.15);
            }
            else
            {
                Console.WriteLine("");
            }
            if (comprar2 >= 1)
            {

                numero2 = 1000;
                Console.WriteLine(" ");
                resultado2 = comprar2 * numero2;
                descuento2 =  (resultado2 * 0.05);
            }
            else
            {
                Console.WriteLine("");
            }
            if (comprar3 >= 1)
            {

                numero3 = 1500;
                Console.WriteLine(" ");
                resultado3 = comprar3 * numero3;
                descuento3 = (resultado3 * 0.1);
            }
            else
            {
                Console.WriteLine("");
            }
            if (comprar4 >= 1)
            {

                numero4 = 4000;
                Console.WriteLine(" ");
                resultado4 = comprar4 * numero4;
                descuento4 =  (resultado4 * 0.2);
            }
            else
            {
                Console.WriteLine("");
            }
            if (comprar5 >= 1)
            {
                numero5 = 3200;
                Console.WriteLine(" ");
                resultado5 = comprar5 * numero5;
                descuento5 =  (resultado5 * 0.25);
            }
            else
            {
                Console.WriteLine("");
            }
            if (comprar6 >= 1)
            {
                numero6 = 7000;
                Console.WriteLine(" ");
                resultado6 = comprar6 * numero6;
                descuento6 =  (resultado6 * 0.2);
            }
            else
            {
                Console.WriteLine("");
            }
            if (comprar7 >= 1)
            {
                numero7 = 4300;
                Console.WriteLine(" ");
                resultado7 = comprar7 * numero7;
                descuento7 =  (resultado7 * 0.05);
            }
            else
            {
                Console.WriteLine("");
            }
            if (comprar8 >= 1)
            {
                numero8 = 9000;
                Console.WriteLine(" ");
                resultado8 = comprar8 * numero8;
                descuento8 =  (resultado8 * 0.15);
            }
            else
            {
                Console.WriteLine("");
            }
            if (comprar9 >= 1)
            {
                numero9 = 2700;
                Console.WriteLine(" " );
                resultado9 = comprar9 * numero9;
                descuento9 =  (resultado9 * 0.1);
            }
            else
            {
                Console.WriteLine("");
            }
            if (comprar10 >= 1)
            {
                numero10 = 1800;
                Console.WriteLine(" " );
                resultado10= comprar10 * numero10;
                descuento10 =  (resultado10 * 0.25);

            }
            else
            {
                Console.WriteLine("");
            }

            orden = comprar1 + comprar2 + comprar3 + comprar4 + comprar5 + comprar6 + comprar7 + comprar8 + comprar9 + comprar10;
            descuentototal = descuento1 + descuento2 + descuento3 + descuento4 + descuento5 + descuento6 + descuento7 + descuento8 + descuento9 + descuento10;
            total = (resultado1 + resultado2 + resultado3 + resultado4 + resultado5 + resultado6 + resultado7 + resultado8 + resultado9 + resultado10)-descuentototal;
            totalimpuesto=total *0.13;
            neto = total +totalimpuesto;
            final = usuario - neto;

            Console.WriteLine(" *.*                  Libreria El Buen Lector                       *.*");
           
            Console.WriteLine(" =======================================================================");
            Console.WriteLine("Factura Proforma                                                 Nº 0001");
            
            Console.Write("Cliente:  "+name);
            name = Console.ReadLine();
            Console.Write("Telefono: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("                Item                       Ctd      Precio    Sub Total ");
            Console.WriteLine("El senor de los anillos, Las dos torres     "+comprar1+"       "+numero1 + "           " + resultado1);
             
            Console.WriteLine("Alicia en el pais de las Maravillas         " + comprar2 + "       " + numero2 + "           " + resultado2);

            Console.WriteLine("Cementerio de mascotas                      " + comprar3 + "       " + numero3 + "           " + resultado3);

            Console.WriteLine("Quiero aprender                             " + comprar4 + "       " + numero4 + "           " + resultado4);

            Console.WriteLine("El poder del pensamiento positivo           " + comprar5 + "       " + numero5 + "           " + resultado5);

            Console.WriteLine("Mi primer libro de matematicas              " + comprar6 + "       " + numero6 + "           " + resultado6);

            Console.WriteLine("Las aventuras de Tom Sawyer                 " + comprar7 + "       " + numero7 + "           " + resultado7);
             
            Console.WriteLine("El mago de OZ                               " + comprar8 + "       " + numero8 + "           " + resultado8);

            Console.WriteLine("La zona muerta                              " + comprar9 + "       " + numero9 + "           " + resultado9);

            Console.WriteLine("Viaje al centro de la tierra                " + comprar10 + "       " + numero10 + "           " + resultado10);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Total Orden                                                        " + orden);
            Console.WriteLine("Descuento                                                          " + descuentototal);
            Console.WriteLine("Impuesto Venta                                                     13% " );
            Console.WriteLine("Impuesto Total                                                     " + totalimpuesto);
            Console.WriteLine("Precio Neto                                                        "+neto);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("Monto Recibido                                                     "+usuario);
            Console.WriteLine("Monto Cambio                                                       "+final);
            Console.WriteLine(" =======================================================================");
            Console.WriteLine("Gracias por su compra....                                                          ");

            Console.ReadKey();

        }
    }
}
