using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino
{
    I, 
    J, 
    L, 
    O, 
    S, 
    T, 
    U,
}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }

    public void Initialize()
    {
        cells = Data.Cells[tetromino];
    }
}