/*
 *创建人：琚建飞
 *创建时间：2016/12/7 19:57:57
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Equipment
    {
        #region 返回设备信息表
        /// <summary>
        /// 返回设备信息表
        /// </summary>
        /// <returns></returns>
        public DataTable EquipmentInfo()
        {
            DAL.Equipment equipment = new DAL.Equipment();
            return equipment.EquipmentInfo();
        }
        #endregion

        #region 添加设备信息
        /// <summary>
        /// 添加设备信息
        /// </summary>
        /// <param name="equipment">输入的设备信息</param>
        /// <returns></returns>
        public bool AddEquipment(Model.Equipment equipment)
        {
            DAL.Equipment addequipment = new DAL.Equipment();
            return addequipment.AddEquipment(equipment);
        }
        #endregion

        #region 根据负责人号返回对应的一行信息
        /// <summary>
        /// 根据设备编号返回对应的一行信息
        /// </summary>
        /// <param name="equipmentno">设备实体</param>
        /// <returns></returns>
        public DataTable SelectEquipmentInfo(string equipmentmno)
        {
            DAL.Equipment equipment = new DAL.Equipment();
            return equipment.SelectEquipmentInfo(equipmentmno);
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
            DAL.Equipment equipment = new DAL.Equipment();
            return equipment.SelectEquipmentByName(equipmentname);
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
            DAL.Equipment equipmentinfo = new DAL.Equipment();
            return equipmentinfo.ModifyEquipmentInfo(equipment);
        }
        #endregion

        #region 删除一个设备信息
        /// <summary>
        /// 删除一个设备信息
        /// </summary>
        /// <param name="sno">设备号</param>
        /// <returns></returns>
        public int DeleteEquipmentInfo(string equipmentno)
        {
            DAL.Equipment equipment = new DAL.Equipment();
            return equipment.DeleteEquipmentInfo(equipmentno);
        }
        #endregion

        #region 返回一张记录表信息
        /// <summary>
        /// 返回一张记录表信息
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnLoanRecord()
        {
            DAL.Equipment equipment = new DAL.Equipment();
            return equipment.ReturnLoanRecord();
        }
        #endregion

        #region 添加一条借出设备记录
        /// <summary>
        /// 添加一条借出设备记录
        /// </summary>
        /// <param name="record">一条借出记录</param>
        /// <returns></returns>
        public int AddLoanRecord(Model.LoanRecord record)
        {
            DAL.Equipment equipment = new DAL.Equipment();
            return equipment.AddLoanRecord(record);
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
            DAL.Equipment equipment = new DAL.Equipment();
            equipment.Update(name, loannum);
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
            DAL.Equipment equipment = new DAL.Equipment();
            return equipment.SelectLoanInfoByName(equipmentname);
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
            DAL.Equipment equipment = new DAL.Equipment();
            return equipment.SelectLoanInfoByno(loanpno);
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
            DAL.Equipment equipment = new DAL.Equipment();
            return equipment.updateRecord(record);
        }
        #endregion
    }
}
