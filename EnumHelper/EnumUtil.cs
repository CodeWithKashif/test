using System;
using System.Collections.Generic;
using PCHP.Utility.Extensions;

namespace PCHP.Utility.EnumHelper
{
    public static class EnumUtil
    {
        public static bool IsValidValue<T>(T value) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
            {
                throw new ArgumentException("not a valid enumerated type");
            }

            var result = Enum.IsDefined(typeof(T), value);
            return result;
        }

        public static Dictionary<int, string> GetAllEnumValues<T>() where T : struct, IConvertible
        {
            var result = new Dictionary<int, string>();

            var enumValues = typeof(T).GetEnumValues();
            foreach (var value in enumValues)
            {
                var description = EnumExtension.GetDescription<T>(value.ToString());
                result.Add((int) value, description ?? value.ToString());
            }
            return result;
        }
    }
}
