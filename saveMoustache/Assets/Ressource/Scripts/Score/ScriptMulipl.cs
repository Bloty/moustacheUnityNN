using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptMulipl : MonoBehaviour
{
    public ScriptPerso scriptPerso;
    public int multipl = 0;
    public Text multiplText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        multiplText.text = ("X " + multipl);
        multipl = scriptPerso.life;
        
    }
}
