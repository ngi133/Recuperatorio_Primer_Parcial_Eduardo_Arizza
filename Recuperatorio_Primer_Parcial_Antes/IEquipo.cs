using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio_Primer_Parcial_Antes
{
    public interface IEquipo
    {
        void Atajar();
        void Patear();
        void guardarEnBD();//El método guardarEnBD() no cumple con DIP porque dentro está acoplando
                           //con una implementación concreta del Repositorio, o sea, es el caso donde una clase
                           //de alto nivel depende directamente de una clase de bajo nivel y no de su abstracción (interfaz).
    }
}
//La interfaz IEquipo no cumple con ISP ni SRP porque obliga a implementar métodos no utilizados 
//y métodos que no son responsabilidad de esas clases guardarEnBD.

