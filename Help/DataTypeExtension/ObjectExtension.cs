using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeExtension
{
    public static class ObjectExtension
    {

        #region Default 转型失败则返回默认值
        public static Boolean ToBooleanOrDefault(this Object current)
        {
            return ToTypeOrDefault<Boolean>(current);
        }
        public static Char ToCharOrDefault(this Object current)
        {
            return ToTypeOrDefault<Char>(current);
        }
        public static Byte ToByteOrDefault(this Object current)
        {
            return ToTypeOrDefault<Byte>(current);
        }
        public static Int16 ToInt16OrDefault(this Object current)
        {
            return ToTypeOrDefault<Int16>(current);
        }
        public static Int32 ToInt32OrDefault(this Object current)
        {
            return ToTypeOrDefault<Int32>(current);
        }
        public static Int64 ToInt64OrDefault(this Object current)
        {
            return ToTypeOrDefault<Int64>(current);
        }
        public static UInt16 ToUInt16OrDefault(this Object current)
        {
            return ToTypeOrDefault<UInt16>(current);
        }
        public static UInt32 ToUInt32OrDefault(this Object current)
        {
            return ToTypeOrDefault<UInt32>(current);
        }
        public static UInt64 ToUInt64OrDefault(this Object current)
        {
            return ToTypeOrDefault<UInt64>(current);
        }
        public static Single ToSingleOrDefault(this Object current)
        {
            return ToTypeOrDefault<Single>(current);
        }
        public static Double ToDoubleOrDefault(this Object current)
        {
            return ToTypeOrDefault<Double>(current);
        }
        public static Decimal ToDecimalOrDefault(this Object current)
        {
            return ToTypeOrDefault<Decimal>(current);
        }
        public static String ToStringOrDefault(this Object current)
        {
            return ToTypeOrDefault<String>(current);
        }
        public static DateTime ToDateTimeOrDefault(this Object current)
        {
            return ToTypeOrDefault<DateTime>(current);
        }
        public static T ToTypeOrDefault<T>(this Object current)
        {
            try {
                if (current.GetType().IsAssignableFrom(typeof(T)))
                {
                    return (T)current;
                }
            }
            catch { }
            return default(T);
        }
        #endregion

        #region Null 转型失败则返回Null
        public static Nullable<Boolean> ToBooleanOrNull(this Object current)
        {
            return ToStructTypeOrNull<Boolean>(current);
        }
        public static Nullable<Char> ToCharOrNull(this Object current)
        {
            return ToStructTypeOrNull<Char>(current);
        }
        public static Nullable<Byte> ToByteOrNull(this Object current)
        {
            return ToStructTypeOrNull<Byte>(current);
        }
        public static Nullable<Int16> ToInt16OrNull(this Object current)
        {
            return ToStructTypeOrNull<Int16>(current);
        }
        public static Nullable<Int32> ToInt32OrNull(this Object current)
        {
            return ToStructTypeOrNull<Int32>(current);
        }
        public static Nullable<Int64> ToInt64OrNull(this Object current)
        {
            return ToStructTypeOrNull<Int64>(current);
        }
        public static Nullable<UInt16> ToUInt16OrNull(this Object current)
        {
            return ToStructTypeOrNull<UInt16>(current);
        }
        public static Nullable<UInt32> ToUInt32OrNull(this Object current)
        {
            return ToStructTypeOrNull<UInt32>(current);
        }
        public static Nullable<UInt64> ToUInt64OrNull(this Object current)
        {
            return ToStructTypeOrNull<UInt64>(current);
        }
        public static Nullable<Single> ToSingleOrNull(this Object current)
        {
            return ToStructTypeOrNull<Single>(current);
        }
        public static Nullable<Double> ToDoubleOrNull(this Object current)
        {
            return ToStructTypeOrNull<Double>(current);
        }
        public static Nullable<Decimal> ToDecimalOrNull(this Object current)
        {
            return ToStructTypeOrNull<Decimal>(current);
        }
        public static Nullable<DateTime> ToDateTimeOrNull(this Object current)
        {
            return ToStructTypeOrNull<DateTime>(current);
        }
        private static Nullable<T> ToStructTypeOrNull<T>(this Object current) where T:struct
        {
            try
            {
                if (current.GetType().IsAssignableFrom(typeof(T)))
                {
                    return (T)current;
                }
            }
            catch { }
            return null;
        }
        #endregion

        #region Try
        public static Boolean ToTryBoolean(this Object current, out Boolean result)
        {
            return TryToType<Boolean>(current, out result);
        }
        public static Boolean ToTryChar(this Object current, out Char result)
        {
            return TryToType<Char>(current, out result);
        }
        public static Boolean ToTryByte(this Object current, out Byte result)
        {
            return TryToType<Byte>(current, out result);
        }
        public static Boolean ToTryInt16(this Object current, out Int16 result)
        {
            return TryToType<Int16>(current, out result);
        }
        public static Boolean ToTryInt32(this Object current, out Int32 result)
        {
            return TryToType<Int32>(current, out result);
        }
        public static Boolean ToTryInt64(this Object current, out Int64 result)
        {
            return TryToType<Int64>(current, out result);
        }
        public static Boolean ToTryUInt16(this Object current, out UInt16 result)
        {
            return TryToType<UInt16>(current, out result);
        }
        public static Boolean ToTryUInt32(this Object current, out UInt32 result)
        {
            return TryToType<UInt32>(current, out result);
        }
        public static Boolean ToTryUInt64(this Object current, out UInt64 result)
        {
            return TryToType<UInt64>(current, out result);
        }
        public static Boolean ToTrySingle(this Object current, out Single result)
        {
            return TryToType<Single>(current, out result);
        }
        public static Boolean ToTryDouble(this Object current, out Double result)
        {
            return TryToType<Double>(current, out result);
        }
        public static Boolean ToTryDecimal(this Object current, out Decimal result)
        {
            return TryToType<Decimal>(current, out result);
        }
        public static Boolean ToTryString(this Object current, out String result)
        {
            return TryToType<String>(current, out result);
        }
        public static Boolean TryToType<T>(this Object current, out T result)
        {
            result = default(T);
            try
            {
                if (current.GetType().IsAssignableFrom(typeof(T)))
                {
                    result = (T)current;
                    return true;
                }
            }
            catch { }
            return false;
        }
        #endregion

    }
}
