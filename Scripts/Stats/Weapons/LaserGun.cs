using System.Collections;
using System.Collections.Generic;
using FireProj;
using LaserProj;
using UnityEngine;

public class LaserGun : Weapon
{
    [SerializeField]
    private GameObject laserObj;
    private int _levelCurrent;
    public Laser Laser;
    public Transform LaserSpawn;
    public void Start()
    {
        //Destroy(GetComponentInChildren<Laser>());
        GameObject Las = Instantiate(laserObj, transform);
        Las.transform.localPosition = this.transform.localPosition + new Vector3(0, 115.5f,0);
        Las.transform.localPosition = new Vector3(0, Las.transform.localPosition.y, 0);
       
    }
}
