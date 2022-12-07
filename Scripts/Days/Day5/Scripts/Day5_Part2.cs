using UnityEngine;

namespace HennoTheo.Day5
{
    public class Day5_Part2 : MonoBehaviour
    {
        [SerializeField] private TextAsset moveInput;
        private CrateStack[] stacks = new CrateStack[] {
            new CrateStack("BPNQHDRT"), new CrateStack("WGBJTV"), new CrateStack("NRHDSVMQ"),
            new CrateStack("PZNMC"), new CrateStack("DZB"), new CrateStack("VCWZ"),
            new CrateStack("GZNCVQLS"), new CrateStack("LGJMDNV"), new CrateStack("TPMFZCG")
        };

        [ContextMenu("Execute")]
        private void Execute()//WDLPFNNNB
        {
            string[] _moveLines = moveInput.text.Split('\n');
            string _answer = Day5ExtensionClass.ComputeDay5(stacks, _moveLines, false);

            Debug.Log($"The number of pairs containing one Fully contains in the other is {_answer}.");
        }
    }
}