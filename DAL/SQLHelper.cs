using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SQLHelper
    {
        #region 该方法执行传入的增删改SQL语句
        /// <summary>
        /// 该方法执行传入的增删改SQL语句
        /// </summary>
        /// <param name="sql">要执行的增删改SQL语句</param>
        /// <returns>返回更新的记录数</returns>
        public int ExecuteNonQuery(string sql)
        {
            string connStr = @"Data Source=.;Initial Catalog=NC;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            int res = cmd.ExecuteNonQuery();
            conn.Close();
            return res;
        }
        #endregion

        #region 该方法执行传入的查询SQL语句
        /// <summary>
        /// 该方法执行传入的查询SQL语句
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            string connStr = @"Data Source=.;Initial Catalog=NC;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader sdr = cmd.ExecuteReader(); //返回一个dataReader，把cmd查询的结果放到sdr里面
            dt.Load(sdr); //把sdr的内容装到dt里面
            sdr.Close();
            conn.Close();
            return dt;
        }
        #endregion
    }
}
