using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    [SerializeField] private CubeSO[] cubeSOArray;
    private int cubesCollected;

    private void Start()
    {
        Player.Instance.OnCubeHit += Player_OnCubeHit;
    }

    private void Player_OnCubeHit(object sender, Player.OnCubeHitEventArgs e)
    {
        foreach (CubeSO cubeSO in cubeSOArray)
        {
            if(cubeSO == e.cubeSO)
            {
                AddCubes(cubeSO,e);
            }
        }
    }
    private void AddCubes(CubeSO cubeSO, Player.OnCubeHitEventArgs e)
    {
        cubeSO.Prefab.GetComponent<BasicCube>().IncreaseCubesCollected(e.cubeSO.Prefab.GetComponent<BasicCube>().GetAmount());
    }
}
