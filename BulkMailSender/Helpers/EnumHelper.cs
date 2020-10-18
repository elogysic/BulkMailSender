﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BulkMailSender.Helpers
{
  public static class EnumHelper
  {
    public static string DescriptionAttr<T>(this T source)
    {
      if (source == null)
        return "";

      FieldInfo fi = source.GetType().GetField(source.ToString());

      DescriptionAttribute[] attributes = (DescriptionAttribute[])fi.GetCustomAttributes(
        typeof(DescriptionAttribute), false);

      if (attributes != null && attributes.Length > 0) return attributes[0].Description;
      else return source.ToString();
    }
  }
}
