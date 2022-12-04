namespace HennoTheo.Day3
{
    public static class Day3ExtensionClass
    {
        public static int AllItemsScores(char[] _items)
        {
            int _result = 0;
            foreach (var _item in _items) _result += GetItemScore(_item);

            return _result;
        }

        public static char FindCommonChar(string[] _arrays)
        {
            foreach (var _char in _arrays[0].ToCharArray())
            {
                if (AllStringsContains(_char, _arrays)) return _char;
            }

            throw new System.Exception("Char not found");
        }

        public static bool AllStringsContains(char _target, string[] _array)
        {
            foreach (var _string in _array) if (!_string.Contains(_target)) return false;

            return true;
        }

        private static int GetItemScore(char _item)
        {
            int _itemAscii = (int)_item;
            int _asciiStart = _itemAscii > 96 ? 96 : (64 - 26);//Ref ascii
            return _itemAscii - _asciiStart;
        }
    }
}