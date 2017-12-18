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
        }
        private void RecordListButton(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MenuPage());
        }
    }
}
