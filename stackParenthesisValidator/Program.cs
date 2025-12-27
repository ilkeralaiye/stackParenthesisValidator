namespace stackParenthesisValidator {
    
    internal class Stack<T> {

        private T[] stackArray;
        private int capacity;
        private int length;

        public Stack(int capacity) {
            this.capacity = capacity;
            this.stackArray = new T[this.capacity];
            this.length = 0;
        }

        public void Push(T data) {

            if (length != capacity) {
                stackArray[length++] = data;
            } else throw new InvalidOperationException("This stack's capacity has been reached.");

        }

        public T Pop() {

            if (length != 0) {

                T itemToReturn = stackArray[--length];
                stackArray[length] = default(T);

                return itemToReturn;
            } else throw new InvalidOperationException("This stack is null.");


        }

        public T Peek() {

            if (length != 0) {
                return stackArray[length-1];
            } else throw new InvalidOperationException("This stack is null.");

        }


        public bool IsEmpty() {
            return length == 0;
        }



    }
    
    
    
    internal class Program {
        static void Main(string[] args) {
            // Initial Commit
        }
    }
}
