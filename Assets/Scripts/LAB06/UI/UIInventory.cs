using TMPro;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    public InvetoryData data;

    public TextMeshProUGUI goldText;
    public TextMeshProUGUI potionsText;
    public TextMeshProUGUI keysText;
    public TextMeshProUGUI Ammotext;

    private void OnEnable()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        goldText.text = "Gold: " + data.gold;
        potionsText.text = "Potions: " + data.potions;
        keysText.text = "Keys: " + data.keys;
        Ammotext.text = "Ammo: " + data.Ammo;

    }


}