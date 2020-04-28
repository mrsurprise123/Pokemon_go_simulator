using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARInsPet : MonoBehaviour {

    public Transform[] traPos;

    private GameObject[] pets;

    public Transform CameraTra;
	void Start () {
        pets = Resources.LoadAll<GameObject>("Pets");
        InsPet();
        checkDis();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void InsPet() {
        int _index = Random.Range(0,traPos.Length);
        Transform _tra = traPos[_index];
        GameObject _pet= Instantiate(pets[StaticData.CatchingPetIndex],_tra.position,_tra.rotation);
        _pet.transform.localScale = new Vector3(0.5f,0.5f,0.5f);
        _pet.transform.LookAt(new Vector3(CameraTra.position.x,_pet.transform.position.y,CameraTra.position.z));
    }

    private void checkDis()
    {
        foreach (Transform pos in traPos)
        {
            float _dis= Vector3.Distance(pos.position,CameraTra.position);
            Debug.Log(_dis);
        }
    }
}
