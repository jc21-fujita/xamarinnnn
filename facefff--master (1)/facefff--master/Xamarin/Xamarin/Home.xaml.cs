using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamForms.Controls;
using PublicHoliday;
using Xamarin.Forms.Xaml;
using Xamarin;

namespace Xamarin
{
    public partial class Home : TabbedPage
    {
        public Home()
        {
            InitializeComponent();

            //カレンダー祝日の設定
            calendarrr.SpecialDates = new List<SpecialDate>{
            new SpecialDate(DateTime.Now)
            {
                   TextColor = Color.Green, BorderColor=Color.Green,
                   BorderWidth =8, Selectable = true }
            };

            SetHoliday(DateTime.Now.Year);
        }

        //カレンダー土日の設定
        private void SetWeekend(int year)
        {
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);

            for (var day = startDate.Date; day.Date <= endDate.Date; day = day.AddDays(1))
            {
                if (DayOfWeek.Saturday == day.DayOfWeek)
                {
                    calendarrr.SpecialDates.Add(new SpecialDate(day)
                    {
                        TextColor = Color.Blue
                    });
                }
                else if (DayOfWeek.Sunday == day.DayOfWeek)
                {
                    calendarrr.SpecialDates.Add(new SpecialDate(day)
                    {
                        TextColor = Color.Red
                    });
                }
            }
        }


        //カレンダー祝日の表示

        private void SetHoliday(int year)
        {
            IList<DateTime> result = new JapanPublicHoliday().PublicHolidays(year);

            foreach (var holiday in result)
            {
                calendarrr.SpecialDates.Add(new SpecialDate(holiday)
                {
                    TextColor = Color.Red
                });
            }
        }


        //カレンダー日付クリック
        private async void OnDateClick(object sender, EventArgs e)
        {
            /*base.OnAppearing();
            List<LocationItem> result = await App.Database.GetItemDay(calendarrr.SelectedDates);
            int x = result.Count;
            if (x == 0)
            {
                await this.Navigation.PushModalAsync(new insert2(calendarrr.SelectedDates));
            }
            else
            {*/
            //await this.Navigation.PushModalAsync(new inserted(calendarrr.SelectedDates));
            await this.Navigation.PushModalAsync(new insert(calendarrr.SelectedDates));
            /*}*/
        }

        //設定画面ボタンの画面遷移
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new notification());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new often_use());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new fixed_cost());
        }
        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new salary());
        }
        private async void OnDateClick_detail(object sender, EventArgs e)
        {
            await this.Navigation.PushModalAsync(new inserted(calendar_detail.SelectedDates));
        }
    }

}