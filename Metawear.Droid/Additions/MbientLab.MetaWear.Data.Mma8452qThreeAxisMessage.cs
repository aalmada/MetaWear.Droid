using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MbientLab.MetaWear.Data {

	public partial class Mma8452qThreeAxisMessage  {

        public CartesianFloat GetDataFloat()
        {
            var data = GetData();

            return new CartesianFloat
            {
                X = (Java.Lang.Float)(BitConverter.ToSingle(data, 0) / 1000.0f),
                Y = (Java.Lang.Float)(BitConverter.ToSingle(data, 1) / 1000.0f),
                Z = (Java.Lang.Float)(BitConverter.ToSingle(data, 1) / 1000.0f)
            };
        }

        public CartesianShort GetDataShort()
        {
            var data = GetData();

            return new CartesianShort
            {
                X = (Java.Lang.Short)BitConverter.ToInt16(data, 0),
                Y = (Java.Lang.Short)BitConverter.ToInt16(data, 1),
                Z = (Java.Lang.Short)BitConverter.ToInt16(data, 1)
            };
        }
    }
}
