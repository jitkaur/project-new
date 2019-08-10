using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace App6
{
    public class FirstFragment : Fragment
    {

        ArrayAdapter myAdapterarray;
        ListView myList;
        ArrayList listCode = new ArrayList();
        string[] subArray = { "Android", "java",
                "C#", "C++", "C", "ios"};


        public String myName;
        public Activity myContext;

       public FirstFragment(string name, Activity context)
        {
            myName = name;
            myContext = context;
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            // Use this to return your custom view for this Fragment
            View myView = inflater.Inflate(Resource.Layout.FirstTabLayout,container, false);
             myList = myView.FindViewById<ListView>(Resource.Id.listID);

            SearchView mySearch = myView.FindViewById<SearchView>(Resource.Id.searchView1);
            // myView.FindViewById<TextView>(Resource.Id.myNameIdl).Text = myName;

            // myList.Adapter = new ArrayAdapter(myContext, Android.Resource.Layout.SimpleListItem1, subArray);

            myAdapterarray = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, subArray);
            myList.Adapter = myAdapterarray;
            myList.ItemClick += MyList_ItemClick;
            mySearch.QueryTextChange += MySearch_QueryTextChange;
           
            return myView;

            //return base.OnCreateView(inflater, container, savedInstanceState);
        }

        private void MyList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var index = e.Position;
            string myvalue = (string)subArray[index];

            if(myvalue == "Android")
            {
                Intent test = new Intent(this.Activity, typeof(Admin));
                StartActivity(test);
            }
            
        }

        private void MySearch_QueryTextChange(object sender, SearchView.QueryTextChangeEventArgs e)
        {
            {
                if (string.IsNullOrWhiteSpace(e.NewText))
                {
                    myAdapterarray = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, subArray);
                    myList.Adapter = myAdapterarray;
                }
                else
                {
                    var mySearchValue = e.NewText;
                    myAdapterarray.Filter.InvokeFilter(mySearchValue);
                }

            }
        }
    }
}