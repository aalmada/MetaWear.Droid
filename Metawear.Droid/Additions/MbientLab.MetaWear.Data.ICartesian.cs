using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MbientLab.MetaWear.Data {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.mbientlab.metawear.data']/interface[@name='Cartesian']"
	[Register ("com/mbientlab/metawear/data/Cartesian", "", "MbientLab.MetaWear.Data.ICartesianInvoker")]
	[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Number"})]
	public partial interface ICartesian<T> : IJavaObject where T : global::Java.Lang.Number {

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mbientlab.metawear.data']/interface[@name='Cartesian']/method[@name='x' and count(parameter)=0]"
		[Register ("x", "()Ljava/lang/Number;", "GetXHandler:MbientLab.MetaWear.Data.ICartesianInvoker, Metawear.Droid")]
		T X ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mbientlab.metawear.data']/interface[@name='Cartesian']/method[@name='y' and count(parameter)=0]"
		[Register ("y", "()Ljava/lang/Number;", "GetYHandler:MbientLab.MetaWear.Data.ICartesianInvoker, Metawear.Droid")]
		T Y ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.mbientlab.metawear.data']/interface[@name='Cartesian']/method[@name='z' and count(parameter)=0]"
		[Register ("z", "()Ljava/lang/Number;", "GetZHandler:MbientLab.MetaWear.Data.ICartesianInvoker, Metawear.Droid")]
		T Z ();

	}

	[global::Android.Runtime.Register ("com/mbientlab/metawear/data/Cartesian", DoNotGenerateAcw=true)]
	internal class ICartesianInvoker<T> : global::Java.Lang.Object, ICartesian<T> where T : global::Java.Lang.Number {

        static IntPtr java_class_ref = JNIEnv.FindClass ("com/mbientlab/metawear/data/Cartesian");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ICartesianInvoker<T>); }
		}

		IntPtr class_ref;

		public static ICartesian<T> GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ICartesian<T>> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.mbientlab.metawear.data.Cartesian"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ICartesianInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_x;
#pragma warning disable 0169
		static Delegate GetXHandler ()
		{
			if (cb_x == null)
				cb_x = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_X);
			return cb_x;
		}

		static IntPtr n_X (IntPtr jnienv, IntPtr native__this)
		{
			global::MbientLab.MetaWear.Data.ICartesian<T> __this = global::Java.Lang.Object.GetObject<global::MbientLab.MetaWear.Data.ICartesian<T>> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.X ());
		}
#pragma warning restore 0169

		IntPtr id_x;
		public unsafe T X ()
		{
			if (id_x == IntPtr.Zero)
				id_x = JNIEnv.GetMethodID (class_ref, "x", "()Ljava/lang/Number;");
			return (T) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_x), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_y;
#pragma warning disable 0169
		static Delegate GetYHandler ()
		{
			if (cb_y == null)
				cb_y = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Y);
			return cb_y;
		}

		static IntPtr n_Y (IntPtr jnienv, IntPtr native__this)
		{
			global::MbientLab.MetaWear.Data.ICartesian<T> __this = global::Java.Lang.Object.GetObject<global::MbientLab.MetaWear.Data.ICartesian<T>> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Y ());
		}
#pragma warning restore 0169

		IntPtr id_y;
		public unsafe T Y ()
		{
			if (id_y == IntPtr.Zero)
				id_y = JNIEnv.GetMethodID (class_ref, "y", "()Ljava/lang/Number;");
			return (T) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_y), JniHandleOwnership.TransferLocalRef);
		}

		static Delegate cb_z;
#pragma warning disable 0169
		static Delegate GetZHandler ()
		{
			if (cb_z == null)
				cb_z = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_Z);
			return cb_z;
		}

		static IntPtr n_Z (IntPtr jnienv, IntPtr native__this)
		{
			global::MbientLab.MetaWear.Data.ICartesian<T> __this = global::Java.Lang.Object.GetObject<global::MbientLab.MetaWear.Data.ICartesian<T>> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Z ());
		}
#pragma warning restore 0169

		IntPtr id_z;
		public unsafe T Z ()
		{
			if (id_z == IntPtr.Zero)
				id_z = JNIEnv.GetMethodID (class_ref, "z", "()Ljava/lang/Number;");
			return (T) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_z), JniHandleOwnership.TransferLocalRef);
		}

	}

}
