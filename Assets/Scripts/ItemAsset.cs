using UnityEngine;

public class ItemAsset : MonoBehaviour
{
    public static ItemAsset Instance
    {
        get; private set;
    }

    [SerializeField] private Sprite redCubeSprite;
    [SerializeField] private Sprite greenCubeSprite;

    private void Awake()
    {
        Instance = this;
    }
    public Sprite GetRedCubeSprite()
    {
        return redCubeSprite;
    }
    public Sprite GetGreenCubeSprite()
    {
        return greenCubeSprite;
    }
}
