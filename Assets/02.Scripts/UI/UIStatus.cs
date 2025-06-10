using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [SerializeField] private Text offensiveValueText;
    [SerializeField] private Text defensiveValueText;
    [SerializeField] private Text hitPointValueText;
    [SerializeField] private Text criticalValueText;

    [SerializeField] private Button returnButton;

    private void Start()
    {
        returnButton.onClick.AddListener(() => gameObject.SetActive(false));
    }

    public void Set(CharacterData data)
    {
        offensiveValueText.text = $"{data.OffensivePower + data.AdditionalOffensivePower} ({data.OffensivePower} + {data.AdditionalOffensivePower})";
        defensiveValueText.text = $"{data.DefensivePower + data.AdditionalDefensivePower} ({data.DefensivePower} + {data.AdditionalDefensivePower})";
        hitPointValueText.text = $"{data.HitPoint + data.AdditionalHitPoint} ({data.HitPoint} + {data.AdditionalHitPoint})";
        criticalValueText.text = $"{data.Critical + data.AdditionalCritical}% ({data.Critical} + {data.AdditionalCritical})%";
    }
}
