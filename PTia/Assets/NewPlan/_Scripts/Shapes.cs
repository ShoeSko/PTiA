using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shapes : MonoBehaviour
{
    public string name { get; private set; }
    public Color colour { get; private set; }

    public Text textDisplay;

    private void Start()
    {
        name = gameObject.name;
        colour = gameObject.GetComponent<Image>().color;
    }

    public virtual void DisplayText()
    {
        textDisplay.text = "You Pressed " + colour.ToString() + name;
        textDisplay.color = colour;
    }
}
