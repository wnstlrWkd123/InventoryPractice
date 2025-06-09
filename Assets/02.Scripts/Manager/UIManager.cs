using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Character character;
    [SerializeField] private UIMainMenu mainMenu;
    [SerializeField] private UIStatus status;
    [SerializeField] private UIInventory inventory;

    public UIManager Instance { get { return this; } }
}
