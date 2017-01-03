/*
 *创建人：琚建飞
 *创建时间：2016/12/7 10:58:48
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Staff
    {

        #region 返回员工信息表
        /// <summary>
        /// 返回员工信息表
        /// </summary>
        /// <returns></returns>
        public DataTable StaffInfo()
        {
            DAL.Staff staffinfo = new DAL.Staff();
            return staffinfo.StaffInfo();
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
            DAL.Staff addstaff = new DAL.Staff();
            bool result = addstaff.AddUser(staffinfo);
            return result;
        }
        #endregion

        #region 根据员工编号返回某一行员工信息
        /// <summary>
        /// 根据员工编号返回某一行员工信息
        /// </summary>
        /// <param name="sno">员工编号</param>
        /// <returns></returns>
        public DataTable SelectStaffInfo(string sno)
        {
            DAL.Staff staffinfo = new DAL.Staff();
            return staffinfo.SelectStaffInfo(sno);
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
            DAL.Staff staffname = new DAL.Staff();
            return staffname.SelectStaffNameInfo(name);
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
            DAL.Staff info = new DAL.Staff();
            int result = info.ModifyStaffInfo(staffinfo);
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
            DAL.Staff deletestaff = new DAL.Staff();
            return deletestaff.DeleteStaffInfo(sno);
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
            DAL.Staff staff = new DAL.Staff();
            return staff.CheckDepartmentNoByName(name);
        }
        #endregion

        #region 显示部门号对应部门信息
        /// <summary>
        /// 显示部门号对应部门信息
        /// </summary>
        /// <returns></returns>
        public DataTable departmentinfo()
        {
            DAL.Staff department = new DAL.Staff();
            return department.departmentinfo();
        }
        #endregion

    }
}
