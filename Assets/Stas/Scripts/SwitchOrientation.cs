using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOrientation : MonoBehaviour {
    public ScenesManager sceneManager;
    public int nextScene = 4;
    private bool isSceneTransition = false;

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {

        //Determines in which direction the Device was turned, and depending on this, 
        //changes the screen orientation to the LandscapeLeft or LandscapeRight.
        if (!isSceneTransition)
        {
            if(Input.gyro.gravity.x < -0.5f)
            {
                Screen.orientation = ScreenOrientation.LandscapeLeft;
                isSceneTransition = true;
            }
            if (Input.gyro.gravity.x > 0.5f)
            {
                Screen.orientation = ScreenOrientation.LandscapeRight;
                isSceneTransition = true;
            }
        }
        else
        {
            sceneManager.SwitchScene(nextScene);
        }
	}
}
