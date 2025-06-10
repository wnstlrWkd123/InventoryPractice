using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot slotPrefab;  // 프리팹 연결
    [SerializeField] private Transform slotParent; // Content Transform 연결

    [SerializeField] private Button returnButton;

    private List<UISlot> slotList = new List<UISlot>();

    private void Start()
    {
        returnButton.onClick.AddListener(() => gameObject.SetActive(false));
        InitInventoryUI();
    }

    private void InitInventoryUI()
    {
        int itemCount = 20; // 예시: 슬롯 20개 생성

        for (int i = 0; i < itemCount; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotParent);
            newSlot.SetItem(null); // 아직 아이템 없음
            slotList.Add(newSlot);
        }
    }
}
