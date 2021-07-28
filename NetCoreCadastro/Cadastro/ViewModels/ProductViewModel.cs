using Cadastro.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.ViewModels
{
    public class ProductViewModel
    {
        [Key]
        [Display(Name = "Código")]
        [Required(ErrorMessage = "O código é requerido.")]
        public int Id { get; set; }

        [Display(Name = "Cliente")]
        [Required(ErrorMessage = "O código é requerido.")]
        public string nome_Cliente { get; set; }

        [Display(Name = "Produto")]
        [Required(ErrorMessage = "O produto é requerido.")]
        public string Produto { get; set; }

        [Display(Name = "Valor")]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [Required (ErrorMessage = "O valor é requirido")]
        public float Value { get; set; }

        [Display(Name = "Ativo")]
        public bool Active { get; set; }

    }
}
