using UnityEngine;

[CreateAssetMenu(fileName = "ConfigData", menuName = "Scriptable Objects/ConfigData")]
public class ConfigData : ScriptableObject
{
    public int fpsLimit;
    public bool vsync;
    public string resolution;
    public int volume;
}
