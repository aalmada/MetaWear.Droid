using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MbientLab.MetaWear.Data
{

    // Metadata.xml XPath class reference: path="/api/package[@name='com.mbientlab.metawear.data']/class[@name='CartesianFloat']"
    [global::Android.Runtime.Register("com/mbientlab/metawear/data/CartesianFloat", DoNotGenerateAcw = true)]
    public class CartesianFloat : global::Java.Lang.Object, global::MbientLab.MetaWear.Data.ICartesian
    {
        public global::Java.Lang.Float X { get; set; }
        public global::Java.Lang.Float Y { get; set; }
        public global::Java.Lang.Float Z { get; set; }

        internal static IntPtr java_class_handle;
        internal static IntPtr class_ref
        {
            get
            {
                return JNIEnv.FindClass("com/mbientlab/metawear/data/CartesianFloat", ref java_class_handle);
            }
        }

        protected override IntPtr ThresholdClass
        {
            get { return class_ref; }
        }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(CartesianFloat); }
        }

        protected CartesianFloat(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

        static IntPtr id_ctor;
        // Metadata.xml XPath constructor reference: path="/api/package[@name='com.mbientlab.metawear.data']/class[@name='CartesianFloat']/constructor[@name='CartesianFloat' and count(parameter)=0]"
        [Register(".ctor", "()V", "")]
        public unsafe CartesianFloat()
            : base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
        {
            if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
                return;

            try
            {
                if (GetType() != typeof(CartesianFloat))
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

        // This method is explicitly implemented as a member of an instantiated MbientLab.MetaWear.Data.ICartesian
        global::Java.Lang.Object global::MbientLab.MetaWear.Data.ICartesian.X()
        {
            return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(X);
        }

        // This method is explicitly implemented as a member of an instantiated MbientLab.MetaWear.Data.ICartesian
        global::Java.Lang.Object global::MbientLab.MetaWear.Data.ICartesian.Y()
        {
            return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Y);
        }

        // This method is explicitly implemented as a member of an instantiated MbientLab.MetaWear.Data.ICartesian
        global::Java.Lang.Object global::MbientLab.MetaWear.Data.ICartesian.Z()
        {
            return global::Java.Interop.JavaObjectExtensions.JavaCast<Java.Lang.Object>(Z);
        }

    }

    [global::Android.Runtime.Register("com/mbientlab/metawear/data/CartesianFloat", DoNotGenerateAcw = true)]
    internal partial class CartesianFloatInvoker : CartesianFloat, global::MbientLab.MetaWear.Data.ICartesian
    {

        public CartesianFloatInvoker(IntPtr handle, JniHandleOwnership transfer) : base(handle, transfer) { }

        protected override global::System.Type ThresholdType
        {
            get { return typeof(CartesianFloatInvoker); }
        }

    }

}
