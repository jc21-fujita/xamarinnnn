using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class salary : ContentPage
	{
		public salary ()
		{
			InitializeComponent ();

            touroku.Clicked += tourokuClicked;
        }
        private void tourokuClicked(object sender, EventArgs e)
        {
            int kin = int.Parse(money.Text);
            //DateTime dt1 = DateTime.Parse(dd);
            //DateTime dt1 = DateTime.Parse(dd);
            salarymoney item = new salarymoney()
            {
                Spay = kin,
            };
            Save(item);
        }
        public async void Save(salarymoney item)
        {
            //await App.Database.SaveItemAsync(item);
            await DisplayAlert("DATA", "登録しました", "OK");
            await App.Database2.SaveItemAsync(item);
        }
    }
}