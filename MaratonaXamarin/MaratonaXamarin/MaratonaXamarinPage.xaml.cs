using System.Collections.Generic;
using Xamarin.Forms;

namespace MaratonaXamarin
{
	public class Veiculo
	{
		public string Nome { get; set; }
		public decimal Preco { get; set; }
	}	

	public partial class MaratonaXamarinPage : ContentPage
	{
		public List<Veiculo> Veiculos { get; set; }

		public MaratonaXamarinPage()
		{
			InitializeComponent();

			this.Veiculos = new List<Veiculo>
			{
				new Veiculo { Nome = "Azera V6", Preco = 60000 },
				new Veiculo { Nome = "Fiesta 2.0", Preco = 50000 },
				new Veiculo { Nome = "Azera V6", Preco = 40000 },
			};

			this.BindingContext = this;
		}
	}
}
