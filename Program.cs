using System;

namespace HOTEL_EL_PROYECTO_FINAL
{
    class Program
    {
        static void Main(string[] args)
        {
            int HabitacionesAgregadas = 0;
            int MaxHabitaciones = 0;
            Console.WriteLine("---Hotel Burj Al Arab---\n");
            Console.WriteLine("Escriba el numero de habitaciones que tiene el hotel");
            MaxHabitaciones = Convert.ToInt32(Console.ReadLine());
            while (MaxHabitaciones == 0)
            {
                Console.WriteLine("Un hotel sin habitaciones, no tiene sentido, pon otro numero");
                MaxHabitaciones = Convert.ToInt32(Console.ReadLine());
            }


            int[] NumeroHabitacion = new int[MaxHabitaciones];
            int[] ValorHabitacion = new int[MaxHabitaciones];
            int[] PersonasHabitacion = new int[MaxHabitaciones];
            int[] DiasReserva = new int[MaxHabitaciones];
            while (HabitacionesAgregadas < MaxHabitaciones)
            {
                if (HabitacionesAgregadas > 0)
                {
                    int t = 0;
                    Console.WriteLine("Habitaciones Actuales: \n");
                    while (t < HabitacionesAgregadas)
                    {

                        Console.WriteLine("Numero Habitacion: " + NumeroHabitacion[t] + "\nNumero de Personas en la habitacion: " + PersonasHabitacion[t] + "\nValor total de la habitacion: " + ValorHabitacion[t] + "\nDias de reserva: " + DiasReserva[t] + "\n\n\n--------\n\n\n");
                        t = t + 1;
                    }

                }
                int temp1 = 0;
                int temp2 = 0;
                int temp3 = 0;
                int temp4 = 0;
                Console.WriteLine("Escriba el numero de puerta de la habitacion\n");
                temp1 = Convert.ToInt32(Console.ReadLine());
                if (HabitacionesAgregadas > 0)
                {

                    int x = 0;
                    while (x < HabitacionesAgregadas)
                    {
                        bool YaExiste = false;
                        while (temp1 == NumeroHabitacion[x])
                        {
                            YaExiste = true;
                            Console.WriteLine("Ese numero de habitacion no esta disponible, escribe nuevamente\n");
                            temp1 = Convert.ToInt32(Console.ReadLine());

                        }
                        if (YaExiste == false)
                        {
                            x = x + 1;
                        }
                        else
                        {
                            x = 0;
                        }
                    }
                }
                Console.WriteLine("Escriba el valor de la habitacion\n");
                temp2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escriba el numero de personas de la habitacion\n");
                temp3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Escriba el numero de dias que sera reservada la habitacion\n");
                temp4 = Convert.ToInt32(Console.ReadLine());

                NumeroHabitacion[HabitacionesAgregadas] = temp1;
                ValorHabitacion[HabitacionesAgregadas] = (temp2 * temp3) + (temp2 * temp4);
                PersonasHabitacion[HabitacionesAgregadas] = temp3;
                DiasReserva[HabitacionesAgregadas] = temp4;
                HabitacionesAgregadas = HabitacionesAgregadas + 1;
                Console.WriteLine("Habitacion Agregada!\n");
            }
            if (HabitacionesAgregadas > 0)
            {
                int t = 0;
                Console.WriteLine("HABITACIONES LLENAS: \n");
                Console.WriteLine("Habitaciones Actuales: \n");
                while (t < HabitacionesAgregadas)
                {

                    Console.WriteLine("Numero Habitacion: " + NumeroHabitacion[t] + "\nNumero de Personas en la habitacion: " + PersonasHabitacion[t] + "\nValor total de la habitacion: " + ValorHabitacion[t] + "\nDias de reserva: " + DiasReserva[t] + "\n\n\n--------\n\n\n");
                    t = t + 1;
                }
                Console.WriteLine("HABITACIONES LLENAS \n");
            }
            Console.WriteLine("Presiona cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}