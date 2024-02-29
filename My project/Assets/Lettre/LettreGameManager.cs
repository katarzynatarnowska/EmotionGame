using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LettreGameManager : MonoBehaviour ,IDragHandler,IEndDragHandler
{
    private Vector2 initialPosition;
    private bool isLettreInPlace = false;
    public GameObject correctPosition;
    
    
    void Start()
    {
        initialPosition = transform.position;   
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (!isLettreInPlace)
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
            isLettreInPlace = true;  
            EndSceneLettre.picInPlace++;
        }
        else
        {
            transform.position = initialPosition;
        }
    }

    
}
