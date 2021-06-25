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
	public partial class Details : ContentPage
	{
        Tache tache = new Tache();
		public Details (Tache _tache)
		{
            tache = _tache;
			InitializeComponent ();
		}

        private void BtnRetour_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}