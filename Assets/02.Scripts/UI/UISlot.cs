using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private Image equipMark;

    private ItemData item;

    public void SetItem(ItemData _item)
    {
        item = _item;
        RefreshUI();
    }

    public void RefreshUI()
    {
        itemImage.sprite = item.sprite;
        itemImage.gameObject.SetActive(true);
    }
}
