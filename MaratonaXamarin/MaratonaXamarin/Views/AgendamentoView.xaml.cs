using System;
using System.Collections.Generic;
using MaratonaXamarin.Views;
using Xamarin.Forms;

namespace MaratonaXamarin
{
	public partial class AgendamentoView : ContentPage
	{
		public Veiculo Veiculo { get; set; }

		public AgendamentoView(Veiculo veiculo)
		{
			InitializeComponent();
			this.Veiculo = veiculo;
			this.BindingContext = this;
		}
	}
}
