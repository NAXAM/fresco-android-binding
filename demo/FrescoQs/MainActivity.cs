using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Com.Facebook.Drawee.View;
using Android.Net;

namespace FrescoQs
{
    [Activity(Label = "FrescoQs", MainLauncher = true, Theme = "@style/AppTheme", Icon = "@mipmap/ic_launcher")]
    public class MainActivity : AppCompatActivity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

			Uri uri = Uri.Parse("https://avatars1.githubusercontent.com/u/25535951");
			SimpleDraweeView draweeView = (SimpleDraweeView)FindViewById(Resource.Id.my_image_view);
			draweeView.SetImageURI(uri);
        }
    }
}

