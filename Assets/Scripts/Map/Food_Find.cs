using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food_Find : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //碰撞函数
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Avatar")
        {
            UI_Mgr_02.Instance.AddFoodNum();
            //调用UI管理器脚本中增加食物数量的函数
            Destroy(gameObject);
            //销毁物体
        }
    }
}
