using UnityEngine;

[CreateAssetMenu(fileName = "New CharacterData", menuName = "Character/Data")]
public class CharacterData : ScriptableObject
{
    public string Name { get; private set; }
    public byte Level { get; private set; }
    public float CurrentEXP { get; private set; }
    public float RequiredEXP { get; private set; }
    public float OffensivePower { get; private set; }
    public float DefensivePower { get; private set; }
    public float HitPoint { get; private set; }
    public float Critical { get; private set; }
}
