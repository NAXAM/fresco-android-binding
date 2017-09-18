using System;
using Android.App;
using Com.Facebook.Drawee.Backends.Pipeline;

namespace FrescoQs
{
    [Application]
    public class MyApplication : Application
    {
        public MyApplication(IntPtr handle, Android.Runtime.JniHandleOwnership transfer) : base(handle, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            Fresco.Initialize(this);
        }
    }
}
