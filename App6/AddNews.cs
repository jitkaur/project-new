using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
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
using Java.Sql;

namespace App6
{
    [Activity(Label = "addNews")]
    public class AddNews : Activity
    {
        EditText name;
        EditText topic;
     //   string date;
        EditText news;
        Button submit;
        Button back;

        EditText tname;
        EditText ttopic;
        //   string date;
        EditText tnews;
        Button backb;

        AdminDatabase myAd;
      //  Android.App.AlertDialog.Builder alert;
        public SQLiteDatabase datae;

        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.addNews);
            // Create your application here
            name = FindViewById<EditText>(Resource.Id.name);
            topic = FindViewById<EditText>(Resource.Id.topic);
           
            news = FindViewById<EditText>(Resource.Id.news);
            submit = FindViewById<Button>(Resource.Id.submit);

            myAd = new AdminDatabase(this);

            submit.Click += delegate
            {
                myAd.insertValue(name.Text, topic.Text, news.Text);
                //myAd.selectMydata(name.Text, topic.Text, news.Text);
                //myAd.OnCreate(datae);
                var value = name.Text;
                var top = topic.Text;
                var khabar = news.Text;
                System.Console.WriteLine("Text Value ---- > " + value);

                Intent newScreen = new Intent(this, typeof(displayActivity));
                newScreen.PutExtra("name",value);
                newScreen.PutExtra("top", top);
                newScreen.PutExtra("khabar", khabar);
                StartActivity(newScreen);

                

                //   //myDB.selectMydata(.Text, Password.Text);
                //   //var name = UserName.Text;
                //   SetContentView(Resource.Layout.dislay);
                //   

                //   /*System.Console.WriteLine("Text Value ---- > " + name.Text);
                //   System.Console.WriteLine("Text Value ---- > " + topic.Text);
                //   System.Console.WriteLine("Text Value ---- > " + news.Text);*/
                //   Intent i = new Intent(this, typeof(displayActivity));
                //   StartActivity(i);



            };
        }   
    }
}