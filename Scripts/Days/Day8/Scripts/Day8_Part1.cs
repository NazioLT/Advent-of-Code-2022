using UnityEngine;

namespace HennoTheo.Day8
{
    public class Day8_Part1 : MonoBehaviour
    {
        [SerializeField] private TextAsset moveInput;

        [ContextMenu("Execute")]
        private void Execute()//1851
        {
            string[] _inputLines = moveInput.text.Split('\n');
            int[,] _forest = Day8ExtensionClass.CreateForest(_inputLines);
            int _visibleTree = CountVisibleTree(_forest);

            Debug.Log($"The number of pairs containing one Fully contains in the other is {_visibleTree}.");
        }

        private int CountVisibleTree(int[,] _forest)
        {
            int _visibleTree = 0;
            for (var j = 0; j < _forest.GetLength(1); j++)
            {
                for (var i = 0; i < _forest.GetLength(0); i++)
                {
                    Vector2Int _coordinates = new Vector2Int(i, j);
                    bool _isInBorder = !Has4Neighbours(_coordinates, _forest);

                    if (_isInBorder || CheckIfVisible(_coordinates, _forest)) _visibleTree++;
                }
            }

            return _visibleTree;
        }

        private bool CheckIfVisible(Vector2Int _coordinates, int[,] _forest) => (IsVisibleFromLeft(_coordinates, _forest) || IsVisibleFromRight(_coordinates, _forest) || IsVisibleFromTop(_coordinates, _forest) || IsVisibleFromBottom(_coordinates, _forest));

        private bool IsVisibleFromLeft(Vector2Int _coordinates, int[,] _forest)
        {
            int _treeHeight = _forest[_coordinates.x, _coordinates.y];
            for (var i = 0; i < _coordinates.x; i++)
            {
                if (_forest[i, _coordinates.y] >= _treeHeight) return false;
            }

            return true;
        }

        private bool IsVisibleFromRight(Vector2Int _coordinates, int[,] _forest)
        {
            int _treeHeight = _forest[_coordinates.x, _coordinates.y];
            for (var i = _coordinates.x + 1; i < _forest.GetLength(0); i++)
            {
                if (_forest[i, _coordinates.y] >= _treeHeight) return false;
            }

            return true;
        }

        private bool IsVisibleFromTop(Vector2Int _coordinates, int[,] _forest)
        {
            int _treeHeight = _forest[_coordinates.x, _coordinates.y];
            for (var i = 0; i < _coordinates.y; i++)
            {
                if (_forest[_coordinates.x, i] >= _treeHeight) return false;
            }

            return true;
        }

        private bool IsVisibleFromBottom(Vector2Int _coordinates, int[,] _forest)
        {
            int _treeHeight = _forest[_coordinates.x, _coordinates.y];
            for (var i = _coordinates.y + 1; i < _forest.GetLength(1); i++)
            {
                if (_forest[_coordinates.x, i] >= _treeHeight) return false;
            }

            return true;
        }

        private bool Has4Neighbours(Vector2Int _coordinates, int[,] _forest) => !(_coordinates.x == 0 || _coordinates.y == 0 || _coordinates.x == _forest.GetLength(0) - 1 || _coordinates.y == _forest.GetLength(1) - 1);
    }
}