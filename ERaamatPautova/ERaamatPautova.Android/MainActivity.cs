﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.Res;
using System.IO;

namespace ERaamatPautova.Droid
{
    [Activity(Label = "ERaamatPautova", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {

            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
            AssetManager assets = this.Assets;

            using (StreamReader sr = new StreamReader(assets.Open("EvgO.txt")))
            {
                Classglav.EvgO = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader(assets.Open("brodskii.txt")))
            {
                Classglav.Brods = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader(assets.Open("DjenEir.txt")))
            {
                Classglav.DjenEir = sr.ReadToEnd();
            }
            using (StreamReader sr = new StreamReader(assets.Open("MM.txt")))
            {
                Classglav.MM = sr.ReadToEnd();
            }
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}