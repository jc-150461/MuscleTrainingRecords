using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;
using SQLitePCL;



namespace MuscleTrainingRecords
{
    [Table("Menu")]
    public  class MuscleMenuModelCS
    {
        [PrimaryKey, AutoIncrement]   //プライマリキー,自動で増える値　下に来るのが主キー

        public int ID { get; set; } //主キー ID列

        public string Menu { get; set; } //メニュー列

        public string Commentary { get; set; } //解説列

        public string Part { get; set; }　//部位


        /********************************インサートメソッド********************************/


        public static void InsertMenu( string menu)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにStockテーブルを作成する
                    db.CreateTable<MuscleMenuModelCS>();

                    db.Insert(new MuscleMenuModelCS() {  Menu = menu});
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }
        public static List<MuscleMenuModelCS> SelectMenu()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースに指定したSQLを発行
                    return db.Query<MuscleMenuModelCS>("SELECT * FROM [Menu] ORDER BY [ID]");

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