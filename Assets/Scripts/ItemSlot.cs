using TMPro;
using UnityEngine;

public class ItemSlot : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI amountTextMesh;

    private bool isEmpty = true;
    public void SetIsEmpty(bool isEmpty)
    {
        this.isEmpty = isEmpty;
    }

    public bool GetIsEmpty()
    {
        return isEmpty;
    }

    public TextMeshProUGUI GetAmountTextMesh()
    {
        return amountTextMesh;
    }
 
    
}
