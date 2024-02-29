using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class MatchGameManager : MonoBehaviour , IDragHandler, IEndDragHandler
{
    private Vector2 initialPosition;
    private bool isDescriptionInPlace = false;
    public GameObject correctPosition;
    
    
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;   

    }

    public void OnDrag(PointerEventData eventData)
    {
        // Dodaj warunek, aby nie przeciągać, jeśli puzzel jest już na swoim miejscu
        if (!isDescriptionInPlace)
        {
            transform.position = Input.mousePosition;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        float distance = Vector3.Distance(transform.position, correctPosition.transform.position);
        if (distance < 60)
        {
            transform.localScale = correctPosition.transform.localScale;
            transform.position = correctPosition.transform.position;
            isDescriptionInPlace = true;  // Ustaw flagę, że puzzel jest na swoim miejscu
            EndSceneMatch.picInPlace++;
        }
        else
        {
            transform.position = initialPosition;
        }
    }
}
