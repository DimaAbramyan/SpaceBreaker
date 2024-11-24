using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class PickUpItem : MonoBehaviour
{
    public GameObject pickupObject;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Метод для поднятия предмета
    public void PickUpItem()
    {
        if (Player.position = buff.position);
        {
            if (Minigun._levelCurrent < 4);
            {
                Minigun._levelCurrent += 1;
                Destroy(Buff);
            }
        }
    }
}