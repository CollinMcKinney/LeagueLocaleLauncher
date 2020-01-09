using System.Collections.Generic;
using System.Globalization;

namespace LeagueLocaleLauncher
{
    public static class Translation
    {
        public static Dictionary<string, Dictionary<int, string>> Translations = new Dictionary<string, Dictionary<int, string>> { };

        public static void Add(CultureInfo cultureInfo, string word, string translation)
        {
            word = word.ToUpperInvariant();

            if (!Translations.ContainsKey(word))
                Translations[word] = new Dictionary<int, string> { };

            Translations[word][cultureInfo.LCID] = translation;
        }

        public static string Translate(CultureInfo cultureInfo, string word)
        {
            word = word.ToUpperInvariant();
            if (Translations.TryGetValue(word, out Dictionary<int, string> median))
            {
                if (median.TryGetValue(cultureInfo.LCID, out string translation))
                    return translation;
                else
                {
                    //throw new WarningException($"No translation of `{word}` available for `{cultureInfo.DisplayName}`. Falling back to `{new CultureInfo("en-US").DisplayName}`");
                    if (median.TryGetValue(new CultureInfo("en-US").LCID, out translation))
                        return translation;
                }
            }

            //throw new WarningException($"`{word}` not recognized as translateable. Falling back to the input word ({word}).");
            return word;
        }

        // TODO: check what regions are actually supported, remove the rest
        public const string REGION = nameof(REGION);
        public const string BR = nameof(Region.BR);
        public const string EUNE = nameof(Region.EUNE);
        public const string EUW = nameof(Region.EUW);
        public const string JP = nameof(Region.JP);
        public const string KR = nameof(Region.KR);
        public const string LA1 = nameof(Region.LA1);
        public const string LA2 = nameof(Region.LA2);
        public const string NA = nameof(Region.NA);
        public const string OC1 = nameof(Region.OC1);
        public const string PBE = nameof(Region.PBE);
        public const string RU = nameof(Region.RU);
        public const string TR = nameof(Region.TR);
       
        public const string LANGUAGE = nameof(LANGUAGE);
        public const string CZECH_CZECH_REPUBLIC = nameof(Language.CZECH_CZECH_REPUBLIC);
        public const string GERMAN_GERMANY = nameof(Language.GERMAN_GERMANY);
        public const string GREEK_GREECE = nameof(Language.GREEK_GREECE);
        public const string ENGLISH_AUSTRALIA = nameof(Language.ENGLISH_AUSTRALIA);
        public const string ENGLISH_UNITED_KINGDOM = nameof(Language.ENGLISH_UNITED_KINGDOM);
        public const string ENGLISH_UNITED_STATES = nameof(Language.ENGLISH_UNITED_STATES);
        public const string SPANISH_SPAIN = nameof(Language.SPANISH_SPAIN);
        public const string SPANISH_MEXICO = nameof(Language.SPANISH_MEXICO);
        public const string FRENCH_FRANCE = nameof(Language.FRENCH_FRANCE);
        public const string HUNGARIAN_HUNGARY = nameof(Language.HUNGARIAN_HUNGARY);
        public const string ITALIAN_ITALY = nameof(Language.ITALIAN_ITALY);
        public const string JAPANESE_JAPAN = nameof(Language.JAPANESE_JAPAN);
        public const string KOREAN_KOREA = nameof(Language.KOREAN_KOREA);
        public const string POLISH_POLAND = nameof(Language.POLISH_POLAND);
        public const string PORTUGUESE_BRAZIL = nameof(Language.PORTUGUESE_BRAZIL);
        public const string ROMANIAN_ROMANIA = nameof(Language.ROMANIAN_ROMANIA);
        public const string RUSSIAN_RUSSIA = nameof(Language.RUSSIAN_RUSSIA);
        public const string TURKISH_TURKEY = nameof(Language.TURKISH_TURKEY);
        
        public const string MINIMIZE_TT = nameof(MINIMIZE_TT);
        public const string CLOSE_TT = nameof(CLOSE_TT);
        public const string REGION_TT = nameof(REGION_TT);
        public const string LANGUAGE_TT = nameof(LANGUAGE_TT);
        public const string LAUNCH_TT = nameof(LAUNCH_TT);


        static Translation()
        {
            #region ENGLISH (UNITED STATES)
            var en_US = new CultureInfo("en-US");
            Add(en_US, REGION, "REGION");
            Add(en_US, BR, "Brazil");
            Add(en_US, EUNE, "EU Nordic and East");
            Add(en_US, EUW, "EU West");
            Add(en_US, JP, "Japan");
            Add(en_US, KR, "Korea");
            Add(en_US, LA1, "Latin America North");
            Add(en_US, LA2, "Latin America South");
            Add(en_US, NA, "North America");
            Add(en_US, OC1, "Oceania");
            Add(en_US, PBE, "PBE");
            Add(en_US, RU, "Russia");
            Add(en_US, TR, "Turkey");

            Add(en_US, LANGUAGE, "LANGUAGE");
            Add(en_US, CZECH_CZECH_REPUBLIC, "Czech (Czech Republic)");
            Add(en_US, GERMAN_GERMANY, "German (Germany)");
            Add(en_US, GREEK_GREECE, "Greek (Greece)");
            Add(en_US, ENGLISH_AUSTRALIA, "English (Australia)");
            Add(en_US, ENGLISH_UNITED_KINGDOM, "English (United Kingdom)");
            Add(en_US, ENGLISH_UNITED_STATES, "English (United States)");
            Add(en_US, SPANISH_SPAIN, "Spanish (Spain)");
            Add(en_US, SPANISH_MEXICO, "Spanish (Mexico)");
            Add(en_US, FRENCH_FRANCE, "French (France)");
            Add(en_US, HUNGARIAN_HUNGARY, "Hungarian (Hungary)");
            Add(en_US, ITALIAN_ITALY, "Italian (Italy)");
            Add(en_US, JAPANESE_JAPAN, "Japanese (Japan)");
            Add(en_US, KOREAN_KOREA, "Korean (Korea)");
            Add(en_US, POLISH_POLAND, "Polish (Poland)");
            Add(en_US, PORTUGUESE_BRAZIL, "Portuguese (Brazil)");
            Add(en_US, ROMANIAN_ROMANIA, "Romanian (Romania)");
            Add(en_US, RUSSIAN_RUSSIA, "Russian (Russia)");
            Add(en_US, TURKISH_TURKEY, "Turkish (Turkey)");

            Add(en_US, MINIMIZE_TT, "Minimize");
            Add(en_US, CLOSE_TT, "Close");
            Add(en_US, REGION_TT, "Select the region you want to play in");
            Add(en_US, LANGUAGE_TT, "Select the language you want the game to use");
            Add(en_US, LAUNCH_TT, "Launch the game with the specified settings");
            #endregion
        }
    }
}
