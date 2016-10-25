using MbientLab.MetaWear.Data;
using System;

namespace MbientLab.MetaWear
{
    public static class MessageExtensions
    {
        public static T GetData<T>(this Message message) where T : Java.Lang.Object
        {
            return (T)message.GetData(Java.Lang.Class.FromType(typeof(T)));
        }

        public static CartesianFloat GetDataCartesianFloat(this Message message)
        {
            return (CartesianFloat)message.GetData(Java.Lang.Class.ForName("com.mbientlab.metawear.data.CartesianFloat"));
        }

        public static CartesianShort GetDataCartesianShort(this Message message) 
        {
            return (CartesianShort)message.GetData(Java.Lang.Class.ForName("com.mbientlab.metawear.data.CartesianShort"));
        }
    }
}