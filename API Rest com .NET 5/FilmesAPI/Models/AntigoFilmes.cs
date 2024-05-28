//using System.ComponentModel.DataAnnotations;

//namespace FilmesAPI.Models
//{
//	public class AntigoFilmes
//	{
//		[Key] // sobre o id
//		[Required] // sobre o id
//		public int Id { get; set; }
//		// pra colocarmos restrições ao inves de criar vários ifs e elses, podemos colocar direto aqui as restrições
//		[Required(ErrorMessage = "O campo Título é obrigatório")]
//		public string Titulo { get; set; }
//		[Required(ErrorMessage = "O campo Diretor é obrigatório")]
//		public string Diretor { get; set; }
//		[StringLength(30, ErrorMessage = "O Gênero não pode passar de 30 caracteres")]
//        public string Genero { get; set; }
//		[Range(1,600, ErrorMessage = "A duração deve ter no minímo 1, e no máximp 600 minutos")] // 1 minuto a 600 minutos
//        public int Duracao { get; set; }

//	}
//}
