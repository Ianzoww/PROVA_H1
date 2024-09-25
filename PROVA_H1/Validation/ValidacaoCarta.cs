using System.ComponentModel.DataAnnotations;

namespace PROVA_H1.Validation
{
    public class ValidacaoCarta : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return new ValidationResult("Carta vazia...Vai ficar sem presente!");
            }

            string carta = (string)value;

            return carta.Length <= 500 ? ValidationResult.Success : new ValidationResult(ErrorMessage);
        }
    }
}
