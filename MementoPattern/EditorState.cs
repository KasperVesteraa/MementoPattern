namespace MementoPattern
{
    public class EditorState
    {
        public EditorState(string content)
        {
            Content = content;
        }

        public string Content { get; }
    }
}