using System.Collections.Generic;

using OxyPlot;


namespace MuscleTrainingRecords
{
    class LineChart
    {
        //public PlotModel Model { get; private set; }

        public LineChart()
        {
            /*this.Model = new PlotModel { Title = "" };

            var X_line = new LineSeries();
            X_line.Color = OxyColors.Red;
            X_line.Points.Add(new DataPoint(0, 0));
            X_line.Points.Add(new DataPoint(1, 4));
            X_line.Points.Add(new DataPoint(2, 1));
            X_line.Points.Add(new DataPoint(3, 3));
            Model.Series.Add(X_line);

            var Y_line = new LineSeries();
            Y_line.Color = OxyColors.Blue;
            Y_line.Points.Add(new DataPoint(0, 0));
            Y_line.Points.Add(new DataPoint(1, 2));
            Y_line.Points.Add(new DataPoint(2, 0));
            Y_line.Points.Add(new DataPoint(3, 6));
            Model.Series.Add(Y_line);
            */
           /************************************ここからついか**************************************/
            DataList1 = new List<DataPoint>
            {
                {new DataPoint(0, 0)},
                {new DataPoint(2, 4)},
                {new DataPoint(5, 8)},
                {new DataPoint(8, 3)},
                {new DataPoint(12, 5)},
            };


            DataList2 = new List<DataPoint>
            {
                {new DataPoint(0, 0)},
                {new DataPoint(2, 4)},
                {new DataPoint(5, 8)},
                {new DataPoint(8, 3)},
                {new DataPoint(12, 5)},
            };
        }

         public List<DataPoint> DataList1 { get; }
         public List<DataPoint> DataList2 { get; }
        /************************************ここからまで**************************************/
    }
}

