using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight {
    public class PoolDeNotas {
        static Dictionary<string, NotaMusical> Notas;
        public PoolDeNotas(){
            Notas = new Dictionary<string,NotaMusical>();
            Notas.Add("Do", new Do());
            Notas.Add("Re", new Re());
            Notas.Add("Mi", new Mi());
            Notas.Add("Fa", new Fa());
            Notas.Add("Sol", new Sol());
            Notas.Add("La", new La());
            Notas.Add("Si", new Si());
        }
        public NotaMusical getNota(string Nome){
            return Notas[Nome];
        }
    }
}
