using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace MaratonaXamarin.ViewModels
{
	public class ListagemViewModel : BaseViewModel
	{
		const string url = "http://aluracar.herokuapp.com/";

		public ObservableCollection<Veiculo> Veiculos { get; set; }

		public ListagemViewModel()
		{
			this.Veiculos = new ObservableCollection<Veiculo>();
			//this.Veiculos = new ListagemVeiculo().Veiculos;
		}

		Veiculo veiculoSelecionado;	

		public Veiculo VeiculoSelecionado
		{
			get
			{
				return veiculoSelecionado;
			}
			set
			{
				veiculoSelecionado = value;
				if (value != null) MessagingCenter.Send(veiculoSelecionado, "VeiculoSelecionado");
			}
		}

		public async Task GetVeiculos()
		{
			Aguarde = true;
			HttpClient cliente = new HttpClient();
			var res = await cliente.GetStringAsync(url);
			var veiculos = JsonConvert.DeserializeObject<VeiculoJson[]>(res);

			foreach (var v in veiculos)
			{
				this.Veiculos.Add(new Veiculo
				{
					Nome = v.nome,
					Preco = v.preco
				});
			}

			Aguarde = false;
		}

		class VeiculoJson
		{
			public string nome { get; set; }
			public int preco { get; set; }
		}

		private bool aguarde;
		public bool Aguarde
		{
			get { return aguarde; }
			set {
				aguarde = value;
				OnPropertyChanged();
			}
		}

	}
}
