using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet_Find : MonoBehaviour {

    public int Pet_Index;
    //储存小精灵的序号

	// Use this for initialization
	void Start () {
		transform.LookAt(GameObject.FindGameObjectWithTag("Avatar").transform);
        //让小精灵面朝角色的位置
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag=="Avatar") //如果碰撞到的物体是角色
        {
            UI_Mgr_02.Instance.SetIm_Catch(true);
            //显示捕捉面板 

            StaticData.CatchingPetIndex = Pet_Index;
            //当碰到角色时 把小精灵的序号赋值给静态数据中正要捕捉的小精灵序号

            Destroy(gameObject);
            //销毁物体
        }

        if (other.tag=="Ball")
        {
            playCatched();
            //播放动画
            StartCoroutine(ShowCatchedPn());
        }
    }

    //延迟显示面板并销毁小精灵
    IEnumerator ShowCatchedPn() {
        yield return new WaitForSeconds(2f);
        ARUI_Mgr.Instance.Show_PnCatched();
        //显示捕捉成功面板
        Destroy(transform.gameObject);
        //销毁小精灵本身
    }

    //播放被捕捉到的动画
    private void playCatched()
    {
        transform.GetComponent<Animator>().SetTrigger("Catched");
    }
}
