/*
 *创建人：琚建飞
 *创建时间：2016/12/8 16:35:50
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Crops
    {
        #region 添加农作物信息
        /// <summary>
        /// 添加农作物信息
        /// </summary>
        /// <param name="crop"></param>
        /// <returns></returns>
        public int AddCropinfo(Model.Crops crop)
        {
            DAL.Crops cropinfo = new DAL.Crops();
            return cropinfo.AddCropinfo(crop);
        }
        #endregion

        #region 返回一张农作物数据表
        /// <summary>
        /// 返回一张农作物数据表
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnCropsInfo()
        {
            DAL.Crops crops = new DAL.Crops();
            return crops.ReturnCropsInfo();
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
            DAL.Crops crop = new DAL.Crops();
            return crop.SelectCropByNo(cropmno);
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
            DAL.Crops crop = new DAL.Crops();
            return crop.ModifyCropinfo(cropinfo);
        }
        #endregion

        #region 根据编号删除农作物信息
        /// <summary>
        /// 根据编号删除农作物信息
        /// </summary>
        /// <param name="cropno">农作物号</param>
        /// <returns></returns>
        public int DeleteCrop(string cropno)
        {
            DAL.Crops crop = new DAL.Crops();
            return crop.DeleteCrop(cropno);
        }
        #endregion

        #region 根据名称显示对应的农作物信息
        /// <summary>
        /// 根据名称显示对应的农作物信息
        /// </summary>
        /// <param name="cropname"></param>
        /// <returns></returns>
        public DataTable SelectCropByName(string cropname)
        {
            DAL.Crops crop = new DAL.Crops();
            return crop.SelectCropByName(cropname);
        }
        #endregion
    }
}
