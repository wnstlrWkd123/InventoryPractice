using UnityEngine;

public class CharacterData : ScriptableObject
{
    public string Name { get; private set; } = "Chad";
    public byte Level { get; private set; } = 1;
    public float CurrentEXP { get; private set; } = 0f;
    public float RequiredEXP { get; private set; } = 10f;
    public float Money { get; private set; } = 1000f;
    public float OffensivePower { get; private set; } = 10f;
    public float AdditionalOffensivePower { get; set; } = 0f;
    public float DefensivePower { get; private set; } = 10f;
    public float AdditionalDefensivePower { get; set; } = 0f;
    public float HitPoint { get; private set; } = 100f;
    public float AdditionalHitPoint { get; set; } = 0f;
    public float Critical { get; private set; } = 5f;
    public float AdditionalCritical { get; set; } = 0f;
}
