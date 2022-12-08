using UnityEngine;

namespace HennoTheo.Day8
{
    public static class Day8ExtensionClass
    {
        public static int[,] CreateForest(string[] _inputLines)
        {
            int[,] _forest = new int[_inputLines[0].ToCharArray().Length - 1, _inputLines.Length];
            for (var _lineID = 0; _lineID < _inputLines.Length; _lineID++)
            {
                for (var _charID = 0; _charID < _inputLines[0].ToCharArray().Length - 1; _charID++)
                {
                    _forest[_charID, _lineID] = int.Parse(_inputLines[_lineID].Substring(_charID, 1));
                }
            }

            return _forest;
        }

        public static int GetScenicScore(int[,] _forest, Vector2Int _coord) => ScoreFromDirection(_forest, _coord, Vector2Int.down) * ScoreFromDirection(_forest, _coord, Vector2Int.left) * ScoreFromDirection(_forest, _coord, Vector2Int.right) * ScoreFromDirection(_forest, _coord, Vector2Int.up);

        public static int ScoreFromDirection(int[,] _forest, Vector2Int _coordinates, Vector2Int _direction)
        {
            int _score = 0;
            Vector2Int _curCoords = _coordinates;
            for (var i = 0; i < _coordinates.x; i++)
            {
                _curCoords += _direction;
                if (IsOut(_forest, _curCoords.x, _curCoords.y)) break;

                _score++;

                if (_forest[_curCoords.x, _curCoords.y] >= _forest[_coordinates.x, _coordinates.y]) break;
            }

            return _score;
        }

        public static bool IsOut(int[,] _array, int x, int y) => x < 0 || y < 0 || _array.GetLength(0) <= x || _array.GetLength(1) <= y;
    }
}