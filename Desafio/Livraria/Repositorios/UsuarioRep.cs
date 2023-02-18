using Livraria.Models;
using Livraria.Dados;
using Livraria.Repositorios.interfaces;

namespace Livraria.Repositorios
{
    public class UsuarioRep : UsuarioRepI
    {
        private readonly TarefasDB _dbContext;

        public UsuarioRep(TarefasDB tarefasDB)
        {
            _dbContext = tarefasDB;
        }

        public async Task<usermodel> Add(usermodel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<bool> Apagar(int id)
        {
            usermodel usuarioId = await BuscaId(id);

            if(usuarioId == null)
            {
                throw new Exception($"Num achou o usuario: {id}");
            }

            _dbContext.Usuarios.Remove(usuarioId);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<usermodel> Att(usermodel usuario, int id)
        {
            usermodel usuarioId = await BuscaId(id);

            if(usuarioId == null)
            {
                throw new Exception($"Num achou o usuario: {id}");
            }

            usuarioId.name  = usuario.name ;
            usuarioId.email = usuario.email;

            _dbContext.Usuarios.Update(usuarioId);
            await _dbContext.SaveChangesAsync();

            return usuarioId;
        }

        public async Task<usermodel> BuscaId(int Id)
        {
            return  await _dbContext.Usuarios.FirstOrDefault(x => x.Id == Id);
        }

        public async Task<List<usermodel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }
    }
}

