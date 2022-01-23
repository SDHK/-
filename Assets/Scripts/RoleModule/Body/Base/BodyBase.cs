using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 飞船机体基类
/// </summary>
public abstract class BodyBase : MonoBehaviour
{
    /// <summary>
    /// 血量上限：固定值
    /// </summary>
    public int HP_Max;

    /// <summary>
    /// 护甲减伤：固定值
    /// </summary>
    public float Armor;

    /// <summary>
    /// 挂载技能？是否改为字符串
    /// </summary>
    public SkillBase skillBase;


    

}
