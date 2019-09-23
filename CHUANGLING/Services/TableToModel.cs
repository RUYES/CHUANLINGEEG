using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
namespace CHUANLING.Services
{


    /// <summary>
    /// 将DataTable数据源转换成实体类
    /// </summary>
    /// <typeparam name="T">实体</typeparam>
    public static class ToModel<T> where T : new()
    {
        /// <summary>
        /// 将DataTable数据源转换成实体类
        /// </summary>
        public static List<T> ConvertToModel(DataTable dt)
        {
            List<T> ts = new List<T>();// 定义集合
            foreach (DataRow dr in dt.Rows)
            {
                T t = new T();
                PropertyInfo[] propertys = t.GetType().GetProperties();// 获得此模型的公共属性
                foreach (PropertyInfo pi in propertys)
                {
                    if (dt.Columns.Contains(pi.Name))
                    {
                        if (!pi.CanWrite) continue;
                        var value = dr[pi.Name];
                        if (value != DBNull.Value)
                        {
                            switch (pi.PropertyType.FullName)
                            {
                                case "System.Decimal":
                                    pi.SetValue(t, decimal.Parse(value.ToString()), null);
                                    break;
                                case "System.String":
                                    pi.SetValue(t, value.ToString(), null);
                                    break;
                                case "System.Int32":
                                    pi.SetValue(t, Int32.Parse(value.ToString()), null);
                                    break;
                                case "System.UInt32":
                                    pi.SetValue(t, UInt32.Parse(value.ToString()), null);
                                    break;
                                case "System.Int64":
                                    pi.SetValue(t, Int64.Parse(value.ToString()), null);
                                    break;
                                case "System.UInt16":
                                    pi.SetValue(t, UInt16.Parse(value.ToString()), null);
                                    break;
                                default:
                                    pi.SetValue(t, value, null);
                                    break;
                            }
                        }
                    }
                }
                ts.Add(t);
            }
            return ts;
        }
    }
}
