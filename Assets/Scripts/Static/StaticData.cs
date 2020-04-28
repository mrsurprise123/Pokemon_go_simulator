using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticData  {

    public static int BallNum = 5;
    //精灵球数量的全局变量 

    public static int CatchingPetIndex;
    //当前正要捕捉的小精灵在预制体集合中的序号

    public static List<PetSave> PetList = new List<PetSave>();
    //申请列表储存捕捉到的小精灵类

    /// <summary>
    /// 向全局数据的小精灵列表中添加小精灵
    /// </summary>
    /// <param name="petSave">小精灵的属性类</param>
    public static void AddPet(PetSave petSave) {
        PetList.Add(petSave);
    }

    /// <summary>
    /// 通过小精灵在预制体集合中的序号获取它的精灵类型
    /// </summary>
    /// <param name="index">小精灵在预制体集合中的序号</param>
    /// <returns>小精灵的类型</returns>
    public static string GetType(int index)
    {
        if (index==0)
        {
            return "小熊";
        }
        else if (index == 1)
        {
            return "小牛";
        }
        else if (index == 2)
        {
            return "兔子";
        }
        else if (index == 3)
        {
            return "小鸡";
        }
        else if (index == 4)
        {
            return "老虎";
        }
        else if (index == 5)
        {
            return "猴子";
        }
        else if (index == 6)
        {
            return "白猫";
        }
        else if (index == 7)
        {
            return "狮子";
        }
        else if (index == 8)
        {
            return "企鹅";
        }
        else if (index == 9)
        {
            return "犀牛";
        }
        else
        {
            return "小黄狗";
        }
    }
}
