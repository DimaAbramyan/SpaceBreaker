using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    [SerializeField] private RectTransform rectTransform;
    public Transform parentAfterDrag;
    private CanvasGroup canvasGroup;
    private void Start()
    {
        //Debug.Log("Im alive");
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
    canvasGroup.alpha = 0.6f;
    parentAfterDrag = transform.parent;
        Debug.Log(parentAfterDrag);
        transform.SetParent(transform.root);
        Debug.Log(transform.root);
    }
public void OnDrag(PointerEventData eventData)
{
   // Debug.Log("onDrag");
    rectTransform.position = Input.mousePosition;
    canvasGroup.blocksRaycasts = false;
}


public void OnEndDrag(PointerEventData eventData)
{
   // Debug.Log("onPointerDown");
    canvasGroup.alpha = 1f;
    canvasGroup.blocksRaycasts = true;
            transform.SetParent(parentAfterDrag);
            Debug.Log(parentAfterDrag);
      if (this.GetComponentInParent<Craft>() != null) 
        { Destroy(gameObject); }
}
}
