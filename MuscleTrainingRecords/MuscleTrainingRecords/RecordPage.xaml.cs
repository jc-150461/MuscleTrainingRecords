﻿using System;
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
		public RecordPage ()
		{
			InitializeComponent ();
		}

        private void 追加_Activated(object sender, EventArgs e)
        {
           
                Navigation.PushAsync(new RecordPage());
            
        }
    }
}