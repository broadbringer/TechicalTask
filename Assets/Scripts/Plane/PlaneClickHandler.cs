using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlaneClickHandler : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private EventManager _eventManager;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        var clickedPosition = eventData.pointerPressRaycast.worldPosition;
        _eventManager.NotifyAboutPressedPlane(clickedPosition);
  
    }
    
}
