﻿using CHUANLING.Models;
using CHUANLING_EEG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHUANLING.Services
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
            System.Data.DataTable table = SqliteHelper.QueryTable("UserInfo", "*", "UserName='" + username + "'");

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
        public static int InsertTrainTable(string tableName, EEG_Para item)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("Date", DateTime.Now.ToString("yyyy/MM/dd"));
            pairs.Add("Time", DateTime.Now.ToString("HH:mm:ss"));
            pairs.Add("Delta", item.Delta.ToString());
            pairs.Add("Theta", item.Theta.ToString());
            pairs.Add("LowAlpha", item.LowAlpha.ToString());
            pairs.Add("HighAlpha", item.HighAlpha.ToString());
            pairs.Add("LowBeta", item.LowBeta.ToString());
            pairs.Add("HighBeta", item.HighBeta.ToString());
            pairs.Add("LowGamma", item.LowGamma.ToString());
            pairs.Add("MiddleGamma", item.MiddleGamma.ToString());
            pairs.Add("Attention", item.Attention.ToString());
            pairs.Add("Meditation", item.Meditation.ToString());
            return SqliteHelper.ExecuteInsert(tableName, pairs);
        }

        public static int AddTrainTable(string tableName)
        {
            //if (keyValues == null)
            //{
            //    return -1;
            //}
            //建立当前数据库
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(" CREATE TABLE '" + tableName + "' (");
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
            SqliteHelper.ExecuteNonQuery(stringBuilder.ToString());
            int iss = 0;
            //foreach (var item in keyValues)
            //{
            //    Dictionary<string, string> pairs = new Dictionary<string, string>();
            //    pairs.Add("Date", item.Key.Date.ToString());
            //    pairs.Add("Time", item.Key.TimeOfDay.ToString());
            //    pairs.Add("Delta", item.Value.Delta.ToString());
            //    pairs.Add("Theta", item.Value.Theta.ToString());
            //    pairs.Add("LowAlpha", item.Value.LowAlpha.ToString());
            //    pairs.Add("HighAlpha", item.Value.HighAlpha.ToString());
            //    pairs.Add("LowBeta", item.Value.LowBeta.ToString());
            //    pairs.Add("HighBeta", item.Value.HighBeta.ToString());
            //    pairs.Add("LowGamma", item.Value.LowGamma.ToString());
            //    pairs.Add("MiddleGamma", item.Value.MiddleGamma.ToString());
            //    pairs.Add("Attention", item.Value.Attention.ToString());
            //    pairs.Add("Meditation", item.Value.Meditation.ToString());
            //    SqliteHelper.ExecuteInsert(userName + dateTime.ToString("yyyyMMddhhmmss"), pairs);
            //    iss++;
            //}
            return iss;


        }
        #endregion

    }
}
