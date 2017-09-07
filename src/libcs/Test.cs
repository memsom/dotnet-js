namespace LibFS {
    public class TestType<T1, T2> {
    }

    public static class Library {
        public static void map<T1, T2>(TestType<T1, T2> t) { }
    }
}
