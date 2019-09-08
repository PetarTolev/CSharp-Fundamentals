namespace P04_Froggy
{
    using System.Collections.Generic;
    using System.Collections;

    public class Lake : IEnumerable<int>
    {
        private int[] stoneValues;

        public Lake(params int[] inputStoneValues)
        {
            this.stoneValues = inputStoneValues;
            
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < this.stoneValues.Length; i++)
            {
                if (i % 2 == 0)
                {
                    yield return this.stoneValues[i];
                }
            }

            for (int i = this.stoneValues.Length - 1; i >= 0; i--)
            {
                if (i % 2 == 1)
                {
                    yield return stoneValues[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => this.GetEnumerator();
    }
}