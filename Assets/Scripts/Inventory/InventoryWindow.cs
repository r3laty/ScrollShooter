using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] private Inventory targetInventory;
    [SerializeField] private RectTransform itemsPanel;
    [SerializeField] private GameObject canvas;
    [Header("{------Text settings-------}")]
    [SerializeField] private float fontSize = 10;
    private Vector3 _fontPosition = new Vector3(18, -65, 0);

    private EventTrigger.Entry _eventType;
    
    private void Start()
    {
        Inventory.ItemAdded += OnItemAdded;
        Redraw();
    }
    private void OnItemAdded(Item item) => Redraw();
    private void Redraw()
    {
        for (int i = 0; i < targetInventory.InventoryItems.Count; i++)
        {
            var item  = targetInventory.InventoryItems[i];

            var icon = new GameObject("Icon");
            icon.transform.SetParent(itemsPanel);
            
            icon.AddComponent<Image>().sprite = item.Icon;
            icon.gameObject.layer = 6;
            icon.tag = "Item";
            icon.AddComponent<BoxCollider2D>();

            var sign = new GameObject("Sign");
            sign.transform.SetParent(icon.transform);
            sign.AddComponent<EventTrigger>();

            _eventType = new EventTrigger.Entry();
            _eventType.eventID = EventTriggerType.PointerEnter;
            _eventType.callback.AddListener((eventData) => { ConvertDescription(item); });

            sign.GetComponent<EventTrigger>().triggers.Add(_eventType);
        }
    }
    public void ConvertDescription(Item currentItem)
    {
        var text = new GameObject("Text");
        text.transform.SetParent(canvas.transform);
        text.AddComponent<TextMeshProUGUI>().text = currentItem.Name;
        text.GetComponent<TextMeshProUGUI>().fontSize = fontSize;
    }
    private void OnDisable()
    {
        Inventory.ItemAdded -= OnItemAdded;
    }
}
