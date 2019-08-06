using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GyroControl : MonoBehaviour
{

    private bool gyroIsOn;

    // Use this for initialization
    void Start()
    {
        Input.gyro.enabled = true;
        StartCoroutine(GyroCorutine());

    }

    // Update is called once per frame
    void Update()
    {
        if (gyroIsOn)
        {
            transform.Rotate(-Input.gyro.rotationRateUnbiased.x, -Input.gyro.rotationRateUnbiased.y, Input.gyro.rotationRateUnbiased.z);
        }

    }

    IEnumerator GyroCorutine()
    {
        yield return new WaitForSeconds(2.0f);
        gyroIsOn = true;
        transform.LookAt(new Vector3(0, Input.gyro.gravity.z, Input.gyro.gravity.y));
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, -Input.gyro.gravity.x * 90);
    }
}
