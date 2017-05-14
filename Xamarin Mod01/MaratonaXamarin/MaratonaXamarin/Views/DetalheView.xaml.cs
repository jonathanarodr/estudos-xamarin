using System;
using System.Collections.Generic;
using MaratonaXamarin.Views;

using Xamarin.Forms;

namespace MaratonaXamarin
{
	public partial class DetalheView : ContentPage
	{
		private bool onFreioABS;
		private const int FREIO_ABS = 800;
		private bool onArCondicionado;
		private const int AR_CONDICIONADO = 1000;
		private bool onMP3Player;
		private const int MP3_PLAYER = 500;


		public Veiculo Veiculo { get; set; }

		public string FreioABS
		{
			get
			{
				return string.Format("Freio ABS - R$ {0}", FREIO_ABS);
			}
		}

		public bool OnFreioABS {
			get
			{
				return onFreioABS;
			}
			set
			{
				onFreioABS = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(ValorTotal));
			}
		}

		public string ArCondicionado
		{
			get
			{
				return string.Format("Ar Condicionado - R$ {0}", AR_CONDICIONADO);
			}
		}

		public bool OnArCondicionado
		{
			get
			{
				return onArCondicionado;
			}
			set
			{
				onArCondicionado = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(ValorTotal));
			}
		}

		public string MP3Player
		{
			get
			{
				return string.Format("MP3 Player - R$ {0}", MP3_PLAYER);
			}
		}

		public bool OnMP3Player
		{
			get
			{
				return onMP3Player;
			}
			set
			{
				onMP3Player = value;
				OnPropertyChanged();
				OnPropertyChanged(nameof(ValorTotal));
			}
		}

		public string ValorTotal
		{
			get
			{
				return string.Format("Valor total R$ {0}", Veiculo.Preco
				                     + (onFreioABS ? FREIO_ABS : 0)
				                     + (onArCondicionado ? AR_CONDICIONADO : 0)
				                     + (onMP3Player ? MP3_PLAYER : 0));
			}
		}

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
