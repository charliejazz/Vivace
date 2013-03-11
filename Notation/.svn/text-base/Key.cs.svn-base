using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Vivace.Notation.Engraving;
using System.Runtime.Serialization;

namespace Vivace.Notation {
    /// <summary>
    /// Represents a musical key
    /// </summary>
    [Serializable]
    public class Key : MusicalTagParameter  {
        #region Declarations
        private int[] mkarray;
        private int[] octarray;
        private int keyNumber = 0;
        private bool isFree;
        #endregion

        #region Constructors
        public Key(Fraction timePosition)
            : base(timePosition, null) {
            mkarray = new int[EngravingRules.NumNotes];
            octarray = new int[EngravingRules.NumNotes];
            isFree = false;
        }

        public Key(int p_keyNumber)
            : base(Fraction.Zero, null) {
            keyNumber = p_keyNumber;
            mkarray = new int[EngravingRules.NumNotes];
            octarray = new int[EngravingRules.NumNotes];
            isFree = false;
        }

        public Key(Key k)
            : base(Fraction.Zero, null) {

            this.IsFree = k.IsFree;
            this.KeyNumber = k.KeyNumber;
            Array.Copy(k.MKArray, this.MKArray, EngravingRules.NumNotes);
            Array.Copy(k.OctArray, this.OctArray, EngravingRules.NumNotes);
        }
        #endregion

        #region Members
        /// <summary>
        /// Determine if two objects are equal
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj) {
            if (obj is Key) {
                Key k = obj as Key;
                if (this.KeyNumber != k.KeyNumber)
                    return false;
                if (this.IsFree != k.IsFree)
                    return false;

                for (int i = 0; i < EngravingRules.NumNotes; i++) {
                    if (this.MKArray[i] != k.MKArray[i])
                        return false;

                    if (this.OctArray[i] != k.OctArray[i])
                        return false;
                }
                
            }
            return false;
        }

        public override int GetHashCode() {
            return base.GetHashCode();
        }

        private void parseKey(String key) {
            char t = key[0];
            bool major = false;

            if (t == Char.ToUpper(t))
                major = true;

            t = Char.ToUpper(t);

            switch (t) {
                case 'F': keyNumber = -1; break;
                case 'C': keyNumber = 0; break;
                case 'G': keyNumber = 1; break;
                case 'D': keyNumber = 2; break;
                case 'A': keyNumber = 3; break;
                case 'E': keyNumber = 4; break;
                case 'H':
                case 'B': keyNumber = 5; break;
                default: keyNumber = 0; break;
            }

            if (!major)
                keyNumber -= 3;

            if (key.Length > 1) {
                t = key[1];
                if (t == '#')
                    keyNumber += 7;
                if (t == 'b')
                    keyNumber -= 7;
            }
        }
        #endregion

        #region Properties
        public bool IsFree {
            get { return isFree; }
            set { isFree = value; }
        }
        public int KeyNumber {
            get { return keyNumber; }
            set { keyNumber = value; }
        }
        public int[] MKArray {
            get { return mkarray; }
            set { mkarray = value; }
        }

        public int[] OctArray {
            get { return octarray; }
            set { octarray = value; }
        }

        public String KeyName {
            set {
                parseKey(value);
            }
        }
        #endregion

        #region Serialization
        /// <summary>
        /// Save object to serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Serialize(SerializationInfo serializationInfo, int order) {
            serializationInfo.AddValue(szKeyNumber, keyNumber);
            serializationInfo.AddValue(szIsFree, isFree);
            for (int i = 0; i < EngravingRules.NumNotes; i++) {
                serializationInfo.AddValue("mkArray", mkarray[i]);
            }

            for (int x = 0; x < EngravingRules.NumNotes; x++) {
                serializationInfo.AddValue("octarray", octarray[x]);
            }
            base.Serialize(serializationInfo, order);
        }
        /// <summary>
        /// Load object from serialization stream
        /// </summary>
        /// <param name="serializationInfo"></param>
        public virtual void Deserialize(SerializationInfo serializationInfo, int order) {
            keyNumber = serializationInfo.GetInt32(szKeyNumber);
            isFree = serializationInfo.GetBoolean(szIsFree);


            for (int i = 0; i < EngravingRules.NumNotes; i++) {
                mkarray[i] = serializationInfo.GetInt32("mkArray");
            }

            for (int x = 0; x < EngravingRules.NumNotes; x++) {
                octarray[x] = serializationInfo.GetInt32("octarray");
            }
            base.Deserialize(serializationInfo, order);
        }
        private static string szKeyNumber = "KeyNumber";
        private static string szIsFree = "IsFree";
        #endregion
    }
}
