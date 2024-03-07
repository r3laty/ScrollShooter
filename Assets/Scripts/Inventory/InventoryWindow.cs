using UnityEngine;
using UnityEngine.UI;

public class InventoryWindow : MonoBehaviour
{
    [SerializeField] private Inventory targetInventory;
    [SerializeField] private RectTransform itemsPanel;
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
        }
    }
    private void OnDisable()
    {
        Inventory.ItemAdded -= OnItemAdded;
    }
}
