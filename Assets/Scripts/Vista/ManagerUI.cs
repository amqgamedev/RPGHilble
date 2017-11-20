using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ManagerUI  : MonoBehaviour {

    public void LoadStart()
    {

        SceneManager.LoadScene("CharSelection");

    }

    public void AppQuit()
    {

        Application.Quit();

    }

}
