using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    private Vector3 lastMousePosition;

    void Update()
    {
        // Pobierz pozycję myszy
        Vector3 mousePosition = Input.mousePosition;

        // Przelicz pozycję myszy na przestrzeń świata gry
        Vector3 newPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        newPosition.z = 0f; // Zabezpieczenie przed ewentualnym przesunięciem w przestrzeń 3D

        // Sprawdź, czy nowa pozycja mieści się w obszarze ekranu
        bool isWithinScreenBounds = IsPositionWithinScreenBounds(newPosition);

        // Wypisz wynik do konsoli
        Debug.Log($"IsPositionWithinScreenBounds: {isWithinScreenBounds}");
        
        if (isWithinScreenBounds)
        {
            // Przesuń puzzle do nowej pozycji
            transform.position = newPosition;

            // Zapisz aktualną pozycję myszy na potrzeby porównań w następnej klatce
            lastMousePosition = mousePosition;
        }
    }

    bool IsPositionWithinScreenBounds(Vector3 position)
    {
        // Pobierz szerokość i wysokość ekranu w jednostkach pikseli
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        // Przelicz minimalne i maksymalne pozycje na ekranie na przestrzeń świata gry
        Vector3 minScreenPoint = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        Vector3 maxScreenPoint = Camera.main.ScreenToWorldPoint(new Vector3(screenWidth, screenHeight, 0));

        // Ustaw granice ekranu
        float minX = minScreenPoint.x;
        float minY = minScreenPoint.y;
        float maxX = maxScreenPoint.x;
        float maxY = maxScreenPoint.y;

        // Sprawdź, czy nowa pozycja mieści się w granicach ekranu
        return position.x >= minX && position.x <= maxX && position.y >= minY && position.y <= maxY;
    }
}