namespace CSDll
{
    public class LibClass
    {
        public LibClass()
        {
            A = 0;
            B = 0;
        }

        public LibClass(int a, int b)
        {
            A = a;
            B = b;
        }

        public void SetA(int a)
        {
            A = a;
        }

        public void SetB(int b)
        {
            B = b;
        }

        public int Sum()
        {
            return A + B;
        }

        public int Multiply()
        {
            return A * B;
        }

        public int A;
        public int B;
    }
}