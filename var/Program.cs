
namespace CSharp.TipoviOperatori
{
    struct S
    {
        public int a;
        public double b;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var i0 = 7;
            var d0 = 7.77;
            //i0 = d0;

            int i1 = 7;
            double d1 = 7.77;
            //i1 = d1;

            var s = new S();
            s.a = 7;
            s.b = 7.7;

        }
    }
}
