/*
 *创建人：琚建飞
 *创建时间：2016/12/10 16:27:55
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace BLL
{
    public class Animal
    {

        #region 返回整张牲畜表
        /// <summary>
        /// 返回整张牲畜表
        /// </summary>
        /// <returns></returns>
        public DataTable ReturnAllAnimalInfo()
        {
            DAL.Animal animal = new DAL.Animal();
            return animal.ReturnAllAnimalInfo();
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
            DAL.Animal animal = new DAL.Animal();
            return animal.SelectAnimalByName(animalname);
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
            DAL.Animal animal = new DAL.Animal();
            return animal.SelectAnimalByMno(mno);
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
            DAL.Animal modify = new DAL.Animal();
            return modify.ModifyAnimalinfo(animal);
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
            DAL.Animal animal = new DAL.Animal();
            return animal.DeleteAnimal(animalname);
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
            DAL.Animal add = new DAL.Animal();
            return add.AddAnimal(animal);
        }
        #endregion

        #region 根据名称修改库存量的数值
        /// <summary>
        /// 根据名称修改库存量的数值
        /// </summary>
        /// <param name="name">牲畜名</param>
        /// <param name="num">数量</param>
        public void ModifyAnimalNumByName(string name, string num)
        {
            DAL.Animal animal = new DAL.Animal();
            animal.ModifyAnimalNumByName(name,num);
        }
        #endregion
    }
}
