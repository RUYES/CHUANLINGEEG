using CHUANLING_EEG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUANLING_Data
{
    public static class DBServices
    {
        /// <summary>
        /// 实体类转字典
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <returns></returns>
        public static Dictionary<string, string> GetProperties<T>(T t)
        {
            Dictionary<string, string> ret = new Dictionary<string, string>();

            if (t == null)
            {
                return null;
            }
            System.Reflection.PropertyInfo[] properties = t.GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);

            if (properties.Length <= 0)
            {
                return null;
            }
            foreach (System.Reflection.PropertyInfo item in properties)
            {
                string name = item.Name;                                                  //实体类字段名称
                string value = (item.GetValue(t, null)).ToString();                //该字段的值

                if (item.PropertyType.IsValueType || item.PropertyType.Name.StartsWith("String"))
                {
                    ret.Add(name, value);        //在此可转换value的类型
                }
            }

            return ret;
        }
        #region Train
        public static int AddNewTrain(Train train)
        {
            return SqliteHelper.ExecuteInsert("TrainRecord", GetProperties(train));
        }

        public static int DeleteRecord(Train train)
        {
            int i = 0;
            if (SqliteHelper.QueryTable("TrainRecord", "*", "UserName='" + train.TableName + "'").Rows.Count == 1)
            {
                i = SqliteHelper.ExecuteNonQuery("delete from UserInfo where UserName='" + train.TableName + "'");
            }
            return i;
        }
        #endregion


        #region UserInfo

        public static User UserLogin(string username, string userpasswd)
        {
            User user = new User("N/A", "N/A");
            System.Data.DataTable table = SqliteHelper.QueryTable("user_info", "*", "UserName='" + username + "'");

            if (table.Rows.Count != 0)
            {
                //比对密码
                if (table.Rows[0]["Password"].ToString() == userpasswd)
                {
                    user.UserName = table.Rows[0]["UserName"].ToString();

                    return user;


                }
                else//密码错误
                {
                    return user;
                }
                //判断超时


                //取值
            }
            else
            {
                return user;
            }
            return user;
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int AddNewUser(User user)
        {
            return SqliteHelper.ExecuteInsert("UserInfo", GetProperties(user));
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int DeleteUser(User user)
        {
            int i = 0;
            if (SqliteHelper.QueryTable("UserInfo", "*", "UserName='" + user.UserName + "'").Rows.Count == 1)
            {
                i = SqliteHelper.ExecuteNonQuery("delete from UserInfo where UserName='" + user.UserName + "'");
            }
            return i;
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static int UpdateUser(User user)
        {
            //  string id = user.UserName;
            //    user.GetDictionary().Remove("UserName");
            return SqliteHelper.ExecuteUpdate("UserInfo", "UserName='" + user.UserName + "'", GetProperties(user));
        }
        #endregion

        #region Table
        public static int AddTrainTable(DateTime dateTime/*, string userName, Dictionary<DateTime, string> keyValues*/)
        {
            //if (keyValues == null)
            //{
            //    return -1;
            //}
            //建立当前数据库
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(" CREATE TABLE '" + dateTime.ToString("yyyy_MM_dd_hh_mm_ss") + "' (");
            stringBuilder.Append("'Date' text,");
            stringBuilder.Append("'Time' text,");
            stringBuilder.Append("'Delta' integer,");
            stringBuilder.Append("'Theta' integer,");
            stringBuilder.Append("'LowAlpha' integer,");
            stringBuilder.Append("'HighAlpha' integer,");
            stringBuilder.Append("'LowBeta' integer,");
            stringBuilder.Append("'HighBeta' integer,");
            stringBuilder.Append("'LowGamma' integer,");
            stringBuilder.Append("'MiddleGamma' integer,");
            stringBuilder.Append(" 'Attention' integer,");
            stringBuilder.Append(" 'Meditation' integer);");
            return SqliteHelper.ExecuteNonQuery(stringBuilder.ToString());
        }
        #endregion

    }
}
