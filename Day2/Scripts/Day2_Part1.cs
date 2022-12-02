using System.Collections.Generic;
using UnityEngine;

namespace HennoTheo.Day2
{
    public enum GameShape { Rock = 1, Paper = 2, Scissors = 3 }
    public enum GameResult { Lost = 0, Draw = 3, Won = 6 }

    public class Day2_Part1 : MonoBehaviour
    {
        [SerializeField] private TextAsset input;

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
                _matches[i] = new Match(Day2ExtensionClass.ShapeFactory(_matchChars[0]), Day2ExtensionClass.ShapeFactory(_matchChars[2]));
            }

            return _matches;
        }
    }
}