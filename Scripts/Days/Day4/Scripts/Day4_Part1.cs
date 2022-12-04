using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace HennoTheo.Day3
{
    public class Day4_Part1 : MonoBehaviour
    {
        [SerializeField] private TextAsset input;

        [ContextMenu("Execute")]
        private void Execute()//433
        {
            string[] _inputLines = input.text.Split('\n');
            int _wrongAssignements = Day4ExtensionClass.CountAssignementPairsWithCondition(_inputLines, (_e1, _e2) => OneFullyContainsTheOther(_e1, _e2));

            Debug.Log($"The number of pairs containing one Fully contains in the other is {_wrongAssignements}.");
        }

        private bool OneFullyContainsTheOther(MinMax _firstElf, MinMax _secondElf) => _firstElf.Contains(_secondElf) || _secondElf.Contains(_firstElf);
    }
}