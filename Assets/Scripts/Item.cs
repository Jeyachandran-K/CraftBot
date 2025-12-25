using UnityEngine;

public class Item 
{
    
    public enum ItemType
    {
        RedCube,
        GreenCube
    }

    public  ItemType itemType;
    public int amount;

    public Sprite GetItemSprite(Item item)
    {
        switch (item.itemType)
        {
            case ItemType.RedCube: return ItemAsset.Instance.GetRedCubeSprite();
            case ItemType.GreenCube: return ItemAsset.Instance.GetGreenCubeSprite();
        }
        return null;
    }
}
