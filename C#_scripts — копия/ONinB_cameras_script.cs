using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ONinB_cameras_script : MonoBehaviour
{
    public Camera[] cameras; // Массив всех камер, которые вы хотите использовать
    public int currentCameraIndex = 0; // Индекс текущей активной камеры

    public Button next_;
    public Button close_all_cameras;

    public void Start()
    {
        
        SwitchCamera(0);
        next_.gameObject.SetActive(false);
        close_all_cameras.gameObject.SetActive(false);
    }

    public void Cameras()
    {
        // Увеличиваем индекс камеры
        currentCameraIndex++;

        // Если индекс камеры достигает конца списка, переключаемся ко второй камере
        if (currentCameraIndex >= cameras.Length)
        {
            currentCameraIndex = 1;
        }
        SwitchCamera(currentCameraIndex);
        
    }

    public void SwitchCamera(int newIndex)
    {
        // Отключаем все камеры
        foreach (Camera cam in cameras)
        {
            cam.gameObject.SetActive(false);
        }
        // Включаем выбранную камеру
        cameras[newIndex].gameObject.SetActive(true);

        next_.gameObject.SetActive(true);
        close_all_cameras.gameObject.SetActive(true);
    }

    public void Close_cameras()
    {
        
        SwitchCamera(0);
        next_.gameObject.SetActive(false);
        close_all_cameras.gameObject.SetActive(false);
    }
}
