using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventory : MonoBehaviour
{
    public GameObject[] itemPrefabs;
    private GameObject currentItemInstance;
    public Image[] inImages;
    public Sprite[] spr;
    

    

    void Update()
    {
        // Взять предмет в руку при нажатии на цифру 1
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            // Проверяем, есть ли уже предмет в руке
            if (currentItemInstance == null)
            {
                TakeItem(0); // Если нет, берем новый предмет
            }
            else
            {
                // Если есть, убираем текущий предмет и берем новый
                RemoveItem();
                TakeItem(0);
            }
        }
        // Взять предмет в руку при нажатии на цифру 2
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            // Проверяем, есть ли уже предмет в руке
            if (currentItemInstance == null)
            {
                TakeItem(1); // Если нет, берем новый предмет
            }
            else
            {
                // Если есть, убираем текущий предмет и берем новый
                RemoveItem();
                TakeItem(1);
            }
        }
        // Взять предмет в руку при нажатии на цифру 3
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            // Проверяем, есть ли уже предмет в руке
            if (currentItemInstance == null)
            {
                TakeItem(2); // Если нет, берем новый предмет
            }
            else
            {
                // Если есть, убираем текущий предмет и берем новый
                RemoveItem();
                TakeItem(2);
            }
        }
        // Взять предмет в руку при нажатии на цифру 4
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            // Проверяем, есть ли уже предмет в руке
            if (currentItemInstance == null)
            {
                TakeItem(3); // Если нет, берем новый предмет
            }
            else
            {
                // Если есть, убираем текущий предмет и берем новый
                RemoveItem();
                TakeItem(3);
            }
        }
        // Взять предмет в руку при нажатии на цифру 5
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            // Проверяем, есть ли уже предмет в руке
            if (currentItemInstance == null)
            {
                TakeItem(4); // Если нет, берем новый предмет
            }
            else
            {
                // Если есть, убираем текущий предмет и берем новый
                RemoveItem();
                TakeItem(4);
            }
        }
        // Убрать предмет из руки при нажатии на цифру 0
        else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            RemoveItem();
        }
        if (currentItemInstance != null)
        {
            currentItemInstance.transform.position = transform.position + transform.forward * 2f;
            currentItemInstance.transform.rotation = transform.rotation;
        }

        
    }

    

    void TakeItem(int itemIndex)
    {
        if (itemIndex < 0 || itemIndex >= itemPrefabs.Length)
            return;

        if (inImages[itemIndex].sprite != null)
        {
            RemoveItem(); // Удаляем текущий предмет перед тем, как взять новый

            // Создаем экземпляр предмета и помещаем его перед игроком
            currentItemInstance = Instantiate(itemPrefabs[itemIndex], transform.position + transform.forward * 0.01f, Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(0f, 180f, 0f)));
        }

        
        
    }

    void RemoveItem()
    {
        if (currentItemInstance != null)
        {
            Destroy(currentItemInstance);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "boards")
        {
            inImages[0].sprite = spr[0];
        }
        if (other.tag == "wire_axe")
        {
            inImages[1].sprite = spr[1];
        }
        if (other.tag == "flashlight")
        {
            inImages[2].sprite = spr[2];
        }
        if (other.tag == "medkit")
        {
            inImages[3].sprite = spr[3];
        }
        if (other.tag == "hammer")
        {
            inImages[4].sprite = spr[4];
        }
    }
}