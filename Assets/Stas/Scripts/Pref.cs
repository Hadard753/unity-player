using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pref : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (!PlayerPrefs.HasKey("VRmode"))
        {
            PlayerPrefs.SetInt("VRmode", 0);
        }
	}
	
    public void SetVRmode(bool vr)
    {
        if(vr)
        {
            PlayerPrefs.SetInt("VRmode", 1);
        }
        else
        {
            PlayerPrefs.SetInt("VRmode", 0);
        }
    }
}
