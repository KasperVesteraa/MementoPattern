namespace MementoPattern
{
    public class Editor
    {
        public string Content { get; set; } = "(no content yet...)";

        public EditorState CreateState()
        {
            return new EditorState(this.Content);
        }

        public void Restore(EditorState state)
        {
            this.Content = state.Content; 
        }
    }
}