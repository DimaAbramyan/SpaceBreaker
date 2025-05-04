using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoAboutWave : MonoBehaviour
{
   
    private void Update()
    {
        if (this.transform.childCount == 0)
            Destroy(this.gameObject);
    }
}
