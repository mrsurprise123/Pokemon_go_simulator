using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARBallCtrl : MonoBehaviour {

    public static ARBallCtrl Instance;


    public Transform PosInsBall;

    private GameObject[] balls;


    void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start () {
        balls = Resources.LoadAll<GameObject>("Balls");
        ARUI_Mgr.Instance.UpdateUIBallNum();
        InsNewBall();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InsNewBall()
    {
        if (StaticData.BallNum>0)
        {
            GameObject _ball = Instantiate(balls[0], PosInsBall.position, PosInsBall.rotation);
            _ball.transform.SetParent(PosInsBall);
            _ball.gameObject.AddComponent<SphereCollider>();
            _ball.gameObject.AddComponent<ARShootBall>();
            _ball.transform.localScale = new Vector3(25f, 25f, 25f);
            _ball.GetComponent<SphereCollider>().radius = 0.01f;
        }

    }
}
