using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageDragHandler : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Transform originalParent;
    private Transform puzzleManager;
    private int pieceIndex;
    private Transform targetSlot;
    private bool isInCorrectSlot = false;

    public void Initialize(PuzzleManager manager, int index)
    {
        puzzleManager = manager.transform;
        pieceIndex = index;
        originalParent = transform.parent;
    }

    public void SetTargetSlot(Transform slot)
    {
        targetSlot = slot;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.SetParent(puzzleManager);
        isInCorrectSlot = false; // Resetuj flagę przy rozpoczęciu przeciągania
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        transform.SetParent(originalParent);

        if (IsInCorrectSlot())
        {
            transform.position = targetSlot.position; // Ustaw kawałek dokładnie w miejscu docelowym
            isInCorrectSlot = true; // Ustaw flagę na true, gdy puzzle jest w poprawnym miejscu docelowym
            puzzleManager.GetComponent<PuzzleManager>().SetPieceInSlot(pieceIndex, true);
        }
    }

    private bool IsInCorrectSlot()
    {
        if (targetSlot != null)
        {
            float distanceThreshold = 100f;
            float distance = Vector2.Distance(transform.position, targetSlot.position);

            return distance < distanceThreshold;
        }

        return false;
    }

    // Funkcja przyciągająca puzzle do miejsca docelowego
    void Update()
    {
        if (isInCorrectSlot)
        {
            // Liniowo przyciągaj puzzle do miejsca docelowego (możesz dostosować prędkość)
            transform.position = Vector3.Lerp(transform.position, targetSlot.position, Time.deltaTime * 100f);
        }
    }
}