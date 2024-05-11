using UnityEngine;

public class BreathingEffect : MonoBehaviour
{
    public float breathingRange = 0.1f; // Амплитуда движения дыхания
    public float breathingSpeed = 1f; // Скорость дыхания
    private Vector3 originalPosition; // Исходная позиция камеры

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        // Вычисляем смещение камеры по вертикали с помощью синусоиды,
        // чтобы создать впечатление дыхания персонажа
        float breathingOffset = Mathf.Sin(Time.time * breathingSpeed) * breathingRange;

        // Применяем смещение к исходной позиции камеры
        Vector3 newPosition = originalPosition + new Vector3(0f, breathingOffset, 0f);
        transform.localPosition = newPosition;
    }
}

