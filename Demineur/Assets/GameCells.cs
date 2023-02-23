using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct GameCells
{
    public enum Type
    {
        Invalid,
        Empty,
        Mine,
        Number,
    };
    public Vector3Int position;
    public Type type;
    public int number;
    public bool flagged;
    public bool revealed;
}
