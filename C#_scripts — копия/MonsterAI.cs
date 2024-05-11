using UnityEngine;

public class MonsterAI : MonoBehaviour
{
    public Transform player; // Ссылка на трансформ игрока
    public float detectionDistance = 10f; // Расстояние, на котором монстр обнаруживает игрока
    public float movementSpeed = 3f; // Скорость движения монстра
    public float changeDirectionInterval = 2f; // Интервал изменения направления движения для блуждания
    public float maxRandomDistance = 5f; // Максимальное случайное расстояние, на которое может переместиться монстр

    private bool isPlayerDetected = false;
    private Vector3 randomDirection;
    private float timer;

    void Start()
    {
        // Выбираем случайное начальное направление движения
        randomDirection = GetRandomDirection();
        timer = changeDirectionInterval;
    }

    void Update()
    {
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