using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public enum Items
    {
        RedCube,
        GreenCube
    }

    private int cubesCollected;

    private void Start()
    {
        Player.Instance.OnCubesHit += Player_OnCubesHit;
    }

    private void Player_OnCubesHit(object sender, System.EventArgs e)
    {
        AddCubes();
        Debug.Log("Number of cubes Collected :"+cubesCollected);
    }

    private void AddCubes()
    {
        cubesCollected++;
    }
}
