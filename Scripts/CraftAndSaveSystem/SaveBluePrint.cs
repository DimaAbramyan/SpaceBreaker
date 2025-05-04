using System.Collections;
using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using UnityEngine;

public class SaveBluePrint : MonoBehaviour
{
    public body_Data shipBody;
    private weapon_Data[] weapons;
    public weapon_Saving[] arr;
    public InputFieldExample SendToText;
    [SerializeField] private GameObject field;
    public void CreateBluePrint()
    {
        body_Data shipBody = FindAnyObjectByType<body_Data>();         
        weapons = shipBody.GetComponentsInChildren<weapon_Data>();
        if (weapons.Length == shipBody.weaponCnt)
        {
            field.SetActive(true);
            ///Сохранение файла
            weapon_Saving[] arr = new weapon_Saving[weapons.Length];
            Debug.Log(weapons.Length);
            for (int i = 0; i < weapons.Length; i++)
            {
                arr[i] = new weapon_Saving(weapons[i].ID, weapons[i].place);
            }
            SendToText.GetValue(arr, shipBody);
        }
        else
        {
            Debug.Log("Нельзя");
            
        }

            
    }
}
