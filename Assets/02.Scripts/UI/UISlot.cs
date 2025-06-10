using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Progress;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private Image equipMark;

    private Item item;  // 예: 아이템 데이터

    public void SetItem(Item newItem)
    {
        item = newItem;
        //RefreshUI();
    }

    //public void RefreshUI()
    //{
    //    if (item != null)
    //    {
    //        iconImage.sprite = item.icon;
    //        countText.text = item.count.ToString();
    //    }
    //    else
    //    {
    //        iconImage.sprite = null;
    //        countText.text = "";
    //    }
    //}
}
