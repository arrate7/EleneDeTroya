using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleneDeTroya
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo un caballo con capacidad para 20 guerreros
            Caballo caballo = new Caballo(20);

            //Creo los griegos
            Griego aquiles = new Griego("Aquiles",20,10);
            Griego agamenon = new Griego("Agamenon", 40, 6);
            Griego ajax = new Griego("Ajax", 35, 8);

            //los monto en el caballo
            caballo.MontarseEnElCaballo(agamenon);
            caballo.MontarseEnElCaballo(ajax);
            caballo.MontarseEnElCaballo(aquiles);

            //muestro el caballo con los tres griegos
            caballo.MostrarCaballo();

            //Creo el guerrero griego anónimo
            Griego anonimo = new Griego();

            //lo monto en el caballo
            caballo.MontarseEnElCaballo(anonimo);

            //Busco agamenon en el caballo. Como el método nos devuele la posición en caso de que lo encuentre
            //tengo que usar esa posición para llamar a el método  MostrarGuerreroPosicion
            int pos=caballo.Buscar("Agamenon");
            caballo.MostrarGuerroPosicion(pos);

            //Busco Odiseo y veo que no existe porque el método Buscar me devuelve -1
            pos = caballo.Buscar("Odiseo");
            caballo.MostrarGuerroPosicion(pos);

            //Creo el Guerrero troyano Paris
            Troyano paris = new Troyano("Paris", 18, 7);
            caballo.MontarseEnElCaballo(paris);
            Console.ReadLine();

        }
    }
}
