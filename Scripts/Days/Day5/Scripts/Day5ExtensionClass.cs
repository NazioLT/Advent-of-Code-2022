using UnityEngine;

namespace HennoTheo.Day5
{
    public static class Day5ExtensionClass
    {
        public static void DecryptMoveInput(string _input, out int _count, out int _from, out int _to)
        {
            string[] _splittedInput = _input.Split(" ");
            _count = int.Parse(_splittedInput[1]);
            _from = int.Parse(_splittedInput[3]) - 1;
            _to = int.Parse(_splittedInput[5]) - 1;
        }

        public static void MoveCrates(ref CrateStack[] _stacks, int _count, int _from, int _to, bool _reverseListBeforePut)
        {
            char[] _stack = _stacks[_from].Pick(_count).ToCharArray();
            if (_reverseListBeforePut) _stack = Reverse(_stack);

            _stacks[_to].Put(Assemble(_stack));
        }

        public static T[] Reverse<T>(T[] _array)
        {
            T[] _result = new T[_array.Length];
            for (var i = 0; i < _array.Length; i++)
            {
                _result[i] = _array[_array.Length - i - 1];
            }

            return _result;
        }

        public static string Assemble(char[] _array)
        {
            string _result = "";
            for (var i = 0; i < _array.Length; i++)
            {
                _result += _array[i];
            }
            return _result;
        }

        public static string ComputeDay5(CrateStack[] _stacks, string[] _moveLines, bool _reverse)
        {
            for (var i = 0; i < _moveLines.Length; i++)
            {
                DecryptMoveInput(_moveLines[i], out int _count, out int _from, out int _to);
                MoveCrates(ref _stacks, _count, _from, _to, _reverse);
            }

            string _output = "";
            foreach (var item in _stacks)
            {
                _output += item.Last;
            }

            return _output;
        }
    }
}