using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_sun : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * 0.2f);
    }
}
