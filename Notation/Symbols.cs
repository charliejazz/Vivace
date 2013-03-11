using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vivace.Notation {
    /// <summary>
    /// 
    /// </summary>
    public static class Symbols {
        #region Readonly fields
        public static readonly uint None = 0;
        public static readonly uint EmptySymbol = 32;	// must stay = 0

        public static readonly uint SharpSymbol = 35;
        public static readonly uint DSharpSymbol = 180;	// 0xB4 > 127 ! (also crosshead)
        public static readonly uint FlatSymbol = 98;	// 0x62
        public static readonly uint DFlatSymbol = 134;	// 0x86 > 127 ! (bb) also 72 (on MacOS)
        public static readonly uint NaturalSymbol = 110;	//0x6E

        public static readonly uint NoteDotSymbol = 46;
        public static readonly uint StaffLineSymbol = 89;
        public static readonly uint StaffSymbol = '=';	// TODO: replace by its value (61 ?)
        public static readonly uint FinishBarSymbol = 92;
        public static readonly uint HelpLineSymbol = 95;	// Ledger line
        public static readonly uint BembelSymbol = 164;	// 0xA4 > 127 !	(amphore)

        public static readonly uint AccoladeSymbol = 171;	// 0xAB > 127 !	
        public static readonly uint AccoladeRightSymbol = '}';	// TODO: replace by its value

        public static readonly uint StemUp1Symbol = 219;	// > 127 ! (vertical line, junction to the head)
        public static readonly uint StemUp2Symbol = 151;	// > 127 ! (vertical line a little longer)

        public static readonly uint StemDown1Symbol = 218;	// > 127 ! (vertical line, junction to the head)
        public static readonly uint StemDown2Symbol = 150;	// > 127 ! (vertical line a little longer)


        public static readonly uint BarGSSymbol = 101;
        public static readonly uint BarSymbol = 139;	// 0x9B > 127 !

        public static readonly uint ClefViolin = 38;
        public static readonly uint ClefBass = 63;
        public static readonly uint ClefBratsche = 66;

        public static readonly uint P4Symbol = 165;	// 0xA5 > 127 ! // Rests
        public static readonly uint P8Symbol = 97;
        public static readonly uint P16Symbol = 64;
        public static readonly uint P32Symbol = 174;	// 0xAE > 127 !
        public static readonly uint P64Symbol = 108;
        public static readonly uint P128Symbol = 47;

        public static readonly uint IntensFSymbol = 102;
        public static readonly uint IntensFFSymbol = 131;	 // > 127 !
        public static readonly uint IntensFFFSymbol = 39;
        public static readonly uint IntensFFFFSymbol = 115;
        public static readonly uint IntensPSymbol = 112;
        public static readonly uint IntensPPSymbol = 132;	 // 0x84 > 127 !	  
        public static readonly uint IntensMFSymbol = 70;
        public static readonly uint IntensMPSymbol = 80;
        public static readonly uint IntensSFSymbol = 83;

        public static readonly uint Flag8UpSymbol = 'j';			// notestem flags
        public static readonly uint Flag8DownSymbol = 'J';
        public static readonly uint Flag16UpSymbol = 'k';
        public static readonly uint Flag16DownSymbol = 'K';
        public static readonly uint Flag32UpSymbol = 221;			// SCR_32UP,  	// > 127 !
        public static readonly uint Flag32DownSymbol = 222;			// SCR_32DOWN, 	// > 127 !
        public static readonly uint Flag64UpSymbol = 's'; 	// Not in font, use the Flag32 !  's'; 
        public static readonly uint Flag64DownSymbol = 'S';  // Not in font, use the Flag32 !  'S';

        public static readonly uint StaccatoSymbol = '.';
        public static readonly uint AccentSymbol = '>';
        public static readonly uint MarcatoUpSymbol = 94;	// 0x5E
        public static readonly uint MarcatoDownSymbol = 'v'; 	// 118; //0x76
        public static readonly uint TenutoSymbol = '-';
        public static readonly uint FermataUpSymbol = 'U'; 	// 0x55 // 85 (up) ?
        public static readonly uint FermataDownSymbol = 117; 	// 0x75 // 85 (up) ?
        public static readonly uint BreathMarkSymbol = ',';	// 0x2C

        public static readonly uint CSymbol = 'c';
        public static readonly uint C2Symbol = 'C';

        public static readonly uint RightBracketSymbol = ']';

        public static readonly uint HalfDiamondHeadSymbol = 79; 		// (JB) added (MacOS) 
        public static readonly uint FullDiamondHeadSymbol = 81; 		// (JB) added (MacOS) 
        public static readonly uint LongaHeadSymbol = 87; 		// 0x57	// (JB) added longanote (2 x whole note)

        public static readonly uint WholeNoteHeadSymbol = 119; 		// 0x77
        public static readonly uint HalfNoteHeadSymbol = 69; 		// SCR_HALFNOTEHEAD,
        public static readonly uint FullHeadSymbol = 88; 		// SCR_FULLHEAD,
        public static readonly uint ErrorHeadSymbol = 191; 		// SCR_ERRORHEAD	> 127 !

        public static readonly uint MordSymbol = 'm'; 		// rename ? (GRTrill.cpp)
        public static readonly uint CodaSymbol = 230;		// 0xE6;
        public static readonly uint SegnoSymbol = 37; 		// 0x025;
        // Total szie of the symbol table
        public static readonly int SymbolTableSize = 256;
        #endregion
    }
}
