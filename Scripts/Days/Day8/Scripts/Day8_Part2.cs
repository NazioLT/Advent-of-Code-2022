using UnityEngine;

namespace HennoTheo.Day8
{
    public class Day8_Part2 : MonoBehaviour
    {
        [SerializeField] private TextAsset moveInput;

        [ContextMenu("Execute")]
        private void Execute()//574080
        {
            string[] _inputLines = moveInput.text.Split('\n');
            int[,] _forest = Day8ExtensionClass.CreateForest(_inputLines);
            int _highScore = GetHeightestScenicScore(_forest);

            Debug.Log($"The highest scenic score is {_highScore}.");
        }

        private int GetHeightestScenicScore(int[,] _forest)
        {
            int _highScore = int.MinValue;
            for (var j = 0; j < _forest.GetLength(1); j++)
            {
                for (var i = 0; i < _forest.GetLength(0); i++)
                {
                    int _currentScenicScore = Day8ExtensionClass.GetScenicScore(_forest, new Vector2Int(i, j));

                    if (_currentScenicScore > _highScore) _highScore = _currentScenicScore;
                }
            }

            return _highScore;
        }
    }
}