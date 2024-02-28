using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class dragObj : MonoBehaviour, IDragHandler, IBeginDragHandler, IEndDragHandler
{
    private RectTransform rectTransform;
    private Image image;
    private Vector3 offset;
    public GameObject child;
    //public Transform backP;
    //public Transform frontP;


    void Start()
    {
        rectTransform.GetComponent<RectTransform>();
        image = GetComponent<Image>();


    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        //image.color = new Color32(255, 255, 255, 170);
        offset = transform.position - Input.mousePosition;
        //rectTransform.SetAsLastSibling();
        child.transform.SetAsLastSibling();
    }

    public void OnDrag(PointerEventData eventData)
    {
        // rectTransform.anchoredPosition += eventData.delta;
        transform.position = Input.mousePosition + offset;
        //rectTransform.SetAsLastSibling();
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //rectTransform.SetAsLastSibling();
        //
    }


    
}
