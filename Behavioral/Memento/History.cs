using System.Collections.Generic;

namespace MementoPattern
{
    public class History
    {
        private Stack<EditorMemento> _history = new Stack<EditorMemento>();

        public void Push(EditorMemento memento)
        {
            _history.Push(memento);
        }

        public EditorMemento Pop()
        {
            return _history.Pop();
        }
    }
}