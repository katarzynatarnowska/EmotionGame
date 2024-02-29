using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

   public void StartGame()
    {
        // Ładuje scenę gry
        SceneManager.LoadScene("QuizScene"); // Zastąp "GameScene" nazwą twojej sceny gry
    }

    public void PuzzleGame()
    {
        // Ładuje scenę gry
        SceneManager.LoadScene("Puzzle2"); // Zastąp "GameScene" nazwą twojej sceny gry
    }

    public void ABCGame()
    {
        // Ładuje scenę gry
        SceneManager.LoadScene("Lettre"); // Zastąp "GameScene" nazwą twojej sceny gry
    }

    public void MatchGame()
    {
        // Ładuje scenę gry
        SceneManager.LoadScene("Match"); // Zastąp "GameScene" nazwą twojej sceny gry
    }

    public void QuitGame()
    {
        // Zamknij grę (działa tylko w kompilacji docelowej, nie w edytorze Unity)
        Application.Quit();
        Debug.Log("Game Closed");
    }
}
