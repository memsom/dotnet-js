using LibFS;

namespace AppFS {

    public static class Program {

        public static void testFunc<T>() {
            Library.map<T, T>(null);
        }

        public static void Main(string[] argv) {
            testFunc<int>();
        }
    }
}
