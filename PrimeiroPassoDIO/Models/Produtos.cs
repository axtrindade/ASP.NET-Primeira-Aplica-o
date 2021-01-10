using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiroPassoDIO.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }
    }
}
