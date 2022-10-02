using System.Collections.Generic;
using System.Globalization;

namespace LeagueLocaleLauncher
{
    public static partial class Translation
    {
        private readonly static Dictionary<string, Dictionary<int, string>> CulturalDictionary = new Dictionary<string, Dictionary<int, string>> { };

        public static void Add(CultureInfo cultureInfo, string word, string translation)
        {
            word = word.ToUpperInvariant();

            if (!CulturalDictionary.ContainsKey(word))
                CulturalDictionary[word] = new Dictionary<int, string> { };

            CulturalDictionary[word][cultureInfo.LCID] = translation;
        }

        public static string Translate(string word)
        {
            word = word.ToUpperInvariant();
            if (CulturalDictionary.TryGetValue(word, out Dictionary<int, string> translations))
            {
                if (translations.TryGetValue(CultureInfo.CurrentCulture.LCID, out string translation))
                    return translation;
                else
                {
                    //throw new WarningException($"No translation of `{word}` available for `{cultureInfo.DisplayName}`. Falling back to `{new CultureInfo("en-US").DisplayName}`");
                    if (translations.TryGetValue(new CultureInfo("en").LCID, out translation))
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
        public const string CHINESE_CHINESE_SIMPLIFIED = nameof(Language.CHINESE_SIMPLIFIED);
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

        private static partial void AddEnglishTranslations();
        private static partial void AddGermanTranslations();
        private static partial void AddSpanishTranslations();

        static Translation()
        {
            AddEnglishTranslations();
            AddGermanTranslations();
            AddSpanishTranslations();
        }
    }
}
