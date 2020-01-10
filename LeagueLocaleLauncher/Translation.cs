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

        public static string Translate(string word)
        {
            word = word.ToUpperInvariant();
            if (Translations.TryGetValue(word, out Dictionary<int, string> median))
            {
                if (median.TryGetValue(CultureInfo.CurrentCulture.LCID, out string translation))
                    return translation;
                else
                {
                    //throw new WarningException($"No translation of `{word}` available for `{cultureInfo.DisplayName}`. Falling back to `{new CultureInfo("en-US").DisplayName}`");
                    if (median.TryGetValue(new CultureInfo("en").LCID, out translation))
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


        static Translation()
        {
            #region ENGLISH
            var en = new CultureInfo("en");
            Add(en, REGION, "REGION");
            Add(en, BR, "Brazil");
            Add(en, EUNE, "EU Nordic and East");
            Add(en, EUW, "EU West");
            Add(en, JP, "Japan");
            Add(en, KR, "Korea");
            Add(en, LA1, "Latin America North");
            Add(en, LA2, "Latin America South");
            Add(en, NA, "North America");
            Add(en, OC1, "Oceania");
            Add(en, PBE, "PBE");
            Add(en, RU, "Russia");
            Add(en, TR, "Turkey");

            Add(en, LANGUAGE, "LANGUAGE");
            Add(en, CHINESE_CHINESE_SIMPLIFIED, "Chinese (Simplified)");
            Add(en, CZECH_CZECH_REPUBLIC, "Czech (Czech Republic)");
            Add(en, GERMAN_GERMANY, "German (Germany)");
            Add(en, GREEK_GREECE, "Greek (Greece)");
            Add(en, ENGLISH_AUSTRALIA, "English (Australia)");
            Add(en, ENGLISH_UNITED_KINGDOM, "English (United Kingdom)");
            Add(en, ENGLISH_UNITED_STATES, "English (United States)");
            Add(en, SPANISH_SPAIN, "Spanish (Spain)");
            Add(en, SPANISH_MEXICO, "Spanish (Mexico)");
            Add(en, FRENCH_FRANCE, "French (France)");
            Add(en, HUNGARIAN_HUNGARY, "Hungarian (Hungary)");
            Add(en, ITALIAN_ITALY, "Italian (Italy)");
            Add(en, JAPANESE_JAPAN, "Japanese (Japan)");
            Add(en, KOREAN_KOREA, "Korean (Korea)");
            Add(en, POLISH_POLAND, "Polish (Poland)");
            Add(en, PORTUGUESE_BRAZIL, "Portuguese (Brazil)");
            Add(en, ROMANIAN_ROMANIA, "Romanian (Romania)");
            Add(en, RUSSIAN_RUSSIA, "Russian (Russia)");
            Add(en, TURKISH_TURKEY, "Turkish (Turkey)");

            Add(en, MINIMIZE_TT, "Minimize");
            Add(en, CLOSE_TT, "Close");
            Add(en, REGION_TT, "Select the region you want to play in");
            Add(en, LANGUAGE_TT, "Select the language you want the game to use");
            Add(en, LAUNCH_TT, "Launch the game with the specified settings");
            #endregion

            #region SPANISH
            var es = new CultureInfo("es");
            Add(es, REGION, "REGIÓN");
            Add(es, BR, "Brasil");
            Add(es, EUNE, "EU Norte y Este");
            Add(es, EUW, "EU Oeste");
            Add(es, JP, "Japón");
            Add(es, KR, "Corea");
            Add(es, LA1, "Latinoamérica Norte");
            Add(es, LA2, "Latinoamérica Sur");
            Add(es, NA, "Norteamérica ");
            Add(es, OC1, "Oceanía");
            Add(es, PBE, "BETA");
            Add(es, RU, "Rusia");
            Add(es, TR, "Turquía");

            Add(es, LANGUAGE, "IDIOMA");
            Add(es, CHINESE_CHINESE_SIMPLIFIED, "Chino (Simplificado)");
            Add(es, CZECH_CZECH_REPUBLIC, "Checo (República Checa)");
            Add(es, GERMAN_GERMANY, "Alemán (Alemania)");
            Add(es, GREEK_GREECE, "Griego (Grecia)");
            Add(es, ENGLISH_AUSTRALIA, "Inglés(Australia)");
            Add(es, ENGLISH_UNITED_KINGDOM, "Inglés (Reino Unido)");
            Add(es, ENGLISH_UNITED_STATES, "Inglés (Estados Unidos)");
            Add(es, SPANISH_SPAIN, "Español (España)");
            Add(es, SPANISH_MEXICO, "Español (Mexico)");
            Add(es, FRENCH_FRANCE, "Francés (Francia)");
            Add(es, HUNGARIAN_HUNGARY, "Húngaro (Hungría)");
            Add(es, ITALIAN_ITALY, "Italiano (Italia)");
            Add(es, JAPANESE_JAPAN, "Japonés (Japón)");
            Add(es, KOREAN_KOREA, "Coreano(Corea)");
            Add(es, POLISH_POLAND, "Polaco(Polonia)");
            Add(es, PORTUGUESE_BRAZIL, "Portugués (Brasil)");
            Add(es, ROMANIAN_ROMANIA, "Rumano (Rumania)");
            Add(es, RUSSIAN_RUSSIA, "Ruso (Rusia)");
            Add(es, TURKISH_TURKEY, "Turco (Turquía)");

            Add(es, MINIMIZE_TT, "Minimiza");
            Add(es, CLOSE_TT, "Cerca");
            Add(es, REGION_TT, "Selecciona la región en la que quieres jugar");
            Add(es, LANGUAGE_TT, "Selecciona el idioma que quieres que use el juego");
            Add(es, LAUNCH_TT, "Inicia el juego con la configuración especificada");
            #endregion
        }
    }
}
