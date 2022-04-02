namespace ControleFinanceiro.DAL.Interfaces
{
    public interface IGraficoRepositorio
    {
        object PegarGanhosAnuaisPeloUsuarioId(string usuarioId, int ano);

        object PegarDespesasAnuaisPeloUsuarioId(string usuarioId, int ano);
    }
}