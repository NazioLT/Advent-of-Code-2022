namespace HennoTheo.Day2
{
    public static class Day2ExtensionClass
    {
        public static int GetTotalMatchPoints(Match[] _matches)
        {
            int _result = 0;
            foreach (Match _match in _matches)
            {
                _result += GetMatchPoint(_match);
            }

            return _result;
        }

        public static int GetMatchPoint(Match _match) => (int)_match.playerShape + (int)_match.playerResult;

        public static GameShape ShapeFactory(char _char)
        {
            if (_char == 'X' || _char == 'A') return GameShape.Rock;

            if (_char == 'Y' || _char == 'B') return GameShape.Paper;

            if (_char == 'Z' || _char == 'C') return GameShape.Scissors;

            throw new System.Exception($"Shape does'nt exist ({_char})");
        }
    }
}