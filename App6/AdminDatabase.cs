using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.Database.Sqlite;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;


namespace App6
{
    public class AdminDatabase : SQLiteOpenHelper   // Step 3
    {
        Context myContex;  // Step 4
        //Android.App.AlertDialog.Builder alert;
        // // Step 6
        public static string DBName = "myDatabase";
        public static string tableName = "newtable";
        public static string topic = "Topic";
        public static string news = "News";
        public static string name = "Name";
        public bool log;
        public int count = 0;


        //working 
        public string creatTable = "Create Table " +
            tableName + "(" + name + " Text" + "," + topic + " Text" + "," + news + " Text" + ")";
        public string selectStm = "Select * from " + tableName;
        // *************************

        // news table
        //public static string tableNameNews = "newtable";
        //public string creatTableNews = "Create Table " +
        //   tableNameNews + "(" + name + " Text" + "," + topic + " Text" + "," + news + " Text" + ")";


        SQLiteDatabase connectionObj;

        public AdminDatabase(Context context) : base(context, name: DBName, factory: null, version: 1) //  // Step 5
        {
            count++;
            myContex = context;
            connectionObj = WritableDatabase;
            //connectionObj.ExecSQL(creatTable);

        }

        public override void OnCreate(SQLiteDatabase datab)
        {
            System.Console.WriteLine("My Create Table STM \n \n" + creatTable);

          connectionObj.ExecSQL(creatTable);    // // Step 7
            //datab.ExecSQL(creatTableNews)
        }


        public void insertValue(string name, string topic, string news)
        {
            //connectionObj.ExecSQL(creatTable);
            string insertStm = "Insert into " +
            tableName + " values (" + "'" + name + "'" + "," + "'" + topic + "'" + " ," + "'" + news + "'" + ");";

            System.Console.WriteLine("My SQL  Insert STM \n  \n" + insertStm);

            connectionObj.ExecSQL(insertStm);

        }

        public ICursor PrintCodeList(Context context)
        {
            //connectionObj = new DataConnection(context).ReadableDatabase;
            string selectCodeStm = string.Format("Select * from {0} ", tableName);

            ICursor myresult = connectionObj.RawQuery(selectCodeStm, null);

            return myresult;
        }




        public Boolean selectMydata(string N, string P, string T)
        {
            int c = 0;
            string selectStm = "Select * from " + tableName + ";";
            ICursor myresut = connectionObj.RawQuery(selectStm, null);




            //tring selectStmwithId = "Select * from "+ tableName " where id="+id +"and name="+nameFiled;
            // myresut.Count > 0;


            while (myresut.MoveToNext())
            {

                var nme = myresut.GetString(myresut.GetColumnIndexOrThrow(name));
                System.Console.WriteLine("Name from sD " + name);

                var email = myresut.GetString(myresut.GetColumnIndexOrThrow(topic));
                System.Console.WriteLine("Email from sD " + email);


                var age = myresut.GetString(myresut.GetColumnIndexOrThrow(news));
                System.Console.WriteLine("Age from BD " + age);


            }



            return false;

        }

        //private void StartActivity(Intent c)
        //{
        //    throw new NotImplementedException();
        //}

        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {
            throw new NotImplementedException();
        }
    }
}