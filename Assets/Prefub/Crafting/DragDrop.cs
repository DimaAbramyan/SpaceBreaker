using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Craft : MonoBehaviour, IPointerDownHandler
{
    [SerializeField] private RectTransform rectTransform;
    public Transform parentAfterDrag;
    public Drag drag;
    private CanvasGroup canvasGroup;
    private void Awake() 
    { 
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        Instantiate(drag, rectTransform);

    }

/*public void OnBeginDrag(PointerEventData eventData)
{
    Instantiate(this, rectTransform);
    canvasGroup.alpha = 0.9f;
    Debug.Log("onPointerDown");
    parentAfterDrag = transform.parent;
    transform.SetParent(transform.root);
}
public void OnDrag(PointerEventData eventData)
{
    Debug.Log("onDrag");
    rectTransform.position = Input.mousePosition;
    canvasGroup.blocksRaycasts = false;
}


public void OnEndDrag(PointerEventData eventData)
{
    Debug.Log("onPointerDown");
    canvasGroup.alpha = 1f;
    canvasGroup.blocksRaycasts = true;
    transform.SetParent(parentAfterDrag);
    }*/
public void OnPointerDown(PointerEventData eventData)
{
    Debug.Log("onPointerDown");
    Instantiate(drag, rectTransform);
}
}
