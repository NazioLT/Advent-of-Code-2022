using UnityEngine;

namespace HennoTheo.Day3
{
    public class Day3_Part1 : MonoBehaviour
    {
        [SerializeField] private TextAsset input;

        [ContextMenu("Execute")]
        private void Execute()//7793
        {
            string[] _stringParts = input.text.Split('\n');
            char[] _items = GetBothCompartmentsItems(_stringParts);
            int _totalPriority = Day3ExtensionClass.AllItemsScores(_items);

            Debug.Log($"The total priority of both compartment items is {_totalPriority}");
        }

        private char[] GetBothCompartmentsItems(string[] _inputs)
        {
            char[] _items = new char[_inputs.Length];
            for (int i = 0; i < _items.Length; i++)
            {
                GetCompartments(_inputs[i], out string _compartment1, out string _compartment2);
                _items[i] = Day3ExtensionClass.FindCommonChar(new string[] { _compartment1, _compartment2 });
            }

            return _items;
        }

        private void GetCompartments(string _rucksack, out string _compartment1, out string _compartment2)
        {
            int _halfLength = _rucksack.Length / 2;
            _compartment1 = _rucksack.Substring(0, _halfLength);
            _compartment2 = _rucksack.Substring(_halfLength);
        }
    }
}