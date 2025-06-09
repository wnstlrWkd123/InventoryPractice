using Unity.VisualScripting;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private UIMainMenu mainMenu;
    public UIMainMenu MainMenu { get { return mainMenu; } }

    [SerializeField] private UIStatus status;
    public UIStatus Status { get { return status; } }

    [SerializeField] private UIInventory inventory;
    public UIInventory Inventory { get { return inventory; } }

    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
}
