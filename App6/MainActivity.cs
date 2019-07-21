using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;
using Android.Database.Sqlite;

using Android.Widget;


namespace App6
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        DBHelperClass myDB;

        // DBHelperClass DB;
        //Android.App.AlertDialog.Builder alert;
        public SQLiteDatabase database;
        EditText Name;
        EditText Password;
        Button myRegbtn;
        Button loginbtn;
        Button edtbtn;
        Button adminbtn;
        Button list;
        Android.App.AlertDialog.Builder alert;
        //  Button myRegbtn;
        bool res;
        public object alrt;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            alrt = new Android.App.AlertDialog.Builder(this);

            Name = FindViewById<EditText>(Resource.Id.name);
            Password = FindViewById<EditText>(Resource.Id.Password);
            myRegbtn = FindViewById<Button>(Resource.Id.btnReg);
            loginbtn = FindViewById<Button>(Resource.Id.btnLogin);
            adminbtn = FindViewById<Button>(Resource.Id.adminbtn);
            //  edtbtn = FindViewById<Button>(Resource.Id.edtReg);
            // list = FindViewById<Button>(Resource.Id.list);
            myDB = new DBHelperClass(this);
            loginbtn.Click += delegate
            {


                res = myDB.selectMydata(Name.Text, Password.Text);
                if (res == true)
                {
                    Intent newScreen = new Intent(this, typeof(WelcomeScreen));
                    StartActivity(newScreen);
                }
                else
                {
                    alert.SetTitle("Error");
                    alert.SetMessage("Invalid login");
                    Dialog myDialog = alert.Create();
                    myDialog.Show();
                }

                // 
                //   myDB.login(Name.Text, Password.Text);

            };
            myRegbtn.Click += delegate
        {
            Intent newScreen = new Intent(this, typeof(Register));
            StartActivity(newScreen);

        };
            adminbtn.Click += delegate
            {
                Intent newScreen = new Intent(this, typeof(Admin));
                StartActivity(newScreen);

            };
            /* edtbtn.Click += delegate
             {
                 Intent Screen = new Intent(this, typeof(WelcomeScreen));
                 StartActivity(Screen);

             };
             list.Click += delegate
             {
                 Intent Screen = new Intent(this, typeof(WelcomeScreen));
                 StartActivity(Screen);
             };*/
        }
    }
}