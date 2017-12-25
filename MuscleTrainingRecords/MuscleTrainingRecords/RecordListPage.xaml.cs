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

         

            //Userテーブルの行データを取得
            var query = RecordsModel.SelectRecords();

            foreach (var Memo in query)
            {

                //Userテーブルの名前列をLabelに書き出します
                layout.Children.Add(new Label { Text = Memo.M_weight});
            }

            Content = layout;

        }
        
        

        private void RecordListButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecordPage());

        }
    }
}
