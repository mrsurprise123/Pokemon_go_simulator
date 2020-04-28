using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetSave  {

    private string strName = "未命名宠物";
    //记录小精灵的名字

    private int petIndex = 0;
    //记录小精灵对应的模型在预制体集合中的序号

    //小精灵名字属性
    public string PetName {
        get { return strName; }
        set { strName = value; }
    }

    //小精灵序号的属性
    public int PetIndex {
        get { return petIndex; }
        set { petIndex = value; }
    }

    /// <summary>
    /// 构造函数
    /// </summary>
    /// <param name="name">为命名传入的参数</param>
    /// <param name="index">为序号赋值传入的参数</param>
    public PetSave(string name,int index) {
        PetName = name;
        //用传入的参数对小精灵的名字进行赋值
        PetIndex = index;
        //用传入的参数对小精灵的序号进行赋值
    }
}
