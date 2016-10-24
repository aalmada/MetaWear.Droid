using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Lang;
using Java.Nio;

namespace MbientLab.MetaWear.Data
{ 
    public partial class Bmi160ThreeAxisMessage
    {
        public CartesianFloat GetDataFloat()
        {
            var data = GetData();
            var scale = Scale;

            return new CartesianFloat
            {
                X = (Java.Lang.Float)(BitConverter.ToSingle(data, 0) / scale),
                Y = (Java.Lang.Float)(BitConverter.ToSingle(data, 1) / scale),
                Z = (Java.Lang.Float)(BitConverter.ToSingle(data, 1) / scale)
            };
        }

        public CartesianShort GetDataShort()
        {
            var data = GetData();
            var scale = Scale;

            return new CartesianShort
            {
                X = (Java.Lang.Short)(BitConverter.ToInt16(data, 0) * 1000 / scale),
                Y = (Java.Lang.Short)(BitConverter.ToInt16(data, 1) * 1000 / scale),
                Z = (Java.Lang.Short)(BitConverter.ToInt16(data, 1) * 1000 / scale)
            };
        }
    }
}
