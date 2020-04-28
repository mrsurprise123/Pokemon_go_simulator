using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARShootBall : MonoBehaviour {

    public float FwdForce = 200f;
    public Vector3 StanTra = new Vector3(0, 1f, 0);

    private bool blTouched = false;
    private bool blShooted = false;
    private Vector3 startPositon;
    private Vector3 endPosition;
    private float disFick;
    private Vector3 offset;
    private int timeFlick;
    private float speedFlick;
    private Camera camera;



	// Use this for initialization
	void Start () {
        camera = Camera.main;

	}
	
	// Update is called once per frame
	void Update () {
        if (blTouched)
        {
            slip();

        }
	}

    private void resetVari()
    {
        startPositon = Input.mousePosition;
        endPosition = Input.mousePosition;
    }

    void OnMouseDown()
    {
        if (blShooted==false) 
        {
            blTouched = true;
        }
    }

    private void slip()
    {
        timeFlick += 25;

        if (Input.GetMouseButtonDown(0))
        {
            resetVari(); //重置参数
        }
        if (Input.GetMouseButton(0)) 
        {
            endPosition = Input.mousePosition;
            offset = camera.transform.rotation * (endPosition-startPositon);
            disFick = Vector3.Distance(startPositon,endPosition);
        }
        if (Input.GetMouseButtonUp(0))
        {
            speedFlick = disFick / timeFlick;
            blTouched = false;
            timeFlick = 0;
            if (disFick>20&&endPosition.y-startPositon.y>0)
            {
                shootBall();
            }
        }
    }

    private void shootBall()
    {
        transform.gameObject.AddComponent<Rigidbody>();
        Rigidbody _rigBall = transform.GetComponent<Rigidbody>();
        _rigBall.velocity = offset.normalized * speedFlick;
        _rigBall.AddForce(camera.transform.forward*FwdForce);
        _rigBall.AddTorque(transform.right);
        _rigBall.drag = 0.5f;
        blShooted = true;
        transform.parent = null;

        StaticData.BallNum--;
        ARUI_Mgr.Instance.UpdateUIBallNum();

        StartCoroutine(LateInsBall());
    }

    IEnumerator LateInsBall() {
        yield return new WaitForSeconds(0.2f);
        ARBallCtrl.Instance.InsNewBall();
    }
}
