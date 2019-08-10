using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace App6
{
    public class FourtFragment : Fragment
    {
        string title, link, disc = "";

        public string myName;
        public Activity myContext;

        AdminDatabase cdm;

        ArrayAdapter myAdapterarray;
        ArrayList listCode = new ArrayList();

        public string name = "Name";
        public static string topic = "Topic";
        public static string news = "News";


        public FourtFragment(string name, Activity context)
        {
            myName = name;
            myContext = context;
        }


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            cdm = new AdminDatabase(this.Activity);
            View myView = inflater.Inflate(Resource.Layout.FourtTabLayout, container, false);
           // SearchView mySearch = myView.FindViewById<SearchView>(Resource.Id.searchView1);
            ListView myList = myView.FindViewById<ListView>(Resource.Id.listID);

            //TextView mytext = myView.FindViewById<TextView>(Resource.Id.textView1);
            

            //myView.FindViewById<TextView>(Resource.Id.textView1).Text = myName;

            // mytext.Text = "Code List";
            //myList.Adapter = new ArrayAdapter(myContext, Android.Resource.Layout.SimpleListItem1, movieArray);

            // Code to display Code List

            ICursor myresult = cdm.PrintCodeList(this.Activity);
           

            listCode.Clear();

            while (myresult.MoveToNext())
            {
                //myEmail = myresult.GetString(myresult.GetColumnIndexOrThrow(emailValue));
                // working code

                title = myresult.GetString(myresult.GetColumnIndexOrThrow(name));
               link = myresult.GetString(myresult.GetColumnIndexOrThrow(topic));
                disc = myresult.GetString(myresult.GetColumnIndexOrThrow(news));

                listCode.Add(title);

                //custom Adaptor addition
            }
            myAdapterarray = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, listCode);
            myList.Adapter = myAdapterarray;
            myList.ItemClick += MyList_ItemClick;
            //mySearch.QueryTextChange += MySearch_QueryTextChange;
            return myView;

            
        }

        private void MyList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var index = e.Position;
            string myvalue = (string)listCode[index];

            Intent newScreen = new Intent(this.Activity, typeof(NewsViewActivity));
            newScreen.PutExtra("title", title);
            newScreen.PutExtra("desc", link);
            newScreen.PutExtra("news", disc);
            StartActivity(newScreen);
        }
    }
}