using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [SerializeField] private Text nameText;
    [SerializeField] private Text levelText;
    [SerializeField] private Text expText;
    [SerializeField] private Text moneyText;

    [SerializeField] private Image expImage;

    [SerializeField] private Button statusButton;
    [SerializeField] private Button inventoryButton;

    private void Start()
    {
        UIManager uiManager = UIManager.Instance;
        statusButton.onClick.AddListener(() => uiManager.Status.gameObject.SetActive(true));
        inventoryButton.onClick.AddListener(() => uiManager.Inventory.gameObject.SetActive(true));
    }

    public void Set(CharacterData data)
    {

    }
}
