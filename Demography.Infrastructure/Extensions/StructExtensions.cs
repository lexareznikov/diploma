using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using Demography.Infrastructure;
using Demography.Infrastructure.Enums;

namespace Demography.Infrastructure.Extensions
{
    public static class StructExtensions
    {
        // This extension method is broken out so you can use a similar pattern with 
        // other MetaData elements in the future. This is your base method for each.
        public static T GetAttribute<T>(this Enum value) where T : System.Attribute
        {
            var type = value.GetType();
            var memberInfo = type.GetMember(value.ToString());
            var attributes = memberInfo[0].GetCustomAttributes(typeof(T), false);
            return (T)attributes[0];
        }

        // This method creates a specific call to the above method, requesting the
        // Description MetaData attribute.
        public static string GetDescriptionAttribute(this Enum value)
        {
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }
        
       

        public static string GetDisplayName(this Enum enumValue)
        {
            if (enumValue == null)
                return "";

            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .Name;
        }
        public static int GetIntValue(this Enum enumValue)
        {
            return (int)((object)enumValue);
        }
        public static string GetStringValue(this Enum enumValue)
        {
            if (enumValue == null)
                return "";

            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<StringValueAttribute>().Value;
        }

        public static T ToEnum<T>(this string str)
        {
            foreach (T item in Enum.GetValues(typeof(T)))
            {
                StringValueAttribute[] attributes = (StringValueAttribute[])item.GetType().GetField(item.ToString()).GetCustomAttributes(typeof(StringValueAttribute), false);
                if ((attributes != null) && (attributes.Length > 0) && (attributes[0].Value.Equals(str)))
                {
                    return item;
                }
            }
            return (T)Enum.Parse(typeof(T), str, true);
        }

    }
}