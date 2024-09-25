using System.ComponentModel.DataAnnotations;
using PROVA_H1.Validation;

namespace PROVA_H1.Models
{
    public class Crianca
    {
        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoNome(ErrorMessage = "O nome não possui o comprimento adequado")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Rua { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string NumeroCasa { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]

        public string Bairro { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!")]

        public string Cidade { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Estado { get; set; }



        [Required(ErrorMessage = "Campo obrigatório!")]
        [ValidacaoIdade(ErrorMessage = "Não é mais criança")]
        public int Idade { get; set; }


        
        [ValidacaoCarta(ErrorMessage = "Carta excede o tamanho maximo...")]
        public string CartaCrianca { get; set; }
    }
}
