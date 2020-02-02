using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayHealth : MonoBehaviour
{
    // Start is called before the first frame update
    private Color color;

    public Color green;
    public Color yellow;
    public Color red;
    public float health;

    void Start()
    {
        color = gameObject.GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        gradientUpdate();
    }

    public void gradientUpdate() {
        Color color1;
        Color color2;
        if (health > 50)
        {
            color1 = green;
            color2 = yellow;
        }
        else {
            color1 = yellow;
            color2 = red;
        }

        color.r = color1.r + (color1.r - color2.r) * (health % 50) / 50.0f;
        color.g = color1.g + (color1.g - color2.g) * (health % 50) / 50.0f;
        color.b = color1.b + (color1.b - color2.b) * (health % 50) / 50.0f;

        gameObject.GetComponent<SpriteRenderer>().color = color;
    }
}
