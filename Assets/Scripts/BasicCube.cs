using UnityEngine;

public class BasicCube : MonoBehaviour
{
    [SerializeField] private CubeSO cubeSO;

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    public CubeSO GetCubeSO()
    {
        return cubeSO;
    }
}
