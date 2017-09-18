namespace Com.Facebook.Imagepipeline.Cache
{
    partial class DefaultBitmapMemoryCacheParamsSupplier
    {
        Java.Lang.Object Com.Facebook.Common.Internal.ISupplier.Get()
        {
            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(Get());
        }
    }
    partial class DefaultEncodedMemoryCacheParamsSupplier
    {
        Java.Lang.Object Com.Facebook.Common.Internal.ISupplier.Get()
        {
            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(Get());
        }
    }
}

namespace Com.Facebook.Imagepipeline.Memory
{
    partial class NativePooledByteBufferFactory {
        Com.Facebook.Common.Memory.IPooledByteBuffer Com.Facebook.Common.Memory.IPooledByteBufferFactory.NewByteBuffer(byte[] bytes){
            return NewByteBuffer(bytes);
		}
		Com.Facebook.Common.Memory.IPooledByteBuffer Com.Facebook.Common.Memory.IPooledByteBufferFactory.NewByteBuffer(int size)
		{
			return NewByteBuffer(size);
		}
		Com.Facebook.Common.Memory.IPooledByteBuffer Com.Facebook.Common.Memory.IPooledByteBufferFactory.NewByteBuffer(System.IO.Stream stream)
		{
			return NewByteBuffer(stream);
		}
        Com.Facebook.Common.Memory.IPooledByteBuffer Com.Facebook.Common.Memory.IPooledByteBufferFactory.NewByteBuffer(System.IO.Stream stream, int offset)
		{
            return NewByteBuffer(stream, offset);
		}
        Com.Facebook.Common.Memory.PooledByteBufferOutputStream Com.Facebook.Common.Memory.IPooledByteBufferFactory.NewOutputStream()
		{
			return NewOutputStream();
		}
        Com.Facebook.Common.Memory.PooledByteBufferOutputStream Com.Facebook.Common.Memory.IPooledByteBufferFactory.NewOutputStream(int size)
		{
			return NewOutputStream(size);
		}
    }

    partial class BitmapPool
    {
        protected override void Free(Java.Lang.Object obj)
        {
            Free(Android.Runtime.Extensions.JavaCast<Android.Graphics.Bitmap>(obj));
        }

        protected override Java.Lang.Object Alloc(int size)
        {
            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(AllocBitmap(size));
        }

        protected override int GetBucketedSizeForValue(Java.Lang.Object obj)
        {
            return GetBucketedSizeForValue(Android.Runtime.Extensions.JavaCast<Android.Graphics.Bitmap>(obj));
        }
	}
	partial class GenericByteArrayPool
	{
		protected override void Free(Java.Lang.Object obj)
		{
            Free(obj.ToArray<byte>());
		}

		protected override Java.Lang.Object Alloc(int size)
		{
            var bytes = AllocBytes(size);
            
            return Android.Runtime.JavaArray<byte>.FromArray<byte>(bytes);
		}

		protected override int GetBucketedSizeForValue(Java.Lang.Object obj)
		{
            return GetBucketedSizeForValue(obj.ToArray<byte>());
		}
	}
}