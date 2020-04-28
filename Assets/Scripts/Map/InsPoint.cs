using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsPoint : MonoBehaviour
{

    public GameObject Ava;
    //储存地图角色
    public GameObject PrePoint;
    //储存事件点预制体
    public float MinDis=3f;
    //储存距离范围的最小值
    public float MaxDis=50f;
    //储存距离范围的最大值

    private Vector3 v3Ava;
    //储存当前角色位置的坐标

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //生成事件点预制体
    public void InsPointFuc()
    {
        v3Ava = Ava.transform.position;
        //获取角色当前的坐标位置
        float _dis = Random.Range(MinDis, MaxDis);
        //从距离范围中取一个随机距离值
        Vector2 _pOri = Random.insideUnitCircle;
        //从原点为（0，0）的坐标上获取任意一个方向的向量
        Vector2 _pNor = _pOri.normalized;
        //获取到向量的单位向量  只有方向，大小为1
        Vector3 _v3Point=new Vector3(v3Ava.x+_pNor.x*_dis,0,v3Ava.z+_pNor.y*_dis );
        //算出随机点的位置
        //_pNor.x*_dis随机向量的x值
        //_pNor.y*_dis随机向量的y值
        GameObject _poiMark = Instantiate(PrePoint,_v3Point,transform.rotation);
        //生成预制体

    }
}
