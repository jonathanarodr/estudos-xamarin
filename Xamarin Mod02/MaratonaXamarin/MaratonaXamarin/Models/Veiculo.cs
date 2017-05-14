using System;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
namespace MaratonaXamarin
{
	public class Veiculo
	{
		public const int FREIO_ABS = 800;
		public const int AR_CONDICIONADO = 1000;
		public const int MP3_PLAYER = 500;

		[JsonPropertyAttribute(PropertyName = "nome")]
		public string Nome { get; set; }
		[JsonPropertyAttribute(PropertyName = "preco")]
		public decimal Preco { get; set; }
		public string PrecoFormatado
		{
			get { return string.Format("R$ {0}", Preco); }
		}
	}	
}
