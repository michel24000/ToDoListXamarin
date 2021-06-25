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
	public partial class ProfilPage : ContentPage
	{
        private Profil profilGeneral = new Profil();
		public ProfilPage ()
		{
			InitializeComponent ();
            profilGeneral = new ProfilDal().Select(1);
            if(profilGeneral != null)
            {
                Nom.Text = profilGeneral.Nom;
                Prenom.Text = profilGeneral.Prenom;
                Age.Text = profilGeneral.Age.ToString();
            }


        }

        private void BtnRetourProfil_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        private void BtnValider_Clicked(object sender, EventArgs e)
        {

            profilGeneral.Nom = Nom.Text;
            profilGeneral.Prenom = Prenom.Text;
            profilGeneral.Age = Convert.ToInt16(Age.Text);
            new ProfilDal().Sauvegarder(profilGeneral);

            //retour page main
            Navigation.PopModalAsync();
        }
    }
}