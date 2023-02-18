using Livraria.Models;

namespace Livraria.Repositorios.interfaces
{
    public interface UsuarioRepI
    {
        Task<List<usermodel>> BuscarTodosUsuarios();

        //Task<usermodel> BuscaId(int Id);

        Task<usermodel> Add(usermodel usuario);

        Task<usermodel> Att(usermodel usuario, int id);

        Task<bool> Apagar(int id);
    }

        

}