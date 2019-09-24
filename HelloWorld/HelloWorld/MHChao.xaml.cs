using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MHChao : ContentPage
	{
		public MHChao ()
		{
			InitializeComponent ();
		}

        private void Chao_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Chào", "Chào bạn: " + txtHoTen.Text, "Thoát");
        }
    }
}