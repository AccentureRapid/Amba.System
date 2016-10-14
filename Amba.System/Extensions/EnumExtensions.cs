using System;
using System.ComponentModel;
using System.Linq;

namespace Amba.System.Extensions
{
    public static class EnumExtensions
    {
        public static Expected GetAttributeValue<T, Expected>(this Enum enumeration, Func<T, Expected> expression)
        where T : Attribute
        {
            T attribute = enumeration.GetType().GetMember(enumeration.ToString())[0].GetCustomAttributes(typeof(T), false).Cast<T>().SingleOrDefault();

            if (attribute == null)
                return default(Expected);

            return expression(attribute);
        }

        public static string GetDescription(this Enum enumeration)
        {
            return enumeration.GetAttributeValue<DescriptionAttribute, string>(x => x.Description);
        }
    }
}
