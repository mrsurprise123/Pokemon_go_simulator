﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Find : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //碰撞触发器检测函数 
    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Avatar") //如果进入的物体标签为“Avatar” 则
        {
            UI_Mgr_02.Instance.AddBallNum();
            //调用UI管理其中的函数增加小球显示的数量
            Destroy(gameObject);
            //销毁物体
        }
    }
}
