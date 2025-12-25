using UnityEngine;

public class BasicCube : MonoBehaviour,IItem
{
    [SerializeField] private CubeSO cubeSO;
    private int amount = 1;
    private int cubesCollected;

    private void Awake()
    {
        cubesCollected = 0;
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
    }

    public CubeSO GetCubeSO()
    {
        return cubeSO;
    }
    public int GetAmount()
    {
        return amount;
    }
    public int GetCubesCollected()
    {
        return cubesCollected;
    }
    public void IncreaseCubesCollected(int numberOfCubes)
    {
        cubesCollected += numberOfCubes;
    }
}
