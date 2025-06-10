using System.Collections.Generic;

public class Character
{
    private CharacterData data;
    public CharacterData Data { get { return data; } }

    // 갖고있는 아이템들
    private List<ItemData> inventory;
    public List<ItemData> Inventory { get { return inventory; } }

    public Character(CharacterData _data, List<ItemData> _inventory)
    {
        data = _data;
        inventory = _inventory;
    }

    public void Equip(ItemData item)
    {

    }

    public void UnEquip(ItemData item)
    {

    }
}
