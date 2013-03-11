using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Note : MusicalEvent  {
        #region Declarations
        private int intensity;
        private Notes pitch;
        private int octave;
        private int accidentals;
        #endregion

        #region Constructors
        public Note(Fraction duration)
            : base(Fraction.Zero, duration) {
            Pitch = Notes.Empty;
        }

        public Note(Fraction tp, Fraction d)
            : base(tp, d) {
            Pitch = Notes.Empty;
        }

        public Note(Fraction tp, Fraction d, int acc, int oct)
            : base(tp, d) {

            this.Accidentals = acc;
            this.Octave = oct;
            Pitch = Notes.Empty;
        }
        #endregion

        #region Properties

        public Notes Pitch {
            get { return pitch; }
            set { pitch = value; }
        }

        public int Octave {
            get { return octave; }
            set { octave = value; }
        }

        public int Accidentals {
            get { return accidentals; }
            set { accidentals = value; }
        }

        public int Intensity {
            get { return intensity; }
            set { intensity = value; }
        }
        #endregion

        #region Overrides
        public override Fraction Duration {
            get {
                return base.Duration;
            }
            set {
                base.Duration = value;
                if (value == Fraction.Zero)
                    this.Points = 0;
            }
        }

        public override bool CanBeMerged(MusicalEvent ev) {
            if (base.CanBeMerged(ev)) {
                Note n = ev as Note;
                if (n != null) {
                    if (this.Pitch == n.Pitch && this.Octave == n.Octave)
                        return true;
                    else
                        return false;
                } else
                    return false;

            } else return false;
        }
        #endregion

        #region Members
        public void OffsetPitch(int offset) {
            if (pitch >= Notes.NOTE_C & pitch <= Notes.NOTE_H) {
                Notes tmpPitch = pitch - (int)Notes.NOTE_C;
                tmpPitch += offset;
                int regChange = 0;
                while ((int)tmpPitch > 6) {
                    tmpPitch -= 7;
                    ++regChange;
                }

                while (tmpPitch < 0) {
                    tmpPitch += 7;
                    --regChange;
                }

                pitch = tmpPitch + (int)Notes.NOTE_C;
                if (regChange > 0) {
                    Octave += regChange;
                }
            }
        }

        public void AddSharp() {
            accidentals++;
        }

        public void AddFlat() {
            accidentals--;
        }
        #endregion

        #region Serialization
        /// <summary>
        /// Save object to serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Serialize(SerializationInfo serializationInfo, int order) {
            serializationInfo.AddValue(szIntensity, intensity);
            serializationInfo.AddValue(szPitch, pitch);
            serializationInfo.AddValue(szOctave, octave);
            serializationInfo.AddValue(szAccidentals, accidentals);
            base.Serialize(serializationInfo, order);
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            intensity = serializationInfo.GetInt32(szIntensity);
            pitch = (Notes)serializationInfo.GetValue(szPitch, typeof(Notes));
            octave = serializationInfo.GetInt32(szOctave);
            accidentals = serializationInfo.GetInt32(szAccidentals);
            base.Deserialize(serializationInfo, order);
        }

        private static string szIntensity = "Intensity";
        private static string szPitch = "Pitch";
        private static string szOctave = "Octave";
        private static string szAccidentals = "Accidentals";
        #endregion

        #region Constants
        public static readonly int MIN_ACCIDENTALS = -2;
        public static readonly int MAX_ACCIDENTALS = 2;
        #endregion
    }
}
