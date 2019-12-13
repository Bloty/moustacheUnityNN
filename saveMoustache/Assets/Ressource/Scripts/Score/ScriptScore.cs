using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptScore : MonoBehaviour
{
    public float time = 0;
    public Text scoreText;
    public int score;
    public ScriptMulipl scriptMultipl;
    public int multipl;




    // Update is called once per frame
    void Update()
    {
        multipl = scriptMultipl.multipl;
        
        time += Time.deltaTime * multipl;
        score = Mathf.RoundToInt(time);
        
        scoreText.text = ("Score : " + score);
    }
}
