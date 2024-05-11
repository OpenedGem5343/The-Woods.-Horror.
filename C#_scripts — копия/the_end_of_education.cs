using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class the_end_of_education : MonoBehaviour
{
    public float targetAlpha = 1f;
    public float fadeSpeed = 0f;

    public Image otherImage;

    public Button button;

    void Start()
    {
        // Скрываем кнопку при запуске игры
        button.gameObject.SetActive(false);
    }

    public void OnCollisionEnter(Collision collision)
    {
        // Получаем текущий цвет изображения
        Color currentColor = otherImage.color;

        // Устанавливаем новый цвет с установленной прозрачностью
        Color newColor = new Color(currentColor.r, currentColor.g, currentColor.b, targetAlpha);

        // Устанавливаем новый цвет изображения
        otherImage.color = newColor;

        

        button.gameObject.SetActive(true);
    }
}
