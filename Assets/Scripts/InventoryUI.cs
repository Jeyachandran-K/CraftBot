using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    [SerializeField] private ItemSlot[] itemSlotArray;


    private void Start()
    {
        Player.Instance.OnCubeHit += Player_OnCubeHit;
    }

    private void Player_OnCubeHit(object sender, Player.OnCubeHitEventArgs e)
    {
        if (e.cubeSO.isStackable)
        {
            if (!DoesItemExist(e))
            {
                UpdateItemSlotIcon(e);
            }
         
        }
        else
        {
            UpdateItemSlotIcon(e);
        }
        Debug.Log("inventory full");
    }
    private void UpdateItemSlotIcon(Player.OnCubeHitEventArgs e)
    {
        for (int i = 0; i < itemSlotArray.Length; i++)
        {

            if (itemSlotArray[i].GetIsEmpty())
            {
                itemSlotArray[i].GetComponentInChildren<Image>().sprite = e.cubeSO.iconSprite;
                itemSlotArray[i].SetIsEmpty(false);
                break;
            }
        }
    }
    private bool DoesItemExist(Player.OnCubeHitEventArgs e)
    {
        foreach (ItemSlot slot in itemSlotArray)
        {
            if (e.cubeSO.iconSprite == slot.GetComponentInChildren<Image>().sprite)
            {
                slot.GetAmountTextMesh().text = e.cubeSO.amount + "";
                return true;
            }
        }
        return false;
    }
}
