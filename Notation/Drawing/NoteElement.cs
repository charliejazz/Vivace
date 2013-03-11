using System;
using System.Collections.Generic;
using System.Text;

namespace Vivace.Notation.Drawing {
    /// <summary>
    /// Score Note element
    /// </summary>
    [Serializable]
    public class NoteElement : ScoreNotationElement<Note> {
        #region Constructors
        public NoteElement() : base() {
        }

        public NoteElement(Note note) : base(note) {
        }
        #endregion

    }
}
