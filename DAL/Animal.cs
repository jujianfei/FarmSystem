/*
 *创建人：琚建飞
 *创建时间：2016/12/10 16:24:44
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace DAL
{
    public class Animal
    {
        private SQLHelper sqlhelper = null;
        public Animal()
        {
            sqlhelper = new SQLHelper();  //初始化sqlhelper
        }

        #region 返回整张牲畜表
        /// <summary>
        /// 返回整张牲畜表
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnAllAnimalInfo()
        {
            string sql = "select * from Animal";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }

        #endregion

        #region 根据名称返回一行牲畜信息
        /// <summary>
        /// 根据名称返回一行牲畜信息
        /// </summary>
        /// <param name="animalname"></param>
        /// <returns></returns>
        public DataTable SelectAnimalByName(string animalname)
        {
            string sql = "select * from Animal where 牲畜名='" + animalname + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 根据负责人号返回一行牲畜信息
        /// <summary>
        /// 根据负责人号返回一行牲畜信息
        /// </summary>
        /// <param name="mno"></param>
        /// <returns></returns>
        public DataTable SelectAnimalByMno(string mno)
        {
            string sql = "select * from Animal where 负责人号='" + mno + "'";
            DataTable dt = sqlhelper.ExecuteQuery(sql);
            return dt;
        }
        #endregion

        #region 修改牲畜信息
        /// <summary>
        /// 修改牲畜信息
        /// </summary>
        /// <param name="animal">牲畜实体</param>
        /// <returns></returns>
        public int ModifyAnimalinfo(Model.Animal animal)
        {
            string sql = "update Animal set 牲畜名='" + animal.name+ "',牲畜数量='" + animal.sum + "', 负责人号='" + animal.mno + "'where 牲畜名='" + animal.name + "'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 删除一行信息
        /// <summary>
        /// 删除一行信息
        /// </summary>
        /// <param name="animalname">牲畜名</param>
        /// <returns></returns>
        public int DeleteAnimal(string animalname)
        {
            string sql = "delete from Animal where 牲畜名='" + animalname + "'";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 添加一行信息
        /// <summary>
        /// 添加一行信息
        /// </summary>
        /// <param name="animal">动物实体</param>
        /// <returns></returns>
        public int AddAnimal(Model.Animal animal)
        {
            string sql = "insert into Animal values('" + animal.name + "','" + animal.sum + "','" + animal.mno + "')";
            int result = sqlhelper.ExecuteNonQuery(sql);
            return result;
        }
        #endregion

        #region 根据名称修改库存量的数值
        /// <summary>
        /// 根据名称修改库存量的数值
        /// </summary>
        /// <param name="name">牲畜名</param>
        /// <param name="num">数量</param>
        public void ModifyAnimalNumByName(string name,string num)
        {
            string sql = "update Animal set 牲畜数量='"+num+"' where 牲畜名='"+name+"' ";
            int result = sqlhelper.ExecuteNonQuery(sql);
        }

        #endregion

    }
}
