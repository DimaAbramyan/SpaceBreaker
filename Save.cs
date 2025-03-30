using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Save : MonoBehaviour
{
    public SaveShip save;

    public void ErazeSave()
    {
        save.shipName = "";
    }
}
