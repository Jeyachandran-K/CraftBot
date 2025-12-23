using UnityEngine;

public class BasicCube : MonoBehaviour
{
    private void Start()
    {
        Player.Instance.OnHittingCubes += Player_OnHittingCubes;
    }

    private void Player_OnHittingCubes(object sender, System.EventArgs e)
    {
        Interact();
    }
    private void Interact()
    {
        Debug.Log("We hit a cube");
    }
}
