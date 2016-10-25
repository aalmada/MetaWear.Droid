namespace MbientLab.MetaWear.Impl
{
    public abstract partial class DefaultMetaWearBoard
    {
        public partial class Mma8452qAccelerometerImpl : global::MbientLab.MetaWear.Module.IAccelerometer
        {
            public partial class MovementConfigEditorImpl : global::MbientLab.MetaWear.Module.IMma8452qAccelerometerDetectionConfigEditor
            {
                global::Java.Lang.Object global::MbientLab.MetaWear.Module.IMma8452qAccelerometerDetectionConfigEditor.SetDuration(int p0)
                {
                    return (global::Java.Lang.Object)SetDuration(p0);
                }

                global::Java.Lang.Object global::MbientLab.MetaWear.Module.IMma8452qAccelerometerDetectionConfigEditor.SetThreshold(float p0)
                {
                    return (global::Java.Lang.Object)SetThreshold(p0);
                }
            }
        }
    }
}