namespace Lesson11
{
    public static class Extensions
    {
        const string chessFigures = "♔♕♖♗♘♙♚♛♜♝♞♟";

        public static string ToChessFormat(this char c)
        {
            string add = chessFigures.Contains(c) ? " " : string.Empty;
            return $"{c}{add}";
        }
    }
}
