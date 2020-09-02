namespace Tiq.Easy.Array
{
    public class RotateImage
    {
        public void Rotate(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length / 2; i++)
            {
                RotateCircle(matrix, i, matrix.Length - i - 1);
            }
        }

        private void RotateCircle(int[][] matrix, int min, int max)
        {
            for (int i = min, j = max; i < max; i++)
            {
                var temp = matrix[i][min];

                matrix[i][min] = matrix[max][i];
                matrix[max][i] = matrix[j][max];
                matrix[j][max] = matrix[min][j];
                matrix[min][j] = temp;

                j--;
            }
        }
    }
}
