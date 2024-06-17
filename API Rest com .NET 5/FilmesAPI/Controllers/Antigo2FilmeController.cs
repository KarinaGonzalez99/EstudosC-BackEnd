//using FilmesAPI.Data;
//using FilmesAPI.Data.Dtos;
//using FilmesAPI.Models;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace FilmesAPI.Controllers
//{ // REFATORADO
//	[ApiController]
//	[Route("[controller]")]

//	public class FilmeController : ControllerBase
//	{
//		private FilmeContext _context;
//		public FilmeController(FilmeContext context)
//		{
//			_context = context;
//		}



//		[HttpPost]
//		public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto) // refatorado
//		{
//			Filme filme = new Filme // criado na refatoração
//			{
//				Titulo = filmeDto.Titulo,
//				Genero = filmeDto.Genero,
//				Duracao = filmeDto.Duracao,
//				Diretor = filmeDto.Diretor
//			};
//			_context.Filmes.Add(filme);
//			_context.SaveChanges();
//			return CreatedAtAction(nameof(RecuperaFilmesPorId), new { Id = filme.Id }, filme);
//		}

//		[HttpGet]
//		public IEnumerable<Filme> RecuperaFilmes()
//		{
//			return _context.Filmes;
//		}

//		[HttpGet("{id}")]
//		public IActionResult RecuperaFilmesPorId(int id)
//		{
//			Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
//			if (filme != null)
//			{
//				ReadFilmeDto filmeDto = new ReadFilmeDto
//				{
//					Id = filme.Id,
//					Titulo = filme.Titulo,
//					Genero = filme.Genero,
//					Diretor = filme.Diretor,
//					Duracao = filme.Duracao,
//					HoraDaConsulta = DateTime.Now

//				};

//				return Ok(filmeDto);
//			}
//			return NotFound();
//		}

//		[HttpPut("{id}")]
//		public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto) // refatorado
//		{
//			Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
//			if (filme == null)
//			{
//				return NotFound();
//			}
//			filme.Titulo = filmeDto.Titulo;
//			filme.Genero = filmeDto.Genero;
//			filme.Diretor = filmeDto.Diretor;
//			filme.Duracao = filmeDto.Duracao;
//			_context.SaveChanges();
//			return NoContent();
//		}

//		[HttpDelete("{id}")]
//		public IActionResult DeletaFilme(int id)
//		{
//			Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
//			if (filme == null)
//			{
//				return NotFound();
//			}
//			_context.Remove(filme);
//			_context.SaveChanges();
//			return NoContent();
//		}

//	}
//}
