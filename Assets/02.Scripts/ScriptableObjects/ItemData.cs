using UnityEngine;

public enum EquipmentType
{
    Weapon,
    Armor
}

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class ItemData : ScriptableObject
{
    public Sprite sprite;
    public string itemName;
    public EquipmentType equipmentType;
    public float pirce;
    public float offensivePower;
    public float defensivePower;            
    public float hitPoint;
    public float critical;
}
