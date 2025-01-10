namespace Com.Truvideo.Sdk.Core
{
	public partial class TruvideoSdkInitializer
	{
        public Java.Lang.Object Create(global::Android.Content.Context context)
        {
            TruvideoSdkInitializer.Companion.Init(context);
            return new Java.Lang.String("");
        }
    }
}