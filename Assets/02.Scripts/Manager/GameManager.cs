using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Character character;
    public Character Character { get { return character; } }

    private void Start()
    {
        SetData();
    }

    private void SetData()
    {
        character = new Character(ScriptableObject.CreateInstance<CharacterData>());

        UIManager uiManager = UIManager.Instance;
        CharacterData data = character.Data;

        uiManager.MainMenu.Set(data);
        uiManager.Status.Set(data);
    }
}
