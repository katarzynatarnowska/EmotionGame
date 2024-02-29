using System.Collections;
// using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneABC : MonoBehaviour
{

    public int NumberOfImage;
    public static int picInPlace;
    public GameObject questionToHide, questionToShow;
   
    void Update()
    {
        if (picInPlace == NumberOfImage)
        {
            Debug.Log("You Win!");
            StartCoroutine(LoadNextPanel());
        }
    }

    IEnumerator LoadNextPanel()
    {
        yield return new WaitForSeconds(1f);
        questionToHide.SetActive(false);
        questionToShow.SetActive(true);
    }


}