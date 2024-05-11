using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu_changer : MonoBehaviour
{

    public float tim = 0f;
    public float timer = 5f;
    public Sprite[] img;
    public int what = 0;
    public Image where;

    void Update()
    {
        tim += Time.deltaTime;

        if (tim >= timer) 
        {
            tim = 0;

            
            if (what == 0)
            {
                what = 1;
            }
            else if (what == 1)
            {
                what = 2;
            }
            else if (what == 2)
            {
                what = 3;
            }
            else if (what == 3)
            {
                what = 4;
            }
            else
            {
                what = 0;
            }
            
            where.sprite = img[what];
        }
    }
}
