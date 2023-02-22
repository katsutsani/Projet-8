using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class GameBoard : MonoBehaviour
{
    public Tilemap tilemap { get; private set; }
    [SerializeField] private Tile UnknowTile;
    [SerializeField] private Tile Bomb;
    [SerializeField] private Tile FlaggedTile;
    [SerializeField] private Tile one;
    [SerializeField] private Tile two;
    [SerializeField] private Tile three;
    [SerializeField] private Tile four;
    [SerializeField] private Tile noNum;
    public void Awake()
    {
        tilemap = GetComponent<Tilemap>();
    }

    public void DrawMap(GameCells[,] gameCells)
    {
        int width = gameCells.GetLength(0);
        int heihgt = gameCells.GetLength(1);
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < heihgt; y++)
            {
                GameCells cell = gameCells[x, y];
                tilemap.SetTile(cell.position, GetTile(cell));
            }
        }
    }

    private Tile GetTile(GameCells cell)
    {
        if (cell.revealed)
        {
            return GetRevealedTile(cell);
        }
        else if (cell.flagged)
        {
            return FlaggedTile;

        }
        else
        {
            return UnknowTile;
        }
    }

    private Tile GetRevealedTile(GameCells cell)
    {
        switch (cell.type)
        {
            case GameCells.Type.Empty:
                return noNum;
            case GameCells.Type.Mine:
                return Bomb;
            case GameCells.Type.Number:
                return GetNumber(cell);
            default: return null;
        }
    }

    private Tile GetNumber(GameCells cell)
    {
        switch (cell.number)
        {
            case 1: return one;
            case 2: return two;
            case 3: return three;
            case 4: return four;
            default: return null;
        }
    }
}
