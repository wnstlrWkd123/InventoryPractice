using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Character character;
    public Character Character { get { return character; } }

    [SerializeField] private List<ItemData> inventory;

    private void Start()
    {
        SetData();
    }

    private void SetData()
    {
        character = new Character(ScriptableObject.CreateInstance<CharacterData>(), inventory);

        UIManager uiManager = UIManager.Instance;
        CharacterData data = character.Data;

        uiManager.character = character;

        uiManager.MainMenu.Set(data);
        uiManager.Status.Set(data);
        uiManager.Inventory.Set(inventory);
    }
}
