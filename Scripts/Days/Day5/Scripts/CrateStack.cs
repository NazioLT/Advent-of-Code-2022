using UnityEngine;

namespace HennoTheo.Day5
{
    public struct CrateStack
    {
        public CrateStack(string _stack)
        {
            stack = _stack;
        }

        private string stack;

        public string Pick(int _count)
        {
            string _result = stack.Substring(stack.Length - _count);//-1 => index start at 0
            stack = stack.Substring(0, stack.Length - _count);

            return _result;
        }

        public void Put(string _input) => stack += _input;

        public char Last => stack.ToCharArray()[stack.Length - 1];
    }
}