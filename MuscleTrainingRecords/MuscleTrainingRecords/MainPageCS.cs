using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MuscleTrainingRecords
{
    public class MainPageCS : TabbedPage
    {
        public MainPageCS()
        {

            var navigationPage = new NavigationPage(new RecordListPageCS());
            navigationPage.Title = "記録";

            var navigationPage2 = new NavigationPage(new TrainingLogPageCS());
            navigationPage2.Title = "トレーニング履歴";

            var navigationPage3 = new NavigationPage(new MenuPageCS());
            navigationPage3.Title = "メニュー一覧";

            var navigationPage4 = new NavigationPage(new GraphPageCS());
            navigationPage.Title = "ボディー統計";

            var navigationPage5 = new NavigationPage(new RMPageCS());
            navigationPage.Title = "RM計算";

            Children.Add(navigationPage);
            Children.Add(navigationPage2);
            Children.Add(navigationPage3);
            Children.Add(navigationPage4);
            Children.Add(navigationPage5);
        }
    }
}








