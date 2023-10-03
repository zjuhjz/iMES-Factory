﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using iMES.Core.CacheManager;
using iMES.Core.DBManager;
using iMES.Core.Extensions.AutofacManager;
using iMES.Core.Services;
using iMES.Entity.DomainModels;

namespace iMES.Core.Infrastructure
{
    public static class DictionaryManager
    {
        private static List<Sys_Dictionary> _dictionaries { get; set; }

        private static object _dicObj = new object();
        private static string _dicVersionn = "";
        public const string Key = "inernalDic";

        public static List<Sys_Dictionary> Dictionaries
        {
            get { return GetAllDictionary(); }
        }

        public static Sys_Dictionary GetDictionary(string dicNo)
        {
            return GetDictionaries(new string[] { dicNo }).FirstOrDefault();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dicNos"></param>
        /// <param name="executeSql">是否执行自定义sql</param>
        /// <returns></returns>
        public static IEnumerable<Sys_Dictionary> GetDictionaries(IEnumerable<string> dicNos, bool executeSql = true)
        {
            static List<Sys_DictionaryList> query(string sql)
            {
                try
                {
                    return DBServerProvider.SqlDapper.QueryList<SourceKeyVaule>(sql, null).Select(s =>
                        new Sys_DictionaryList()
                        {
                            DicName = s.Value,
                            DicValue = s.Key.ToString()
                        }).ToList();
                }
                catch (Exception ex)
                {
                    Logger.Error($"字典执行sql异常,sql:{sql},异常信息：{ex.Message + ex.StackTrace}");
                    throw ex;
                    //  Console.WriteLine(ex.Message);
                    // return null;
                }
            }

            foreach (var item in Dictionaries.Where(x => dicNos.Contains(x.DicNo)))
            {
                if (executeSql)
                {
                    Console.WriteLine("execute sql :" + item.DbSql);
                    //  2020.05.01增加根据用户信息加载字典数据源sql
                    string sql = DictionaryHandler.GetCustomDBSql(item.DicNo, item.DbSql);
                    Console.WriteLine("execute sql :" + sql);
                    if (!string.IsNullOrEmpty(item.DbSql))
                    {
                        item.Sys_DictionaryList = query(sql);

                        foreach (var v in item.Sys_DictionaryList)
                        {
                            Console.WriteLine(v.DicName);
                            Console.WriteLine(v.DicValue);
                        }


                        Console.WriteLine(item.Sys_DictionaryList.Count);
                        Console.WriteLine(item.Sys_DictionaryList.ToString());
                    }
                }

                yield return item;
            }
        }

        /// <summary>
        /// 根据数据字典名称和键值获取文本
        /// </summary>
        /// <param name="dicNo">数据字典名称</param>
        /// <param name="key">键值</param>
        /// <returns></returns>
        public static string GetDictionaryList(string dicNo, string key)
        {
            Sys_Dictionary sd = GetDictionary(dicNo);
            if (sd.Sys_DictionaryList.Find(x => x.DicValue == key) != null)
            {
                return sd.Sys_DictionaryList.Find(x => x.DicValue == key).DicName;
            }
            else
            {
                return "";
            }
        }

        /// <summary>
        /// 每次变更字典配置的时候会重新拉取所有配置进行缓存(自行根据实际处理)
        /// </summary>
        /// <returns></returns>
        private static List<Sys_Dictionary> GetAllDictionary()
        {
            ICacheService cacheService = AutofacContainerModule.GetService<ICacheService>();
            //每次比较缓存是否更新过，如果更新则重新获取数据
            if (_dictionaries != null && _dicVersionn == cacheService.Get(Key))
            {
                return _dictionaries;
            }

            lock (_dicObj)
            {
                if (_dicVersionn != "" && _dictionaries != null && _dicVersionn == cacheService.Get(Key))
                    return _dictionaries;
                _dictionaries = DBServerProvider.DbContext
                    .Set<Sys_Dictionary>()
                    .Where(x => x.Enable == 1)
                    .Include(c => c.Sys_DictionaryList).ToList();

                string cacheVersion = cacheService.Get(Key);
                if (string.IsNullOrEmpty(cacheVersion))
                {
                    cacheVersion = DateTime.Now.ToString("yyyyMMddHHMMssfff");
                    cacheService.Add(Key, cacheVersion);
                }
                else
                {
                    _dicVersionn = cacheVersion;
                }
            }

            return _dictionaries;
        }
    }

    public class SourceKeyVaule
    {
        public object Key { get; set; }
        public string Value { get; set; }
    }
}