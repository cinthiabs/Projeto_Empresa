using Microsoft.AspNetCore.Mvc;
using ProjetoEmpresa.Validação;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Models
{
    public class Fornecedor
    {
        [Key]
        public int idfornecedor { get; set; }

        [Display(Name = "Empresa:")]
        public int empresaId { get; set; }
        public Empresa Empresa { get; set; }

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string nome { get; set; }
        
       [Remote("fornecedorpessoa", "Fornecedor")]
        [Display(Name = " Tipo de Pessoa(Fisica/Juridica):")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string pessoa { get; set; }
        
       
        [Display(Name = "CPF ou CNPJ:")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string cpf_cnpj { get; set; }


        [Display(Name = "RG:")]
        public string rg { get; set; }


        [Display(Name = "Data:")]
        [DataType(DataType.Date)]
        public DateTime datahora { get; set; }

        [Adulto]
        [Display(Name = "Idade:")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        [Range(18, 90, ErrorMessage = "Idade Invalida")]
        public int nascimento { get; set; }

        [Display(Name = "Telefone:")]
        [Required(ErrorMessage = "Campo Obrigatório")]
        public string telefone { get; set; }


    }
}
