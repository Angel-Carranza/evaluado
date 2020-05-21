using System;

namespace Eva2_MA19011_GL20
{
    class Program
    {
        //En la Tienda “Todo a Cinco” el precio de todos sus productos es de $5.00. Elabore  un programa en C#, utilizando la técnica de 
        //programación modular, que determine e imprima lo que la Tienda necesita conocer a diario:
        // a)	Monto que pagará cada cliente que compre en el día;
        //b)	Cantidad de clientes que compraron en el día
        //c)	Monto total de ventas en el día.

        static int CantCompra(int compra)//modulo que sirve para pedir la cantidad de producto que lleva el cliente
        {
            int Cantidad;
            Console.WriteLine("\nIngrese la cantidad de productos que lleva el cliente", compra);
            Cantidad = int.Parse(Console.ReadLine());
            while(Cantidad<=0)
            {
                Console.WriteLine("cantidad erronea intente con otra cantidad");
                Cantidad = int.Parse(Console.ReadLine());
                    

            }
            return Cantidad;//retorna cantidad de productos
            
         }

        static int ContinuarP()//modulo que sirve para cantinuar o cerrar el bucle
        {
            int continuarL;
            do
            {
                Console.WriteLine("\nSi desea un nuevo proceso preciones\nPulse1 Para repetir este proceso.\n Pulse 0 si ya no desea continuar");
                continuarL = int.Parse(Console.ReadLine());
            }
            while (continuarL != 1 && continuarL != 0);

            return continuarL;

        }




        static void Main(string[] args)
        {
            //declaracion de variables
            int ncompras=1, montoCliente, montoTotal, continuar, cant;
            float producto=5;


            //proceso 
            do
            {
                Console.Clear();
                ncompras = 1;
                ncompras = CantCompra(ncompras);

                while (producto <= ncompras)
                {
                    ncompras = 1;
                    montoCliente = 0;
                    montoTotal = 0;
                    while (producto <= ncompras)
                    {
                        montoCliente += producto;
                        producto++;
                        Console.WriteLine("El monto del cliente es: {0}");
                    }
                    montoTotal += montoCliente;

                    Console.WriteLine("El monto del dia es: {0}");
                }
                continuar = ContinuarP();
            }
            while(continuar != 0)

            //proceso que nos ayudara a finalizar el programa
             Console.WriteLine("\nPrecione Cualquier tecla para finalizar");
            Console.ReadKey(true);





        }

    }
            
        }
    }
}
