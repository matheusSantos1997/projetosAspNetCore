using CrudContatosMvc.Data;
using CrudContatosMvc.Models;


namespace CrudContatosMvc.Repositories
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly BancoContext _context;

        public ContatoRepository(BancoContext context)
        {
            _context = context;
        }

        public ContatoModel ListarPorId(int id)
        {
            return _context.Contatos.FirstOrDefault(x => x.Id == id)!;
        }

        public List<ContatoModel> BuscarTodos(int usuarioId)
        {
            return _context.Contatos.Where(x => x.UsuarioId == usuarioId).ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            _context.Contatos.Add(contato);

            _context.SaveChanges();

            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = ListarPorId(contato.Id);

            if(contatoDB == null)
            {
                throw new Exception("Houve um erro na Atualização do contato!");
            }

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;

            _context.Contatos.Update(contatoDB);
            _context.SaveChanges();

            return contatoDB;
        }

        public bool Excluir(int id)
        {
            ContatoModel contatoDB = ListarPorId(id);

            if(contatoDB == null) throw new Exception("Houve um erro ao deletar um contato!");

            _context.Contatos.Remove(contatoDB);
            _context.SaveChanges();

            return true;
        }
    }
}
