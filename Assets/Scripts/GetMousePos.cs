using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GetMousePos : MonoBehaviour
{
    public static bool OverUI;

    private int UILayer;

    private void Start()
    {
        UILayer = LayerMask.NameToLayer("UI");
    }

    private void Update()
    {
        if (IsPointerOverUIElement(GetEventSystemRaycastResults()))
        {
            OverUI = true;
            print("Over UI");
        }
        else
        {
            OverUI = false;
            print("Not over UI");
        }
    }

    private bool IsPointerOverUIElement(List<RaycastResult> eventSystemRaysastResults)
    {
        for (int index = 0; index < eventSystemRaysastResults.Count; index++)
        {
            RaycastResult curRaysastResult = eventSystemRaysastResults[index];
            if (curRaysastResult.gameObject.layer == UILayer)
                return true;
        }
        return false;
    }

    private List<RaycastResult> GetEventSystemRaycastResults()
    {
        PointerEventData eventData = new PointerEventData(EventSystem.current);
        eventData.position = Input.mousePosition;
        List<RaycastResult> raysastResults = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventData, raysastResults);
        return raysastResults;
    }
}