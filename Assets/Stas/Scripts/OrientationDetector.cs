using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrientationDetector : MonoBehaviour {

	public void SwitchOrientation(bool portrait)
    {
        if(portrait)
        {
            Screen.orientation = ScreenOrientation.Portrait;
        }
        
    }
}
