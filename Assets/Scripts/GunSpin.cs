using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpin : MonoBehaviour
{
    public float spinSpeed;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q)){
            transform.Rotate(Vector3.up, -spinSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E)){
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
        }
    }
}
