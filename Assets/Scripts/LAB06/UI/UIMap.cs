using TMPro;
using UnityEngine;

public class UIMap : MonoBehaviour
{
    public MapData data;

    public TextMeshProUGUI zoneText;
    public TextMeshProUGUI discoveredText;
    public TextMeshProUGUI discoveredTreasures;
    private void OnEnable()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        zoneText.text = "Zone: " + data.currentZone;
        discoveredText.text = "Discovered: " + data.discoveredZones;
        discoveredTreasures.text = "Treasures: " + data.discoveredTreasures;

    }


}