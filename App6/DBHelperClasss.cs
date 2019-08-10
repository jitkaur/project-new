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
using Android.Content;

namespace App6
{
    public class DBHelperClass : SQLiteOpenHelper   // Step 3
    {
        Context myContex;  // Step 4
        //Android.App.AlertDialog.Builder alert;
        // // Step 6
        public static string DBName = "myDatabase";
        public static string tableName = "User";
        public static string Email = "Email";
        public static string Password = "Password";
        public static string Age = "Age";
        public static string Name = "Name";
        public bool log;


        public string creatTable = "Create Table " +
            tableName + "(" + Name + " Text" + ", " + Email + " Text " + " , " + Password + " Text " + " ," + Age + " Text " + ")";
        public string selectStm = "Select * from " + tableName;

        // news table
        //public string creatTableNews = "Create Table " +
        //    tableName + "(" + name + " Text" + "," + topic + " Text" + "," + news + " Text" + ")";
        //public string selectStm = "Select * from " + tableName;
        // *************

        SQLiteDatabase connectionObj;

        public DBHelperClass(Context context) : base(context, name: DBName, factory: null, version: 1) //  // Step 5
        {
            myContex = context;
            connectionObj = WritableDatabase;
        }

        public override void OnCreate(SQLiteDatabase db)
        {
            System.Console.WriteLine("My Create Table STM \n \n" + creatTable);

            db.ExecSQL(creatTable);
            //db.ExecSQL(creatTableNews);
            // // Step 7
        }


        public void insertValue(string Name, string Email, string Password, string Age)
        {

            string insertStm = "Insert into " +
            tableName + " values (" + "'" + Name + "'" + "," + "'" + Email + "'" + " ," + "'" + Password + "'" + " ," + "'" + Age + "'" + ");";

            System.Console.WriteLine("My SQL  Insert STM \n  \n" + insertStm);

            connectionObj.ExecSQL(insertStm);

        }

        public void updt(string nm, string eml, string ag)
        {
            string updateStm = "Update " + tableName + " set Email = '" + eml + "', Age ='" + ag + "' where Name ='" + nm + "'";
            System.Console.WriteLine(updateStm);
            System.Console.WriteLine("My SQL  update STM \n  \n" + updateStm);
            connectionObj.ExecSQL(updateStm);
            // break;
        }

        public void dlt(string nm)
        {
            string dltStm = "Delete from " + tableName + " where Name='" + nm + "'";
            Console.WriteLine(dltStm);
            System.Console.WriteLine("My SQL  delete STM \n  \n" + dltStm);
            connectionObj.ExecSQL(dltStm);
        }

        /* public void login(string N, string P)
         {
             string select = "Select Name,Password from " + tableName + " where Name ="
                 + "'" + N + "'" + "and Password =" + "'" + Password + "'" + ";";
             Name = N;
             Password = P;
             ICursor myresut = connectionObj.RawQuery(select, null);
             /*while (myresut.MoveToNext())
             {*/
        /* var name = myresut.GetString(myresut.GetColumnIndexOrThrow(Name));
           System.Console.WriteLine("namw from BD " + name);
          /* var email = myresut.GetString(myresut.GetColumnIndexOrThrow(Email));
           System.Console.WriteLine("email from BD " + email);*/

        // var pass = myresut.GetString(myresut.GetColumnIndexOrThrow(Password));
        //System.Console.WriteLine("pass from BD " + pass);

        /*var age = myresut.GetString(myresut.GetColumnIndexOrThrow(Age));
        System.Console.WriteLine("age from BD " + age);*/
        /*  if ((email.Equals(E))&&(pass.Equals(P)))
          {*/
        //Intent Screen = new Intent(this,typeof(Redirect));
        //StartActivity(Screen);
        /*  if (myresut.Count > 0)
          {
              System.Console.WriteLine("Successfull");
          }
          else
          {
              System.Console.WriteLine(" not Successfull");
              // alert.SetTitle("Error");
             // alert.SetMessage("Please Enter Valid Data");
              // alert.SetPositiveButton("OK", alertOKButton);
              // alert.SetNegativeButton("Cancel", alertOKButton);
              Dialog myDialog = alert.Create();
              myDialog.Show();
          }
    }*/
        public Boolean selectMydata(string N, string P)
        {
            int c = 0;
            string selectStm = "Select * from " + tableName + ";";
            ICursor myresut = connectionObj.RawQuery(selectStm, null);

            // ICursor myresut = connectionObj.RawQuery(selectStm, null);


            //tring selectStmwithId = "Select * from "+ tableName " where id="+id +"and name="+nameFiled;
            //myresut.Count >0


            while (myresut.MoveToNext())
            {

                var name = myresut.GetString(myresut.GetColumnIndexOrThrow(Name));
                System.Console.WriteLine("Name from sD " + name);

                var email = myresut.GetString(myresut.GetColumnIndexOrThrow(Email));
                System.Console.WriteLine("Email from sD " + email);

                var pass = myresut.GetString(myresut.GetColumnIndexOrThrow(Password));
                System.Console.WriteLine("Pass from BD " + pass);

                var age = myresut.GetString(myresut.GetColumnIndexOrThrow(Age));
                System.Console.WriteLine("Age from BD " + age);

                if ((N == name) && (P == pass))
                { c++; }
            }
            if (c > 0)
            {
                System.Console.WriteLine("Successfull");
                log = true;
                return true;

            }
            log = false;
            System.Console.WriteLine(log);
            return false;

        }

        private void StartActivity(Intent c)
        {
            throw new NotImplementedException();
        }

        public override void OnUpgrade(SQLiteDatabase db, int oldVersion, int newVersion)
        {
            throw new NotImplementedException();
        }
    }
}