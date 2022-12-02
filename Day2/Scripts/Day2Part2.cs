using UnityEngine;
using System.Collections.Generic;

namespace HennoTheo.Day2
{
    public class Day2Part2 : MonoBehaviour
    {
        [SerializeField] private TextAsset input;

        private Dictionary<GameShape, GameShape> loseShape = new Dictionary<GameShape, GameShape>
        {
            {GameShape.Rock, GameShape.Scissors}, {GameShape.Paper, GameShape.Rock}, {GameShape.Scissors, GameShape.Paper}
        };
        private Dictionary<GameShape, GameShape> winShape = new Dictionary<GameShape, GameShape>
        {
            {GameShape.Rock, GameShape.Paper}, {GameShape.Paper, GameShape.Scissors}, {GameShape.Scissors, GameShape.Rock}
        };

        [ContextMenu("Execute")]
        private void Execute()//70296
        {
            Match[] _matches = GetMatches(input.text);
            int _playerPoints = Day2ExtensionClass.GetTotalMatchPoints(_matches);

            Debug.Log($"The player has a total of {_playerPoints} points.");
        }

        private Match[] GetMatches(string _data)
        {
            string[] _stringParts = _data.Split('\n');
            Match[] _matches = new Match[_stringParts.Length];

            for (int i = 0; i < _matches.Length; i++)
            {
                char[] _matchChars = _stringParts[i].ToCharArray();
                GameResult _playerStrategy = PlayerStrategy(_matchChars[2]);

                GameShape _elfShape = Day2ExtensionClass.ShapeFactory(_matchChars[0]);
                GameShape _playerShape = PlayerShapeFollowingStrategy(_playerStrategy, _elfShape);

                _matches[i] = new Match(_elfShape, _playerShape);
            }

            return _matches;
        }

        private GameResult PlayerStrategy(char _char)
        {
            if (_char == 'X') return GameResult.Lost;
            if (_char == 'Y') return GameResult.Draw;

            return GameResult.Won;
        }

        private GameShape PlayerShapeFollowingStrategy(GameResult _strategy, GameShape _opponentShape)
        {
            if (_strategy == GameResult.Draw) return _opponentShape;
            if (_strategy == GameResult.Lost) return loseShape[_opponentShape];

            return winShape[_opponentShape];
        }
    }
}