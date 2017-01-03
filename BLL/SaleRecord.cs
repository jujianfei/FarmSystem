/*
 *创建人：琚建飞
 *创建时间：2016/12/11 13:03:46
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class SaleRecord
    {
         #region 添加一条销售记录
        /// <summary>
        /// 添加一条销售记录
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public int AddSaleRecord(Model.SaleRecord record)
        {
            DAL.SaleRecord sale = new DAL.SaleRecord();
            return sale.AddSaleRecord(record);
        }
        #endregion

        #region 返回一张销售记录表信息
        /// <summary>
        /// 返回一张销售记录表信息
        /// </summary>
        /// <returns></returns>
        public DataTable salerecord()
        {
            DAL.SaleRecord record = new DAL.SaleRecord();
            return record.salerecord();
        }
        #endregion

        #region 根据名字返回一条销售信息
        /// <summary>
        /// 根据名字返回一条销售信息
        /// </summary>
        /// <param name="name">名字</param>
        /// <returns></returns>
        public DataTable saleinfo(string name)
        {
            DAL.SaleRecord record = new DAL.SaleRecord();
            return record.saleinfo(name);
        }
        #endregion

        #region 根据产品名修改信息
        /// <summary>
        /// 根据产品名修改信息
        /// </summary>
        /// <param name="record">记录实体</param>
        /// <returns></returns>
        public int modifyinfo(Model.SaleRecord record)
        {
            DAL.SaleRecord sale = new DAL.SaleRecord();
            return sale.modifyinfo(record);
        }
        #endregion

        #region 删除一行信息
        /// <summary>
        /// 删除一行信息
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int delete(string name)
        {
            DAL.SaleRecord record = new DAL.SaleRecord();
            return record.delete(name);
        }
        #endregion

        #region 添加一条配送信息
        /// <summary>
        /// 添加一条配送信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="no"></param>
        /// <returns></returns>
        public void transport(string name, string no)
        {
            DAL.SaleRecord record = new DAL.SaleRecord();
            record.transport(name,no);
        }
        #endregion

        #region 从数据库中读取运输表数据
        /// <summary>
        /// 从数据库中读取运输表数据
        /// </summary>
        /// <returns></returns>
        public DataTable Transportinfo()
        {
            DAL.SaleRecord record = new DAL.SaleRecord();
            return record.Transportinfo();
        }
        #endregion
    }
}
