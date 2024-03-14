using UnityEngine;
[CreateAssetMenu(fileName = "ItemData", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public string Name;
    public Sprite Icon;
}
