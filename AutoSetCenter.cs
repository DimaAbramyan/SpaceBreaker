using System.Collections;
using System.Collections.Generic;
using LaserProj;
using UnityEngine;

public class AutoSetCenter : MonoBehaviour
{
    public Vector3 posOfCenter = new Vector3();
    private float scale = 0.8f;
    public void SetCenter()
    {
        scale = 0.8f;
        //0.05*(0.24/0.8)
       // Debug.Log($"Pos: {this.transform.position},Center: {posOfCenter},a/b {transform.localScale/scale}");
        this.transform.position +=  posOfCenter * (transform.localScale/scale).x;
        if (this.GetComponentInChildren<Laser>() != null )
        {
            GameObject Laser = GetComponentInChildren<Laser>().gameObject;
            Laser.transform.localPosition += new Vector3(0,50.5f,0);
             }
    }
}
