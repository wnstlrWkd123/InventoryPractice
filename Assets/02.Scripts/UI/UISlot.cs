using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private Image equipMark;

    [SerializeField] private Button button;

    private ItemData item;

    private bool equipping = false;

    private void Start()
    {
        button.onClick.AddListener(OnClickButton);
    }

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

    private void OnClickButton()
    {
        if (equipping)
        {
            UIManager.Instance.character.UnEquip(item);
        }
        else
        {
            UIManager.Instance.character.Equip(item);
        }

        equipping = !equipping;
        equipMark.gameObject.SetActive(equipping);
    }
}
