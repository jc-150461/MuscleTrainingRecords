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
	public partial class RecordPage : ContentPage
	{

        //DateTime yyyymmdd;

		public RecordPage ()
		{
			InitializeComponent ();
		}
        /*
        private void Insert_Clicked(object sender, EventArgs e)//保存(インサート)ボタンを押したとき
        {
            MuscleModelCS.InsertMuscle(yyyymmdd.ToString(),Weight.Text, Reg.Text);
            //DisplayAlert("記録しました");

            Navigation.PushAsync(new RecordListPage());


        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e) //Dateピッカーで日付を選択したとき
        {
            yyyymmdd = new DateTime(DatePicker.Date.Year, DatePicker.Date.Month, DatePicker.Date.Day);

        }
        */
    }
}