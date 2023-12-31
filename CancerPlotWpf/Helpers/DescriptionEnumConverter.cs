﻿using System;
using System.Windows.Data;
using System.ComponentModel;
using System.Reflection;

namespace CancerPlotWpf.Helpers;

public class DescriptionEnumConverter : IValueConverter
{
	public DescriptionEnumConverter()
	{
		
	}

	private string GetEnumDescription(Enum enumObj)
    {
        if (enumObj == null)
            return string.Empty;
		FieldInfo fieldInfo = enumObj.GetType().GetField(enumObj.ToString()) ?? throw new InvalidOperationException();

		object[] attribArray = fieldInfo.GetCustomAttributes(false);

		if (attribArray.Length == 0)
		{
			return enumObj.ToString();
		}
		else
		{
			DescriptionAttribute attrib = attribArray[0] as DescriptionAttribute ?? throw new InvalidOperationException();
			return attrib.Description;
		}
	}


	public object? Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
	{
		try
		{
			Enum myEnum = (Enum)value;
			string description = GetEnumDescription(myEnum);
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