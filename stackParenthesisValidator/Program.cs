namespace stackParenthesisValidator {
    
    internal class Stack<T> {

        private T[] stackArray;
        public int capacity;
        public int length;

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

            string stringToTest = "{x+(y-[a+b])*c-[(d+e)]}/(h-(j-(k-[l-n])))";

            // Initial Commit

            Stack<char> testStack = new Stack<char>(stringToTest.Length);

            

            int capacity = testStack.capacity;
            for (int i=0;i<capacity;i++) {

                char temp = stringToTest[i];

                if (temp == '(' || temp == '[' || temp == '{') {
                    testStack.Push(temp);
                }else if (temp == ')') {

                    if (testStack.Pop() != '(') throw new InvalidOperationException("This stack is not valid.");

                } else if (temp == ']') {

                    if (testStack.Pop() != '[') throw new InvalidOperationException("This stack is not valid.");

                } else if (temp == '}') {

                    if (testStack.Pop() != '{') throw new InvalidOperationException("This stack is not valid.");

                }


            }

            if (testStack.length != 0) {
                throw new InvalidOperationException("This stack is not valid.\n\n");
            }

            Console.WriteLine("String is valid");
            



        }

        


    }
}
