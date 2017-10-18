using Android.App;
using Android.Widget;
using Android.OS;
using SQLite;
using System.IO;
using System;

namespace DBLogin
{
    [Activity(Label = "DBLogin", MainLauncher = true)]
    public class MainActivity : Activity
    {

        Button btnLogin;
        Button btnRegister;
        EditText txtUsername;
        EditText txtPassword;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            btnLogin = FindViewById<Button>(Resource.Id.btnLogin);
            btnRegister = FindViewById<Button>(Resource.Id.btnRegister);
            txtUsername = FindViewById<EditText>(Resource.Id.txtUsername);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnLogin.Click += BtnLogin_Click;
            btnRegister.Click += BtnRegister_Click;
            CreateDB();
        }
        private void BtnRegister_Click(object sender, EventArgs e)  
    {  
        StartActivity(typeof(RegisterActivity));  
    }  
    private void BtnLogin_Click(object sender, EventArgs e)  
    {  
        try  
        {  
            string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3"); //Call Database  
            var db = new SQLiteConnection(dpPath);  
            var data = db.Table < LoginTable > (); //Call Table  
            var data1 = data.Where(x => x.username == txtUsername.Text && x.password == txtPassword.Text).FirstOrDefault(); //Linq Query  
            if (data1 != null)  
            {  
                Toast.MakeText(this, "Login Success", ToastLength.Short).Show();
                    StartActivity(typeof(WelcomeActivity));
            }  
            else  
            {  
                Toast.MakeText(this, "Username or Password invalid", ToastLength.Short).Show();  
            }  
        }  
        catch (Exception ex)  
        {  
            Toast.MakeText(this, ex.ToString(), ToastLength.Short).Show();  
        }  
    }  
    public string CreateDB()  
    {  
        var output = "";  
        output += "Creating Databse if it doesnt exists";  
        string dpPath = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "user.db3"); //Create New Database  
        var db = new SQLiteConnection(dpPath);  
        output += "\n Database Created....";  
        return output;  
    }  
    }
}

