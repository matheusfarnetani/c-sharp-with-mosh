namespace Generics
{
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
        public TType Max<TType>(TType a, TType b) where TType : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

    }
}