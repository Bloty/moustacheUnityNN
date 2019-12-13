using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptePerdu : MonoBehaviour
{
    public ScriptPerso scriptPerso;
    public GameObject menuFin;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(scriptPerso.life <= 0)
        {
            Time.timeScale = 0;
            menuFin.SetActive(true);
        }
    }

    public void LoadMenuPrincipal()
    {
        SceneManager.LoadScene("menu_principal");
    }
}
