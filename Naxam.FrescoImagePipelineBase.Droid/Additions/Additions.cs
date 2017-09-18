namespace Com.Facebook.Cache.Disk
{
    partial class DefaultDiskStorage
    {
        System.Collections.Generic.ICollection<global::Com.Facebook.Cache.Disk.IDiskStorageEntry> Com.Facebook.Cache.Disk.IDiskStorage.Entries
        {
            get
            {
                return new System.Collections.Generic.List<global::Com.Facebook.Cache.Disk.IDiskStorageEntry>(this.Entries);
            }
        }

        partial class EntryImpl
        {
            Com.Facebook.Binaryresource.IBinaryResource Com.Facebook.Cache.Disk.IDiskStorageEntry.Resource
            {
                get
                {
                    return this.Resource;
                }
            }
        }

    }
}

namespace Com.Facebook.Imagepipeline.Bitmaps
{
    partial class SimpleBitmapReleaser
    {
        void Com.Facebook.Common.References.IResourceReleaser.Release(global::Java.Lang.Object p0)
        {
            this.Release(Android.Runtime.Extensions.JavaCast<Android.Graphics.Bitmap>(p0));
        }
    }
}