using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private Transform slotParent;

    [SerializeField] private Text itemCountText;
    [SerializeField] private Text slotCountText;

    [SerializeField] private Button returnButton;

    private List<UISlot> slotList = new List<UISlot>();
    private List<ItemData> inventory;

    private void Start()
    {
        InitInventoryUI();
    }

    private void InitInventoryUI()
    {
        int slotCount = 30;

        for (int i = 0; i < slotCount; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotParent);
            if (i < inventory.Count)
            {
                newSlot.SetItem(inventory[i]);
            }
            slotList.Add(newSlot);
        }

        itemCountText.text = inventory.Count.ToString();
        slotCountText.text = $"/ {slotCount}";
        returnButton.onClick.AddListener(() => gameObject.SetActive(false));
    }

    public void Set(List<ItemData> _inventory)
    {
        inventory = _inventory;
    }
}
