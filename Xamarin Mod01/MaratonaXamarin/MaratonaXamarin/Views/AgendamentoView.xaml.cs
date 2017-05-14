using System;
using System.Collections.Generic;
using MaratonaXamarin.Views;
using Xamarin.Forms;

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

		private void btnAgendar_Clicked(object sender, System.EventArgs e) {
			DisplayAlert("Agendamento", string.Format(@"
			Nome: {0}
			Fone: {1}
			Email: {2}
			Data: {3} às {4}", Nome, Fone, Email, data.ToString("dd/MM/yyyy"), Hora), "ok");
		}
	}
}
