using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoInstuction : MonoBehaviour {

    
    SpriteRenderer rend;

    public RawImage rawImage;
    public VideoPlayer videoPlayer;
    public AudioSource audioSource;

	// Use this for initialization
	void Start () {
        //rend = GetComponent<SpriteRenderer>();
        //Color c = rend.material.color;
        //c.a = 0f;
        //rend.material.color = c;

        StartCoroutine(PlayVideo());
	}
	
	// Update is called once per frame
	void Update () {
        
    }
    /*
    IEnumerator CheckForChange()
    {
        while (true)
            switch (Input.deviceOrientation)
            {
                case DeviceOrientation.Unknown:
                case DeviceOrientation.FaceUp:
                case DeviceOrientation.FaceDown:
                    yield return null;
                    break;
                default:
                    yield return Screen.orientation == (ScreenOrientation)Input.deviceOrientation ?
                        null : StartCoroutine(Fade());
                    break;
            }
    }

    IEnumerator Fade()
    {
        for(float f = 0.05f; f<1; f+=0.05f)
        {
            Color c = rend.material.color;
            c.a = f;
            rend.material.color = c;
            yield return new WaitForSeconds(0.05f);
        }
    }
    */
    IEnumerator PlayVideo()
    {
        videoPlayer.Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(1);
        while(!videoPlayer.isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage.texture = videoPlayer.texture;
        videoPlayer.Play();
        audioSource.Play();
    }
}
