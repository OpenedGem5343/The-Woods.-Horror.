using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTeleport : MonoBehaviour
{
    public Transform player; // Ссылка на трансформ игрока
    public Transform monster; // Ссылка на трансформ монстра

    private float teleportTimer = 0f; // Таймер для отслеживания времени для телепортации
    private float teleportInterval = 360f; // Интервал телепортации в секундах 

    private void Update()
    {
        // Обновляем таймер
        teleportTimer += Time.deltaTime;

        // Если прошло достаточно времени для телепортации
        if (teleportTimer >= teleportInterval)
        {
            // Телепортируем монстра на расстояние 10 от игрока
            TeleportMonster();

            // Сбрасываем таймер
            teleportTimer = 0f;
        }
    }

    // Метод для телепортации монстра на расстояние 10 от игрока
    private void TeleportMonster()
    {
        Vector3 teleportPosition = player.position + (player.forward * 10f); // Позиция для телепортации
        monster.position = teleportPosition; // Телепортируем монстра
    }
}
