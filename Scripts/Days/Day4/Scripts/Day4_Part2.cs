using UnityEngine;

namespace HennoTheo.Day4
{
    public class Day4_Part2 : MonoBehaviour
    {
        [SerializeField] private TextAsset input;

        [ContextMenu("Execute")]
        private void Execute()//852
        {
            string[] _inputLines = input.text.Split('\n');
            int _wrongAssignements = Day4ExtensionClass.CountAssignementPairsWithCondition(_inputLines, (_e1, _e2) => OneOverlapTheOther(_e1, _e2));

            Debug.Log($"The number of pairs containing an overlap is {_wrongAssignements}.");
        }

        private bool OneOverlapTheOther(MinMax _firstElf, MinMax _secondElf) => _firstElf.Overlap(_secondElf) || _secondElf.Overlap(_firstElf);
    }
}