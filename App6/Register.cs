using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database.Sqlite;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Java.Lang;
//using Java.Util.Regex;
using static Android.Resource;
using String = Java.Lang.String;

namespace App6
{
    [Activity(Label = "registration")]
    public class Register : Activity
    {
        EditText UserName;
        EditText Password;
        EditText Email;
        EditText Age;
        Button regbtn;

        DBHelperClass myDB;
        Android.App.AlertDialog.Builder alert;
        public SQLiteDatabase database;
        //private object android;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.registration);
            // Create your application here

            UserName = FindViewById<EditText>(Resource.Id.name);
            Password = FindViewById<EditText>(Resource.Id.password);
            Email = FindViewById<EditText>(Resource.Id.email);
            Age = FindViewById<EditText>(Resource.Id.age);
            regbtn = FindViewById<Button>(Resource.Id.register);

            
            alert = new Android.App.AlertDialog.Builder(this);


            myDB = new DBHelperClass(this);

            regbtn.Click += delegate
            {

                var value = UserName.Text;
                var email = Email.Text;
                System.Console.WriteLine("Text Value ---- > " + value);
                //check for empty value
               

                if (value.Trim().Equals("") || value.Length < 0)
                {

                    alert.SetTitle("Error");
                    alert.SetMessage("Please Enter Valid Data");
                   // alert.SetPositiveButton("OK", alertOKButton);
                   // alert.SetNegativeButton("Cancel", alertOKButton);
                    Dialog myDialog = alert.Create();
                    myDialog.Show();
                }
                else
                {  // some value 
                    //myDB.OnCreate(database);
                    myDB.insertValue(UserName.Text,Email.Text, Password.Text, Age.Text);

                   // myDB.selectMydata(.Text, Password.Text);
                    //var value = UserName.Text;

                    System.Console.WriteLine("Text Value ---- > " + UserName.Text);
                    System.Console.WriteLine("Text Value ---- > " + Password.Text);
                    System.Console.WriteLine("Text Value ---- > " + Email.Text);
                    System.Console.WriteLine("Text Value ---- > " + Age.Text);
                    Intent i = new Intent( this,typeof(MainActivity));
                    StartActivity(i);
                }
            };




    }
    }
}