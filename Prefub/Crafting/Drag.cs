using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Drag : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler //��� ������
{
    [SerializeField] private RectTransform rectTransform;
    public Transform parentAfterDrag;
    private CanvasGroup canvasGroup;
    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }
    public void OnBeginDrag(PointerEventData eventData) //������ �����
    {
      //  Instantiate(gameObject);
        canvasGroup.alpha = 0.6f;
        parentAfterDrag = transform.parent;
       // Debug.Log("������ �����");
        transform.SetParent(transform.root);
       // Debug.Log(transform.root);
    }
public void OnDrag(PointerEventData eventData)
{
    //Debug.Log("�����");
    rectTransform.position = Input.mousePosition;
    canvasGroup.blocksRaycasts = false;
}
public void OnEndDrag(PointerEventData eventData)
{
    //Debug.Log("onPointerDown");
    canvasGroup.alpha = 1f;
    canvasGroup.blocksRaycasts = true;
    transform.SetParent(parentAfterDrag);
    //Debug.Log(parentAfterDrag);
    if (this.GetComponentInParent<Craft>() != null) 
        { Destroy(gameObject); }
    if (GetComponentInParent<SetVeapon>().GetComponentsInChildren<Drag>().Length > 1)
        {
            Destroy(GetComponentInParent<SetVeapon>().GetComponentInChildren<Drag>().gameObject);
        }
}
}
