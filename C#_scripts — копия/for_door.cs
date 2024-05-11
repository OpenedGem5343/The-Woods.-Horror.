using UnityEngine;

public class for_door : MonoBehaviour
{
    public float doorOpenHeight = 5f; // Высота, на которую открывается дверь

    private Vector3 initialPosition; // Исходная позиция двери

    void Start()
    {
        initialPosition = transform.position;
    }

    public void OnTriggerEnter(Collider other)
    {
        // Если в зону триггера входит игрок, открываем дверь вверх
        transform.position = initialPosition + Vector3.down * doorOpenHeight;
    }

    public void OnTriggerExit(Collider other)
    {
        // Если игрок выходит из зоны триггера, закрываем дверь
        transform.position = initialPosition;
    }
}
