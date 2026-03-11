using Microsoft.AspNetCore.Mvc;

namespace uc10_Locatem.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class UsuariosController : ControllerBase
    {
        

        [HttpGet("GetAll")]
        public IActionResult GetAllClientes()
        {
            var usuarios = new[]
            {
                new { Id = 1, Nome = "Felipe Aragão", Tipo = "locador", Email = "felipe1@email.com" },
                new { Id = 2, Nome = "Miguel Souza", Tipo = "locatario", Email = "miguel2@email.com" },
                new { Id = 3, Nome = "Rai Silva", Tipo = "locador", Email = "rai3@email.com" },
                new { Id = 4, Nome = "Stephany Costa", Tipo = "locatario", Email = "stephany4@email.com" },
                new { Id = 5, Nome = "Benjamin Alves", Tipo = "locador", Email = "benjamin5@email.com" },
                new { Id = 6, Nome = "Lucas Ferreira", Tipo = "locatario", Email = "lucas6@email.com" },
                new { Id = 7, Nome = "Pedro Henrique", Tipo = "locador", Email = "pedro7@email.com" },
                new { Id = 8, Nome = "Matheus Ribeiro", Tipo = "locatario", Email = "matheus8@email.com" },
                new { Id = 9, Nome = "João Vitor", Tipo = "locador", Email = "joao9@email.com" },
                new { Id = 10, Nome = "Gabriel Martins", Tipo = "locatario", Email = "gabriel10@email.com" },

                new { Id = 11, Nome = "Rafael Gomes", Tipo = "locador", Email = "rafael11@email.com" },
                new { Id = 12, Nome = "Bruno Carvalho", Tipo = "locatario", Email = "bruno12@email.com" },
                new { Id = 13, Nome = "André Teixeira", Tipo = "locador", Email = "andre13@email.com" },
                new { Id = 14, Nome = "Victor Barros", Tipo = "locatario", Email = "victor14@email.com" },
                new { Id = 15, Nome = "Gustavo Rocha", Tipo = "locador", Email = "gustavo15@email.com" },
                new { Id = 16, Nome = "Daniel Pereira", Tipo = "locatario", Email = "daniel16@email.com" },
                new { Id = 17, Nome = "Thiago Mendes", Tipo = "locador", Email = "thiago17@email.com" },
                new { Id = 18, Nome = "Eduardo Nogueira", Tipo = "locatario", Email = "eduardo18@email.com" },
                new { Id = 19, Nome = "Leonardo Batista", Tipo = "locador", Email = "leo19@email.com" },
                new { Id = 20, Nome = "Caio Santana", Tipo = "locatario", Email = "caio20@email.com" },

                new { Id = 21, Nome = "Rodrigo Pires", Tipo = "locador", Email = "rodrigo21@email.com" },
                new { Id = 22, Nome = "Fernando Lopes", Tipo = "locatario", Email = "fernando22@email.com" },
                new { Id = 23, Nome = "Marcelo Freitas", Tipo = "locador", Email = "marcelo23@email.com" },
                new { Id = 24, Nome = "Igor Duarte", Tipo = "locatario", Email = "igor24@email.com" },
                new { Id = 25, Nome = "Renato Farias", Tipo = "locador", Email = "renato25@email.com" },
                new { Id = 26, Nome = "Paulo Azevedo", Tipo = "locatario", Email = "paulo26@email.com" },
                new { Id = 27, Nome = "Henrique Melo", Tipo = "locador", Email = "henrique27@email.com" },
                new { Id = 28, Nome = "Diego Campos", Tipo = "locatario", Email = "diego28@email.com" },
                new { Id = 29, Nome = "Otávio Figueiredo", Tipo = "locador", Email = "otavio29@email.com" },
                new { Id = 30, Nome = "Samuel Torres", Tipo = "locatario", Email = "samuel30@email.com" },

                new { Id = 31, Nome = "Arthur Neves", Tipo = "locador", Email = "arthur31@email.com" },
                new { Id = 32, Nome = "Vitor Hugo", Tipo = "locatario", Email = "vitor32@email.com" },
                new { Id = 33, Nome = "Murilo Tavares", Tipo = "locador", Email = "murilo33@email.com" },
                new { Id = 34, Nome = "Enzo Oliveira", Tipo = "locatario", Email = "enzo34@email.com" },
                new { Id = 35, Nome = "Nathan Coelho", Tipo = "locador", Email = "nathan35@email.com" },
                new { Id = 36, Nome = "Alexandre Lemos", Tipo = "locatario", Email = "alex36@email.com" },
                new { Id = 37, Nome = "Douglas Moraes", Tipo = "locador", Email = "douglas37@email.com" },
                new { Id = 38, Nome = "Patrick Cunha", Tipo = "locatario", Email = "patrick38@email.com" },
                new { Id = 39, Nome = "Fábio Guedes", Tipo = "locador", Email = "fabio39@email.com" },
                new { Id = 40, Nome = "Vinicius Matos", Tipo = "locatario", Email = "vinicius40@email.com" },

                new { Id = 41, Nome = "Leandro Pacheco", Tipo = "locador", Email = "leandro41@email.com" },
                new { Id = 42, Nome = "Adriano Braga", Tipo = "locatario", Email = "adriano42@email.com" },
                new { Id = 43, Nome = "Carlos Eduardo", Tipo = "locador", Email = "carlos43@email.com" },
                new { Id = 44, Nome = "Ricardo Antunes", Tipo = "locatario", Email = "ricardo44@email.com" },
                new { Id = 45, Nome = "Juliano Matias", Tipo = "locador", Email = "juliano45@email.com" }
            };


            return Ok(usuarios);
        }

        [HttpGet("{tipo}/{id}")]

        public IActionResult GetByTipoAndId([FromRoute] string tipo, [FromRoute] int id) 
        {
            var usuarios = new[]
{
                new { Id = 1, Nome = "Felipe Aragão", Tipo = "locador", Email = "felipe1@email.com" },
                new { Id = 2, Nome = "Miguel Souza", Tipo = "locatario", Email = "miguel2@email.com" },
                new { Id = 3, Nome = "Rai Silva", Tipo = "locador", Email = "rai3@email.com" },
                new { Id = 4, Nome = "Stephany Costa", Tipo = "locatario", Email = "stephany4@email.com" },
                new { Id = 5, Nome = "Benjamin Alves", Tipo = "locador", Email = "benjamin5@email.com" },
                new { Id = 6, Nome = "Lucas Ferreira", Tipo = "locatario", Email = "lucas6@email.com" },
                new { Id = 7, Nome = "Pedro Henrique", Tipo = "locador", Email = "pedro7@email.com" },
                new { Id = 8, Nome = "Matheus Ribeiro", Tipo = "locatario", Email = "matheus8@email.com" },
                new { Id = 9, Nome = "João Vitor", Tipo = "locador", Email = "joao9@email.com" },
                new { Id = 10, Nome = "Gabriel Martins", Tipo = "locatario", Email = "gabriel10@email.com" },

                new { Id = 11, Nome = "Rafael Gomes", Tipo = "locador", Email = "rafael11@email.com" },
                new { Id = 12, Nome = "Bruno Carvalho", Tipo = "locatario", Email = "bruno12@email.com" },
                new { Id = 13, Nome = "André Teixeira", Tipo = "locador", Email = "andre13@email.com" },
                new { Id = 14, Nome = "Victor Barros", Tipo = "locatario", Email = "victor14@email.com" },
                new { Id = 15, Nome = "Gustavo Rocha", Tipo = "locador", Email = "gustavo15@email.com" },
                new { Id = 16, Nome = "Daniel Pereira", Tipo = "locatario", Email = "daniel16@email.com" },
                new { Id = 17, Nome = "Thiago Mendes", Tipo = "locador", Email = "thiago17@email.com" },
                new { Id = 18, Nome = "Eduardo Nogueira", Tipo = "locatario", Email = "eduardo18@email.com" },
                new { Id = 19, Nome = "Leonardo Batista", Tipo = "locador", Email = "leo19@email.com" },
                new { Id = 20, Nome = "Caio Santana", Tipo = "locatario", Email = "caio20@email.com" },

                new { Id = 21, Nome = "Rodrigo Pires", Tipo = "locador", Email = "rodrigo21@email.com" },
                new { Id = 22, Nome = "Fernando Lopes", Tipo = "locatario", Email = "fernando22@email.com" },
                new { Id = 23, Nome = "Marcelo Freitas", Tipo = "locador", Email = "marcelo23@email.com" },
                new { Id = 24, Nome = "Igor Duarte", Tipo = "locatario", Email = "igor24@email.com" },
                new { Id = 25, Nome = "Renato Farias", Tipo = "locador", Email = "renato25@email.com" },
                new { Id = 26, Nome = "Paulo Azevedo", Tipo = "locatario", Email = "paulo26@email.com" },
                new { Id = 27, Nome = "Henrique Melo", Tipo = "locador", Email = "henrique27@email.com" },
                new { Id = 28, Nome = "Diego Campos", Tipo = "locatario", Email = "diego28@email.com" },
                new { Id = 29, Nome = "Otávio Figueiredo", Tipo = "locador", Email = "otavio29@email.com" },
                new { Id = 30, Nome = "Samuel Torres", Tipo = "locatario", Email = "samuel30@email.com" },

                new { Id = 31, Nome = "Arthur Neves", Tipo = "locador", Email = "arthur31@email.com" },
                new { Id = 32, Nome = "Vitor Hugo", Tipo = "locatario", Email = "vitor32@email.com" },
                new { Id = 33, Nome = "Murilo Tavares", Tipo = "locador", Email = "murilo33@email.com" },
                new { Id = 34, Nome = "Enzo Oliveira", Tipo = "locatario", Email = "enzo34@email.com" },
                new { Id = 35, Nome = "Nathan Coelho", Tipo = "locador", Email = "nathan35@email.com" },
                new { Id = 36, Nome = "Alexandre Lemos", Tipo = "locatario", Email = "alex36@email.com" },
                new { Id = 37, Nome = "Douglas Moraes", Tipo = "locador", Email = "douglas37@email.com" },
                new { Id = 38, Nome = "Patrick Cunha", Tipo = "locatario", Email = "patrick38@email.com" },
                new { Id = 39, Nome = "Fábio Guedes", Tipo = "locador", Email = "fabio39@email.com" },
                new { Id = 40, Nome = "Vinicius Matos", Tipo = "locatario", Email = "vinicius40@email.com" },

                new { Id = 41, Nome = "Leandro Pacheco", Tipo = "locador", Email = "leandro41@email.com" },
                new { Id = 42, Nome = "Adriano Braga", Tipo = "locatario", Email = "adriano42@email.com" },
                new { Id = 43, Nome = "Carlos Eduardo", Tipo = "locador", Email = "carlos43@email.com" },
                new { Id = 44, Nome = "Ricardo Antunes", Tipo = "locatario", Email = "ricardo44@email.com" },
                new { Id = 45, Nome = "Juliano Matias", Tipo = "locador", Email = "juliano45@email.com" }
            };

            var usuario = usuarios.FirstOrDefault(usuario => usuario.Id == id && usuario.Tipo.ToLower() == tipo.ToLower());

            if(usuario == null)
            {
                return BadRequest(
                    new 
                    {
                        Erro = true,
                        Mensagem = $"O cliente com o id {id} não foi encontrado"
                    }
                    );
            }

            return Ok( usuario );
        }
    }
}
