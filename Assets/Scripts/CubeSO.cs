using UnityEditor;
using UnityEngine;


[CreateAssetMenu()]
public class CubeSO : ScriptableObject
{
    public Transform Prefab;
    public string color;
    public Sprite iconSprite;
    public bool isStackable;
}
