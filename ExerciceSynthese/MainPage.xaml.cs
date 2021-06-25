using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExerciceSynthese
{
	public partial class MainPage : ContentPage

	{
		public MainPage()
		{

            InitializeComponent();
            lblTitre.Text = string.Format("{0}/{1}/{2}", DateTime.Today.Day, DateTime.Today.Month, DateTime.Today.Year);
            List<Tache> taches = new List<Tache>();
            taches = new TacheDal().SelectAll();
            lstTaches.ItemsSource = taches;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        private void LstTaches_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Navigation.PushModalAsync(new Details((Tache) e.Item));
        }

        private void BtnProfil_Clicked(object sender, EventArgs e)
        {
            //navigation sur la page de profilPage
            Navigation.PushModalAsync(new ProfilPage());
        }

        private void BtnTache_Clicked(object sender, EventArgs e)
        {
            //navigation sur la page de tachePage
            Navigation.PushModalAsync(new TachesPage());
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {

        }
    }
}
