using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class InventoryWindow : MonoBehaviour
{
    [SerializeField] private Inventory targetInventory;
    [SerializeField] private RectTransform itemsPanel;
    [Header("{------Text settings-------}")]
    [SerializeField] private float fontSize = 10;
    private Vector3 _fontPosition = new Vector3(18, -65, 0);
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
            sign.AddComponent<TextMeshProUGUI>().text = item.Name;
            sign.GetComponent<TextMeshProUGUI>().fontSize = fontSize;
            sign.GetComponent<RectTransform>().anchoredPosition3D = _fontPosition;
        }
    }
    private void OnDisable()
    {
        Inventory.ItemAdded -= OnItemAdded;
    }
}
