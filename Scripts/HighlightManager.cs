using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HighlightManager : MonoBehaviour
{
    public Tilemap mapGrid;      // Assign the MapGrid's tilemap in Inspector
    public Tilemap highlightGrid; // Assign the HighlightGrid's tilemap in Inspector
    public TileBase highlightTile; // Assign a highlight tile in Inspector

    private Vector3Int lastCell = new Vector3Int(int.MinValue, int.MinValue, int.MinValue);

    void Update()
    {
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int cell = mapGrid.WorldToCell(worldPos);

        // Clear old highlight
        if (lastCell != new Vector3Int(int.MinValue, int.MinValue, int.MinValue) && lastCell != cell)
        {
            highlightGrid.SetTile(lastCell, null);
        }

        // Set new highlight
        if (cell != lastCell)
        {
            highlightGrid.SetTile(cell, highlightTile);
            lastCell = cell;
        }
    }
}
