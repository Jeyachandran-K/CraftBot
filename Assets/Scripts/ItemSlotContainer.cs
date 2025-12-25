using UnityEngine;

public class ItemSlotContainer : MonoBehaviour
{
    [SerializeField] private int slotNumber;

    private bool isEmpty;

    public int GetSlotNumber()
    {
        return slotNumber;
    }
    public bool GetIsEmpty()
    {
        return isEmpty;
    }
}
