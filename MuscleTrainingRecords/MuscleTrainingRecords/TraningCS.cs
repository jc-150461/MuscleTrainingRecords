using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MuscleTrainingRecords
{
    public class TraningCS
    {
        public class TrainingCS
        {
            public string Menu { get; set; }
            public string Load { get; set; }

            public override string ToString()
            {
                return Menu + Load;
            }
        }
    }
}
