using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App6
{
    [Activity(Label = "quiz2")]
    public class quiz2 : Activity
    {
        private RadioGroup rbGroup;
        private RadioButton rb1;
        private RadioButton rb2;
        private RadioButton rb3, rb4, rb5, rb6;
        private RadioButton rb7, rb8, rb9, rb10;
        private RadioButton rb11, rb12, rb13, rb14, rb15;
        private Button confirmButton;
        private int count = 0;
        private TextView msg, msg1, msg2, msg3, msg4, msg5;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.quiz2);
            rbGroup = FindViewById<RadioGroup>(Resource.Id.radio_group1);
            rb1 = FindViewById<RadioButton>(Resource.Id.radio_button1);
            rb2 = FindViewById<RadioButton>(Resource.Id.radio_button2);
            rb3 = FindViewById<RadioButton>(Resource.Id.radio_button3);
            rb4 = FindViewById<RadioButton>(Resource.Id.radio_button4);
            rb5 = FindViewById<RadioButton>(Resource.Id.radio_button5);
            rb6 = FindViewById<RadioButton>(Resource.Id.radio_button6);
            rb7 = FindViewById<RadioButton>(Resource.Id.radio_button6);
            rb8 = FindViewById<RadioButton>(Resource.Id.radio_button8);
            rb9 = FindViewById<RadioButton>(Resource.Id.radio_button9);
            rb10 = FindViewById<RadioButton>(Resource.Id.radio_button10);
            rb11 = FindViewById<RadioButton>(Resource.Id.radio_button11);
            rb12 = FindViewById<RadioButton>(Resource.Id.radio_button12);
            rb13 = FindViewById<RadioButton>(Resource.Id.radio_button13);
            rb14 = FindViewById<RadioButton>(Resource.Id.radio_button14);
            rb15 = FindViewById<RadioButton>(Resource.Id.radio_button15);
            confirmButton = FindViewById<Button>(Resource.Id.button_confirm_next);
            msg = FindViewById<TextView>(Resource.Id.message);
            msg1 = FindViewById<TextView>(Resource.Id.q1message);
            msg2 = FindViewById<TextView>(Resource.Id.q2message);
            msg3 = FindViewById<TextView>(Resource.Id.q3message);
            msg4 = FindViewById<TextView>(Resource.Id.q4message);
            msg5 = FindViewById<TextView>(Resource.Id.q5message);


            confirmButton.Click += delegate
            {
                confirmButton.Enabled = false;
                if (rb1.Checked)
                {
                    count++;
                    msg1.Text = "you answer is correct";
                }
                else
                {
                    msg1.Text = "you answer is incorrect answer is a";
                }
                if (rb6.Checked)
                {
                    count++;
                    msg2.Text = "you answer is correct";
                }
                else
                {
                    msg2.Text = "you answer is incorrect answer is c";
                }
                if (rb8.Checked)
                {
                    count++;
                    msg3.Text = "you answer is correct";

                }
                else
                {
                    msg3.Text = "you answer is incorrect answer is b";
                }

                if (rb11.Checked)
                {
                    msg4.Text = "you answer is correct";

                    count++;
                }
                else
                {
                    msg4.Text = "you answer is incorrect answer is b";
                }
                if (rb15.Checked)
                {
                    msg5.Text = "you answer is correct";

                    count++;
                }
                else
                {
                    msg5.Text = "you answer is incorrect answer is c";
                }

                msg.Text = "numberof correct answers are is" + count;

                // Create your application here
            };
        }
    }
}
