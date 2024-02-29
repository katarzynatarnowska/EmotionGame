// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ChangeLevel : MonoBehaviour
// {
//    public GameObject[] levels; // Przypisz obiekty plansz w kolejności
//     private int currentLevelIndex = 0;

//     void Start()
//     {
//         // Ustaw pierwszą planszę na starcie gry
//         SetActiveLevel(currentLevelIndex);
//     }

//     void SetActiveLevel(int levelIndex)
//     {
//         // Dezaktywuj wszystkie plansze
//         foreach (var level in levels)
//         {
//             level.SetActive(false);
//         }

//         // Sprawdź, czy index jest w zakresie
//         if (levelIndex >= 0 && levelIndex < levels.Length)
//         {
//             levels[levelIndex].SetActive(true);
//         }
//     }

//     // Metoda wywoływana po naciśnięciu przycisku "Next"
//     public void GoToNextLevel()
//     {
//         currentLevelIndex++;

//         // Sprawdź, czy nie przekroczyliśmy liczby plansz
//         if (currentLevelIndex < levels.Length)
//         {
//             SetActiveLevel(currentLevelIndex);
//         }
//         else
//         {
//             Debug.Log("To już ostatnia plansza.");
//             currentLevelIndex = levels.Length - 1;
//         }
//     }
// }