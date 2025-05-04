using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingSaveShips : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Ships; 
    [SerializeField]
    private GameObject[] Weapons;
    private void Awake()
    {
        SaveData[] saveData = FindObjectOfType<GotSaves>().allSaves.AllSavesThatLoaded;
        for (int i = 0; i < saveData.Length; i++)
        {
            //GameObject ShipCreated = Instantiate(Ships[CurrentShipIBuild.save.shipId]);
            BuildingShip(saveData[i], i);
            if (i > 0)
            {

            }

        }
    }
    private void BuildingShip(SaveData Ship, int j)
    {
        GameObject ShipCreated = Instantiate(Ships[Ship.shipId], transform);
        if (j > 0) {ShipCreated.SetActive(false); }
        Debug.Log(Ship.Data.Length);
        for (int i = 0; i < Ship.Data.Length; i++)
        {
            Debug.Log($"i = {i}");
            GameObject WeaponICreate = Instantiate(Weapons[Ship.Data[i].ID], ShipCreated.transform);
           // WeaponICreate.transform.position = (Ship.Data[i].place);
            MakeVeaponLookGood(WeaponICreate, Ship.shipId, i);
            if (i > 0)
            {
                //ShipCreated.gameObject.SetActive(false);
            }
        }
    }
    void MakeVeaponLookGood(GameObject weapon, int ShipId, int weaponPos)
    {
        Debug.Log($"ID корабля:{ShipId}");
        Debug.Log($"ID номер пушки:{weaponPos}");
        switch (ShipId)
        {
            case 2:
                weapon.transform.localScale = weapon.transform.localScale * 0.3f;
                //Debug.Log(weapon.transform.localPosition);
                switch (weaponPos)
                {
                    case 0:
                        weapon.transform.localPosition = new Vector3(-0.2f, -0.2f, 0);
                        break;
                    case 1:
                        weapon.transform.localPosition = new Vector3(-0.08f, -0.015f, 0);
                        break;
                    case 2:
                        weapon.transform.localPosition = new Vector3(0.08f, -0.015f, 0);
                        break;
                    case 3:
                        weapon.transform.localPosition = new Vector3(0.2f, -0.2f, 0);
                        break;
                }
                weapon.GetComponent<AutoSetCenter>().SetCenter();
                break;
            case 0:
                weapon.transform.localScale = weapon.transform.localScale * 0.7f;
               // Debug.Log(weapon.transform.localPosition);
                switch (weaponPos)
                {
                    case 0:
                        weapon.transform.localPosition = new Vector3(-0.36f, 0.18f, 0);
                        break;
                    case 1:
                        weapon.transform.localPosition = new Vector3(0.36f, 0.18f, 0);
                        break;
                    case 2:
                        weapon.transform.localPosition = new Vector3(0.45f, -0.4f, 0);
                        break;
                    case 3:
                        weapon.transform.localPosition = new Vector3(-0.45f, -0.4f, 0);
                        break;
                    case 4:
                        weapon.transform.localPosition = new Vector3(0.0f, -0.5f, 0);
                        break;
                }
                weapon.GetComponent<AutoSetCenter>().SetCenter();
                break;
            case 1:
                weapon.transform.localScale = weapon.transform.localScale * 0.4f;
              //  Debug.Log(weapon.transform.localPosition);
                switch (weaponPos)
                {
                    case 0:
                        weapon.transform.localPosition = new Vector3(-0.2f, 0.12f, 0);
                        break;
                    case 1:
                        weapon.transform.localPosition = new Vector3(0.2f, 0.12f, 0);
                        break;
                    case 2:
                        weapon.transform.localPosition = new Vector3(-0.015f, -0.2f, 0);
                        break;
                }
                weapon.GetComponent<AutoSetCenter>().SetCenter();
                break;

        }
    }
}
