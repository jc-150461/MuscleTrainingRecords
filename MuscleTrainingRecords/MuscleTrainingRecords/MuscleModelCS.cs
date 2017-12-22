using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLite;

namespace MuscleTrainingRecords
{
    class MuscleModelCS
    {
        [Table("Mucle")] //デーブル名を指定
        public class MuscleModelCS
        {

            [PrimaryKey, AutoIncrement]　　 //プライマリキー,自動で増える値　下に来るのが主キー

            public int Tno { get; set; } //筋トレno 主キー

            public string Tname { get; set; } //トレーニング名列

            public int Weight { get; set; } //重量列

            public int Leg { get; set; } //回数列

            public int Set { get; set; } //セット列

            public double Bwieght { get; set; } //体重列

            public double Bfat { get; set; } //体脂肪列

            public DateTime Date { get; set; }　//日付列


          

            public static void InsertMuscle(int Tno, string Tname, int Weight, int Leg, int Set, double Bweight, double Bfat, DateTime Date)
            {
                using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
                {
                    try
                    {

                        db.CreateTable<MuscleModel>();

                        db.Insert(new MuscleModel() { Tno = tno, Tname = Tname, Weight = Weight, Set = Set, Bweight = Bweight, Bfat = bfat, Date = date });
                        db.Commit();
                    }
                    catch (Exception e)
                    {
                        db.RollBack();
                        System.Diagnostics.Debug.WriteLine(e);
                    }
                }
            }

          

            public static  List<MuscleModel>SelectMuscle()
            { 
                using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
                {
                    try
                    {
                        return db.Query<MuscleModel>("SELECT * FROM[Muscle] ORDER BY [Date]");
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine(e);
                        return null;
                    }
                }
            }
        }
    }
}


