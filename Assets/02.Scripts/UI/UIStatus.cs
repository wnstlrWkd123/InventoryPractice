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
        offensiveValueText.text = data.OffensivePower.ToString();
        defensiveValueText.text = data.DefensivePower.ToString();
        hitPointValueText.text = data.HitPoint.ToString();
        criticalValueText.text = $"{data.Critical}%";
    }
}
