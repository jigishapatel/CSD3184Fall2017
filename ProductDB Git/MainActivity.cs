﻿using Android.App;
using Android.Widget;
using Android.OS;

namespace ProductDB
{
    [Activity(Label = "ProductDB", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
         protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnAdd = FindViewById<Button>(Resource.Id.btnAddProduct);

            btnAdd.Click += delegate { 
                StartActivity(typeof(ProductCreate));
            };

            Button btnList = FindViewById<Button>(Resource.Id.btnProductList);
            btnList.Click+=delegate {
                StartActivity(typeof(ProductDetail));
            };
        }
    }
}

