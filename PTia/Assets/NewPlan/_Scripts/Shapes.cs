using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shapes : MonoBehaviour
{
    public string name { get; private set; }
    public Color colour { get; private set; }

    public Text textDisplay;
    public virtual void DisplayText()
    {

    }
}
