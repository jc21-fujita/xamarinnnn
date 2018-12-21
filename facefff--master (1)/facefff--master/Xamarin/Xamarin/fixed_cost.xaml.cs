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
    public partial class fixed_cost : TabbedPage
    {
        public  fixed_cost()
        {
            InitializeComponent();

            b1.Clicked += b1Clicked;
            b2.Clicked += b2Clicked;
            b3.Clicked += b3Clicked;
            touroku.Clicked += tourokuClicked;

        }

        private void tourokuClicked(object sender, EventArgs e)
        {
            int kin = int.Parse(money.Text);
            //DateTime dt1 = DateTime.Parse(dd);
            //DateTime dt1 = DateTime.Parse(dd);
            fixedmoney item = new fixedmoney()
            {
                Spay = kin,
                Name = koumoku.Text
            };
            Save(item);
        }

        public async void Save(fixedmoney item)
        {
            //await App.Database.SaveItemAsync(item);
            await DisplayAlert("DATA", "登録しました", "OK");
            await App.Database1.SaveItemAsync(item);
        }

        private void b1Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b1.Text;
        }
        private void b2Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b2.Text;
        }
        private void b3Clicked(object sender, EventArgs e)
        {
            koumoku.Text = b3.Text;
        }

    }
}