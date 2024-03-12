using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemDescription : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Inventory targetInventory;
    [Space]
    [SerializeField] private LayerMask inventoryLayerMask;
    [SerializeField] private float raycastDistance = 2;
    [Space]
    [SerializeField] private RectTransform itemsPanel;
    public void OnPointerEnter(PointerEventData eventData)
    {
        print("Pointer enter");

        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.down, raycastDistance);

        if (hit.collider.CompareTag("Item"))
        {
            print("Item was found");
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        print("Pointer exit");
    }
}
