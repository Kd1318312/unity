using UnityEngine;

public class ColorGetter : MonoBehaviour
{
    public Renderer rend;
    public Color[] colors = { Color.red, Color.blue, Color.green, Color.yellow };
    public int currentColorIndex = 0;
    public Color rendcolor;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rendcolor = rend.material.color;
    }

    void OnMouseDown()
    {
    }
}