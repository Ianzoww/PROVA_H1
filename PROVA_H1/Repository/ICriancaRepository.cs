using PROVA_H1.Models;
namespace PROVA_H1.Repository
{
    public interface ICriancaRepository
    {
        public void InserirDadosCarta(Crianca crianca);

        public List<Crianca> GetCarta();
    }
}
