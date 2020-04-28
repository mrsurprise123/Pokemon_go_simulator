using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoreUIMgr : MonoBehaviour {

    public Text[] Tx_PetNm;
    //储存显示小精灵名字的Text组件

    public Text[] Tx_PetType;
    //储存显示小精灵类型的Text组件

    public static StoreUIMgr Instance;

    void Awake()
    {
        Instance = this;
    }

    /// <summary>
    /// 刷新小精灵名字的显示
    /// </summary>
    /// <param name="index">指定Text在数组中的序号</param>
    /// <param name="strNm">具体要显示的名字</param>
    public void UpdatePetNm(int index,string strNm) {
        Tx_PetNm[index].text = strNm;
    }

    //跳转到地图场景的按钮
    public void Btn_ToMap()
    {
        SceneManager.LoadScene("Map_Scn");
    }

    /// <summary>
    /// 刷新精灵仓库中显示的小精灵种类
    /// </summary>
    /// <param name="index">显示小精灵种类的Text组件序号</param>
    /// <param name="strType">小精灵的种类</param>
    public void UpdatePetType(int index,string strType)
    {
        Tx_PetType[index].text = strType;
    }
}
