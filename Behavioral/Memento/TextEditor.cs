namespace MementoPattern
{
    public class TextEditor
    {
        private string _content = "";

        public void Write(string text)
        {
            _content += text;
        }

        public string GetContent()
        {
            return _content;
        }

        public EditorMemento Save()
        {
            return new EditorMemento(_content);
        }

        public void Restore(EditorMemento memento)
        {
            _content = memento.Content;
        }
    }
}