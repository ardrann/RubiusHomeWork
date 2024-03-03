using Xunit;

namespace UnitTests
{
    public class StackTests
    {
        [Fact]
        public void PushSuccessfully()
        {
            var StackForTest = new Stack<int>();
            int LengthOfStack = StackForTest.Count;
            var NewElement = 5;
            StackForTest.Push(NewElement);
            int NewLengthOfStack = StackForTest.Count;
            Assert.Equal(NewLengthOfStack, LengthOfStack + 1);
        }
        [Fact]
        public void PopSuccessfully()
        {
            var StackForTest = new Stack<int>();
            StackForTest.Push(2);
            StackForTest.Push(3);
            int LengthOfStack = StackForTest.Count;
            StackForTest.Pop();
            int NewLengthOfStack = StackForTest.Count;
            Assert.Equal(NewLengthOfStack, LengthOfStack - 1);
        }
    }
}