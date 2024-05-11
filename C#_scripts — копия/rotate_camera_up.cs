using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_camera_up : MonoBehaviour
{
    public float rotateSpeed = 200f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.left * Time.deltaTime * rotateSpeed * Input.GetAxis("Mouse Y"));
    }
}
