using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net.Attributes;
using SQLite;
using SQLite.Net;

namespace MuscleTrainingRecords
{

    [Table("Mucle")] //デーブル名を指定
    public class MuscleModelCS
    {

        [PrimaryKey, AutoIncrement]   //プライマリキー,自動で増える値　下に来るのが主キー

        public int Tno { get; set; } //筋トレno 主キー

        public string Tname { get; set; } //トレーニング名列

        public int Weight { get; set; } //重量列

        public int Leg { get; set; } //回数列

        public int Set { get; set; } //セット列

        public double Bwieght { get; set; } //体重列

        public double Bfat { get; set; } //体脂肪列

        public DateTime Date { get; set; } //日付列



        /********************インサートメソッド**********************/
        public static void InsertMuscle(int tno, string tname, int weight, int leg, int set, double bweight, double bfat, DateTime date)
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


        /*******************セレクトメソッド**************************************/
        public static List<MuscleModelCS> SelectMuscle()
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

        public static void DeleteStock(int s_no)
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    db.CreateTable<MuscleModel>();

                    db.Delete<MuscleModel>(tno);
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /********************オールデリートメソッド*************************************/
        public static void DeleteAll()
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<MuscleModel>();

                    db.DeleteAll<MuscleModel>();
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
    }
}

