using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ayuntamiento
{
    public class Reserva
    {
        String puesto;
        String hora;
        String vecino;

        public Reserva(string puesto, string hora, string vecino)
        {
            this.puesto = puesto;
            this.hora = hora;
            this.vecino = vecino;
        }
        //constructor para el equals
        public Reserva(string hora)
        {
            this.hora = hora;
        }
        //equals para comprobar las horas disponibles
        public override bool Equals(object obj)
        {
            return obj is Reserva reserva &&
                   hora == reserva.hora;
        }

        public override int GetHashCode()
        {
            return 1604164965 + EqualityComparer<string>.Default.GetHashCode(hora);
        }

        public String getHora()
        {
            return hora;
        }
        public string getPuesto()
        {
            return puesto;
        }
        public string getUsuario()
        {
            return vecino;
        }



    }

}
