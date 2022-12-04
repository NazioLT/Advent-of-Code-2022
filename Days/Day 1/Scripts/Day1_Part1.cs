using System.Collections.Generic;
using UnityEngine;

namespace HennoTheo.Day1
{
    public class Day1_Part1 : MonoBehaviour
    {
        [SerializeField] private TextAsset input;

        [ContextMenu("Execute")]
        private void Execute()//70296
        {
            string[] _stringParts = input.text.Split('\n');
            List<int> _calories = Day1ExtensionClass.GetCaloriesForEachElf(_stringParts);

            int _targetElfCalories = Day1ExtensionClass.FindMaximum(_calories, out int _targetElfID);
            
            print($"The elf who's carrying the most is the number {_targetElfID}. He's carrying {_targetElfCalories}");
        }
    }
}