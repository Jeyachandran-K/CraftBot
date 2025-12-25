using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    private Inventory inventory;
    [SerializeField]private ItemSlotContainer[] itemSlotContainerArray;

    private void Start()
    {
        inventory.OnItemAdded += Inventory_OnItemAdded;
    }

    private void Inventory_OnItemAdded()
    {
        
    }

    public void SetInventory(Inventory inventory)
    {
        this.inventory = inventory;
        
    }
    private void SetItemToContainer(Item item)
    {
        foreach (ItemSlotContainer itemSlotContainer in itemSlotContainerArray)
        {
            if (itemSlotContainer.GetIsEmpty())
            {
                itemSlotContainer.GetComponentInChildren<Image>().sprite=item.GetItemSprite(item);
            }
        }

    }

}
