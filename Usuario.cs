using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ayuntamiento
{
    public class Usuario
    {
        string nombre;
        string contra;
        List<Reserva> reservas;

        public Usuario(string nombre, string contra) {
            this.nombre = nombre;
            this.contra = contra;
            reservas = new List<Reserva>();
        }
        //busca el nombre
        public override bool Equals(object obj)
        {
            return obj is Usuario usuario &&
                   nombre == usuario.nombre;
        }
       
        public override int GetHashCode()
        {
            return -1597784800 + EqualityComparer<string>.Default.GetHashCode(nombre);
        }

        public string getContra()
        {
            return contra;
        }
        //constructor para el index of
        public Usuario(String nombre) {
            this.nombre = nombre;
        }
        public void setReserva(Reserva reserva)
        {
            this.reservas.Add(reserva);
        }
        public List<Reserva> getReservas()
        {
            return reservas;
        }
    }

    
}
