using System.Collections.Generic;

namespace LeagueLocaleLauncher
{
    // TODO: check what regions are actually supported, remove the rest
    public enum Region
    {
        BR,
        EUNE,
        EUW,
        JP,
        KR, // doesn't work
        LA1,
        LA2,
        NA,
        OC1,
        PBE, // doesn't work
        RU,
        TR,
    }

    public enum Language
    {
        CZECH_CZECH_REPUBLIC,
        GERMAN_GERMANY,
        GREEK_GREECE,
        ENGLISH_AUSTRALIA,
        ENGLISH_UNITED_KINGDOM,
        ENGLISH_UNITED_STATES,
        SPANISH_SPAIN,
        SPANISH_MEXICO,
        FRENCH_FRANCE,
        HUNGARIAN_HUNGARY,
        ITALIAN_ITALY,
        JAPANESE_JAPAN,
        KOREAN_KOREA,
        POLISH_POLAND,
        PORTUGUESE_BRAZIL,
        ROMANIAN_ROMANIA,
        RUSSIAN_RUSSIA,
        TURKISH_TURKEY,
    }

    public static class Enumerations
    {
        public static Dictionary<Language, string> Languages = new Dictionary<Language, string>
        {
            { Language.CZECH_CZECH_REPUBLIC,    "cs_CZ"},
            { Language.GERMAN_GERMANY,          "de_DE"},
            { Language.GREEK_GREECE,            "el_GR"},
            { Language.ENGLISH_AUSTRALIA,       "en_AU"},
            { Language.ENGLISH_UNITED_KINGDOM,  "en_GB"},
            { Language.ENGLISH_UNITED_STATES,   "en_US"},
            { Language.SPANISH_SPAIN,           "es_ES"},
            { Language.SPANISH_MEXICO,          "es_MX"},
            { Language.FRENCH_FRANCE,           "fr_FR"},
            { Language.HUNGARIAN_HUNGARY,       "hu_HU"},
            { Language.ITALIAN_ITALY,           "it_IT"},
            { Language.JAPANESE_JAPAN,          "ja_JP"},
            { Language.KOREAN_KOREA,            "ko_KR"},
            { Language.POLISH_POLAND,           "pl_PL"},
            { Language.PORTUGUESE_BRAZIL,       "pt_BR"},
            { Language.ROMANIAN_ROMANIA,        "ro_RO"},
            { Language.RUSSIAN_RUSSIA,          "ru_RU"},
            { Language.TURKISH_TURKEY,          "tr_TR"}
        };
    }
}
