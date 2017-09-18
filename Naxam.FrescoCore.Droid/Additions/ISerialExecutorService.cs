using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Facebook.Common.Executors
{

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.facebook.common.executors']/interface[@name='SerialExecutorService']"
	[Register("com/facebook/common/executors/SerialExecutorService", "", "Com.Facebook.Common.Executors.ISerialExecutorServiceInvoker")]
	public partial interface ISerialExecutorService : global::Java.Util.Concurrent.IExecutorService
	{

	}

	[global::Android.Runtime.Register("com/facebook/common/executors/SerialExecutorService", DoNotGenerateAcw = true)]
	internal class ISerialExecutorServiceInvoker : global::Java.Lang.Object, ISerialExecutorService
	{

		static IntPtr java_class_ref = JNIEnv.FindClass("com/facebook/common/executors/SerialExecutorService");

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return typeof(ISerialExecutorServiceInvoker); }
		}

		IntPtr class_ref;

		public static ISerialExecutorService GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISerialExecutorService>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance(handle), "com.facebook.common.executors.SerialExecutorService"));
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public ISerialExecutorServiceInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_isShutdown;
#pragma warning disable 0169
		static Delegate GetIsShutdownHandler()
		{
			if (cb_isShutdown == null)
				cb_isShutdown = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_IsShutdown);
			return cb_isShutdown;
		}

		static bool n_IsShutdown(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsShutdown;
		}
#pragma warning restore 0169

		IntPtr id_isShutdown;
		public unsafe global::System.Boolean IsShutdown
		{
			get
			{
				if (id_isShutdown == IntPtr.Zero)
					id_isShutdown = JNIEnv.GetMethodID(class_ref, "isShutdown", "()Z");
				return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isShutdown);
			}
		}

		static Delegate cb_isTerminated;
#pragma warning disable 0169
		static Delegate GetIsTerminatedHandler()
		{
			if (cb_isTerminated == null)
				cb_isTerminated = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, bool>)n_IsTerminated);
			return cb_isTerminated;
		}

		static bool n_IsTerminated(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTerminated;
		}
#pragma warning restore 0169

		IntPtr id_isTerminated;
		public unsafe global::System.Boolean IsTerminated
		{
			get
			{
				if (id_isTerminated == IntPtr.Zero)
					id_isTerminated = JNIEnv.GetMethodID(class_ref, "isTerminated", "()Z");
				return JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_isTerminated);
			}
		}

		static Delegate cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetAwaitTermination_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ == null)
				cb_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, long, IntPtr, bool>)n_AwaitTermination_JLjava_util_concurrent_TimeUnit_);
			return cb_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		}

		static bool n_AwaitTermination_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, long timeout, IntPtr native_unit)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.AwaitTermination(timeout, unit);
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_awaitTermination_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::System.Boolean AwaitTermination(long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_awaitTermination_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_awaitTermination_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(class_ref, "awaitTermination", "(JLjava/util/concurrent/TimeUnit;)Z");
			JValue* __args = stackalloc JValue[2];
			__args[0] = new JValue(timeout);
			__args[1] = new JValue(unit);
			global::System.Boolean __ret = JNIEnv.CallBooleanMethod(((global::Java.Lang.Object)this).Handle, id_awaitTermination_JLjava_util_concurrent_TimeUnit_, __args);
			return __ret;
		}

		static Delegate cb_invokeAll_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetInvokeAll_LSystem_Collections_ICollection_Handler()
		{
			if (cb_invokeAll_LSystem_Collections_ICollection_ == null)
				cb_invokeAll_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_InvokeAll_LSystem_Collections_ICollection_);
			return cb_invokeAll_LSystem_Collections_ICollection_;
		}

		static IntPtr n_InvokeAll_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle(__this.InvokeAll(tasks));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAll_LSystem_Collections_ICollection_;
		public unsafe global::System.Collections.IList InvokeAll(global::System.Collections.ICollection tasks)
		{
			if (id_invokeAll_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_invokeAll_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(class_ref, "invokeAll", "(LSystem/Collections/ICollection;)Ljava/util/List;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(native_tasks);
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAll_LSystem_Collections_ICollection_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetInvokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == null)
				cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>)n_InvokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_);
			return cb_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_InvokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList.ToLocalJniHandle(__this.InvokeAll(tasks, timeout, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::System.Collections.IList InvokeAll(global::System.Collections.ICollection tasks, long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(class_ref, "invokeAll", "(LSystem/Collections/ICollection;JLjava/util/concurrent/TimeUnit;)Ljava/util/List;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue(native_tasks);
			__args[1] = new JValue(timeout);
			__args[2] = new JValue(unit);
			global::System.Collections.IList __ret = global::Android.Runtime.JavaList.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAll_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate cb_invokeAny_LSystem_Collections_ICollection_;
#pragma warning disable 0169
		static Delegate GetInvokeAny_LSystem_Collections_ICollection_Handler()
		{
			if (cb_invokeAny_LSystem_Collections_ICollection_ == null)
				cb_invokeAny_LSystem_Collections_ICollection_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_InvokeAny_LSystem_Collections_ICollection_);
			return cb_invokeAny_LSystem_Collections_ICollection_;
		}

		static IntPtr n_InvokeAny_LSystem_Collections_ICollection_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.InvokeAny(tasks));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAny_LSystem_Collections_ICollection_;
		public unsafe global::Java.Lang.Object InvokeAny(global::System.Collections.ICollection tasks)
		{
			if (id_invokeAny_LSystem_Collections_ICollection_ == IntPtr.Zero)
				id_invokeAny_LSystem_Collections_ICollection_ = JNIEnv.GetMethodID(class_ref, "invokeAny", "(LSystem/Collections/ICollection;)Ljava/lang/Object;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(native_tasks);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAny_LSystem_Collections_ICollection_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
#pragma warning disable 0169
		static Delegate GetInvokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_Handler()
		{
			if (cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == null)
				cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, long, IntPtr, IntPtr>)n_InvokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_);
			return cb_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		}

		static IntPtr n_InvokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_(IntPtr jnienv, IntPtr native__this, IntPtr native_tasks, long timeout, IntPtr native_unit)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var tasks = global::Android.Runtime.JavaCollection.FromJniHandle(native_tasks, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.TimeUnit unit = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.TimeUnit>(native_unit, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.InvokeAny(tasks, timeout, unit));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_;
		public unsafe global::Java.Lang.Object InvokeAny(global::System.Collections.ICollection tasks, long timeout, global::Java.Util.Concurrent.TimeUnit unit)
		{
			if (id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ == IntPtr.Zero)
				id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_ = JNIEnv.GetMethodID(class_ref, "invokeAny", "(LSystem/Collections/ICollection;JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			IntPtr native_tasks = global::Android.Runtime.JavaCollection.ToLocalJniHandle(tasks);
			JValue* __args = stackalloc JValue[3];
			__args[0] = new JValue(native_tasks);
			__args[1] = new JValue(timeout);
			__args[2] = new JValue(unit);
			global::Java.Lang.Object __ret = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_invokeAny_LSystem_Collections_ICollection_JLjava_util_concurrent_TimeUnit_, __args), JniHandleOwnership.TransferLocalRef);
			JNIEnv.DeleteLocalRef(native_tasks);
			return __ret;
		}

		static Delegate cb_shutdown;
#pragma warning disable 0169
		static Delegate GetShutdownHandler()
		{
			if (cb_shutdown == null)
				cb_shutdown = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr>)n_Shutdown);
			return cb_shutdown;
		}

		static void n_Shutdown(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Shutdown();
		}
#pragma warning restore 0169

		IntPtr id_shutdown;
		public unsafe void Shutdown()
		{
			if (id_shutdown == IntPtr.Zero)
				id_shutdown = JNIEnv.GetMethodID(class_ref, "shutdown", "()V");
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_shutdown);
		}

		static Delegate cb_shutdownNow;
#pragma warning disable 0169
		static Delegate GetShutdownNowHandler()
		{
			if (cb_shutdownNow == null)
				cb_shutdownNow = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr>)n_ShutdownNow);
			return cb_shutdownNow;
		}

		static IntPtr n_ShutdownNow(IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.ToLocalJniHandle(__this.ShutdownNow());
		}
#pragma warning restore 0169

		IntPtr id_shutdownNow;
		public unsafe global::System.Collections.Generic.IList<global::Java.Lang.IRunnable> ShutdownNow()
		{
			if (id_shutdownNow == IntPtr.Zero)
				id_shutdownNow = JNIEnv.GetMethodID(class_ref, "shutdownNow", "()Ljava/util/List;");
			return global::Android.Runtime.JavaList<global::Java.Lang.IRunnable>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_shutdownNow), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_submit_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_lang_Runnable_Handler()
		{
			if (cb_submit_Ljava_lang_Runnable_ == null)
				cb_submit_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_Submit_Ljava_lang_Runnable_);
			return cb_submit_Ljava_lang_Runnable_;
		}

		static IntPtr n_Submit_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable task = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_lang_Runnable_;
		public unsafe global::Java.Util.Concurrent.IFuture Submit(global::Java.Lang.IRunnable task)
		{
			if (id_submit_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_submit_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(class_ref, "submit", "(Ljava/lang/Runnable;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(task);
			global::Java.Util.Concurrent.IFuture __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_submit_Ljava_lang_Runnable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_lang_Runnable_Ljava_lang_Object_Handler()
		{
			if (cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == null)
				cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>)n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_);
			return cb_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
		}

		static IntPtr n_Submit_Ljava_lang_Runnable_Ljava_lang_Object_(IntPtr jnienv, IntPtr native__this, IntPtr native_task, IntPtr native_result)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable task = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_task, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object result = global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(native_result, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task, result));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_lang_Runnable_Ljava_lang_Object_;
		public unsafe global::Java.Util.Concurrent.IFuture Submit(global::Java.Lang.IRunnable task, global::Java.Lang.Object result)
		{
			if (id_submit_Ljava_lang_Runnable_Ljava_lang_Object_ == IntPtr.Zero)
				id_submit_Ljava_lang_Runnable_Ljava_lang_Object_ = JNIEnv.GetMethodID(class_ref, "submit", "(Ljava/lang/Runnable;Ljava/lang/Object;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue[2];
			__args[0] = new JValue(task);
			__args[1] = new JValue(result);
			global::Java.Util.Concurrent.IFuture __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_submit_Ljava_lang_Runnable_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_submit_Ljava_util_concurrent_Callable_;
#pragma warning disable 0169
		static Delegate GetSubmit_Ljava_util_concurrent_Callable_Handler()
		{
			if (cb_submit_Ljava_util_concurrent_Callable_ == null)
				cb_submit_Ljava_util_concurrent_Callable_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_Submit_Ljava_util_concurrent_Callable_);
			return cb_submit_Ljava_util_concurrent_Callable_;
		}

		static IntPtr n_Submit_Ljava_util_concurrent_Callable_(IntPtr jnienv, IntPtr native__this, IntPtr native_task)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Util.Concurrent.ICallable task = (global::Java.Util.Concurrent.ICallable)global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.ICallable>(native_task, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle(__this.Submit(task));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_submit_Ljava_util_concurrent_Callable_;
		public unsafe global::Java.Util.Concurrent.IFuture Submit(global::Java.Util.Concurrent.ICallable task)
		{
			if (id_submit_Ljava_util_concurrent_Callable_ == IntPtr.Zero)
				id_submit_Ljava_util_concurrent_Callable_ = JNIEnv.GetMethodID(class_ref, "submit", "(Ljava/util/concurrent/Callable;)Ljava/util/concurrent/Future;");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(task);
			global::Java.Util.Concurrent.IFuture __ret = global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_submit_Ljava_util_concurrent_Callable_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_execute_Ljava_lang_Runnable_;
#pragma warning disable 0169
		static Delegate GetExecute_Ljava_lang_Runnable_Handler()
		{
			if (cb_execute_Ljava_lang_Runnable_ == null)
				cb_execute_Ljava_lang_Runnable_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_Execute_Ljava_lang_Runnable_);
			return cb_execute_Ljava_lang_Runnable_;
		}

		static void n_Execute_Ljava_lang_Runnable_(IntPtr jnienv, IntPtr native__this, IntPtr native_command)
		{
			global::Com.Facebook.Common.Executors.ISerialExecutorService __this = global::Java.Lang.Object.GetObject<global::Com.Facebook.Common.Executors.ISerialExecutorService>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.IRunnable command = (global::Java.Lang.IRunnable)global::Java.Lang.Object.GetObject<global::Java.Lang.IRunnable>(native_command, JniHandleOwnership.DoNotTransfer);
			__this.Execute(command);
		}
#pragma warning restore 0169

		IntPtr id_execute_Ljava_lang_Runnable_;
		public unsafe void Execute(global::Java.Lang.IRunnable command)
		{
			if (id_execute_Ljava_lang_Runnable_ == IntPtr.Zero)
				id_execute_Ljava_lang_Runnable_ = JNIEnv.GetMethodID(class_ref, "execute", "(Ljava/lang/Runnable;)V");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue(command);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_execute_Ljava_lang_Runnable_, __args);
		}

	}

}
