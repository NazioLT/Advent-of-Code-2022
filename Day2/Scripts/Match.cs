namespace HennoTheo.Day2
{
    public struct Match
    {
        public Match(GameShape _elfShape, GameShape _playerShape)
        {
            elfShape = _elfShape;
            playerShape = _playerShape;

            playerResult = GetPlayerResult(elfShape, playerShape);
        }

        public readonly GameShape elfShape, playerShape;
        public readonly GameResult playerResult;

        public static GameResult GetPlayerResult(GameShape _elfShape, GameShape _playerShape)
        {
            if (_elfShape == _playerShape) return GameResult.Draw;

            if (_elfShape == GameShape.Rock && _playerShape == GameShape.Paper ||
            _elfShape == GameShape.Paper && _playerShape == GameShape.Scissors ||
            _elfShape == GameShape.Scissors && _playerShape == GameShape.Rock) return GameResult.Won;

            return GameResult.Lost;
        }
    }
}