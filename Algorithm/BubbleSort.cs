namespace Algorithm {
    public class BubbleSort<T> : AlgorithmBase<T>
        where T : IComparable {
        public BubbleSort(IEnumerable<T> items) : base(items) {}

        public BubbleSort() {}
        protected override void MakeSort() {
            var count = Items.Count;

            for (int j = 0; j < count; j++) {
                for (int i = 0; i < count - 1 - j; i++) {
                    var left = Items[i];
                    var right = Items[i + 1];

                    if (left.CompareTo(right) == 1) {
                        Swap(i, i + 1);
                    }
                }
            }
        }
    }
}