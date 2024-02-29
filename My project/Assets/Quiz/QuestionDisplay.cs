using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class QuestionDisplay : MonoBehaviour
{
    public GameObject screenQuestion;
    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;
    public RawImage questionImage;
    public static Texture textureQuestion;
    public static string newQuestion;
    public static string newA;
    public static string newB;
    public static string newC;
    public static string newD;
    public static bool pleaseUpdate = false;

    void Update()
    {
        if (pleaseUpdate == false)
        {
            pleaseUpdate = true;
            StartCoroutine(PushTextOnScreen());
        }
    }

    IEnumerator PushTextOnScreen()
    {
        yield return new WaitForSeconds(0.25f);
        screenQuestion.GetComponent<TMPro.TextMeshProUGUI>().text = newQuestion;
        answerA.GetComponent<TMPro.TextMeshProUGUI>().text = newA;
        answerB.GetComponent<TMPro.TextMeshProUGUI>().text = newB;
        answerC.GetComponent<TMPro.TextMeshProUGUI>().text = newC;
        answerD.GetComponent<TMPro.TextMeshProUGUI>().text = newD;



        // Sprawdź, czy istnieje obraz do wyświetlenia
        if (textureQuestion != null && questionImage != null)
        {
            // Wyświetl obraz w RawImage
            questionImage.texture = textureQuestion;
        }
        // else
        // {
        //     // Jeśli obraz nie istnieje, ukryj RawImage
        //     questionImage.gameObject.SetActive(false);
        // }
    }
}