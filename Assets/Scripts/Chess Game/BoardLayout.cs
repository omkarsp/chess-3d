using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Board/Layout")]
public class BoardLayout : ScriptableObject
{
    [Serializable]
    private class BoardSquareSetup
    {
        public Vector2Int position;
        public PieceType pieceType;
        public TeamColor teamColor;
    }

    [SerializeField] private BoardSquareSetup[] boardSquares;

    public int GetPieceCount()
    {
        return boardSquares.Length;
    }

    public Vector2Int GetSquareCoordsIndices(int index)
    {
        if (index >= boardSquares.Length)
        {
            Debug.LogError("Index of piece is out of range");
            return new Vector2Int(-1, -1);
        }
    }

    public string GetSquarePieceNameAtIndex(int index)
    {

    }

    public TeamColor GetSquareTeamColorAtIndex(int index)
    {

    }
}
