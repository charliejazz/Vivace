using System;
using System.Collections.Generic;
using System.Text;

namespace Vivace.Notation {
    /// <summary>
    /// Available Articulations
    /// </summary>
    [Serializable, Flags]
    public enum Articulations : int {
        Staccato = 1, 
        Staccatissimo = 2, 
        Tenuto = 4,
        Accent = 8, 
        Marcato = 16,
        Fermata = 32, 
        BreathMark = 64
    }
}
