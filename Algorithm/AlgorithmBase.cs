using System.Diagnostics;

namespace Algorithm {
    public class AlgorithmBase<T>
        where T : IComparable {
        public int SwapCount { get; protected set; } = 0;
        public List<T> Items { get; set; } = new List<T>();

        public AlgorithmBase(IEnumerable<T> items) {
            Items.AddRange(items);
        }

        public AlgorithmBase() {}

        public void Swap(int left, int right) {
            if (left < Items.Count && right < Items.Count) {
                var temp = Items[left];
                Items[left] = Items[right];
                Items[right] = temp;
            }

            SwapCount++;
        }

        protected virtual void MakeSort() {
            Items.Sort();
        }

        public TimeSpan Sort() {
            var timer = new Stopwatch();
            SwapCount = 0;

            timer.Start();
            MakeSort();
            timer.Stop();

            return timer.Elapsed;
        }

        protected int Compare(T left, T right) {
            return left.CompareTo(right);
        }

        protected void Set(int position, T item) {
            if (position < Items.Count) {
                Items[position] = item;
            }
        }
    }
}