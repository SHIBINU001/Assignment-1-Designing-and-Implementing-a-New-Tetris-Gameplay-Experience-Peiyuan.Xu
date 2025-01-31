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
}