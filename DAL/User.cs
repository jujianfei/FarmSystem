using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class Users
    {
        private SQLHelper sqlhelper = null;
        public Users()
        {
            sqlhelper = new SQLHelper();  //初始化sqlhelper
        }

        #region 判断用户密码是否正确
        /// <summary>
        /// 判断用户密码是否正确
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public bool SelectUserPassword(Model.User user)
        {
            bool flag = false;
            string sql = "select * from Login where 用户名='" + user.username + "' and 密码='" + user.password + "'";
            DataTable ds = sqlhelper.ExecuteQuery(sql);
            if (ds.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 判断用户是否存在
        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public bool SelectUser(string username)
        {
            bool flag = false;
            string sql = "select * from Login where 用户名='" + username + "' ";
            DataTable ds = sqlhelper.ExecuteQuery(sql);
            if (ds.Rows.Count > 0)
            {
                flag = true;
            }
            return flag;
        }
        #endregion

        #region 根据用户名查询用户的权限
        /// <summary>
        /// 根据用户名查询用户的权限
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public string SelectUserLevel(string username)
        {
            string sql = "select 职位 from Login where 用户名='" + username + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            string level = (dt.Rows[0][0]).ToString().Trim();
            return level;
        }
        #endregion

        #region 添加登录用户
        /// <summary>
        /// 添加登录用户
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public int AddUser(Model.User user)
        {
            string sql = "insert into Login values('" + user.username + "','" + user.password + "','" + user.level + "')";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 用户修改密码
        /// <summary>
        /// 用户修改密码
        /// </summary>
        /// <param name="user">用户实体</param>
        /// <returns></returns>
        public int ModifyPassword(Model.User user)
        {
            string sql = "update Login set 密码='" + user.password + "' where 用户名='" + user.username + "'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion
    }
}
