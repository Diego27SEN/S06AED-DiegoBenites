using TMPro;
using UnityEngine;

public class UIStats : MonoBehaviour
{
    public StatsData data;

    public TextMeshProUGUI hpText;
    public TextMeshProUGUI strText;
    public TextMeshProUGUI levelText;

    private void OnEnable()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        hpText.text = "HP: " + data.hp;
        strText.text = "STR: " + data.str;
        levelText.text = "Level: " + data.level;
    }

    public void UpdateAll()
    {
        data.hp += 10;
        data.str += 5;
        data.level += 1;

        UpdateUI();
    }
}