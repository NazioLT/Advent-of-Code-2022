using System.Collections.Generic;
using UnityEngine;

namespace HennoTheo.Day1
{
    public class Day1_Part2 : MonoBehaviour
    {
        [SerializeField] private TextAsset input;

        [ContextMenu("Execute")]
        private void Execute()//205381
        {
            string[] _stringParts = input.text.Split('\n');
            List<int> _calories = Day1ExtensionClass.GetCaloriesForEachElf(_stringParts);
            _calories.Sort();
            _calories.Reverse();
            int _top3Total = _calories[0] + _calories[1] + _calories[2];

            print($"The top 3 elves are carrying a total of : {_top3Total} calories.");
        }
    }
}