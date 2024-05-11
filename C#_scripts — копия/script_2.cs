using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        transform.Translate(0, -2, 0);
    }
}
