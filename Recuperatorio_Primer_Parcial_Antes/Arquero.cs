using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio_Primer_Parcial_Antes
{
    public class Arquero : IEquipo
    {
        public string nombre;
        public string apellido;
        public string club;
        public int numero;


        public void Atajar()
        {

        }

        public void Patear()
        {

        }

        public void guardarEnBD()
        {
            throw new NotImplementedException();
        }


        public void GuardarEnBD()
        {
            EquipoRepository repository = new EquipoRepository();
            repository.guardar(this);
        }
    }
}
