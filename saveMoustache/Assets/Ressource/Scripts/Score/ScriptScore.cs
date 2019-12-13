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

    void Update()
    {
        //recuperation du multiple
        multipl = scriptMultipl.multipl;
        

        //incrémentation du timer avec le multiplicateur
        time += Time.deltaTime * multipl;
        score = Mathf.RoundToInt(time);
        
        //affichage du texte
        scoreText.text = ("Score : " + score);
    }
}
