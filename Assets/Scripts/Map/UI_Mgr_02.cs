using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Mgr_02 : MonoBehaviour
{

    public Text Tx_BallNum;
    //储存显示精灵球数量的 Text组件
    public Text Tx_FoodNum;
    //储存显示食物数量的 Text组件
    public GameObject Im_Catch;
    //储存捕捉面板
    public static UI_Mgr_02 Instance;
    //申请静态公有脚本类变量

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        Tx_BallNum.text = StaticData.BallNum.ToString();
    }

    //增加精灵球数量显示
    public void AddBallNum()
    {
        StaticData.BallNum++;
        //小球的数量增加1

        Tx_BallNum.text = StaticData.BallNum.ToString();
        //把增加后的数字转化为字符串显示在Text组件上
    }

    //增加食物的显示数量
    public void AddFoodNum()
    {
        int _num = Int32.Parse(Tx_FoodNum.text);
        //将从Text组件中获取的字符串转化为数字储存在局部变量_num中
        _num++;
        //在原有的数字基础上加1
        Tx_FoodNum.text = _num.ToString();
        //把增加后的数字转化为字符串显示在Text组件上
    }

    //设置捕捉面板的激活状态
    public void SetIm_Catch(bool bl)
    {
        Im_Catch.SetActive(bl);
        //通过调用函数时传入的bool类型参数bl来设置面板状态
    }

    //跳转AR场景的按钮函数
    public void Btn_GoARScn() {
        SceneManager.LoadScene("AR_Scn");
    }

    //跳转到精灵仓库
    public void Btn_ToStore()
    {
        SceneManager.LoadScene("Store_Scn");
    }
}
