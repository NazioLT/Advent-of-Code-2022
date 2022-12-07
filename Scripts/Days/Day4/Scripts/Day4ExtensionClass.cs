namespace HennoTheo.Day4
{
    public static class Day4ExtensionClass
    {
        public static void GetElvesPairs(string _inputLine, out MinMax _firstElf, out MinMax _secondElf)
        {
            string[] _pairs = _inputLine.Split(',');
            _firstElf = GetElfPair(_pairs[0]);
            _secondElf = GetElfPair(_pairs[1]);
        }

        public static MinMax GetElfPair(string _inputPair)
        {
            string[] _chars = _inputPair.Split('-');
            return new MinMax(int.Parse(_chars[0]), int.Parse(_chars[1]));
        }

        public static int CountAssignementPairsWithCondition(string[] _inputLines, System.Func<MinMax, MinMax, bool> _condition)
        {
            int _result = 0;
            foreach (var _line in _inputLines)
            {
                GetElvesPairs(_line, out MinMax _firstElf, out MinMax _secondElf);
                _result += _condition(_firstElf, _secondElf) ? 1 : 0;
            }

            return _result;
        }
    }
}