using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio_Primer_Parcial_Antes
{
    public class Delantero : IEquipo
    {
        public string nombre;
        public string apellido;
        public string club;
        public int numero;


        public void Atajar()
        {
            return;
        }
        public void Patear()
        {
            return;
        }

        public void guardarEnBD()
        {
            EquipoRepository repository = new EquipoRepository();
            repository.guardar(this);
        }
    }
}
