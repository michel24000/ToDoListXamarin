using ExerciceSynthese.Dal;
using ExerciceSynthese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExerciceSynthese
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TachesPage : ContentPage
	{
		public TachesPage ()
		{
			InitializeComponent ();
		}

        private void BtnRetourMain_Clicked(object sender, EventArgs e)
        {
            //retour page main
            Navigation.PopModalAsync();
        }

        private void BtnValider_Clicked(object sender, EventArgs e)
        {
            Tache tache = new Tache();
            tache.Title = titre.Text;
            tache.Date = dtpDate.Date;
            tache.Description = description.Text;
            tache.Etat = Convert.ToBoolean(etat.Text);
            new TacheDal().Sauvegarder(tache);

            //retour page main
            Navigation.PopModalAsync();
        }
    }
}