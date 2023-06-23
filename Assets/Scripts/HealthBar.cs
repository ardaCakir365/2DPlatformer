using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private int MaxValue;
    private int MinValue;
    public int HealthValue;
    public Slider GameHealthBar;

    void Start()
    {
        GameHealthBar = GetComponent<Slider>();
        GameHealthBar.maxValue = 100;
        GameHealthBar.minValue = 0;
        
    }
    


}
