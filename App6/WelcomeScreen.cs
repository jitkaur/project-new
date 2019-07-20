using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App6
{
    [Activity(Label = "WelcomeScreen")]
    public class WelcomeScreen : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.main);
            string valueFromLoginUser;
            string passwordFromLogin;
            EditText name;
            EditText useremail;
            EditText userage;
            Button editBtn;
            Button updateBtn;
            Button deleteBtn;
            DBHelperClass mDB;
            ICursor cr;
       // Android.App.AlertDialog.Builder alert;

       

            valueFromLoginUser = Intent.GetStringExtra("userName");
            passwordFromLogin = Intent.GetStringExtra("passWordValue");
            name = FindViewById<EditText>(Resource.Id.UserName);
            useremail = FindViewById<EditText>(Resource.Id.Email);
            userage = FindViewById<EditText>(Resource.Id.Age);
            editBtn = FindViewById<Button>(Resource.Id.button2);
            updateBtn = FindViewById<Button>(Resource.Id.button3);
            deleteBtn = FindViewById<Button>(Resource.Id.button4);
            //name.Enabled = false;
            //useremail.Enabled = false;
           // userage.Enabled = false;
            //editBtn.Enabled = false;
            name.Text = valueFromLoginUser;
            mDB = new DBHelperClass(this);
            //mDB.SelectMyToUpdate(name.Text);

            mDB.updt(name.Text, useremail.Text, userage.Text);

          //  useremail.Text = GetString(GetColumnIndex("Email"));
            //userage.Text = GetString(GetColumnIndex("Age"));
            //uemail.Text = mDB.SelectMyToUpdate(name.Text).ToString();



            editBtn.Click += delegate {
                //name.Enabled = true;
             //   useremail.Enabled = true;
                //userage.Enabled = true;
                // editBtn.Enabled = true;
            };

            updateBtn.Click += delegate {
                mDB.updt(name.Text, useremail.Text, userage.Text);
                //AlertDialog.SetTitle("Success");
                //alert.SetMessage("Updated Successfully!");
                //alert.SetPositiveButton("OK", alertOKButton);
            };

            deleteBtn.Click += delegate {
                mDB.dlt(name.Text);
                //alert.SetTitle("Success");
                //alert.SetMessage("Deleted Successfully!");
                //alert.SetPositiveButton("OK", alertOKButton);
            };
        }
        public void alertOKButton(object sender, Android.Content.DialogClickEventArgs e)
        {

            System.Console.WriteLine("OK Button Pressed");
        }

    }
}