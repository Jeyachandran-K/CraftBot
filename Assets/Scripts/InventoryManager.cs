using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    [SerializeField] private CubeSO[] cubeSOArray;

    private void Start()
    {
        Player.Instance.OnCubeHit += Player_OnCubeHit;
    }

    private void Player_OnCubeHit(object sender, Player.OnCubeHitEventArgs e)
    {
        foreach (CubeSO c in cubeSOArray)
        {
            if(c == e.cubeSO)
            {
                AddCubes(c);
            }
        }
    }
    private void AddCubes(CubeSO c)
    {
        c.amount++;
    }
}
