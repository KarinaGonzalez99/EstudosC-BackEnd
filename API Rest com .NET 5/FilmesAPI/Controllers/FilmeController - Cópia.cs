using FilmesAPI.Data;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.AntigoFilmeController
{
	// definindo como controlador:
	[ApiController]
	//definir a rota
	[Route("[controller]")]
	public class FilmeController : ControllerBase
	{
		private FilmeContext _context;
		public FilmeController(FilmeContext context)
		{
			_context = context;
		}
		// agora que temos o banco de dados criados não precisamos salvar numa lista
		//private static List<Filme> filmes = new List<Filme>();
		//// adicionar diretamente o id em todos:
		//private static int id = 1;


		[HttpPost]
		// quando eu enviar uma requisição eu quero que adiciona um filme:
		public IActionResult AdicionaFilme([FromBody] Filme filme) // from body pq vem do corpo da requisição
		{
			_context.Filmes.Add(filme);
			//salvar estado dela:
			_context.SaveChanges();
			//filme.Id = id++;
			// guardar de maneira simples:
			//filmes.Add(filme);
			//Console.WriteLine(filme.Titulo);
			return CreatedAtAction(nameof(RecuperaFilmesPorId), new { Id = filme.Id }, filme);// aonde esse recurso foi criado
		}

		[HttpGet]
		public IEnumerable<Filme> RecuperaFilmes()
		{
			return _context.Filmes;
		}

		[HttpGet("{id}")]
		public IActionResult RecuperaFilmesPorId(int id)
		{
			//foreach (Filme filme in filmes)
			//{
			//	if (filme.Id == id)
			//	{
			//		return filme;
			//	}
			//}
			//return null;

			Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
			if (filme != null)
			{
				return Ok(filme); // ok é a chamada
			}
			return NotFound();
		}

		[HttpPut("{id}")]
		public IActionResult AtualizaFilme(int id, [FromBody] Filme filmeNovo)
		{
			Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
			if (filme == null)
			{
				return NotFound();
			}
			filme.Titulo = filmeNovo.Titulo;
			filme.Genero = filmeNovo.Genero;
			filme.Diretor = filmeNovo.Diretor;
			filme.Duracao = filmeNovo.Duracao;
			_context.SaveChanges();
			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult DeletaFilme(int id)
		{
			Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
			if (filme == null)
			{
				return NotFound();
			}
			_context.Remove(filme);
			_context.SaveChanges();
			return NoContent();
		}

	}
}
