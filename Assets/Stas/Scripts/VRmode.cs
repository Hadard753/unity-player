using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRmode : MonoBehaviour {
    public GameObject headCam;
    public GameObject rightCam;
    public GameObject leftCam;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.GetInt("VRmode") == 1)
        {
            rightCam.SetActive(true);
            leftCam.SetActive(true);
            headCam.SetActive(false);
        }
        else
        {
            rightCam.SetActive(false);
            leftCam.SetActive(false);
            headCam.SetActive(true);
        }
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }
}
