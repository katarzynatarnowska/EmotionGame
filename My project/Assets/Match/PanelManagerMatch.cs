using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PanelManagerMatch : MonoBehaviour
{
   public void MainMenu()
    {
        // Ładuje scenę gry
        SceneManager.LoadScene("MainMenu"); // Zastąp "GameScene" nazwą twojej sceny gry
    }

    public void NewGame()
    {

        
 SceneManager.LoadScene("Match");
    }
}
