using PROVA_H1.Models;


namespace PROVA_H1.Repository
{
    public class CriancaRepository : ICriancaRepository
    {
        public static List<Crianca> listaCriancas = new List<Crianca>();

        public void InserirDadosCarta(Crianca crianca)
        {
            listaCriancas.Add(crianca);
        }

        public List<Crianca> GetCarta()
        {
            return listaCriancas;
        }
    }
}
