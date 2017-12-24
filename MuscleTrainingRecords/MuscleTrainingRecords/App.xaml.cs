
using Xamarin.Forms;

namespace MuscleTrainingRecords
{
    public partial class App : Application
    {
        //データベースのパスを格納
        //public static string dbPath;

        //コンストラクタの引数にstring型の引数を追加
        public App()//(string dbPath)
        {
            //AppのdbPathに引数のパスを設定します
           // App.dbPath = dbPath;

            InitializeComponent();

            MainPage = new MuscleTrainingRecords.MainPage();
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
    }
}



/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using Xamarin.Forms;

namespace MuscleTrainingRecords
{
    public partial class App : Application
    {

        public static string dbPath; //データベースのパスを格納

        public App(string dbPath)
        {
            App.dbPath = dbPath; //AppのdbPathに引数のパスを指定

            InitializeComponent();

            MainPage = new MuscleTrainingRecords.MainPage();
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
    }
}
*/
