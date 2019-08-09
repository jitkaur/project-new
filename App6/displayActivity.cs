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
    [Activity(Label = "displayActivity")]
    public class displayActivity : Activity
    {
        TextView tname, ttopic, tnews;
        Button back;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.dislay);
            // Create your application here

            
            string name_intent = Intent.GetStringExtra("name");
            string top_intent = Intent.GetStringExtra("top");

            string khabar_intent = Intent.GetStringExtra("khabar");

            tname = FindViewById<TextView>(Resource.Id.nameOfUser);
            ttopic = FindViewById<TextView>(Resource.Id.TopicOfNews);
            tnews = FindViewById<TextView>(Resource.Id.OfNews);
            //back = FindViewById<Button>(Resource.Id.btn);
            tname.Text = name_intent ;
            ttopic.Text = top_intent;
            tnews.Text = khabar_intent;
            //   backb.Text = back;

            // MyList list = FindViewById<>();
            //SearcView sv = FindViewById<>();
            // list.Clear();
            //Icursor ch value get krio
            // while {
            // arralist ch values pani aa i cursor vali
            // }
            // adaptorarray = arralist add krni aa

            // list.Adaptor = adaptorarray;

            //list.Itemclick += list_ItemClick

            // implement list Item CLick
            // {  }

            //private void MySearch_QueryTextChange(object sender, SearchView.QueryTextChangeEventArgs e)
            //{
            //if (string.IsNullOrWhiteSpace(e.NewText))
            //{
            //    myAdapterarray = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, listCode);
            //    myList.Adapter = myAdapterarray;
            //}
            //else
            //{
            //    var mySearchValue = e.NewText;
            //    myAdapterarray.Filter.InvokeFilter(mySearchValue);
            //}
            //}


        }
    }
}