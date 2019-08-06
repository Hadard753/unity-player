using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuiControl : MonoBehaviour {

    public GameObject monoCam;
    public GameObject leftCam;
    public GameObject rightCam;
    private bool isStereo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SwitchMode()
    {
        if(isStereo)
        {
            monoCam.SetActive(false);
            leftCam.SetActive(true);
            rightCam.SetActive(true);
        }
        else
        {
            monoCam.SetActive(true);
            leftCam.SetActive(false);
            rightCam.SetActive(false);
        }
        isStereo = !isStereo;
    }
}
