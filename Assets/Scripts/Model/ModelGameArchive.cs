using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using CoroutineSystem;
using LitJson;
using Singleton;
using StateMachine;
using UnityEngine;
using UnityEngine.Networking;

public class ModelGameArchive : SingletonBase<ModelGameArchive>
{
    private string ArchiveFileName;
    private DataGameArchive data;

    public static DataGameArchive Data { get => Instance().data; set => Instance().data = value; }

    /// <summary>
    /// 读取文件名字(后缀过滤)
    /// </summary>
    public static List<FileInfo> GetNames()
    {
        List<FileInfo> FileNames = new List<FileInfo>();
        DirectoryInfo info = new DirectoryInfo(Application.streamingAssetsPath + Cd.PathGameArchive);//读取路径文件夹文件
        FileInfo[] infos = info.GetFiles();//读取所有文件名
        foreach (FileInfo file in infos)//遍历每个文件
        {
            string[] fileName = file.Name.Split('.');
            if ("JSON" == fileName[fileName.Length - 1].ToUpper()) FileNames.Add(file);//存入链表        
        }
        return FileNames;
    }

    public static void Load(string saveFileName)//!加载完后进入游戏？
    {
        UnityWebRequest.Get(Application.streamingAssetsPath + Cd.PathGameArchive + "/" + saveFileName)
        .CoroutineWeb(
        (Request) =>
        {
            Instance().data = JsonMapper.ToObject<DataGameArchive>(Request.downloadHandler.text);
            instance.ArchiveFileName = saveFileName;

            Cd.FSMgame.FocusStateMachineGet().Set(StateGame.instance);
        });
    }


    public static void Save()
    {
        File.WriteAllText(Application.streamingAssetsPath + Cd.PathGameArchive + "/" + Instance().ArchiveFileName, Convert_String(JsonMapper.ToJson(Instance().data)));
    }

    public static void Delete(string saveFileName)
    {
        File.Delete(Application.streamingAssetsPath + Cd.PathGameArchive + "/" + saveFileName);
    }


    public static void New(string archiveName)
    {
        Instance().ArchiveFileName = archiveName;
        instance.data = new DataGameArchive()
        {
            gameMaps = new List<string> { "Test001" },

            playerEquipment = new PlayerEquipment()
            {
                weapon = "武器1疾锋",
                wing = "机翼1锋棱",
                body = "主体1护盾",
                special = "特殊1辐光"
            },
            playerArsenal = new PlayerArsenal()
            {
                weapon = new List<string>() { "武器1疾锋" },
                wing = new List<string>() { "机翼1锋棱" },
                body = new List<string>() { "主体1护盾" },
                special = new List<string>() { "特殊1辐光" }
            }
        }
        ;

        Save();
    }

    /// <summary>
    /// 乱码转换：用于解决LitJson把类转换成string时出现的乱码
    /// </summary>
    /// <param name="source">乱码字符串</param>
    /// <returns>正常字符串</returns>
    public static string Convert_String(string source)
    {
        return new Regex(@"\\u([0-9A-F]{4})", RegexOptions.IgnoreCase)
        .Replace(source, x => string.Empty + Convert.ToChar(Convert.ToUInt16(x.Result("$1"), 16)));
    }

}


public class DataGameArchive//存档结构
{
    public List<string> gameMaps;//卡关解锁

    public PlayerEquipment playerEquipment;
    public PlayerArsenal playerArsenal;
}

public class PlayerEquipment//玩家装备
{
    public string weapon;
    public string wing;
    public string body;
    public string special;
}

public class PlayerArsenal//玩家武器库
{
    public List<string> weapon;
    public List<string> wing;
    public List<string> body;
    public List<string> special;
}
