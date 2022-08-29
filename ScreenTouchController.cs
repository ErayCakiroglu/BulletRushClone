using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ScreenTouchController : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    Vector2 touchPosition;
    bool pivotImageSetActive;
    [SerializeField] Image pivotImage;
    public Vector2 Direction {get; private set;}

    void Start()
    {
        pivotImage.enabled = false;
    }
    
    public void OnPointerDown(PointerEventData eventData)
    {
        touchPosition = eventData.position;
        pivotImageSetActive = true;
        if(pivotImageSetActive)
        {
            pivotImage.enabled = true;
            pivotImage.transform.position = touchPosition;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Direction = Vector2.zero;
        pivotImage.enabled = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        var delta = eventData.position - touchPosition;
        Direction = delta.normalized;
    }
}
