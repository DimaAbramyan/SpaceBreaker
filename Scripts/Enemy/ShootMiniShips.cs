using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ShootMiniShips : MonoBehaviour
{
    [SerializeField] GameObject gm;
    MotherShip motherShip;
    private int cntOfChild;
    void Start()
    {
        motherShip.Timer = 3;
        motherShip =  GetComponentInParent<MotherShip>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LaunchShips()
    {
        List<MiniShip> miniShips = GetComponentsInChildren<MiniShip>().ToList();
        StartCoroutine(LaunchShipsSequentially(miniShips));
    }

    private IEnumerator LaunchShipsSequentially(List<MiniShip> miniShips)
    {
        cntOfChild = miniShips.Count;
        foreach (MiniShip miniShip in miniShips)
        {
            miniShip.Launch();
            if (cntOfChild == 0)
            {
                Reload();
            }
            cntOfChild--;
            yield return new WaitForSeconds(0.25f); 
        }
    }
    private void  Reload()
    {
        Debug.Log("Пенис");
        Instantiate(this, motherShip.transform);
        Destroy(this);
    }
}
