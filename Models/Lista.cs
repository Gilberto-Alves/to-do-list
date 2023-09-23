using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    [Table("list")]
    public class Lista
    {
        [Key]
        public int Id {get; set;}

        [Column("descricao")]
        public string Descricao { get; set; }

        [Column("conclusao")]
        public bool Conclusao { get; set; }

        [Column("editado")]
        public bool Editado { get; set; }

        public Lista(){}

        public Lista(string des, bool conclu, bool edit){
            this.Descricao = des;
            this.Conclusao = conclu;
            this.Editado = edit;
        }
    }
}