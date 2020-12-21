using ProjetoEmpresa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEmpresa.Validação
{
    public class AdultoAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value,ValidationContext validationContext)
        {
            Fornecedor fornecedor = (Fornecedor)validationContext.ObjectInstance;
            if(fornecedor.nascimento < 18)
            {
                return new ValidationResult("Apenas Maiores de idade!");
               
            }
            return ValidationResult.Success;
        }
    }
}
