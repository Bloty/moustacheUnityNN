using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ProgressBar : MonoBehaviour
{
    public ScriptBoom scriptBoom;
    public GameObject collisionBoom;
    public int minimum;
    public int maximum;
    public int current;
    public Image mask;
    public Image fill;
    public Color color;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        getCurrentFill();
    }

    void getCurrentFill()
    {

        current = (int)scriptBoom.time;
        maximum = (int)scriptBoom.boomDelay;

        float minimumOffset = current - minimum;
        float maximumOffset = maximum - minimum;
        float fillAmount = (float)current / (float)maximum;
        mask.fillAmount = fillAmount;

        fill.color = color;
    }
}
