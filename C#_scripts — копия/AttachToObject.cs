using UnityEngine;

public class AttachToObject : MonoBehaviour
{
    private Rigidbody rb;
    private bool isAttached = false;
    private bool isLowered = false;
    private Collision attachedCollision;

    public Transform cameraTransform; // Ссылка на трансформ камеры

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (isAttached)
        {
            // Прикреплен к игроку, проверяем нажатие клавиши Ctrl
            if (Input.GetKeyDown(KeyCode.LeftControl) || Input.GetKeyDown(KeyCode.RightControl))
            {
                if (!isLowered)
                {
                    // Опускаем объект на определенную высоту
                    transform.position -= Vector3.up * 100f;
                    isLowered = true;
                }
                else
                {
                    // Поднимаем объект на уровень игрока
                    transform.position = new Vector3(transform.position.x, attachedCollision.transform.position.y, transform.position.z);
                    isLowered = false;
                }
            }

            // Поворачиваем объект вместе с камерой по оси X
            transform.rotation = Quaternion.Euler(cameraTransform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Проверяем, соприкасается ли объект с тэгом "Player"
        if (collision.collider.CompareTag("Player"))
        {
            // Делаем текущий объект дочерним по отношению к игроку
            transform.parent = collision.transform;
            isAttached = true;
            attachedCollision = collision;

            // Отключаем физику объекта, чтобы он не сталкивался с окружающими объектами
            if (rb != null)
            {
                rb.isKinematic = true;
            }
        }
    }
}
