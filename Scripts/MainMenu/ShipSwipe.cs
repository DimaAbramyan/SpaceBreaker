using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipSwipe : MonoBehaviour
{
    private  int selectedShip;
    [SerializeField] private GameObject[] ships;
     private Vector2 range;
     private Vector2 startPos;
     private Vector2 endPos;
    [SerializeField]
    private GameObject gameObject;
    private void Start()
    {
        range.x = Screen.width/10;
        range.y = Screen.height/8; 
    }
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    startPos = touch.position;
                    break;
                case TouchPhase.Ended:
                    endPos = touch.position;
                    HandleSwipe();
                    break;
            }
        }
    }
    private void HandleSwipe()
    {
        if (!gameObject.activeSelf)
        {
            if ((Mathf.Abs(startPos.x - endPos.x) > range.x) && (Mathf.Abs(startPos.y - endPos.y) < range.y))
            {
                if (startPos.x - endPos.x > 0)
                {
                    SelectNext();
                }
                else
                {
                    SelectPrevious();
                }
            }
        }
    }
    public void SelectNext()
    {
        ships[selectedShip].SetActive(false); // Скрываем текущий объект
        selectedShip = (selectedShip + 1) % ships.Length; // Переходим к следующему объекту
        ships[selectedShip].SetActive(true); // Показываем следующий объект
    }

    public void SelectPrevious()
    {
        ships[selectedShip].SetActive(false); // Скрываем текущий объект
        selectedShip = (selectedShip - 1 + ships.Length) % ships.Length; // Переходим к предыдущему объекту
        ships[selectedShip].SetActive(true); // Показываем предыдущий объект
    }
}
