using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Views;
using System;

namespace App6
{
    [Activity(Label = "@string/app_name")]
    public class AfterLogin : Activity
    {

        Fragment[] _fragmentsArray;
        string name = "Welcome To my App";



        protected override void OnCreate(Bundle savedInstanceState)
        {
            // Set our view from the "main" layout resource
            RequestWindowFeature(WindowFeatures.ActionBar);

            ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;

            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.afterlog);


            _fragmentsArray = new Fragment[]
            {
            new FirstFragment("List Of Courses", this),
            new FourtFragment("News",this),
            new ThirdFragment( "Quiz", this),
            };


            AddTabToActionBar("Courses");  //First Tab
            //AddTabToActionBar("Tutorials"); //Second Tab
            AddTabToActionBar("News");
           AddTabToActionBar("Quizes"); // Third Tab
            

        }

        [Obsolete]
        void AddTabToActionBar(string tabTitle)
        {
            Android.App.ActionBar.Tab tab = ActionBar.NewTab();
            tab.SetText(tabTitle);

            tab.SetIcon(Android.Resource.Drawable.IcInputAdd);

            tab.TabSelected += TabOnTabSelected;

            ActionBar.AddTab(tab);
        }

        [Obsolete]
        void TabOnTabSelected(object sender, Android.App.ActionBar.TabEventArgs
            tabEventArgs)
        {
            Android.App.ActionBar.Tab tab = (Android.App.ActionBar.Tab)sender;

            //Log.Debug(Tag, "The tab {0} has been selected.", tab.Text);
            Fragment frag = _fragmentsArray[tab.Position];

            tabEventArgs.FragmentTransaction.Replace(Resource.Id.frameLayout1, frag);
        }



    }
}