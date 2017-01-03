/*
 *创建人：琚建飞
 *创建时间：2016/12/8 16:28:50
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Crops
    {
        private SQLHelper sqlhelper = null;
        public Crops()
        {
            sqlhelper = new SQLHelper();  //初始化sqlhelper
        }

        #region 添加农作物信息
        /// <summary>
        /// 添加农作物信息
        /// </summary>
        /// <param name="crop">农作物实体信息</param>
        /// <returns></returns>
        public int AddCropinfo(Model.Crops crop)
        {
            string sql = "insert into Crops values('"+crop.name+"','"+crop.area+"','"+crop.mno+"')";
            int result=sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 返回一张农作物数据表
        /// <summary>
        /// 返回一张农作物数据表
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnCropsInfo()
        {
            string sql = "select * from Crops";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 根据负责人号显示对应的农作物信息
        /// <summary>
        /// 根据负责人号显示对应的农作物信息
        /// </summary>
        /// <param name="cropmno">负责人号</param>
        /// <returns></returns>
        public DataTable SelectCropByNo(string cropmno)
        {
            string sql = "select * from Crops where 负责人号='" + cropmno + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 根据名称显示对应的农作物信息
        /// <summary>
        /// 根据名称显示对应的农作物信息
        /// </summary>
        /// <param name="cropname">农作物名称</param>
        /// <returns></returns>
        public DataTable SelectCropByName(string cropname)
        {
            string sql = "select * from Crops where 农作物名='" + cropname + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 修改农作物信息
        /// <summary>
        /// 修改农作物信息
        /// </summary>
        /// <param name="cropinfo">农作物信息实体</param>
        /// <returns></returns>
        public int ModifyCropinfo(Model.Crops cropinfo)
        {
            string sql = "update Crops set 农作物名='" + cropinfo.name + "',种植面积='" + cropinfo.area + "', 负责人号='" + cropinfo.mno + "'where 农作物名='" + cropinfo.name + "'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 根据农作物名删除农作物信息
        /// <summary>
        /// 根据农作物名删除农作物信息
        /// </summary>
        /// <param name="cropno">农作物名</param>
        /// <returns></returns>
        public int DeleteCrop(string cropname)
        {
            string sql = "delete from Crops where 农作物名='" + cropname + "'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

    }
}
