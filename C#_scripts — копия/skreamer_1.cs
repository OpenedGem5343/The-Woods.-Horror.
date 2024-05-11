using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skreamer_1 : MonoBehaviour
{
    public Transform player;

    public float targetAlpha = 1f; 
    public float fadeSpeed = 0f;

    public Image otherImage; 

    public Sprite spr;
    public Sprite u_died;

    public float time = 0f;

    public Button button;

    void Start()
    {
        // Скрываем кнопку при запуске игры
        button.gameObject.SetActive(false);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Получаем текущий цвет изображения
            Color currentColor = otherImage.color;

            // Устанавливаем новый цвет с установленной прозрачностью
            Color newColor = new Color(currentColor.r, currentColor.g, currentColor.b, targetAlpha);

            // Устанавливаем новый цвет изображения
            otherImage.color = newColor;

            // Устанавливаем спрайт
            otherImage.sprite = spr;

            //экран смерти

            player.position = new Vector3(0, -100, 0);

            StartCoroutine(DisplayDeathScreen());

        }
    }
    IEnumerator DisplayDeathScreen()
    {
        
        yield return new WaitForSeconds(3f);

        otherImage.sprite = null;

        otherImage.sprite = u_died;

        
        button.gameObject.SetActive(true);
    }
}
