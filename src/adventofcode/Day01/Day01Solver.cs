namespace adventofcode.Day01
{
    public class Day01Solver
    {
        private int sum;
        private readonly int indexOffset;
        private string input;
        
        public Day01Solver(int indexOffset = 1)
        {
            this.indexOffset = indexOffset;
        }

        public string Solve(string input)
        {
            sum = 0;
            this.input = input;
            
            for (var i = 0; i < input.Length; i++)
            {
                AddToSumIfDigitsEquals(i, GetIndexByOffset(i));
            }
            return sum.ToString();
        }
        
        private void AddToSumIfDigitsEquals(int leftIndex, int rightIndex)
        {
            var left = input[leftIndex];
            var right = input[rightIndex];
            if (left == right)
                sum += int.Parse(right.ToString());
        }

        private int GetIndexByOffset(int currentIndex)
        {
            return (currentIndex + indexOffset) % (input.Length);
        }
         
    }
}