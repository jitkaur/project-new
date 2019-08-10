using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace App6
{
    [Activity(Label = "java")]
    public class javaTutorial : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.javaTut);


            string strUrl = "https://www.youtube.com/embed/eIrMbAQSU34";
            string html = @"<html><body><div align=""center""><iframe width=""600"" height=""450"" align=""center"" src=""strUrl""></div></iframe></body></html>";
            var myWebView = (WebView)FindViewById(Resource.Id.webView);
            var settings = myWebView.Settings;
            settings.JavaScriptEnabled = true;
            settings.UseWideViewPort = true;
            settings.LoadWithOverviewMode = true;
            settings.JavaScriptCanOpenWindowsAutomatically = true;
            settings.DomStorageEnabled = true;
            settings.SetRenderPriority(WebSettings.RenderPriority.High);
            settings.BuiltInZoomControls = false;

            settings.JavaScriptCanOpenWindowsAutomatically = true;
            myWebView.SetWebChromeClient(new WebChromeClient());
            settings.AllowFileAccess = true;
            settings.SetPluginState(WebSettings.PluginState.On);

            string strYouTubeURL = html.Replace("strUrl", strUrl);

            myWebView.LoadDataWithBaseURL(null, strYouTubeURL, "text/html", "UTF-8", null);



            // Create your application here
        }
    }
}