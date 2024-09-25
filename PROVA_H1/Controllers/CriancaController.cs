using Microsoft.AspNetCore.Mvc;
using PROVA_H1.Repository;
using PROVA_H1.Models;

namespace PROVA_H1.Controllers
{
    [ApiController]
    [Route("API/CriancaController")]
    public class CriancaController : ControllerBase
    {


        private readonly ICriancaRepository _criancaRepository;
        public CriancaController(ICriancaRepository criancaRepository)
        {
            _criancaRepository = criancaRepository;
        }


        [HttpPost]
        [Route("ReceberDados")]
        public IActionResult ReceberDados(Crianca crianca)
        {
            _criancaRepository.InserirDadosCarta(new Crianca()
            {
                Nome = crianca.Nome,
                Idade = crianca.Idade,
                Rua = crianca.Rua,
                Bairro = crianca.Bairro,
                NumeroCasa = crianca.NumeroCasa,
                Estado = crianca.Estado,
                Cidade = crianca.Cidade,
                CartaCrianca = crianca.CartaCrianca
            }
             );
            return Ok($"{crianca.Nome}, papai Noel vai entregar seu presente!");
        }


        [HttpGet]
        [Route("ObterCartas")]
        public IActionResult ObterCartas()
        {
            return Ok(_criancaRepository.GetCarta());
        }
    }
}
