using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class board_breaker : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("abc"))
        {
            transform.position = new Vector3(0, -10, 0);
        }
    }
}
