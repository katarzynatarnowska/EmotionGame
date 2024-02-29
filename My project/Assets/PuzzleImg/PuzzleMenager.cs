using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public float sensitivity = 1.0f;  // Współczynnik czułości myszy

    void Update()
    {
        // Pobierz pozycję myszy
        Vector3 mousePosition = Input.mousePosition;

        // Zastosuj czułość myszy
        mousePosition *= sensitivity;

        // Zrób coś z pozycją myszy (np. przesuń postać)
        MoveCharacter(mousePosition);
    }

    void MoveCharacter(Vector3 targetPosition)
    {
        // Implementuj logikę poruszania postaci na podstawie pozycji myszy
        // ...
    }
    public Image[] puzzlePieces;
    public Transform[] puzzleSlots;

    private bool[] pieceInSlot;

    void Start()
    {
        InitializePuzzle();
    }

    void InitializePuzzle()
    {
        pieceInSlot = new bool[puzzlePieces.Length];

        if (puzzlePieces.Length == puzzleSlots.Length)
        {
            for (int i = 0; i < puzzlePieces.Length; i++)
            {
                AddDragHandler(puzzlePieces[i], i);
            }
        }
        else
        {
            Debug.LogError("Nieprawidłowe skonfigurowane puzzlePieces i puzzleSlots. Muszą mieć taką samą długość.");
        }
    }

    void AddDragHandler(Image puzzlePiece, int index)
    {
        var dragHandler = puzzlePiece.gameObject.AddComponent<ImageDragHandler>();
        dragHandler.Initialize(this, index);
        dragHandler.SetTargetSlot(puzzleSlots[index]);
    }

    public void CheckPuzzle()
    {
        for (int i = 0; i < puzzleSlots.Length; i++)
        {
            if (!pieceInSlot[i])
                return; // Jeśli jakiś kawałek nie jest jeszcze na miejscu, nie sprawdzaj dalej
        }

        Debug.Log("Puzzle ułożone poprawnie!");
        // Tutaj możesz dodać kod reakcji na ułożenie puzzle'u
    }

    public void SetPieceInSlot(int index, bool inSlot)
    {
        pieceInSlot[index] = inSlot;
        CheckPuzzle();
    }
}