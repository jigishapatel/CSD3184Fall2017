
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace ProductDB
{
    [Activity(Label = "ProductDetail")]
    public class ProductDetail : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.ProductDetail);
            // Create your application here

            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");
            var db = new SQLiteConnection(dpPath);
            var data = db.Table<Product>();


            var records = new List<string>();
            foreach (var listing in data)
            {
                records.Add(listing.pName + "   -   " + listing.pPrice);
            }

            ListView listtable = (ListView)FindViewById(Resource.Id.ProductList);
            listtable.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, records.ToArray());
        }
    }
}
