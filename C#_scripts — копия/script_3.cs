using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_3 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        transform.Translate(0, 4, 0);
    }
}
