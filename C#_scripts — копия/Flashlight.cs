using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour
{
    public float batteryLife = 60f; // Продолжительность работы фонарика в секундах
    public Light flashlight; // Ссылка на компонент света

    private float currentBatteryLife; // Текущая продолжительность работы батареек

    public Image img_1;
    public Image img_2;
    public Image img_3;
    public Image img_4;
    public Image img_5;
    public GameObject panel;

    void Start()
    {
        currentBatteryLife = batteryLife;

        panel.gameObject.SetActive(false);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            panel.gameObject.SetActive(true);
        }
    }

    void Update()
    {
        if (currentBatteryLife > 0f)
        {
            currentBatteryLife -= Time.deltaTime; // Уменьшаем время работы батареек
            if (currentBatteryLife <= 0f)
            {
                flashlight.enabled = false; // Выключаем фонарик, когда батарейки севшие
            }
        }

        if (currentBatteryLife <= 0f)
        {
            img_1.gameObject.SetActive(false);
        }
        else if (currentBatteryLife >= 0f)
        {
            img_1.gameObject.SetActive(true);
        }
        if (currentBatteryLife <= 60f)
        {
            img_2.gameObject.SetActive(false);
        }
        else if (currentBatteryLife >= 60f)
        {
            img_2.gameObject.SetActive(true);
        }
        if (currentBatteryLife <= 120f)
        {
            img_3.gameObject.SetActive(false);
        }
        else if (currentBatteryLife >= 120f)
        {
            img_3.gameObject.SetActive(true);
        }
        if (currentBatteryLife <= 180f)
        {
            img_4.gameObject.SetActive(false);
        }
        else if (currentBatteryLife >= 180f)
        {
            img_4.gameObject.SetActive(true);
        }
        if (currentBatteryLife <= 240f)
        {
            img_5.gameObject.SetActive(false);
        }
        else if (currentBatteryLife >= 240f)
        {
            img_5.gameObject.SetActive(true);
        }
    }

    public void ReplaceBatteries()
    {
        currentBatteryLife = batteryLife; // Полная зарядка батареек
        flashlight.enabled = true; // Включаем фонарик
    }

    public float GetCurrentBatteryLife()
    {
        return currentBatteryLife;
    }
}
