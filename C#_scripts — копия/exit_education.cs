using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class exit_education : MonoBehaviour
{
    public Button button_1;
    public Button button_2;
    public GameObject panel;

    void Start()
    {
        button_1.gameObject.SetActive(false);
        button_2.gameObject.SetActive(false);
        panel.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            button_1.gameObject.SetActive(true);
            button_2.gameObject.SetActive(true);
            panel.SetActive(true);
        }
    }

    public void close_that_window()
    {
        button_1.gameObject.SetActive(false);
        button_2.gameObject.SetActive(false);
        panel.SetActive(false);
    }
}
