using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]private int typesOfCubes = 2;
    public enum Items
    {
        RedCube,
        GreenCube
    }

    [SerializeField]private BasicCube[] cubeList;

    private int redCubesCollected;
    private int greenCubesCollected;

    private void Awake()
    {
        cubeList = new BasicCube[typesOfCubes];
    }

    private void Start()
    {
        Player.Instance.OnRedCubesHit += Player_OnRedCubesHit;
        Player.Instance.OnGreenCubesHit += Player_OnGreenCubesHit;
    }

    private void Player_OnGreenCubesHit(object sender, System.EventArgs e)
    {
        AddGreenCubes();
        Debug.Log("Numebr of Green cubes Collected : " + greenCubesCollected);
    }

    private void Player_OnRedCubesHit(object sender, System.EventArgs e)
    {
        AddRedCubes();
        Debug.Log("Number of  Red cubes Collected :"+redCubesCollected);
    }

    private void AddRedCubes()
    {
        redCubesCollected++;
    }
    private void AddGreenCubes()
    {
        greenCubesCollected++;
    }
}
