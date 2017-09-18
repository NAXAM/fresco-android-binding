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
    partial class NativePooledByteBufferFactory
    {
        Com.Facebook.Common.Memory.IPooledByteBuffer Com.Facebook.Common.Memory.IPooledByteBufferFactory.NewByteBuffer(byte[] bytes)
        {
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

    partial class NativeMemoryChunkPool
    {
        protected override void Free(Java.Lang.Object obj)
        {
            Free(Android.Runtime.Extensions.JavaCast<Com.Facebook.Imagepipeline.Memory.NativeMemoryChunk>(obj));
        }

        protected override Java.Lang.Object Alloc(int size)
        {
            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(AllocChunk(size));
        }

        protected override int GetBucketedSizeForValue(Java.Lang.Object obj)
        {
            return GetBucketedSizeForValue(Android.Runtime.Extensions.JavaCast<Com.Facebook.Imagepipeline.Memory.NativeMemoryChunk>(obj));
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

    partial class NativePooledByteBufferOutputStream
    {
        public override unsafe Com.Facebook.Common.Memory.IPooledByteBuffer ToByteBuffer()
        {
            return ToNativePooledByteBuffer();
        }

    }

}

namespace Com.Facebook.Imagepipeline.Producers
{
    partial class BitmapMemoryCacheKeyMultiplexProducer
    {
        protected override unsafe Java.Lang.Object GetKey(Com.Facebook.Imagepipeline.Producers.IProducerContext producerContext)
        {
            return GetKeyPair(producerContext);
        }

        protected override unsafe Java.Lang.Object CloneOrNull(Java.Lang.Object closeableImage)
        {
            return CloneOrNull(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(closeableImage));
        }
    }

    partial class EncodedCacheKeyMultiplexProducer
    {
        protected override unsafe Java.Lang.Object GetKey(Com.Facebook.Imagepipeline.Producers.IProducerContext producerContext)
        {
            return GetKeyPair(producerContext);
        }

        protected override unsafe Java.Lang.Object CloneOrNull(Java.Lang.Object closeableImage)
        {
            return CloneOrNull(Android.Runtime.Extensions.JavaCast<Com.Facebook.Imagepipeline.Image.EncodedImage>(closeableImage));
        }
    }
    partial class PostprocessedBitmapMemoryCacheProducer
    {
        partial class CachedPostprocessorConsumer
        {
            protected override unsafe void OnNewResultImpl(Java.Lang.Object newResult, int status)
            {
                OnNewResultImpl(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(newResult), status);
            }
        }
    }
    partial class MediaVariationsFallbackProducer
    {
        partial class VariantComparator
        {
            int Java.Util.IComparator.Compare(Java.Lang.Object l, Java.Lang.Object r)
            {
                return Compare(
                    Android.Runtime.Extensions.JavaCast<Com.Facebook.Imagepipeline.Request.MediaVariations.Variant>(l),
                    Android.Runtime.Extensions.JavaCast<Com.Facebook.Imagepipeline.Request.MediaVariations.Variant>(r)
                );
            }
        }
    }
    partial class MediaVariationsFallbackProducer
    {
        partial class MediaVariationsConsumer
        {
            protected override unsafe void OnNewResultImpl(Java.Lang.Object newResult, int status)
            {
                OnNewResultImpl(Android.Runtime.Extensions.JavaCast<Com.Facebook.Imagepipeline.Image.EncodedImage>(newResult), status);
            }
        }
    }
    partial class PostprocessorProducer
    {
        partial class RepeatedPostprocessorConsumer
        {
            protected override unsafe void OnNewResultImpl(Java.Lang.Object newResult, int status)
            {
                OnNewResultImpl(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(newResult), status);
            }
        }
        partial class SingleUsePostprocessorConsumer
        {
            protected override unsafe void OnNewResultImpl(Java.Lang.Object newResult, int status)
            {
                OnNewResultImpl(Android.Runtime.Extensions.JavaCast<Com.Facebook.Common.References.CloseableReference>(newResult), status);
            }
        }
    }
}