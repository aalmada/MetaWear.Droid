using System;
using System.Collections.Generic;
using Android.Runtime;

namespace MbientLab.MetaWear.Data {

	public partial class Bmm150ThreeAxisMessage {

        public CartesianFloat GetDataFloat()
        {
            var data = GetData();

            return new CartesianFloat
            {
                X = (Java.Lang.Float)(BitConverter.ToSingle(data, 0) / 16.0f),
                Y = (Java.Lang.Float)(BitConverter.ToSingle(data, 1) / 16.0f),
                Z = (Java.Lang.Float)(BitConverter.ToSingle(data, 1) / 16.0f)
            };
        }
    }
}
