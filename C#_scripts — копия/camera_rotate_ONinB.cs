using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_rotate_ONinB : MonoBehaviour
{
    public float rotateSpeed = 100f;

    
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed * Input.GetAxis("Horizontal"));
    }
}
