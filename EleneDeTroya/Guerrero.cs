using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Guerrero
    {
        private string nombre;
        private int edad;
        private int fuerza;
        private bool herido;
        private bool muerto;

        //Constructor para crear un guerrero por defecto
        public Guerrero()
        {
            nombre = "GuerreroX";
            edad = 25;
            fuerza = 5;
        }

        public Guerrero(string nombre, int edad, int fuerza)
        {
            this.nombre = nombre;
            if (ComprobarEdad(edad))
            {
                this.edad = edad;
            }
            else
            {
                this.edad = 25;
            }


            if (ComprobarFuerza(fuerza))
            {
                this.fuerza = fuerza;
            }
            else
            {
                this.edad = 25;
            }

            this.fuerza = fuerza;
            //Herido y muerto se inician automáticamente a false

        }

        //GETTERS Y SETTERS
        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
        public int GetFuerza()
        {
            return fuerza;
        }
        public void SetFuerza(int fuerza)
        {
            this.fuerza=fuerza;
        }
        public bool GetHerido()
        {
            return herido;
        }
        public void SetHerido(bool herido)
        {
            this.herido=herido;
        }
        public void SetMuerto(bool muerto)
        {
            this.muerto = muerto;
        }
        public bool GetMuerto()
        {
            return muerto;
        }
        //Métodos de la clase

        //Creo este método virtual para que lo hereden griego y troyano y lo editen para que haga lo que tenga que hacer
        public virtual string Retirarse()
        {
            return "";
        }
        public bool ComprobarEdad(int edad)
        {
            if (edad > 14 && edad < 66)
            {
                return true;
            }
            return false;
        }
        public bool ComprobarFuerza(int fuerza)
        {
            if (fuerza > 0 && fuerza < 11)
            {
                return true;
            }
            return false;
        }
        //Construyo el mensaje que va a ser igual tanto para griego como para troyano
        public override string ToString()
        {
            string mensaje;
            mensaje = "\t\tAcción: Retirarse\nTroyano: " + nombre + "\nEdad: 19" + "   Fuerza: " + fuerza;
            if (herido)
            {
                mensaje = mensaje + "\nEstá herido ----> ";
            }
            else
            {
                mensaje = mensaje + "\nNo está herido ----> ";
            }
            return mensaje; 
        }
    }
}
