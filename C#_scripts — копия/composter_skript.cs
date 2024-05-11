using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class composter_skript : MonoBehaviour
{
    public Transform player; // Ссылка на трансформ игрока
    public Transform composter; // Ссылка на трансформ монстра

    private float teleportTimer = 0f; // Таймер для отслеживания времени для телепортации
    private float teleportInterval = 220f; // Интервал телепортации в секундах 

    
    public float detectionDistance = 15f; // Расстояние, на котором монстр обнаруживает игрока
    public float movementSpeed = 2.8f; // Скорость движения монстра
    public float changeDirectionInterval = 2f; // Интервал изменения направления движения для блуждания
    public float maxRandomDistance = 5f; // Максимальное случайное расстояние, на которое может переместиться монстр

    private bool isPlayerDetected = false;
    private Vector3 randomDirection;
    private float timer;

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


        if (transform.eulerAngles.z <= 0 && transform.eulerAngles.z >= 0 && transform.eulerAngles.x <= 0 && transform.eulerAngles.x >= 0)
        {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y, 0);
        }

        // Проверяем расстояние до игрока
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        // Если расстояние до игрока меньше или равно detectionDistance, монстр обнаруживает игрока
        if (distanceToPlayer <= detectionDistance)
        {
            isPlayerDetected = true;
        }
        else
        {
            isPlayerDetected = false;
        }

        if (isPlayerDetected)
        {
            // Если монстр видит игрока, он начинает преследовать его
            transform.LookAt(player);
            transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
        }
        else
        {
            // Если монстр не видит игрока, он продолжает случайное блуждание
            RandomWander();
        }
    }

    
    private void TeleportMonster()
    {
        Vector3 teleportPosition = player.position - (player.forward * 8f); // Позиция для телепортации
        composter.position = teleportPosition; // Телепортируем монстра
    }

    void RandomWander()
    {
        // Обновляем таймер
        timer -= Time.deltaTime;

        // Если таймер истек, выбираем новое случайное направление движения
        if (timer <= 0)
        {
            randomDirection = GetRandomDirection();
            timer = changeDirectionInterval;
        }

        // Перемещаем монстра в выбранном направлении
        Vector3 newPosition = transform.position + randomDirection * movementSpeed * Time.deltaTime;
        newPosition = new Vector3(
            newPosition.x,
            newPosition.y,
            newPosition.z
        );
        transform.position = newPosition;
    }

    Vector3 GetRandomDirection()
    {
        // Генерируем случайное направление движения
        float randomX = Random.Range(-1f, 1f);
        float randomZ = Random.Range(-1f, 1f);
        Vector3 direction = new Vector3(randomX, 0f, randomZ).normalized;

        // Умножаем направление на случайное расстояние
        direction *= Random.Range(0f, maxRandomDistance);

        return direction;
    }
}
