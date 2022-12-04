using UnityEngine;

namespace HennoTheo.Day3
{
    public class Day3_Part2 : MonoBehaviour
    {
        [SerializeField] private TextAsset input;

        [ContextMenu("Execute")]
        private void Execute()//2499
        {
            string[] _stringParts = input.text.Split('\n');
            char[] _elfGroupsCommonItems = GetGroupCommonItem(_stringParts);
            int _totalPriority = Day3ExtensionClass.AllItemsScores(_elfGroupsCommonItems);

            Debug.Log($"The total priority of elf groups commons items is {_totalPriority}");
        }

        private char[] GetGroupCommonItem(string[] _inputs)
        {
            char[] _elfGroupsCommonItems = new char[_inputs.Length / 3];
            for (int i = 0; i < _elfGroupsCommonItems.Length; i++)
            {
                int _startIndex = i * 3;
                _elfGroupsCommonItems[i] = Day3ExtensionClass.FindCommonChar(new string[] { _inputs[_startIndex], _inputs[_startIndex + 1], _inputs[_startIndex + 2] });
            }

            return _elfGroupsCommonItems;
        }
    }
}