using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneMatch : MonoBehaviour
{
    public int NumberOfImage;
    public static int picInPlace;
    public GameObject EndGamePanel;

    void Update()
    {
        if (picInPlace == NumberOfImage)
        {
            Debug.Log("You Win!");
            StartCoroutine(ShowEndPanel());
        }
    }

    IEnumerator ShowEndPanel()
    {
        yield return new WaitForSeconds(1f); // Poczekaj na 1 sekundę (możesz dostosować czas)
        EndGamePanel.SetActive(true);
    }
}