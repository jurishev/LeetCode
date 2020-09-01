using System.Collections.Generic;

namespace Tiq.Easy.Array
{
    public class ValidSudoku
    {
        public bool IsValidSudoku(char[][] board)
        {
            var rows = NewHashSetArray(9);
            var cols = NewHashSetArray(9);
            var sqrs = NewHashSetBoard(3);

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    var c = board[i][j];

                    if (c == '.')
                    {
                        continue;
                    }

                    if (!rows[i].Add(c) ||
                        !cols[j].Add(c) ||
                        !sqrs[i / 3][j / 3].Add(c))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private HashSet<char>[] NewHashSetArray(int length)
        {
            var set = new HashSet<char>[length];

            for (int i = 0; i < set.Length; i++)
            {
                set[i] = new HashSet<char>();
            }

            return set;
        }

        private HashSet<char>[][] NewHashSetBoard(int volume)
        {
            var matrix = new HashSet<char>[volume][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = NewHashSetArray(volume);
            }

            return matrix;
        }
    }
}
