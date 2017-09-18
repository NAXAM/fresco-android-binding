namespace Com.Facebook.Drawee.Controller
{
    partial class AbstractDraweeControllerBuilder
    {
        Com.Facebook.Drawee.Interfaces.IDraweeController Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder.Build()
        {
            return this.Build();
        }

        Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder.SetOldController(global::Com.Facebook.Drawee.Interfaces.IDraweeController oldController)
        {
            var obj = Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(oldController);
            return Android.Runtime.Extensions.JavaCast<Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder>(this.SetCallerContext(obj));
		}

		Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder.SetCallerContext(global::Java.Lang.Object callerContext)
		{
            var obj = Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(callerContext);
            return Android.Runtime.Extensions.JavaCast<Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder>(this.SetCallerContext(obj));
		}
    }
}

namespace Com.Facebook.Drawee.Drawable
{
    partial class AutoRotateDrawable
    {   
        Android.Graphics.Drawables.Drawable Com.Facebook.Drawee.Drawable.ICloneableDrawable.CloneDrawable() {
            return this.CloneDrawable();
        }
    }
}