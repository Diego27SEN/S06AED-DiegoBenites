using TMPro;
using UnityEngine;

public class UIConfiguration : MonoBehaviour
{
    public ConfigData data;

    public TextMeshProUGUI fpsText;
    public TextMeshProUGUI vsyncText;
    public TextMeshProUGUI resolutionText;
    public TextMeshProUGUI volumeText;

    private void OnEnable()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        fpsText.text = "FPS: " + data.fpsLimit;
        vsyncText.text = "VSync: " + (data.vsync ? "ON" : "OFF");
        resolutionText.text = "Resolution: " + data.resolution;
        volumeText.text = "Volume: " + data.volume;
    }

}