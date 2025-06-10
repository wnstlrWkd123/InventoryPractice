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

    // 슬롯에서 관리될 아이템들
    private List<UISlot> slotList = new List<UISlot>();

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
            if (i < inventoryItems.Count)
            {
                newSlot.SetItem(inventoryItems[i]);
            }
            slotList.Add(newSlot);
        }

        itemCountText.text = inventoryItems.Count.ToString();
        slotCountText.text = $"/ {slotCount}";
        returnButton.onClick.AddListener(() => gameObject.SetActive(false));
    }
}
