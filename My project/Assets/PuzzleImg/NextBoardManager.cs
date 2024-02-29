using UnityEngine;
using UnityEngine.UI;

public class NextBoardManager : MonoBehaviour
{
    public GameObject[] puzzleBoards;
    private int currentBoardIndex = 0;
    

    void Start()
    {
        // Upewnij się, że plansze są ustawione jako nieaktywne (chcesz pokazać tylko jedną na raz)
        SetActiveBoard(currentBoardIndex);
    }

    void SetActiveBoard(int index)
    {
        // Dezaktywuj wszystkie plansze
        foreach (var puzzleBoard in puzzleBoards)
        {
            puzzleBoard.SetActive(false);
        }

        // Sprawdź, czy index jest w zakresie
        if (index >= 0 && index < puzzleBoards.Length)
        {
            puzzleBoards[index].SetActive(true);
        }
    }

    public void OnNextButtonClick()
    {
        currentBoardIndex++;

        // Sprawdź, czy nie przekroczyliśmy liczby plansz
        if (currentBoardIndex < puzzleBoards.Length)
        {
            SetActiveBoard(currentBoardIndex);
        }
        else
        {
            Debug.Log("To już ostatnia plansza puzzli.");
            currentBoardIndex = puzzleBoards.Length - 1;
        }
    }

    public void OnBackButtonClick()
    {
        currentBoardIndex--;

        // Sprawdź, czy nie wyszliśmy poza pierwszą planszę
        if (currentBoardIndex >= 0)
        {
            SetActiveBoard(currentBoardIndex);
        }
        else
        {
            Debug.Log("To już pierwsza plansza puzzli.");
            currentBoardIndex = 0;
        }
    }

    public void OnResetButtonClick()
    {
        currentBoardIndex = 0;
        SetActiveBoard(currentBoardIndex);
    }
}