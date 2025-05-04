using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class SelfControl : MonoBehaviour
{
    [SerializeField] bool LockedLook = true;
    private void Start()
    {
        if (LockedLook)
        transform.localScale = new Vector3(
    -transform.localScale.x,
    transform.localScale.y,
    transform.localScale.z
);
    }
    void LateUpdate()
    {
        if (LockedLook)
        transform.up = -Vector3.up;
        // сброс поворота
    }
}
