using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BLL
{
    public class User
    {
        #region 判断用户密码是否正确
        /// <summary>
        /// 判断用户密码是否正确
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public bool SelectUserPassword(Model.User user)
        {
            DAL.Users selectuser = new DAL.Users();
            bool result = selectuser.SelectUserPassword(user);
            return result;
        }
        #endregion

        #region 判断用户是否存在
        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <param name="username">用户名</param>
        /// <returns></returns>
        public bool SelectUser(string username)
        {
            DAL.Users selectuser = new DAL.Users();
            bool result = selectuser.SelectUser(username);
            return result;
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
            DAL.Users user = new DAL.Users();
            return user.SelectUserLevel(username);
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
            DAL.Users adduser = new DAL.Users();
            return adduser.AddUser(user);
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
            DAL.Users modifypassword = new DAL.Users();
            return modifypassword.ModifyPassword(user);
        }
        #endregion
    }
}
