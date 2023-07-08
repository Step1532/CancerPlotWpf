using System.ComponentModel;
using System.Reflection;
using System;
using System.Windows.Data;

namespace CancerPlotWpf.Helpers;

public class ValueEnumConverter : IValueConverter
{
	private string GetEnumValue(Enum enumObj)
	{
		FieldInfo fieldInfo = enumObj.GetType().GetField(enumObj.ToString()) ?? throw new InvalidOperationException();

		object[] attribArray = fieldInfo.GetCustomAttributes(false);

		if (attribArray.Length == 0)
		{
			return enumObj.ToString();
		}
		else
		{
			DefaultValueAttribute attrib = attribArray[1] as DefaultValueAttribute ?? throw new InvalidOperationException();
			return attrib.Value.ToString();
		}
	}


	public object? Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	{
		try
		{
			Enum myEnum = (Enum)value;
			string description = GetEnumValue(myEnum);
			return description;
		}
		catch
		{
			return string.Empty;
		}
	}

	public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}