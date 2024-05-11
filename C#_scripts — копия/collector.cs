using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collector : MonoBehaviour
{
    public Image[] inImages;
    public Sprite spr;

    public float targetAlpha = 1f;
    public float fadeSpeed = 0f;

    public Image otherImage;

    public Sprite spr_;
    

    public float time = 0f;

    public Button button;

    void Start()
    {
        button.gameObject.SetActive(false);
    }

    void Update()
    {
        if (inImages[0].sprite != null && inImages[1].sprite != null && inImages[2].sprite != null && inImages[3].sprite != null && inImages[4].sprite != null && inImages[5].sprite != null && inImages[6].sprite != null)
        {
            // Получаем текущий цвет изображения
            Color currentColor = otherImage.color;

            // Устанавливаем новый цвет с установленной прозрачностью
            Color newColor = new Color(currentColor.r, currentColor.g, currentColor.b, targetAlpha);

            // Устанавливаем новый цвет изображения
            otherImage.color = newColor;

            transform.position = new Vector3(0, -100, 0);

            otherImage.sprite = spr_;

            button.gameObject.SetActive(true);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "001")
        {
            inImages[0].sprite = spr;
        }
        else if (other.tag == "002")
        {
            inImages[1].sprite = spr;
        }
        else if (other.tag == "003")
        {
            inImages[2].sprite = spr;
        }
        else if (other.tag == "004")
        {
            inImages[3].sprite = spr;
        }
        else if (other.tag == "005")
        {
            inImages[4].sprite = spr;
        }
        else if (other.tag == "006")
        {
            inImages[5].sprite = spr;
        }
        else if (other.tag == "007")
        {
            inImages[6].sprite = spr;
        }
    }
}
