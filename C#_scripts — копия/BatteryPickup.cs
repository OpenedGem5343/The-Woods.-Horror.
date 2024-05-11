using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    public Flashlight flashlight; // Ссылка на объект фонарика

    private void OnTriggerEnter(Collider other)
    {
        // Проверяем, что объект, с которым столкнулся триггер, игрок
        if (other.CompareTag("Player"))
        {
            // Активируем метод ReplaceBatteries() у объекта фонарика
            flashlight.ReplaceBatteries();
            // Уничтожаем объект батареек после использования
            Destroy(gameObject);
        }
    }
}
