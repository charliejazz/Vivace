using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Vivace.Infrastructure.Configuration {
    /// <summary>
    /// Holds application settings
    /// </summary>
    public sealed class ApplicationSettings {

        private string backgroundTextureFile;
        private Color backgroundColor = Color.Black;
        private string pageTextureFile;
        private Color pageColor = Color.White;

        private static readonly ApplicationSettings currentSettings = new ApplicationSettings();

        public ApplicationSettings() {
            // load settings here
        }
        /// <summary>
        /// Gets the current application settings
        /// </summary>
        public static ApplicationSettings CurrentSetting {
            get {
                return currentSettings;
            }
        }

        public string BackgroundTextureFile {
            get { return backgroundTextureFile; }
            set { backgroundTextureFile = value; }
        }

        public Color BackgroundColor {
            get { return backgroundColor; }
            set { backgroundColor = value; }
        }


        public string PageTextureFile {
            get { return pageTextureFile; }
            set { pageTextureFile = value; }
        }

        public Color PageColor {
            get { return pageColor; }
            set { pageColor = value; }
        }
    }
}
