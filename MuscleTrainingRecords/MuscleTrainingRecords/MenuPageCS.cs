using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MuscleTrainingRecords
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public  partial class MenuPageCS : ContentPage
    {
        public MenuPageCS()
        {

            /* Title = "メニュー一覧";
             Content = new StackLayout
             {
                 Children = {
                     new Label {
                         Text = "Welcome to MenuPage!",
                         HorizontalOptions = LayoutOptions.Center,
                         VerticalOptions = LayoutOptions.CenterAndExpand
                     },
                 }
             };*/

            InitializeComponent();

            var training = new List<TrainingCS>
            {
                new TrainingCS { Menu = "腕立て", Load = "☆☆" },
                new TrainingCS { Menu = "腹筋", Load = "☆☆☆" },
            };

            // ListViewを生成する
            listView.ItemsSource = training;
        }



        //SearchBarを押した時のイベントハンドラ
        private void Select_SearchButtonPressed(object sender, EventArgs e)
        {
            DisplayAlert("", Select.Text, "OK");
            /*if (0<=Select.Text.IndexOf(array1))
            {   
            }
            else
            {
                this.listView.ItemsSource = "データがありません";
            }*/

        }


        private void 全部_Clicked(object sender, EventArgs e)
        {
            //配列に値を入れる
            int[] array1 = new int[] { 2, 3, 1, 5, 6 };

            // ListViewを生成する
            listView.ItemsSource = array1;
        }

        private void 腹_Clicked(object sender, EventArgs e)
        {
            //配列に値を入れる
            int[] array1 = new int[] { 2 };

            // ListViewを生成する
            listView.ItemsSource = array1;
        }

        private void 腕_Clicked(object sender, EventArgs e)
        {
            //配列に値を入れる
            int[] array1 = new int[] { 2, 3 };

            // ListViewを生成する
            listView.ItemsSource = array1;
        }

        private void 背中_Clicked(object sender, EventArgs e)
        {
            //配列に値を入れる
            int[] array1 = new int[] { 2, 3, 1 };

            // ListViewを生成する
            listView.ItemsSource = array1;
        }

        private void 胸_Clicked(object sender, EventArgs e)
        {
            //配列に値を入れる
            int[] array1 = new int[] { 2, 3, 1, 5 };

            // ListViewを生成する
            listView.ItemsSource = array1;
        }

        private void 肩_Clicked(object sender, EventArgs e)
        {
            //配列に値を入れる
            int[] array1 = new int[] { 1, 5, 6 };

            // ListViewを生成する
            listView.ItemsSource = array1;
        }

        private void 脚_Clicked(object sender, EventArgs e)
        {
            //配列に値を入れる
            int[] array1 = new int[] { 2, 3, 1 };

            // ListViewを生成する
            listView.ItemsSource = array1;
        }




        private void Sort_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //int s = Sort.SelectedIndex;
            String si = (String)Sort.SelectedItem;
            //if (si==0)
            if (si.Equals("五十音順"))
            {
                // 配列に値を入れる
                int[] array1 = new int[] { 1, 2, 3, 4, 5 };

                // ListViewを生成する
                listView.ItemsSource = array1;
            }
            else
            {
                // 配列に値を入れる
                int[] array1 = new int[] { 5, 4, 3, 2, 1 };

                // ListViewを生成する
                listView.ItemsSource = array1;
            }
        }

       
        
    }
}
