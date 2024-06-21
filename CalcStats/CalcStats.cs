

namespace CalcStatsKata
{
    public class CalcStats
    {
        private int[] _numberSequence;

        public int Length => _numberSequence.Length;
        public CalcStats(int[] numberSequence)
        {
            _numberSequence = numberSequence;
        }

        public int Min()
        {
            int min = _numberSequence[0];
            for (var i = 1; i < _numberSequence.Length; i++)
            {
                if (min > _numberSequence[i])
                    min = _numberSequence[i];
            }
            return min;
        }

        public int Max()
        {
            int max = _numberSequence[0];
            for (var i = 1; i < _numberSequence.Length; i++)
            {
                if (max < _numberSequence[i])
                    max = _numberSequence[i];
            }
            return max;
        }

        private int Sum()
        {
            var sum = 0;
            foreach (var item in _numberSequence)
            {
                sum += item;
            }

            return sum;
        }

        public int Average()
        {
            var sum = Sum();
            return sum / Length;
        }
    }
}
