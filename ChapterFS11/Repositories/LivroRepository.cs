using ChapterFS11.Context;
using ChapterFS11.Models;


namespace ChapterFS11.Repositories
{
    // classe onde manipulamos o banco de dados
    public class LivroRepository
    {
        private readonly SqlContext _context;
        public LivroRepository(SqlContext context)
        {
            _context = context;
        }

        public List<Livro> Listar()
        {
            return _context.Livros.ToList();
        }
    }
}
