using System;
using System.Collections.Generic;
using SQLite;
using System.Linq;

namespace MuscleTrainingRecords
{
    //テーブル名を指定
    [Table("Memo")]
    class MuscleMenuModelCS
    {

        //主キーー　自動採番される*/
        [PrimaryKey, AutoIncrement, Column("_id")]
        //id列
        public int Id { get; set; }
        //名前列
        public string Name { get; set; }

        /****************************インサートメソッド********************/
        public static void insertUser(string name)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにUserテーブルを作成する
                    db.CreateTable<MuscleMenuModelCS>();

                    db.Insert(new MuscleMenuModelCS() { Name = name });
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /********************インサートメソッド（オーバーロード）*********************/
        public static void insertUser(int id, string name)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにUserテーブルを作成する
                    db.CreateTable<MuscleMenuModelCS>();

                    db.Insert(new MuscleMenuModelCS() { Name = name, Id = id });
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
        public static List<MuscleMenuModelCS> selectUser()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {

                try
                {
                    //データベースに指定したSQLを発行します
                    return db.Query<MuscleMenuModelCS>("SELECT * FROM [Memo] ");

                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }

        /*******************アップデートメソッド**************************************/
        public static List<MuscleMenuModelCS> UpdateUser(int id, string name)
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {

                try
                {
                    //データベースに指定したSQLを発行します
                    return db.Query<MuscleMenuModelCS>("UPDATE [Memo] SET [NAME]=[name] WHERE [Id]=[id]");

                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }


        /*******************オーダーメソッド**************************************/
        public static List<MuscleMenuModelCS> orderUser()
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {

                try
                {
                    //データベースに指定したSQLを発行します
                    return db.Query<MuscleMenuModelCS>("SELECT * FROM [Memo] ORDER BY Memo.Id DESC ");

                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }

        public override string ToString()
        {
            return Name;
        }

        public static void deleteUser(int id)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにUserテーブルを作成する
                    db.CreateTable<MuscleMenuModelCS>();

                    db.Delete<MuscleMenuModelCS>(id);//デリートで渡す値は主キーじゃないといけない説
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























/*using System;
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

        */
/********************************インサートメソッド********************************/

/*
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
}*/
