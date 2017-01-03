/*
 *创建人：琚建飞
 *创建时间：2016/12/7 19:56:21
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Equipment
    {
        private SQLHelper sqlhelper = null;
        public Equipment()
        {
            sqlhelper = new SQLHelper();  //初始化sqlhelper
        }

        #region 返回设备信息表
        /// <summary>
        /// 返回员工信息表
        /// </summary>
        /// <returns></returns>
        public DataTable EquipmentInfo()
        {
            string sql = "select * from Equipment";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 添加设备信息
        /// <summary>
        /// 添加设备信息
        /// </summary>
        /// <param name="user">输入的设备信息</param>
        /// <returns></returns>
        public bool AddEquipment(Model.Equipment equipment)
        {
            string sql = "insert into Equipment(设备名,总数量,库存数量,负责人号,购买时间) values('" + equipment.name + "','" + equipment.sum + "','" + equipment.sum + "','" + equipment.mno + "','" + equipment.time + "')";
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

        #region 根据负责人号返回对应的一行信息
        /// <summary>
        /// 根据设备编号返回对应的一行信息
        /// </summary>
        /// <param name="equipmentname">设备名</param>
        /// <returns></returns>
        public DataTable SelectEquipmentInfo(string equipmentname)
        {
            string sql = "select * from Equipment where 负责人号='" + equipmentname + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 根据设备名称返回对应的一行信息
        /// <summary>
        /// 根据设备名称返回对应的一行信息
        /// </summary>
        /// <param name="equipmentname">设备名称</param>
        /// <returns></returns>
        public DataTable SelectEquipmentByName(string equipmentname)
        {
            string sql = "select * from Equipment where 设备名='" + equipmentname + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 修改设备信息
        /// <summary>
        /// 修改设备信息
        /// </summary>
        /// <param name="equipment">设备实体</param>
        /// <returns></returns>
        public int ModifyEquipmentInfo(Model.Equipment equipment)
        {
            string sql = "update Equipment set 设备名='" + equipment.name + "',总数量='" + equipment.sum + "',库存数量='" + equipment.stock + "',负责人号='" + equipment.mno + "',购买时间='" + equipment.time + "' where 设备名='" + equipment.name + "'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 删除一个设备信息
        /// <summary>
        /// 删除一个设备信息
        /// </summary>
        /// <param name="sno">设备名</param>
        /// <returns></returns>
        public int DeleteEquipmentInfo(string equipmentname)
        {
            string sql = "delete from Equipment where 设备名='" + equipmentname + "'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 返回一张记录表信息
        /// <summary>
        /// 返回一张记录表信息
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnLoanRecord()
        {
            string sql = "select * from LoanRecord";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 添加一条借出设备记录
        /// <summary>
        /// 添加一条借出设备记录
        /// </summary>
        /// <param name="record">一条借出记录</param>
        /// <returns></returns>
        public int AddLoanRecord(Model.LoanRecord record )
        {
            string sql = "insert into LoanRecord(设备名,借用人编号,数量,借用日期,归还状态) values('" + record.name + "','" + record.loanpno + "','" + record.num + "','" + record.time + "','" + record .state+ "')";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion 

        #region 更新设备的数量
        /// <summary>
        /// 更新设备的数量
        /// </summary>
        /// <param name="name">设备名</param>
        /// <param name="loannum">设备借出数量</param>
        public void Update(string name, int loannum)
        {
            string sql = "update Equipment set 库存数量=库存数量 -'"+loannum+"' where 设备名='"+name+"'";
            int result = sqlhelper.ExecuteNonQuery(sql);
        }

        #endregion

        #region 根据设备名称返回借出表对应的一行信息
        /// <summary>
        /// 根据设备名称返回借出表对应的一行信息
        /// </summary>
        /// <param name="equipmentname">设备名称</param>
        /// <returns></returns>
        public DataTable SelectLoanInfoByName(string equipmentname)
        {
            string sql = "select * from LoanRecord where 设备名='" + equipmentname + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 根据借用人编号返回借出表的一行信息
        /// <summary>
        /// 根据借用人编号返回借出表的一行信息
        /// </summary>
        /// <param name="loanpno">借出人编号</param>
        /// <returns></returns>
        public DataTable SelectLoanInfoByno(int loanpno)
        {
            string sql = "select * from LoanRecord where 借用人编号='" + loanpno + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;

        }
        #endregion

        #region 更新借出记录表数据
        /// <summary>
        /// 更新借出记录表数据
        /// </summary>
        /// <param name="record">记录实体</param>
        /// <returns></returns>
        public int updateRecord(Model.LoanRecord record)
        {
            string sql = "update LoanRecord set 设备名='" + record.name + "',借用人编号='" + record.loanpno + "',数量='" + record.num + "',借用日期='" + record.time + "',归还状态='" + record.state + "' where 设备名='" + record.name+"'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion
    }
}
