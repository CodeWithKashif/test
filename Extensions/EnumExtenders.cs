using System;
using System.ComponentModel;
using System.Reflection;

namespace PCHP.Utility.Extensions
{
	public static class EnumExtenders
	{
		public static string Description(this Enum value)
		{
			string description = value.ToString();
			FieldInfo fieldInfo = value.GetType().GetField(description);

			if (fieldInfo != null)
			{
				DescriptionAttribute[] attribs = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
				description = attribs.Length > 0 ? attribs[0].Description : description;
			}

			return description;
		}

	}
}
