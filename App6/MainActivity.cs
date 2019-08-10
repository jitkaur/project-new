using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using Android;
using System;
using Android.Content;

namespace App6
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true )]
    public class MainActivity : AppCompatActivity
    {

        //AppCompatActivity
        //, 
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            // set the menu layout on Main Activity  
            MenuInflater.Inflate(Resource.Layout.mainMenu, menu);
            return base.OnCreateOptionsMenu(menu);
        }
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Resource.Id.menuItem1:
                    {
                        // add your code  
                        Console.WriteLine("Wecome1");
                        Intent newScreen = new Intent(this, typeof(WelcomeScreen));
                        StartActivity(newScreen);
                        //SetContentView(Resource.Layout.page);
                        return true;
                    }
                case Resource.Id.menuItem2:
                    {
                        // add your code  
                        Console.WriteLine("Wecome");
                        Intent newScreen = new Intent(this, typeof(Register));
                        StartActivity(newScreen);
                        // SetContentView(Resource.Layout.page);
                        return true;
                    }
                case Resource.Id.menuItem3:
                    {
                        // add your code  
                        Console.WriteLine("Wecome3");
                        Intent newScreen = new Intent(this, typeof(Admin));
                        StartActivity(newScreen);
                        SetContentView(Resource.Layout.activity_main);
                        return true;
                    }
            }

            return base.OnOptionsItemSelected(item);
        }
    }
}