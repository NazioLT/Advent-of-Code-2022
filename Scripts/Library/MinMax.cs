public struct MinMax
{
    public MinMax(int _number1, int _number2)
    {
        bool _firstGreater = _number1 >= _number2;
        min = _firstGreater ? _number2 : _number1;
        max = _firstGreater ? _number1 : _number2;
    }

    public readonly int min, max;

    public bool Contains(int _value) => _value >= min && _value <= max;
    public bool Contains(MinMax _content) => Contains(_content.min) && Contains(_content.max);
    public bool Overlap(MinMax _content) => Contains(_content.min) || Contains(_content.max);

    public string Text => $"Min : {min} / Max : {max}";
}