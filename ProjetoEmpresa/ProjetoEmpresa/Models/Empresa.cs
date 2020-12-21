using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Models
{
    public class Empresa
    {
        [Key]
        public int empresaId { get; set; }

     
        [Display(Name = "UF:")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(2, ErrorMessage = "Maximo de Caracteres permitido 2")]
        public string uf { get; set; }

        [Display(Name = "Nome Fantasia:")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string nomeFantasia { get; set; }

        [Remote("EmpresaExiste", "Empresa")]
        [Display(Name = "CNPJ:")]
        public string cnpj { get; set; }

        public ICollection<Fornecedor> Fornecedores { get; set; }
    }
}
