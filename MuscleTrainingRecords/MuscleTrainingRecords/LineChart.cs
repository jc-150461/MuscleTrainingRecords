﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OxyPlot;
using OxyPlot.Series;
using OxyPlot.Axes;


namespace MuscleTrainingRecords
{
    class LineChart
    {
        public PlotModel Model { get; private set; }

        public LineChart()
        {
            this.Model = new PlotModel { Title = "" };

            
            var X_line = new LineSeries() { Title="体重"};
           
            X_line.Color = OxyColors.Red;
            X_line.Points.Add(new DataPoint(0, 0));
            X_line.Points.Add(new DataPoint(1, 4));
            X_line.Points.Add(new DataPoint(2, 1));
            X_line.Points.Add(new DataPoint(3, 3));
            Model.Series.Add(X_line);

            var Y_line = new LineSeries() { Title="体脂肪"};
            Y_line.Color = OxyColors.Blue;
            Y_line.Points.Add(new DataPoint(0, 0));
            Y_line.Points.Add(new DataPoint(1, 2));
            Y_line.Points.Add(new DataPoint(2, 0));
            Y_line.Points.Add(new DataPoint(3, 6));
            Model.Series.Add(Y_line);
        }
    }
}
