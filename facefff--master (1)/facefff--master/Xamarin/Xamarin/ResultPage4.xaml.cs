﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage4 : ContentPage
    {
        public ResultPage4()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var result = await App.Database2.GetItemsAsync();


            int size = result.Count;
            await DisplayAlert("ResultPage", "record=" + size, "OK");

            var layout2 = new StackLayout() { Spacing = 10 };
            //foreach (var loc in result)
            //{
            //loc.Num = loc.Spay + loc.Longitude;
            //}
            //await App.Database1.DeleteItemAsync(result[1]);
            /*foreach(var locat in result){
                await App.Database.DeleteItemAsync(locat);
            }*/
            foreach (var location in result)
            {
                var layout3 = new StackLayout();
                //layout3.Children.Add(new Label() { Text = "name:" + location.ID });
                layout3.Children.Add(new Label() { Text = "Spay:" + location.Spay });
                //layout3.Children.Add(new Label() { Text = "Name:" + location.Name });
                //layout3.Children.Add(new Label() { Text = "Day:" + location.Day });
                //layout3.Children.Add(new Label() { Text = "Longitude:" + location.Longitude });
                layout3.Children.Add(new Label() { Text = "Num:" + location.Num });
                //layout3.Children.Add(new Label() { Text = "Day:" + location.Day });
                layout2.Children.Add(layout3);
            }
            layout.Children.Add(layout2);
        }

    }
}