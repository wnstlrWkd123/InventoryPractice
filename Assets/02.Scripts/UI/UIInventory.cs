using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [SerializeField] private UISlot slotPrefab;  // ������ ����
    [SerializeField] private Transform slotParent; // Content Transform ����

    [SerializeField] private Button returnButton;

    private List<UISlot> slotList = new List<UISlot>();

    private void Start()
    {
        returnButton.onClick.AddListener(() => gameObject.SetActive(false));
        InitInventoryUI();
    }

    private void InitInventoryUI()
    {
        int itemCount = 20; // ����: ���� 20�� ����

        for (int i = 0; i < itemCount; i++)
        {
            UISlot newSlot = Instantiate(slotPrefab, slotParent);
            newSlot.SetItem(null); // ���� ������ ����
            slotList.Add(newSlot);
        }
    }
}
