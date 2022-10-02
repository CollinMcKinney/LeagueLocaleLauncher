namespace LeagueLocaleLauncher
{
    public static partial class Translation
    {
        private static partial void AddEnglishTranslations()
        {
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
        }
    }
}