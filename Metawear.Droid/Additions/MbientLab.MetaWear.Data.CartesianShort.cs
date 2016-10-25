using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MbientLab.MetaWear.Data
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.mbientlab.metawear.data']/class[@name='CartesianShort']"
    [global::Android.Runtime.Register("com/mbientlab/metawear/data/CartesianShort", DoNotGenerateAcw = true)]
    public abstract class CartesianShort : global::Java.Lang.Object, global::MbientLab.MetaWear.Data.ICartesian<global::Java.Lang.Short>
    {
        internal static IntPtr java_class_handle;
        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/mbientlab/metawear/data/CartesianShort", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(CartesianShort); }
        }

        protected CartesianShort(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.mbientlab.metawear.data']/class[@name='CartesianShort']/constructor[@name='CartesianShort' and count(parameter)=0]"
        [Register(".ctor", "()V", "")]
        public unsafe CartesianShort()
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                if (GetType() != typeof(CartesianShort))
                {
                    SetHandle(
                            global::Android.Runtime.JNIEnv.StartCreateInstance(GetType(), "()V"),
                            JniHandleOwnership.TransferLocalRef);
                    global::Android.Runtime.JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, "()V");
                    return;
                }

                if (id_ctor == IntPtr.Zero)
                    id_ctor = JNIEnv.GetMethodID(class_ref, "<init>", "()V");
                SetHandle(
                        global::Android.Runtime.JNIEnv.StartCreateInstance(class_ref, id_ctor),
                        JniHandleOwnership.TransferLocalRef);
                JNIEnv.FinishCreateInstance(((global::Java.Lang.Object)this).Handle, class_ref, id_ctor);
            }
            finally
            {
            }
        }

        IntPtr id_x;
        public unsafe global::Java.Lang.Short X()
        {
            if (id_x == IntPtr.Zero)
                id_x = JNIEnv.GetMethodID(class_ref, "x", "()Ljava/lang/Number;");
            return (global::Java.Lang.Short)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_x), JniHandleOwnership.TransferLocalRef);
        }

        IntPtr id_y;
        public unsafe global::Java.Lang.Short Y()
        {
            if (id_y == IntPtr.Zero)
                id_y = JNIEnv.GetMethodID(class_ref, "y", "()Ljava/lang/Number;");
            return (global::Java.Lang.Short)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_y), JniHandleOwnership.TransferLocalRef);
        }

        IntPtr id_z;
        public unsafe global::Java.Lang.Short Z()
        {
            if (id_z == IntPtr.Zero)
                id_z = JNIEnv.GetMethodID(class_ref, "z", "()Ljava/lang/Number;");
            return (global::Java.Lang.Short)global::Java.Lang.Object.GetObject<global::Java.Lang.Object>(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_z), JniHandleOwnership.TransferLocalRef);
        }

    }

    [global::Android.Runtime.Register("com/mbientlab/metawear/data/CartesianShort", DoNotGenerateAcw = true)]
    internal partial class CartesianShortInvoker : CartesianShort, global::MbientLab.MetaWear.Data.ICartesian<global::Java.Lang.Short>
    {

        public CartesianShortInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer) { }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(CartesianShortInvoker); }
        }

    }

}
