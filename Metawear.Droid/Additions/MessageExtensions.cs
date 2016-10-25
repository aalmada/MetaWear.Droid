using System;

namespace MbientLab.MetaWear
{
    public static class MessageExtensions
    {
        public static T GetData<T>(this Message message) where T : Java.Lang.Object
        {
            return (T)message.GetData(Java.Lang.Class.FromType(typeof(T)));
        }
    }
}