using UnityEngine;

[CreateAssetMenu(fileName = "MapData", menuName = "Scriptable Objects/MapData")]
public class MapData : ScriptableObject
{
    public string currentZone;
    public int discoveredZones;
    public int discoveredTreasures;
}