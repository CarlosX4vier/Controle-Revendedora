using System.Collections.Generic;

namespace ControleRevendaWF.Models
{
    public class Revendedora
    {
        public long Id;
        public string Nome;
        public string Sobrenome;
        public List<Catalogo> Catalogos = new List<Catalogo>();
    }
}
