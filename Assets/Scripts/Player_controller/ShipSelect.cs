using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerController;
using System.Transactions;
using JetBrains.Annotations;
using ShipInterface;
public class ShipSelect : MonoBehaviour
{
    
    private static int selectedShip = 0;
    public static int previousSelectedShip;
    // Start is called before the first frame update
    void Start()
    {
        SelectShip();
    }

    // Update is called once per frame
    void Update()
    {
        //previousSelectedShip = selectedShip;
        Debug.Log(selectedShip);
        if (previousSelectedShip != selectedShip)
        {
            SelectShip();
            //previousSelectedShip = selectedShip;
        }
    }
    void SelectShip()
    {
        IShip currentShip;
        PlayerControllerClass playerRB = GetComponent<PlayerControllerClass>();
        int i = 0;
        foreach (Transform ship in transform)
        {
            if (i == selectedShip)
            {
                ship.gameObject.SetActive(true);
                currentShip = ship.gameObject.GetComponent<IShip>();
                playerRB.changeCurrent(currentShip);
                previousSelectedShip = selectedShip;
            }
            else
            {
                ship.gameObject.SetActive(false);
            }
            i++;
        }
    }
    public void Selected1()
    {
        selectedShip = 0;
    }
    public void Selected2()
    {
        selectedShip = 1;
    }
    public void Selected3()
    {
        selectedShip = 2;
    }
}
