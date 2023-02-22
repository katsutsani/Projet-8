using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Game : MonoBehaviour
{
    public int width = 16;
    public int height = 16;
    public int MineCount = 32; 

    private GameBoard gameBoard;
    private GameCells[,] gameCells;

    private void Awake()
    {
        gameBoard = GetComponentInChildren<GameBoard>();
    }
    // Start is called before the first frame update
    private void Start()
    {
        NewGame();
        
    }

    private void NewGame()
    {
        gameCells = new GameCells[width, height];

        GenerateCells();
        GenerateMines();
        GenerateNumbers();

        Camera.main.transform.position = new Vector3(width/2f, height/2f, -10f);
        gameBoard.DrawMap(gameCells);
    }

    private void GenerateCells()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GameCells gameCell = new GameCells();
                gameCell.position = new Vector3Int(x, y,0);
                gameCell.type = GameCells.Type.Empty;
                gameCells[x, y] = gameCell;
            }
        }
    }

    private void GenerateMines()
    {
        for (int i = 0; i < MineCount; i++)
        {
            int x = Random.Range(0, width);
            int y = Random.Range(0, height);

            while(gameCells[x, y].type == GameCells.Type.Mine)
            {
                x++;
                if(x >= width)
                {
                    x = 0;
                    y++;
                    if(y>=height)
                    {
                        y = 0;
                    }
                }
            }
            gameCells[x, y].type = GameCells.Type.Mine;
        }
    }

    private void GenerateNumbers()
    {
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GameCells gameCell = gameCells[x,y];
                if(gameCell.type == GameCells.Type.Mine)
                {
                    continue;
                }
                gameCell.number = CountMines(x,y);

                if(gameCell.number > 0)
                {
                    gameCell.type= GameCells.Type.Number;
                }
                gameCell.revealed= true;
                gameCells[x, y] = gameCell;
            }
        }
    }

    private int CountMines(int cellX,int cellY)
    {
        int count = 0;
        for (int adjacentX = -1; adjacentX <=1; adjacentX++)
        {
            for (int adjacentY = -1; adjacentY <=1; adjacentY++)
            {
                if(adjacentX == 0 && adjacentY == 0)
                {
                    continue;
                }
                int x = cellX + adjacentX;
                int y = cellY + adjacentY;

                if(x<0 || x >= width || y < 0 || y>= height)
                {
                    continue;
                }
                if (gameCells[x,y].type == GameCells.Type.Mine)
                {
                    count++;
                }
            }
        }
        return count;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetMouseButtonDown(1))
    //    {
    //        flag();
    //    }
    //    else if (Input.GetMouseButtonDown(0))
    //    {
    //        RemoveTile();
    //    }
    //}

    //private void flag()
    //{
    //    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Instantiate(prefab2, new Vector2(worldPosition.x, worldPosition.y), Quaternion.identity);
    //}

    //private void RemoveTile()
    //{
    //    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    Instantiate(prefab2, new Vector2(worldPosition.x, worldPosition.y), Quaternion.identity);
    //}

    //private bool isATile(int x, int y)
    //{
    //    //if ()
    //    //{

    //    //}
    //    return false;
    //}
}
