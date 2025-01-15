namespace Stack
{
    public class Stack<T>
    {
        private Node<T>? _top;
        public int Count { get; private set; }
        public bool IsEmpty() => _top == null;

        public void Push(T item)
        {
            _top = new Node<T>(item, _top);
            Count++;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Cannot pop from an empty stack");
            var value = _top.Value;
            _top = _top.Next;
            Count--;
            return value;
        }

        public object Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Cannot pop from an empty stack");
            return _top.Value;
        }
        public void Clear()
        {
            _top = null;
            Count = 0;
        }
    }
}