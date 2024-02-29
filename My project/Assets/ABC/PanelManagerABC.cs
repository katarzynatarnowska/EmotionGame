using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PanelManagerABC : MonoBehaviour
{
   public void MainMenu()
    {
        // Ładuje scenę gry
        SceneManager.LoadScene("MainMenu"); // Zastąp "GameScene" nazwą twojej sceny gry
    }

    public void NewGame()
    {
        // Wczytaj scenę od nowa
        SceneManager.LoadScene("ABC");
    }
}
