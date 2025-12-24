using UnityEngine;

public class BasicCube : MonoBehaviour
{
    private string color;

    public void DestroySelf()
    {
        Destroy(gameObject);
    }
    public void SetColor(string color)
    {
        this.color = color;
    }
    public string GetColor()
    {
        return color;
    }
}
