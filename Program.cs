namespace Assignment_6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int [] { 1, 2, 3 };
            matrix[1] = new int [] { 4, 5, 6 };
            matrix[2] = new int [] { 7, 8, 9 };

            int left = 0;
            int right = matrix.Length - 1;

            //swaps the top of the matrix with the bottom of the matrix
            while (left < right)
            {
                (matrix[left], matrix[right]) = (matrix[right], matrix[left]);
                left += 1;
                right -= 1;
            }
            //swaps positions of matrix that are diagonal from each other
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < row; col++)
                {
                    (matrix[row][col], matrix[col][row]) = (matrix[col][row], matrix[row][col]);
                }
            }

        }
    }
}
