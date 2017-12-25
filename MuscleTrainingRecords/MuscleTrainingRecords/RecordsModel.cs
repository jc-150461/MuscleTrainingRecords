using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MuscleTrainingRecords
{
    [Table("Food")]//テーブル名を指定
    class RecordsModel
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int F_no { get; set; } //食材No

        public string F_name { get; set; } //食材名

        public int F_result { get; set; } //登録時点での、消費期限までの日数

        public DateTime F_date { get; set; } //消費期限

        //[ForeignKey(typeof(SettingModel))]
       // public int Set_no { get; set; } //Setting表の外部キー

        /********************インサートメソッド**********************/
        public static void InsertFood(int f_no, string f_name, int f_result, DateTime f_date)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<RecordsModel>();

                    db.Insert(new RecordsModel() { F_no = f_no, F_name = f_name, F_result = f_result, F_date = f_date });
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /*******************セレクトメソッド**************************************/
        public static List<RecordsModel> SelectFood()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースに指定したSQLを発行
                    return db.Query<RecordsModel>("SELECT * FROM [Food] ORDER BY [F_result]");

                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }

        /********************デリートメソッド*************************************/
        public static void DeleteFood(int f_no)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<RecordsModel>();

                    db.Delete<RecordsModel>(f_no);//デリートで渡す値は主キーじゃないといけない説
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
        public static void DeleteAllFood()
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<RecordsModel>();

                    db.DeleteAll<RecordsModel>();//デリートで渡す値は主キーじゃないといけない説
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /********************アップデートメソッド（日付）*************************************/
        public static void UpdateF_date(int f_no, string f_name, int f_result, DateTime f_date)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<RecordsModel>();

                    //TimeSpan t = f_date - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day+1);//よくわからん
                    TimeSpan t = f_date - new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);//よくわからん

                    int span = t.Days;

                    db.Update(new RecordsModel() { F_no = f_no, F_name = f_name, F_result = span, F_date = f_date });

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