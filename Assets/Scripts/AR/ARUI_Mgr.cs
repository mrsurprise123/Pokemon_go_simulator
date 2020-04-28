using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ARUI_Mgr : MonoBehaviour {

    public static ARUI_Mgr Instance;

    public Text Tx_BallNum;

    public GameObject PnCatched;

    public Text InputPetName;

    void Awake()
    {
        Instance = this;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void Btn_GoMapScn()
    {
        SceneManager.LoadScene("Map_Scn");
    }


    public void UpdateUIBallNum()
    {
        Tx_BallNum.text = StaticData.BallNum.ToString();

    }

    public void Show_PnCatched()
    {
        PnCatched.SetActive(true);
    }

    public void Btn_Yes() {
        string _name = InputPetName.text;
        int _index = StaticData.CatchingPetIndex;
        StaticData.AddPet(new PetSave(_name, _index));
        SceneManager.LoadScene("Store_Scn");
    }


    public void Btn_GiveUp() {
        SceneManager.LoadScene("Map_Scn");
    }


    public void Btn_ToStore() {
        SceneManager.LoadScene("Store_Scn");
    }
}
