using System;
using System.Collections.Generic;
namespace MaratonaXamarin
{
	public class ListagemVeiculo
	{
		public List<Veiculo> Veiculos { get; set; }
			
		public ListagemVeiculo()
		{
            this.Veiculos = new List<Veiculo>
			{
				new Veiculo { Nome = "Azera V6", Preco = 60000 },
				new Veiculo { Nome = "Fiesta 2.0", Preco = 50000 },
				new Veiculo { Nome = "Azera V6", Preco = 40000 },
			};
		}
	}
}
