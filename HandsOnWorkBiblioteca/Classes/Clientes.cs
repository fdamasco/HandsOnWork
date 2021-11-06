using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


//Biblioteca destinada às regras de negócio
namespace HandsOnWorkBiblioteca
{
    public class Clientes
    {
        //Subclasse que representa a unidade de Cliente
        public class Unit
        {
            
            public int Id { get; set; }

            [Required(ErrorMessage = "Campo 'Nome' é obrigatório!")]
            public string Nome { get; set; }

            [Required(ErrorMessage = "Campo 'CPF' é obrigatório!")]
            [RegularExpression(("[0-9]+"), ErrorMessage = "O campo 'CPF' aceita apenas números!")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "O campo 'CPF' deve ter 11 dígitos!")]

            public string Cpf { get; set; }

            [Required(ErrorMessage = "Campo 'E-mail' é obrigatório!")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Campo 'Conta' é obrigatório!")]
            [RegularExpression(("[0-9]+"), ErrorMessage = "Campo 'Conta' aceita apenas números!")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "Campo 'Conta' deve ter 8 dígitos!")]
            public string Conta { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());

                }
            }
            //Subclasse que representa uma lista de Clientes
            public class List
            {
                //A lista de clientes é um conjuntod de Clientes.Unit
                public List<Unit> ListUnit { get; set; }
            }
        }

    }
}
