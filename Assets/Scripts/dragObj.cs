using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dragObj : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private Vector3 offset;
    public RectTransform parent;
    //public Transform backP;
    //public Transform frontP;


    void Start()
    {

    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        offset = parent.localPosition - Input.mousePosition;
        parent.transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        parent.localPosition = Input.mousePosition + offset;
    }

    public void OnEndDrag(PointerEventData eventData)
    {

    }


    
}
