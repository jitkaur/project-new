using System;
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
    public class SecondFragment : Fragment
    {
        /*ArrayAdapter myAdapterarray;
        ListView myList;
        ArrayList listCode = new ArrayList();
        string[] subArray = { "Intro", "Make class",
                "Database", "Deployment"};


        public String myName;
        public Activity myContext;

        public SecondFragment(string name, Activity context)
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
            myAdapterarray = new ArrayAdapter(this.Activity, Android.Resource.Layout.SimpleListItem1, subArray);
            myList.Adapter = myAdapterarray;
            myList.ItemClick += MyList_ItemClick;
        

            return myView;

            //return base.OnCreateView(inflater, container, savedInstanceState);
        }

        private void MyList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var index = e.Position;
            string myvalue = (string)subArray[index];

            if (myvalue == "Android")
            {
                Intent test = new Intent(this.Activity, typeof(android_listpageact));
                StartActivity(test);
            }

        }*/

       
    }
}