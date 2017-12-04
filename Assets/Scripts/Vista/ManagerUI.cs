using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ManagerUI  : MonoBehaviour {

    public void LoadSelection()
    {

        SceneManager.LoadScene("CharSelection");

    }

     public void LoadMenu ()
    {

        SceneManager.LoadScene ("Menu");

    }

    public void LoadGame ()
    {

        SceneManager.LoadScene("Game");

    }

   
    

    public void AppQuit()
    {

        Application.Quit();

    }

}
