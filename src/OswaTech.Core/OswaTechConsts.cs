using OswaTech.Debugging;

namespace OswaTech
{
    public class OswaTechConsts
    {
        public const string LocalizationSourceName = "OswaTech";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e51b96ed38d344cca4c6b22a61628419";
    }
}
