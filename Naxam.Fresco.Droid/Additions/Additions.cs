namespace Com.Facebook.Drawee.Backends.Pipeline
{
    partial class PipelineDraweeControllerBuilderSupplier
    {
        Java.Lang.Object Com.Facebook.Common.Internal.ISupplier.Get()
        {
            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(Get());
        }
    }

    partial class PipelineDraweeControllerBuilder
    {
        protected override unsafe Java.Lang.Object RawThis
        {
            get => This;
        }

        public override unsafe Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri(string p0)
        {
            return SetUri2(p0);
        }

        public override unsafe Com.Facebook.Drawee.Interfaces.ISimpleDraweeControllerBuilder SetUri(Android.Net.Uri p0)
        {
            return SetUri2(p0);
        }

        protected override global::Com.Facebook.Datasource.IDataSource GetDataSourceForRequest(global::Java.Lang.Object p0, global::Java.Lang.Object p1, global::Com.Facebook.Drawee.Controller.AbstractDraweeControllerBuilder.CacheLevel p2)
        {
            return GetDataSourceForRequest(
                Android.Runtime.Extensions.JavaCast<Com.Facebook.Imagepipeline.Request.ImageRequest>(p0),
                p1,
                p2
            );
        }

        protected override Com.Facebook.Drawee.Controller.AbstractDraweeController ObtainController() => ObtainController2();

    }

    partial class PipelineDraweeController
    {
        protected override unsafe global::Android.Graphics.Drawables.Drawable CreateDrawable(Java.Lang.Object image)
        {
            return CreateDrawable(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(image));
        }

        protected override unsafe Java.Lang.Object GetImageInfo(Java.Lang.Object image)
        {
            var info = GetImageInfo(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(image));

            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(info);
        }

        protected override unsafe void ReleaseImage(Java.Lang.Object image)
        {
            ReleaseImage(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(image));
        }
    }
}