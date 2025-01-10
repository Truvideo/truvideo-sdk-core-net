using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using AndroidX.AppCompat.Widget;
using AndroidX.AppCompat.App;
using Google.Android.Material.FloatingActionButton;
using Google.Android.Material.Snackbar;
using System.Security.Cryptography;
using Com.Truvideo.Sdk.Core.Interfaces;
using Com.Truvideo.Sdk.Core;
using Truvideo.Sdk.Common.Exceptions;

namespace TruVideoAndroidTestApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Authenticate();

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (View.IOnClickListener)null).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        private void Authenticate() {
            String apiKey = "VS2SG9WK";
            String secretKey = "ST2K33GR";
            String externalId = "";

            String payload = TruvideoSdkX.Instance.GeneratePayload();
            String signature = ToSha256String(secretKey, payload);

            TruvideoSdkX.Instance.Authenticate(apiKey, payload, signature, externalId, new TruvideoSdkCallbackImpl());
        }

        // Helper method to generate SHA-256 hash
        private string ToSha256String(string key, string data)
        {
            using (var hmac = new HMACSHA256(System.Text.Encoding.UTF8.GetBytes(key)))
            {
                byte[] hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(data));
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }

        public class TruvideoSdkCallbackImpl : Java.Lang.Object, ITruvideoSdkCallback
        {
            public void OnComplete(Java.Lang.Object unit)
            {
                // Authentication Ready
                Console.WriteLine("Authentication Ready");
            }

            public void OnError(TruvideoSdkException e)
            {
                // Authentication failed
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}

