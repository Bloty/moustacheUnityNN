using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptScoreFin : MonoBehaviour
{

    public Text scoreText;
    public int score;
    public ScriptScore scriptScore;

    // Start is called before the first frame update
    void Start()
    {
        score = scriptScore.score;
        scoreText.text = ("Score : " + score);
    }
}
