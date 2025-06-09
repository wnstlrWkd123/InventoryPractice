public class Character
{
    private CharacterData data;
    public CharacterData Data { get { return data; } }

    public Character(CharacterData _data)
    {
        data = _data;
    }
}
