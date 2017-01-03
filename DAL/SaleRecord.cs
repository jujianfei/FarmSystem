/*
 *创建人：琚建飞
 *创建时间：2016/12/11 12:57:19
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class SaleRecord
    {
        private SQLHelper sqlhelper = null;
        public SaleRecord()
        {
            sqlhelper = new SQLHelper();  //初始化sqlhelper
        }

        #region 添加一条销售记录
        /// <summary>
        /// 添加一条销售记录
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public int AddSaleRecord(Model.SaleRecord record)
        {
            string sql = "insert into SaleTable(产品名,卖出,库存,时间) values('" + record.name + "','" + record.sale + "','" + record.save + "','"+record.time+"')";
            int result=sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 返回一张销售记录表信息
        /// <summary>
        /// 返回一张销售记录表信息
        /// </summary>
        /// <returns></returns>
        public DataTable salerecord()
        {
            string sql = "select * from SaleTable";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
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
            string sql = "select * from SaleTable where 产品名='"+name+"'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
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
            string sql = "update SaleTable set 产品名='"+record.name+"',卖出='"+record.sale+"',库存='"+record.save+"',时间='"+record.time+"' where 产品名='"+record.name+"'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
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
            string sql = "delete from SaleTable where 产品名='"+name+"'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 添加一条配送信息
        /// <summary>
        /// 添加一条配送信息
        /// </summary>
        /// <param name="name"></param>
        /// <param name="no"></param>
        /// <returns></returns>
        public void transport(string name,string no)
        {
            string sql = "insert into Transport(产品名,配送人编号) values('"+name+"','"+no+"')";
            int result = sqlhelper.ExecuteNonQuery(sql);
        }
        #endregion

        #region 从数据库中读取运输表数据
        /// <summary>
        /// 从数据库中读取运输表数据
        /// </summary>
        /// <returns></returns>
        public DataTable Transportinfo()
        {
            string sql = "select * from Transport";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion
    }
}
