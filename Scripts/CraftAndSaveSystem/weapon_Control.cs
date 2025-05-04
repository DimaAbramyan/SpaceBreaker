using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_Control : MonoBehaviour //
{
    public weapon_Data weapon_Data;
    private Vector3 place;
    private SetVeapon handler;
    private void Update()
    {
        place = this.transform.position;
        if (GetComponentInParent<SetVeapon>() != null)
        {
            handler = GetComponentInParent<SetVeapon>();
            place = handler.GetComponent<RectTransform>().transform.localPosition;
            weapon_Data.place = place;
        }
    }
}
