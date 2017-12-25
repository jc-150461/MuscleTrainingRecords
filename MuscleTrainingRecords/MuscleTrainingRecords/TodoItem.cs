using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace MuscleTrainingRecords
{
    public class TodoItem
    {
        [PrimaryKey, AutoIncrement] //主キー
        public int ID { get; set; }
        public DateTime Created { get; set; }　//日
        public string Name { get; set; }
        public string Notes { get; set; }
        public bool Done { get; set; }
        public int Count { get; set; }
    }
}