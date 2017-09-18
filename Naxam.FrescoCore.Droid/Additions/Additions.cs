using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Datasource
{
    partial class FirstAvailableDataSourceSupplier
    {
        Java.Lang.Object Com.Facebook.Common.Internal.ISupplier.Get()
        {
            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(Get());
        }
    }
    partial class IncreasingQualityDataSourceSupplier
    {
        Java.Lang.Object Com.Facebook.Common.Internal.ISupplier.Get()
        {
            return Android.Runtime.Extensions.JavaCast<Java.Lang.Object>(Get());
        }
    }
}

namespace Com.Facebook.Common.Executors
{
    partial class ScheduledFutureImpl
    {
        int Java.Lang.IComparable.CompareTo(Java.Lang.Object obj)
        {
            return CompareTo(Android.Runtime.Extensions.JavaCast<Java.Util.Concurrent.IDelayed>(obj));
        }
    }
}