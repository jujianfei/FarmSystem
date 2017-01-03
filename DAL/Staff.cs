/*
 *创建人：琚建飞
 *创建时间：2016/12/7 10:59:06
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Staff
    {
        private SQLHelper sqlhelper = null;
        public Staff()
        {
            sqlhelper = new SQLHelper();  //初始化sqlhelper
        }

        #region 返回员工信息表
        /// <summary>
        /// 返回员工信息表
        /// </summary>
        /// <returns></returns>
        public DataTable StaffInfo()
        {
            string sql = "select * from StaffInfo";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 添加员工信息
        /// <summary>
        /// 添加员工信息
        /// </summary>
        /// <param name="user">输入的员工信息</param>
        /// <returns></returns>
        public bool AddUser(Model.Staff staffinfo)
        {
            string sql = "insert into StaffInfo(部门号,姓名,年龄,学历,工资,职位) values('" + staffinfo.departmentno + "','" + staffinfo.name + "','" + staffinfo.age + "','" + staffinfo.school + "','" + staffinfo.money + "','" + staffinfo.level + "')";
            int dt = sqlhelper.ExecuteNonQuery(sql);
            if (dt > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region 根据编号返回某一行员工信息
        /// <summary>
        /// 根据编号返回某一行员工信息
        /// </summary>
        /// <param name="sno">员工编号</param>
        /// <returns></returns>
        public DataTable SelectStaffInfo(string sno)
        {
            string sql = "select * from StaffInfo where 编号='" + sno + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 修改员工信息
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="staffinfo">重新填写的员工信息</param>
        /// <returns></returns>
        public int ModifyStaffInfo(Model.Staff staffinfo)
        {
            string sql = "update StaffInfo set 姓名='" + staffinfo.name + "',年龄='" + staffinfo.age + "',学历='" + staffinfo.school + "',职位='" + staffinfo.level + "',工资='" + staffinfo.money + "' where 编号='" + staffinfo.no + "'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 删除一条员工信息
        /// <summary>
        /// 删除一条员工信息
        /// </summary>
        /// <param name="sno">员工编号</param>
        /// <returns></returns>
        public int DeleteStaffInfo(string sno)
        {
            string sql = "delete from StaffInfo where 编号='" + sno + "'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 根据员工姓名返回某一行员工信息
        /// <summary>
        /// 根据员工姓名返回某一行员工信息
        /// </summary>
        /// <param name="name">员工姓名</param>
        /// <returns></returns>
        public DataTable SelectStaffNameInfo(string name)
        {
            string sql = "select * from StaffInfo where 姓名='" + name + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 根据部门名称查询部门号
        /// <summary>
        /// 根据部门名称查询部门号
        /// </summary>
        /// <param name="name">部门名称</param>
        /// <returns></returns>
        public int CheckDepartmentNoByName(string name)
        {
            string sql = "select Staffinfo.部门号 from StaffInfo join Department on StaffInfo.部门号=Department.部门号 where Department.部门名称='" + name + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            int result = Convert.ToInt32(dt.Rows[0][0].ToString());
            return result;
        }
        #endregion

        #region 显示部门号对应部门信息
        /// <summary>
        /// 显示部门号对应部门信息
        /// </summary>
        /// <returns></returns>
        public DataTable departmentinfo()
        {
            string sql = "select * from Department";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

    }
}
