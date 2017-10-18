
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

namespace DBLogin
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        EditText txtNewUsername;
        EditText txtNewPassword;
        Button btnCreate;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Register); 

            // Create your application here
            btnCreate = FindViewById<Button>(Resource.Id.btnCreate);
            txtNewUsername = FindViewById<EditText>(Resource.Id.txtNewUsername);
            txtNewPassword = FindViewById<EditText>(Resource.Id.txtNewPassword);
            btnCreate.Click += Btncreate_Click;
        }

        private void Btncreate_Click(object sender, EventArgs e)   
    {  
        try   
        {  
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3");  
            var db = new SQLiteConnection(dpPath);  
            db.CreateTable < LoginTable > ();  
            LoginTable tbl = new LoginTable();  
            tbl.username = txtNewUsername.Text;  
            tbl.password = txtNewPassword.Text;  
            db.Insert(tbl);  
            Toast.MakeText(this, "Record Added Successfully...,", ToastLength.Short).Show();
                StartActivity(typeof(MainActivity));
        } catch (Exception ex) {  
            Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();  
        }  
    } 
    }
}
