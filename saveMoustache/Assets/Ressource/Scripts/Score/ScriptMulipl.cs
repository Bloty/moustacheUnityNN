using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptMulipl : MonoBehaviour
{
    public ScriptPerso scriptPerso;
    public int multipl = 0;
    public Text multiplText;


    void Update()
    {
        //affichage du multipl
        multiplText.text = ("X " + multipl);

        //affectation du multple avec le nombre de point de vie
        multipl = scriptPerso.life;
        
    }
}
