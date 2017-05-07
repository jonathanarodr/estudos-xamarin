using System;
using System.Collections.Generic;
using MaratonaXamarin.Views;

using Xamarin.Forms;

namespace MaratonaXamarin
{
	public partial class DetalheView : ContentPage
	{
		public Veiculo Veiculo { get; set; }

		public DetalheView(Veiculo veiculo)
		{
			InitializeComponent();
			this.Veiculo = veiculo;
			this.BindingContext = this;
		}

		void btnProximo_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushAsync(new AgendamentoView(this.Veiculo));
		}
	}
}
