using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class AnswerButtons : MonoBehaviour
{
    public GameObject answerAbackBlue; //Blue is waiting
    public GameObject answerAbackGreen; //Green is Correct
    public GameObject answerAbackRed; //Red is Wrong

    public GameObject answerBbackBlue; //Blue is waiting
    public GameObject answerBbackGreen; //Green is Correct
    public GameObject answerBbackRed; //Red is Wrong

    public GameObject answerCbackBlue; //Blue is waiting
    public GameObject answerCbackGreen; //Green is Correct
    public GameObject answerCbackRed; //Red is Wrong

    public GameObject answerDbackBlue; //Blue is waiting
    public GameObject answerDbackGreen; //Green is Correct
    public GameObject answerDbackRed; //Red is Wrong

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject answerD;

    public GameObject currentScore;
    public int scoreValue;
    public int bestScore;
    public GameObject bestDisplay;
    

    void Start()
    {
        bestScore= PlayerPrefs.GetInt("BestScoreQuiz");
        bestDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Rekord: " + bestScore;
    }
    

    void Update()
    {
        currentScore.GetComponent<TMPro.TextMeshProUGUI>().text = "Punkty: " + scoreValue;
    }


    public void ResetScore()
    {
        scoreValue = 0;
        currentScore.GetComponent<TMPro.TextMeshProUGUI>().text = "Punkty: " + scoreValue;
    }


    public void AnswerA()
    {
        if(QuestionGenerate.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            scoreValue +=5;
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            scoreValue =0;  
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

     public void AnswerB()
    {
        if(QuestionGenerate.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
            scoreValue +=5;
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
            scoreValue =0; 
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

     public void AnswerC()
    {
        if(QuestionGenerate.actualAnswer == "C")
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            scoreValue +=5;
        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            scoreValue =0; 
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

     public void AnswerD()
    {
        if(QuestionGenerate.actualAnswer == "D")
        {
            answerDbackGreen.SetActive(true);
            answerDbackBlue.SetActive(false);
            scoreValue +=5;
        }
        else
        {
            answerDbackRed.SetActive(true);
            answerDbackBlue.SetActive(false);
            scoreValue =0; 
        }
        answerA.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerC.GetComponent<Button>().enabled = false;
        answerD.GetComponent<Button>().enabled = false;
        StartCoroutine(NextQuestion());
    }

    IEnumerator NextQuestion()
    {
        if (bestScore < scoreValue)
        {
            PlayerPrefs.SetInt("BestScoreQuiz", scoreValue);
            bestScore = scoreValue;
            bestDisplay.GetComponent<TMPro.TextMeshProUGUI>().text = "Rekord: " + scoreValue;

        }
        yield return new WaitForSeconds(2);

        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerDbackGreen.SetActive(false);
        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerDbackRed.SetActive(false);
        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        answerDbackBlue.SetActive(true);

        answerA.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerC.GetComponent<Button>().enabled = true;
        answerD.GetComponent<Button>().enabled = true;
        QuestionGenerate.displayingQuestion = false;
   
   
    }
}