using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuestionGenerate : MonoBehaviour
{
    public static string actualAnswer;
    public static bool displayingQuestion = false;
    public int questionNumber;
    public Texture texture1;
    public Texture texture2;
    public Texture texture3;
    public Texture texture4;
    public Texture texture5;
    public RawImage imageDisplay;

    // Lista, która śledzi zadane pytania
    private List<int> usedQuestionNumbers = new List<int>();

    // Zmienna, która śledzi stan gry
    private bool gameOver = false;

    public GameObject endGamePanel;

    void Start()
    {
        // Przypisz początkowy obraz do RawImage
        imageDisplay.texture = texture1;

        endGamePanel.SetActive(false);
    }

    void Update()
    {
        if (!gameOver && displayingQuestion == false)
        {
            displayingQuestion = true;

            // Wybierz unikalne pytanie
            questionNumber = GetUniqueQuestionNumber();

            if (questionNumber != -1)
            {
                // Oznacz pytanie jako użyte
                usedQuestionNumbers.Add(questionNumber);

                // Przypisz treści pytania i odpowiedzi
                AssignQuestionAndAnswers(questionNumber);

                imageDisplay.texture = QuestionDisplay.textureQuestion;
            }
            else
            {
                // Jeśli skończyły się pytania, to koniec gry
                EndGame();
            }

            // Resetuj flagę aktualizacji w klasie QuestionDisplay
            QuestionDisplay.pleaseUpdate = false;
        }
    }

    int GetUniqueQuestionNumber()
    {
        // Lista dostępnych numerów pytań
        List<int> availableQuestionNumbers = new List<int> { 1, 2, 3, 4, 5 };

        // Usuń już użyte numery pytań
        availableQuestionNumbers.RemoveAll(usedQuestionNumbers.Contains);

        if (availableQuestionNumbers.Count > 0)
        {
            // Wybierz losowy numer pytania spośród dostępnych
            int randomIndex = Random.Range(0, availableQuestionNumbers.Count);
            return availableQuestionNumbers[randomIndex];
        }
        else
        {
            // Jeśli skończyły się dostępne pytania, zwróć -1
            return -1;
        }
    }

    void AssignQuestionAndAnswers(int questionNumber)
    {
        // Przypisz treści pytania i odpowiedzi w zależności od numeru pytania
        switch (questionNumber)
        {
            case 1:
                QuestionDisplay.newQuestion = "Jaką emocję przedstawia postać?";
                QuestionDisplay.textureQuestion = texture1;
                QuestionDisplay.newA = "A. Radość";
                QuestionDisplay.newB = "B. Strach";
                QuestionDisplay.newC = "C. Smutek";
                QuestionDisplay.newD = "D. Zaskoczenie";
                actualAnswer = "A";
                break;
            case 2:
                QuestionDisplay.newQuestion = "Jakie emocje przedstawia postać?";
                QuestionDisplay.textureQuestion = texture2;
                QuestionDisplay.newA = "A. Zaskoczenie";
                QuestionDisplay.newB = "B. Złość";
                QuestionDisplay.newC = "C. Smutek";
                QuestionDisplay.newD = "D. Zadowolenie";
                actualAnswer = "C";
                break;
            case 3:
                QuestionDisplay.newQuestion = "Jakie uczucia wyraża postać?";
                QuestionDisplay.textureQuestion = texture3;
                QuestionDisplay.newA = "A. Radość";
                QuestionDisplay.newB = "B. Złość";
                QuestionDisplay.newC = "C. Smutek";
                QuestionDisplay.newD = "D. Strach";
                actualAnswer = "B";
                break;
            case 4:
                QuestionDisplay.newQuestion = "Która emocja jest obecna u postaci?";
                QuestionDisplay.textureQuestion = texture4;
                QuestionDisplay.newA = "A. Ekscytacja";
                QuestionDisplay.newB = "B. Złość";
                QuestionDisplay.newC = "C. Radość";
                QuestionDisplay.newD = "D. Strach";
                actualAnswer = "D";
                break;
            case 5:
                QuestionDisplay.newQuestion = "Jaką emocję wyraża postać?";
                QuestionDisplay.textureQuestion = texture5;
                QuestionDisplay.newA = "A. Radość";
                QuestionDisplay.newB = "B. Złość";
                QuestionDisplay.newC = "C. Zaskoczenie";
                QuestionDisplay.newD = "D. Smutek";
                actualAnswer = "C";
                break;
        }
    }

    void EndGame()
    {
        // Ustaw stan gry na zakończony, aby nie naliczać dodatkowych punktów
        gameOver = true;

        if (endGamePanel != null)
        {
            // Aktywuj panel końca gry
            endGamePanel.SetActive(true);

            // // Dodaj obsługę przycisku "Nowa Gra"
            // Button newGameButton = endGamePanel.GetComponentInChildren<Button>();
            // if (newGameButton != null)
            // {
            //     newGameButton.onClick.AddListener(NewGame);
            // }
            // else
            // {
            //     Debug.LogError("New Game Button not found!");
            // }

            // Dodaj obsługę przycisku "Menu"
            Button menuButton = endGamePanel.transform.Find("MenuButton").GetComponent<Button>();
            if (menuButton != null)
            {
                menuButton.onClick.AddListener(ReturnToMainMenu);
            }
            else
            {
                Debug.LogError("Menu Button not found!");
            }
        }
        else
        {
            Debug.LogError("endGamePanel is null!");
        }
    }

    // Funkcja obsługująca przycisk "Nowa Gra"
    // void NewGame()
    // {
    //     // Resetuj ustawienia gry
    //     gameOver = false;
    //     usedQuestionNumbers.Clear();

    //     // Wywołaj metodę resetującą punkty z klasy AnswerButtons
    // FindObjectOfType<AnswerButtons>().ResetScore();


    //     // Wyłącz panel końca gry
    //     endGamePanel.SetActive(false);

    //     // SceneManager.LoadScene("MainMenu");

    //     // Rozpocznij nową grę (możesz dodać tutaj dodatkowe czynności)
    // }

    // // Funkcja obsługująca przycisk "Menu"
    void ReturnToMainMenu()
    {
        // Powróć do sceny MainMenu
        SceneManager.LoadScene("MainMenu");
    }
}