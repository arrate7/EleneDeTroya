using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Griego : Guerrero
    {
        public Griego(string nombre, int edad, int fuerza) : base(nombre, edad, fuerza)
        {
        }
        public Griego()
        {
            base.SetEdad(20);
            base.SetFuerza(8);
            base.SetNombre("GriegoX");
        }
        //modifico el mensaje de la clase padre y en este caso el mensaje será diferente dependiendo de si el griego está herido o muerto
        public override string Retirarse()
        {
            if (GetHerido())
            {
                return base.Retirarse() + " RETIRADA ";
            }
            else
            {
                return base.Retirarse() + " Los Guerreros " + GetType().Name + " NUNCA se retiran";
            }
        }
        public override string ToString()
        {
            return base.ToString() + Retirarse();
        }

    }
}