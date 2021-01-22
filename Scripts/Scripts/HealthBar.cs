using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public static int healthValue = 3;
    Text Healthtext;

    void Start()
    {
        Healthtext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Healthtext.text = "Health: " + healthValue;
    }
}
