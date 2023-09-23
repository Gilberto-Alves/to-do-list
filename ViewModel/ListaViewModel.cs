using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.ViewModel
{
    public class ListaViewModel
    {
        public string Descricao { get; set; }

        public bool Conclusao { get; set; }

        public bool Editado { get; set; }
    }
}