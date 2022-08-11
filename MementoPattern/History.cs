using System.Collections.Generic;
using System.Data.SqlClient;

namespace MementoPattern
{
    public class History
    {
        private List<EditorState> states = new List<EditorState>();

        public void Push(EditorState state)
        {
            states.Add(state);
        }

        public EditorState Pop()
        {
            int lastIndex = this.states.Count - 1;
            EditorState lastState = this.states[lastIndex];
            states.Remove(lastState);

            return lastState;
        }
    }
}