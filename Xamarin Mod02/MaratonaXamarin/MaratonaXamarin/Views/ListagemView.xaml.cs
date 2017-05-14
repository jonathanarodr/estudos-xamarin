using System.Collections.Generic;
using Xamarin.Forms;
using MaratonaXamarin.ViewModels;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MaratonaXamarin.Views
{
	public partial class ListagemView : ContentPage
	{
		public ListagemViewModel ViewModel { get; set; }

		public ListagemView()
		{
			InitializeComponent();
			this.ViewModel = new ListagemViewModel();
			this.BindingContext = this.ViewModel;
		}

		/*void listViewVeiculo_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			var veiculo = (Veiculo)e.Item;
			Navigation.PushAsync(new DetalheView(veiculo));            
		}*/

		protected async override void OnAppearing()
		{
			base.OnAppearing();
			MessagingCenter.Subscribe<Veiculo>(this, "VeiculoSelecionado",(msg) => {
				Navigation.PushAsync(new DetalheView(msg));
			});

			await this.ViewModel.GetVeiculos();
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			MessagingCenter.Unsubscribe<Veiculo>(this, "VeiculoSelecionado");
		}
	}
}
