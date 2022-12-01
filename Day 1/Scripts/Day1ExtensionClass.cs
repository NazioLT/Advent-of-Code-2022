using System.Collections.Generic;

namespace HennoTheo.Day1
{
    public static class Day1ExtensionClass
    {
        public static List<int> GetCaloriesForEachElf(string[] _stringPart)
        {
            List<int> _calories = new List<int>() { 0 };
            int _curElfID = 0;
            for (int i = 0; i < _stringPart.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(_stringPart[i]))
                {
                    _curElfID++;
                    _calories.Add(0);
                    continue;
                }

                int _curCalories = int.Parse(_stringPart[i]);
                _calories[_curElfID] += _curCalories;
            }

            return _calories;
        }

        public static int FindMaximum(List<int> _datas, out int _maxID)
        {
            _maxID = 0;
            int _maxValue = int.MinValue;
            for (int i = 0; i < _datas.Count; i++)
            {
                if (_datas[i] < _maxValue) continue;

                _maxValue = _datas[i];
                _maxID = i;
            }

            return _maxValue;
        }
    }
}