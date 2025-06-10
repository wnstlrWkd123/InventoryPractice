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
        UIManager uiManager = UIManager.Instance;
        Character character = uiManager.character;

        if (equipping)
        {
            character.UnEquip(item);
        }
        else
        {
            character.Equip(item);
        }

        equipping = !equipping;
        equipMark.gameObject.SetActive(equipping);
        uiManager.Status.Set(character.Data);
    }
}
