using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Xamarin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new Home();
            //MainPage = new ResultPage();
            //MainPage = new ResultPage3();
            MainPage = new ResultPage4();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        static LocationItemDatabase database;

        public static LocationItemDatabase Database
        {
            get
            {
                if (database == null)
                {
                    String ss = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s = Path.Combine(ss, "LocationSQLite.db4");
                    database = new LocationItemDatabase(s);
                }
                return database;
            }
        }

        static fixedmoneyDatabase database1;

        public static fixedmoneyDatabase Database1
        {
            get
            {
                if (database1 == null)
                {
                    String ss = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s = Path.Combine(ss, "fixedmoneySQLite.db1");
                    database1 = new fixedmoneyDatabase(s);
                }
                return database1;
            }
        }
        static salarymoneyDatabase database2;

        public static salarymoneyDatabase Database2
        {
            get
            {
                if (database2 == null)
                {
                    String ss = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    String s = Path.Combine(ss, "salarymoneySQLite.db1");
                    database2 = new salarymoneyDatabase(s);
                }
                return database2;
            }
        }
    }
}
