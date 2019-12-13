using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    //var
    public GameObject MainMenu, MenuOptions;
    private bool booMainMenu = true, booMenuOptions = false;


    void Start()
    {
        MainMenu.SetActive(true);
        MenuOptions.SetActive(false);
    }

    //activer et desactiver menu principal
    public void EnableDisableMainMenu()
    {

        if(booMainMenu)
        {
            MainMenu.SetActive(false);
            booMainMenu = false;
        }
        else
        {
            MainMenu.SetActive(true);
            booMainMenu = true;
        }
    }

    //activer et desactiver menu d'options
    public void EnableDisableMenuOptions()
    {
        if(booMenuOptions)
        {
            MenuOptions.SetActive(false);
            booMenuOptions = false;
        }
        else
        {
            MenuOptions.SetActive(true);
            booMenuOptions = true;
        }
    }

    //Load level
    public void LoadLevel_01()
    {
        SceneManager.LoadScene("level");
    }

    //quitter le jeu
    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}

