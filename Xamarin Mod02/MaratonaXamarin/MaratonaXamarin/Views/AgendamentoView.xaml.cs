using System;
using System.Collections.Generic;
using MaratonaXamarin.Views;
using Xamarin.Forms;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace MaratonaXamarin
{
	public partial class AgendamentoView : ContentPage
	{
		public Veiculo Veiculo { get; set; }
		public string Nome { get; set; }
		public string Fone { get; set; }
		public string Email { get; set; }
		public DateTime data = DateTime.Today;
		public TimeSpan Hora { get; set; }

		public DateTime Data
		{
			get
			{
				return data;	
			}
			set
			{
				data = value;
			}
		}
		public TimeSpan hora { get; set; }

		public AgendamentoView(Veiculo veiculo)
		{
			InitializeComponent();
			this.Veiculo = veiculo;
			this.BindingContext = this;
		}

		private async void btnAgendar_Clicked(object sender, System.EventArgs e) {
			var ok = await DisplayAlert("Salvar agendamento", "Confirma o agendamento?", "Sim", "Não");

			if (!ok)
			{
				return;
			}

			string url = "https://aluracar.herokuapp.com/salvaragendamento";
			HttpClient client = new HttpClient();

			var json = JsonConvert.SerializeObject(new {
				nome = Nome,
				fone = Fone,
				email = Email,
				carro = Veiculo.Nome,
				preco = Veiculo.Preco,
				dataAgendamento = DateTime.Now
			});
			var content = new StringContent(json, Encoding.UTF8, "application/json");

			var res = await client.PostAsync(url, content);

			if (res.IsSuccessStatusCode)
				await DisplayAlert("Agendamento", "Agendamento realizado com sucesso", "ok");
			else
				await DisplayAlert("Agendamento", "Falha ao realizar o agendamento, tente novamente", "ok");
				
		}
	}
}
