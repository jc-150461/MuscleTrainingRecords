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
    public partial class RecordListPage : ContentPage
    {
        public RecordListPage()
        {
            InitializeComponent();
            var layout = new StackLayout { HorizontalOptions = LayoutOptions.Center, Margin = new Thickness { Top = 100 } };

            //Userテーブルに適当なデータを追加
            MuscleMenuModelCS.InsertMenu("鈴木");
            MuscleMenuModelCS.InsertMenu("田中");
            MuscleMenuModelCS.InsertMenu("斎藤");

            //Userテーブルの行データを取得
            var query = MuscleMenuModelCS.SelectMenu();

            foreach (var Menu in query)
            {

                //Userテーブルの名前列をLabelに書き出します
                layout.Children.Add(new Label { Text = Menu.Menu });
            }

            Content = layout;
        }
        private void RecordListButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

       
    }
}
