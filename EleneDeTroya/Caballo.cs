using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Caballo
    {
        private int capacidad;
        private List<Guerrero> caballo;

        //Me contruye un caballo vacio con capacidad suficiente como la que le paso por parámetro
        public Caballo(int capacidad)
        {
            this.capacidad = capacidad;
            caballo = new List<Guerrero>();
        }

        public void SetCaballo(List<Guerrero> caballo)
        {
            this.caballo = caballo;
        }
        public void SetCapacidad(int capacidad)
        {
            this.capacidad = capacidad;
        }
        public List<Guerrero> GetCaballo()
        {
            return caballo;
        }
        public int GetCapacidad()
        {
            return capacidad;
        }

        public int Buscar(string nombre)
        {
            foreach(Guerrero x in caballo)
            {
                //Si el nombre coincide 
                if (x.GetNombre().ToUpper() == nombre.ToUpper())
                {
                    //me devuelves la posición en la que has encontrado el guerrero
                    return caballo.IndexOf(x);
                }
            }
            return -1;
        }

        public void MostrarGuerroPosicion(int pos)
        {
            //Si la posición que pasamos por parámetro existe en la lista
           if (pos >=0 && pos<= caballo.Count)
            {
                Console.WriteLine("Datos del Guerrero " + caballo.ElementAt(pos).GetType().Name);
                Console.WriteLine("Nombre: " + caballo.ElementAt(pos).GetNombre());
                Console.WriteLine("Edad: " + caballo.ElementAt(pos).GetEdad());
                Console.WriteLine("Fuerza: " + caballo.ElementAt(pos).GetFuerza());
            }else
            {
                Console.WriteLine("No se ha encontrado ningún guerrero en la posición " + pos);
            }
            Console.ReadLine();
        }
        public void MontarseEnElCaballo(Guerrero x)
        {
            //Si es griego y hay sitio
            if (x.GetType().Name=="Griego" && caballo.Count < capacidad)
            {
                Console.WriteLine("Guerrero Griego " + x.GetNombre() + " montado en caballo");
                caballo.Add(x);
            //Si es griego pero no hay sitio
            }else if (x.GetType().Name == "Griego" && caballo.Count >= capacidad)
            {
                Console.WriteLine("No hay sitio en el caballo ");
                caballo.Add(x);
            }
            //si es troyano
            else
            {
                Console.WriteLine("Guerrero Troyano " + x.GetNombre() + " intentando acceder al caballo");
               
            }
            Console.ReadLine();
        }
        public void MostrarCaballo()
        {
            //recorremos el caballo y mostramos los datos de todos los guerreros
            foreach(Guerrero x in caballo)
            {
                Console.WriteLine("*********************");
                Console.WriteLine("Nombre: " + x.GetNombre());
                Console.WriteLine("Edad: " + x.GetEdad());
                Console.WriteLine("Fuerza: " + x.GetFuerza());
            }
            Console.ReadLine();
        }
    }
}
