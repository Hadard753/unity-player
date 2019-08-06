using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestOrient : MonoBehaviour {
    public Text text;

	// Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
    }
	
	// Update is called once per frame
	void Update () {
        text.text = Input.gyro.gravity.ToString();
	}
}
