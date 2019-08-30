using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;

namespace CHUANLING_Data
{
    public class SqliteHelper
    {
        //连接字符串
        private static readonly string str = @"Data Source=C:\Users\rzzss\Desktop\CHUANLING.db;Version=3;UseUTF16Encoding=True;";

        /// <summary>
        /// 增删改
        /// 20180723
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns>受影响的行数</returns>
        public static int ExecuteNonQuery(string sql, params SQLiteParameter[] param)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(str))
                {
                    using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                    {
                        con.Open();
                        if (param != null)
                        {
                            cmd.Parameters.AddRange(param);
                        }

                        string sql2 = cmd.CommandText;

                        return cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException se)
            {
                return 0;
            }
        }

        /// <summary>
        /// 查询
        /// 20180723
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns>首行首列</returns>
        public static object ExecuteScalar(string sql, params SQLiteParameter[] param)
        {
            using (SQLiteConnection con = new SQLiteConnection(str))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    con.Open();
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }

                    return cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// 多行查询
        /// 20180723
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns>SQLiteDateReader</returns>
        public static SQLiteDataReader ExecuteReader(string sql, params SQLiteParameter[] param)
        {
            using (SQLiteConnection con = new SQLiteConnection(str))
            {
                using (SQLiteCommand cmd = new SQLiteCommand(sql, con))
                {
                    if (param != null)
                    {
                        cmd.Parameters.AddRange(param);
                    }
                    try
                    {
                        con.Open();
                        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    }
                    catch (Exception ex)
                    {
                        con.Close();
                        con.Dispose();
                        throw ex;
                    }
                }
            }

        }

        /// <summary>
        /// 查询多行数据
        /// 20180723
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="param">sql参数</param>
        /// <returns>一个表</returns>
        public static DataTable ExecuteTable(string sql, params SQLiteParameter[] param)
        {
            DataTable dt = new DataTable();
            using (SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, str))
            {
                if (param != null)
                {
                    sda.SelectCommand.Parameters.AddRange(param);
                }
                sda.Fill(dt);
            }
            return dt;
        }

        /// <summary>
        /// 查询封装
        /// 20180725
        /// </summary>
        /// <param name="tbName">表名</param>
        /// <param name="fields">查询需要的字段名："id, name, age"</param>
        /// <param name="where">查询条件："id = 1"</param>
        /// <param name="orderBy">排序："id desc"</param>
        /// <param name="limit">分页："0,10"</param>
        /// <param name="param">sql参数</param>
        /// <returns>受影响行数</returns>
        public static DataTable QueryTable(string tbName, string fields = "*", string where = "1", string orderBy = "", string limit = "", params SQLiteParameter[] param)
        {
            //排序
            if (orderBy != "")
            {
                orderBy = "ORDER BY " + orderBy;//Deom: ORDER BY id desc
            }

            //分页
            if (limit != "")
            {
                limit = "LIMIT " + limit;//Deom: LIMIT 0,10
            }

            string sql = string.Format("SELECT {0} FROM `{1}` WHERE {2} {3} {4}", fields, tbName, where, orderBy, limit);

            //return sql;
            return SqliteHelper.ExecuteTable(sql, param);

        }

        /// <summary>
        /// 数据插入
        /// 20180725
        /// </summary>
        /// <param name="tbName">表名</param>
        /// <param name="insertData">需要插入的数据字典</param>
        /// <returns>受影响行数</returns>
        public static int ExecuteInsert(string tbName, Dictionary<String, String> insertData)
        {
            string point = "";//分隔符号(,)
            string keyStr = "";//字段名拼接字符串
            string valueStr = "";//值的拼接字符串

            List<SQLiteParameter> param = new List<SQLiteParameter>();
            foreach (string key in insertData.Keys)
            {
                keyStr += string.Format("{0} `{1}`", point, key);
                valueStr += string.Format("{0} @{1}", point, key);
                param.Add(new SQLiteParameter("@" + key, insertData[key]));
                point = ",";
            }
            string sql = string.Format("INSERT INTO `{0}`({1}) VALUES({2})", tbName, keyStr, valueStr);

            //return sql;
            return ExecuteNonQuery(sql, param.ToArray());

        }

        /// <summary>
        /// 执行Update语句
        /// 20180725
        /// </summary>
        /// <param name="tbName">表名</param>
        /// <param name="where">更新条件：id=1</param>
        /// <param name="insertData">需要更新的数据</param>
        /// <returns>受影响行数</returns>
        public static int ExecuteUpdate(string tbName, string where, Dictionary<String, String> insertData)
        {
            string point = "";//分隔符号(,)
            string kvStr = "";//键值对拼接字符串(Id=@Id)

            List<SQLiteParameter> param = new List<SQLiteParameter>();
            foreach (string key in insertData.Keys)
            {
                kvStr += string.Format("{0} {1}=@{2}", point, key, key);
                param.Add(new SQLiteParameter("@" + key, insertData[key]));
                point = ",";
            }
            string sql = string.Format("UPDATE `{0}` SET {1} WHERE {2}", tbName, kvStr, where);

            return ExecuteNonQuery(sql, param.ToArray());

        }


    }
}
