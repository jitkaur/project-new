using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App6
{
    [Activity(Label = "admin" )]
    public class Admin : Activity
    {
        EditText Name;
        string email = "Admin@gmail.com";
        string pass = "12345";
        EditText Password;
        Button loginbtn;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.admin);
            // Create your application here
           
            Name = FindViewById<EditText>(Resource.Id.name);
            Password = FindViewById<EditText>(Resource.Id.Password);
            loginbtn = FindViewById<Button>(Resource.Id.btnLogin);
            string user_input = Name.Text.ToString();
            string pass_input = Password.Text.ToString();

            Console.WriteLine(user_input);
            Console.WriteLine(pass_input);
            Console.WriteLine(Name);
            Console.WriteLine(Password);

            loginbtn.Click += delegate
            {
                 user_input = Name.Text.ToString();
                pass_input = Password.Text.ToString();
             //   Console.WriteLine(user_input);
             //   Console.WriteLine(pass_input);
             //   Console.WriteLine(Name.Text);
             //   Console.WriteLine(Password.Text);

                if ((email == user_input) && (pass == pass_input))
                {
                    Console.WriteLine("Welcome");


                    Intent newScreen = new Intent(this, typeof(AddNews));
                    StartActivity(newScreen);
                }
                else
                {
                    Console.WriteLine("Sorry");
                }
            };
        }
    }
}