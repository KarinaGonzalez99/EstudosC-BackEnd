using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data
{
	public class FilmeContext : DbContext
	{
		// quais as opçõoes desse contexto, que é o do filme 
		public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
		{

		}

		// referencia ao banco de dados Filme
		public DbSet<Filme> Filmes { get; set; }
	}
}
