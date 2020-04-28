using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreInsPet : MonoBehaviour {

    public Transform[] Pos;
    //储存宠物栏中小精灵的生成点


    private GameObject[] pets;
    //储存所有的小精灵预制体
    private GameObject[] petsShow = new GameObject[3];
    //在仓库中展示出来的小精灵

    void Awake()
    {
        pets = Resources.LoadAll<GameObject>("Pets");
    }

    // Use this for initialization
    void Start () {
        InsPet();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InsPet() {
        int _petNum = StaticData.PetList.Count;
        //通过全局类中储存的 已经捕捉小精灵的 数量 来判断已经捕捉到了多少小精灵

        //如果有捕捉到的宠物 则
        if (_petNum>0)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((_petNum - 1)<i)
                {
                    return;
                }
                PetSave _petInfo = StaticData.PetList[i];
                //从全局类中获取到对应序号的小精灵属性类

                Instantiate(pets[_petInfo.PetIndex],Pos[i].position, Pos[i].rotation);
                //通过小精灵属性中的 预制体集合序号 生成对应的小精灵模型
                //生成的位置是在 宠物栏的对应位置上

                string _petNm = _petInfo.PetName;
                //获取到这个小精灵的命名

                StoreUIMgr.Instance.UpdatePetNm(i,_petNm);
                //刷新小精灵名字的显示

                string _petType = StaticData.GetType(_petInfo.PetIndex);
                //获取小精灵的种类

                StoreUIMgr.Instance.UpdatePetType(i,_petType);
                //刷新小精灵种类的显示

            }
        }
        
    }
}
