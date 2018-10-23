using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Troyano : Guerrero
    {
        public Troyano(string nombre,int edad, int fuerza):base(nombre,edad,fuerza)
        {

        }

        public Troyano()
        {          
            base.SetEdad(18);
            base.SetFuerza(10);
            base.SetNombre("TroyanoX");
        }
        //Modifico este método de la clase padre y le pongo el mensaje que nos indica que los Troyanos nunca se retiran
        public override string Retirarse()
        {
            return base.Retirarse() + " Los Guerreros " + GetType().Name + "s NUNCA se retiran";
        }
        public override string ToString()
        {
            return base.ToString() + Retirarse();
        }

    }
}
