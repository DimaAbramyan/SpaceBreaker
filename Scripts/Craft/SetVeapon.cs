using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class SetVeapon : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        Drag draggableItem = dropped.GetComponent<Drag>();
        draggableItem.parentAfterDrag = transform;  
    }
}
