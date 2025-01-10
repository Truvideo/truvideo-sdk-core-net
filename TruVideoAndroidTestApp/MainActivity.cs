// using Com.Truvideo.Sdk.Core.Interfaces;
// using Com.Truvideo.Sdk.Core;
// using Truvideo.Sdk.Common.Exceptions;
using System.Security.Cryptography;

namespace TruVideoAndroidTestApp;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        // Authenticate();

        // Set our view from the "main" layout resource
        SetContentView(Resource.Layout.activity_main);
    }

    // private void Authenticate() {
    //         String apiKey = "VS2SG9WK";
    //         String secretKey = "ST2K33GR";
    //         String externalId = "";

    //         String payload = TruvideoSdkX.Instance.GeneratePayload();
    //         String signature = ToSha256String(secretKey, payload);

    //         TruvideoSdkX.Instance.Authenticate(apiKey, payload, signature, externalId, new TruvideoSdkCallbackImpl());
    //     }

    //     // Helper method to generate SHA-256 hash
    //     private string ToSha256String(string key, string data)
    //     {
    //         using (var hmac = new HMACSHA256(System.Text.Encoding.UTF8.GetBytes(key)))
    //         {
    //             byte[] hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(data));
    //             return BitConverter.ToString(hash).Replace("-", "").ToLower();
    //         }
    //     }

    //     public class TruvideoSdkCallbackImpl : Java.Lang.Object, ITruvideoSdkCallback
    //     {
    //         public void OnComplete(Java.Lang.Object unit)
    //         {
    //             // Authentication Ready
    //             Console.WriteLine("Authentication Ready");
    //         }

    //         public void OnError(TruvideoSdkException e)
    //         {
    //             // Authentication failed
    //             Console.WriteLine($"Error: {e.Message}");
    //         }
    //     }
}