using System.Collections.Generic;

//<option value=af>Afrikaans</option><option value=sq>Albanian</option><option value=am>Amharic</option><option value=ar>Arabic</option><option value=hy>Armenian</option><option value=az>Azerbaijani</option><option value=eu>Basque</option><option value=be>Belarusian</option><option value=bn>Bengali</option><option value=bs>Bosnian</option><option value=bg>Bulgarian</option><option value=ca>Catalan</option><option value=ceb>Cebuano</option><option value=ny>Chichewa</option><option value=zh-CN>Chinese (Simplified)</option><option value=zh-TW>Chinese (Traditional)</option><option value=co>Corsican</option><option value=hr>Croatian</option><option value=cs>Czech</option><option value=da>Danish</option><option value=nl>Dutch</option><option value=en>English</option><option value=eo>Esperanto</option><option value=et>Estonian</option><option value=tl>Filipino</option><option value=fi>Finnish</option><option value=fr>French</option><option value=fy>Frisian</option><option value=gl>Galician</option><option value=ka>Georgian</option><option value=de>German</option><option value=el>Greek</option><option value=gu>Gujarati</option><option value=ht>Haitian Creole</option><option value=ha>Hausa</option><option value=haw>Hawaiian</option><option value=iw>Hebrew</option><option value=hi>Hindi</option><option value=hmn>Hmong</option><option value=hu>Hungarian</option><option value=is>Icelandic</option><option value=ig>Igbo</option><option value=id>Indonesian</option><option value=ga>Irish</option><option value=it>Italian</option><option value=ja>Japanese</option><option value=jw>Javanese</option><option value=kn>Kannada</option><option value=kk>Kazakh</option><option value=km>Khmer</option><option value=ko>Korean</option><option value=ku>Kurdish (Kurmanji)</option><option value=ky>Kyrgyz</option><option value=lo>Lao</option><option value=la>Latin</option><option value=lv>Latvian</option><option value=lt>Lithuanian</option><option value=lb>Luxembourgish</option><option value=mk>Macedonian</option><option value=mg>Malagasy</option><option value=ms>Malay</option><option value=ml>Malayalam</option><option value=mt>Maltese</option><option value=mi>Maori</option><option value=mr>Marathi</option><option value=mn>Mongolian</option><option value=my>Myanmar (Burmese)</option><option value=ne>Nepali</option><option value=no>Norwegian</option><option value=ps>Pashto</option><option value=fa>Persian</option><option value=pl>Polish</option><option value=pt>Portuguese</option><option value=pa>Punjabi</option><option value=ro>Romanian</option><option value=ru>Russian</option><option value=sm>Samoan</option><option value=gd>Scots Gaelic</option><option value=sr>Serbian</option><option value=st>Sesotho</option><option value=sn>Shona</option><option value=sd>Sindhi</option><option value=si>Sinhala</option><option value=sk>Slovak</option><option value=sl>Slovenian</option><option value=so>Somali</option><option value=es>Spanish</option><option value=su>Sundanese</option><option value=sw>Swahili</option><option value=sv>Swedish</option><option value=tg>Tajik</option><option value=ta>Tamil</option><option value=te>Telugu</option><option value=th>Thai</option><option value=tr>Turkish</option><option value=uk>Ukrainian</option><option value=ur>Urdu</option><option value=uz>Uzbek</option><option value=vi>Vietnamese</option><option value=cy>Welsh</option><option value=xh>Xhosa</option><option value=yi>Yiddish</option><option value=yo>Yoruba</option><option value=zu>Zulu</option>

namespace ResxTranslator
{    
    /// <summary>
    /// Languanges for translate API.
    /// </summary>
    public sealed class Language : Enumeration<Language>
    {
        /// <summary>
        /// The Unknown. Default value.
        /// </summary>
        public static readonly Language Unknown = new Language("Unknown", string.Empty, true);

        /// <summary>
        /// The Afrikaans.
        /// </summary>
        public static readonly Language Afrikaans = new Language("Afrikaans", "af");

        /// <summary>
        /// The Albanian.
        /// </summary>
        public static readonly Language Albanian = new Language("Albanian", "sq");

        /// <summary>
        /// The Amharic.
        /// </summary>
        public static readonly Language Amharic = new Language("Amharic", "am");

        /// <summary>
        /// The Arabic.
        /// </summary>
        public static readonly Language Arabic = new Language("Arabic", "ar");

        /// <summary>
        /// The Armenian.
        /// </summary>
        public static readonly Language Armenian = new Language("Armenian", "hy");

        /// <summary>
        /// The Azerbaijani.
        /// </summary>
        public static readonly Language Azerbaijani = new Language("Azerbaijani", "az");

        /// <summary>
        /// The Basque.
        /// </summary>
        public static readonly Language Basque = new Language("Basque", "eu");

        /// <summary>
        /// The Belarusian.
        /// </summary>
        public static readonly Language Belarusian = new Language("Belarusian", "be");

        /// <summary>
        /// The Bengali.
        /// </summary>
        public static readonly Language Bengali = new Language("Bengali", "bn");

        /// <summary>
        /// The Bihari.
        /// </summary>
        public static readonly Language Bihari = new Language("Bihari", "bh");

        /// <summary>
        /// The Bulgarian.
        /// </summary>
        public static readonly Language Bulgarian = new Language("Bulgarian", "bg");

        /// <summary>
        /// The Bosnian.
        /// </summary>
        public static readonly Language Bosnian = new Language("Bosnian", "bs");

        /// <summary>
        /// The Burmese.
        /// </summary>
        public static readonly Language Burmese = new Language("Burmese", "my");

        /// <summary>
        /// The Catalan.
        /// </summary>
        public static readonly Language Catalan = new Language("Catalan", "ca");

        /// <summary>
        /// The Cebuano.
        /// </summary>
        public static readonly Language Cebuano = new Language("Cebuano", "ceb");

        /// <summary>
        /// The Chichewa.
        /// </summary>
        public static readonly Language Chichewa = new Language("Chichewa", "ny");

        /// <summary>
        /// The Cherokee.
        /// </summary>
        public static readonly Language Cherokee = new Language("Cherokee", "chr");

        /// <summary>
        /// The Chinese.
        /// </summary>
        public static readonly Language Chinese = new Language("Chinese", "zh");

        /// <summary>
        /// The Simplified Chinese.
        /// </summary>
        public static readonly Language ChineseSimplified = new Language("Simplified Chinese", "zh-CN");

        /// <summary>
        /// The Traditional Chinese.
        /// </summary>
        public static readonly Language ChineseTraditional = new Language("Traditional Chinese", "zh-TW");

        /// <summary>
        /// The Corsican.
        /// </summary>
        public static readonly Language Corsican = new Language("Corsican", "co");

        /// <summary>
        /// The Croatian.
        /// </summary>
        public static readonly Language Croatian = new Language("Croatian", "hr");

        /// <summary>
        /// The Czech.
        /// </summary>
        public static readonly Language Czech = new Language("Czech", "cs");

        /// <summary>
        /// The Danish.
        /// </summary>
        public static readonly Language Danish = new Language("Danish", "da");

        /// <summary>
        /// The Dhivehi.
        /// </summary>
        public static readonly Language Dhivehi = new Language("Dhivehi", "dv");

        /// <summary>
        /// The Dutch.
        /// </summary>
        public static readonly Language Dutch = new Language("Dutch", "nl");

        /// <summary>
        /// The English.
        /// </summary>
        public static readonly Language English = new Language("English", "en");

        /// <summary>
        /// The Esperanto.
        /// </summary>
        public static readonly Language Esperanto = new Language("Esperanto", "eo");

        /// <summary>
        /// The Estonian.
        /// </summary>
        public static readonly Language Estonian = new Language("Estonian", "et");

        /// <summary>
        /// The Filipino.
        /// </summary>
        public static readonly Language Filipino = new Language("Filipino", "tl");

        /// <summary>
        /// The Finnish.
        /// </summary>
        public static readonly Language Finnish = new Language("Finnish", "fi");

        /// <summary>
        /// The Frisian.
        /// </summary>
        public static readonly Language Frisian = new Language("Frisian", "fy");

        /// <summary>
        /// The French.
        /// </summary>
        public static readonly Language French = new Language("French", "fr");

        /// <summary>
        /// The Galician.
        /// </summary>
        public static readonly Language Galician = new Language("Galician", "gl");

        /// <summary>
        /// The Georgian.
        /// </summary>
        public static readonly Language Georgian = new Language("Georgian", "ka");

        /// <summary>
        /// The German.
        /// </summary>
        public static readonly Language German = new Language("German", "de");

        /// <summary>
        /// The Greek.
        /// </summary>
        public static readonly Language Greek = new Language("Greek", "el");

        /// <summary>
        /// The Guarani.
        /// </summary>
        public static readonly Language Guarani = new Language("Guarani", "gn");

        /// <summary>
        /// The Gujarati.
        /// </summary>
        public static readonly Language Gujarati = new Language("Gujarati", "gu");

        /// <summary>
        /// The HaitianCreole.
        /// </summary>
        public static readonly Language HaitianCreole = new Language("HaitianCreole", "ht");

        /// <summary>
        /// The Hausa.
        /// </summary>
        public static readonly Language Hausa = new Language("Hausa", "ha");

        /// <summary>
        /// The Hawaiian.
        /// </summary>
        public static readonly Language Hawaiian = new Language("Hawaiian", "haw");

        /// <summary>
        /// The Hebrew.
        /// </summary>
        public static readonly Language Hebrew = new Language("Hebrew", "iw");

        /// <summary>
        /// The Hindi.
        /// </summary>
        public static readonly Language Hindi = new Language("Hindi", "hi");

        /// <summary>
        /// The Hmong.
        /// </summary>
        public static readonly Language Hmong = new Language("Hmong", "hmn");

        /// <summary>
        /// The Hungarian.
        /// </summary>
        public static readonly Language Hungarian = new Language("Hungarian", "hu");

        /// <summary>
        /// The Icelandic.
        /// </summary>
        public static readonly Language Icelandic = new Language("Icelandic", "is");

        /// <summary>
        /// The Igbo.
        /// </summary>
        public static readonly Language Igbo = new Language("Igbo", "ig");

        /// <summary>
        /// The Indonesian.
        /// </summary>
        public static readonly Language Indonesian = new Language("Indonesian", "id");

        /// <summary>
        /// The Inuktitut.
        /// </summary>
        public static readonly Language Inuktitut = new Language("Inuktitut", "iu");

        /// <summary>
        /// The Irish.
        /// </summary>
        public static readonly Language Irish = new Language("Irish", "ga");

        /// <summary>
        /// The Italian.
        /// </summary>
        public static readonly Language Italian = new Language("Italian", "it");

        /// <summary>
        /// The Japanese.
        /// </summary>
        public static readonly Language Japanese = new Language("Japanese", "ja");

        /// <summary>
        /// The Javanese.
        /// </summary>
        public static readonly Language Javanese = new Language("Javanese", "jw");

        /// <summary>
        /// The Kannada.
        /// </summary>
        public static readonly Language Kannada = new Language("Kannada", "kn");

        /// <summary>
        /// The Kazakh.
        /// </summary>
        public static readonly Language Kazakh = new Language("Kazakh", "kk");

        /// <summary>
        /// The Khmer.
        /// </summary>
        public static readonly Language Khmer = new Language("Khmer", "km");

        /// <summary>
        /// The Korean.
        /// </summary>
        public static readonly Language Korean = new Language("Korean", "ko");

        /// <summary>
        /// The Kurdish.
        /// </summary>
        public static readonly Language Kurdish = new Language("Kurdish", "ku");

        /// <summary>
        /// The Kyrgyz.
        /// </summary>
        public static readonly Language Kyrgyz = new Language("Kyrgyz", "ky");

        /// <summary>
        /// The Laothian.
        /// </summary>
        public static readonly Language Laothian = new Language("Laothian", "lo");

        /// <summary>
        /// The Latin.
        /// </summary>
        public static readonly Language Latin = new Language("Latin", "la");

        /// <summary>
        /// The Latvian.
        /// </summary>
        public static readonly Language Latvian = new Language("Latvian", "lv");

        /// <summary>
        /// The Lithuanian.
        /// </summary>
        public static readonly Language Lithuanian = new Language("Lithuanian", "lt");

        /// <summary>
        /// The Luxembourgish.
        /// </summary>
        public static readonly Language Luxembourgish = new Language("Luxembourgish", "lb");

        /// <summary>
        /// The Macedonian.
        /// </summary>
        public static readonly Language Macedonian = new Language("Macedonian", "mk");

        /// <summary>
        /// The Malagasy.
        /// </summary>
        public static readonly Language Malagasy = new Language("Malagasy", "mg");

        /// <summary>
        /// The Malay.
        /// </summary>
        public static readonly Language Malay = new Language("Malay", "ms");

        /// <summary>
        /// The Malayalam.
        /// </summary>
        public static readonly Language Malayalam = new Language("Malayalam", "ml");

        /// <summary>
        /// The Maltese.
        /// </summary>
        public static readonly Language Maltese = new Language("Maltese", "mt");

        /// <summary>
        /// The Maori.
        /// </summary>
        public static readonly Language Maori = new Language("Maori", "mi");

        /// <summary>
        /// The Marathi.
        /// </summary>
        public static readonly Language Marathi = new Language("Marathi", "mr");

        /// <summary>
        /// The Mongolian.
        /// </summary>
        public static readonly Language Mongolian = new Language("Mongolian", "mn");

        /// <summary>
        /// The MyanmarBurmese.
        /// </summary>
        public static readonly Language MyanmarBurmese = new Language("MyanmarBurmese", "my");

        /// <summary>
        /// The Nepali.
        /// </summary>
        public static readonly Language Nepali = new Language("Nepali", "ne");

        /// <summary>
        /// The Norwegian.
        /// </summary>
        public static readonly Language Norwegian = new Language("Norwegian", "no");

        /// <summary>
        /// The Oriya.
        /// </summary>
        public static readonly Language Oriya = new Language("Oriya", "or");

        /// <summary>
        /// The Pashto.
        /// </summary>
        public static readonly Language Pashto = new Language("Pashto", "ps");

        /// <summary>
        /// The Persian.
        /// </summary>
        public static readonly Language Persian = new Language("Persian", "fa");

        /// <summary>
        /// The Polish.
        /// </summary>
        public static readonly Language Polish = new Language("Polish", "pl");

        /// <summary>
        /// The Portuguese.
        /// </summary>
        public static readonly Language Portuguese = new Language("Portuguese", "pt-PT");

        /// <summary>
        /// The Punjabi.
        /// </summary>
        public static readonly Language Punjabi = new Language("Punjabi", "pa");

        /// <summary>
        /// The Romanian.
        /// </summary>
        public static readonly Language Romanian = new Language("Romanian", "ro");

        /// <summary>
        /// The Russian.
        /// </summary>
        public static readonly Language Russian = new Language("Russian", "ru");

        /// <summary>
        /// The Samoan.
        /// </summary>
        public static readonly Language Samoan = new Language("Samoan", "sm");

        /// <summary>
        /// The Sanskrit.
        /// </summary>
        public static readonly Language Sanskrit = new Language("Sanskrit", "sa");

        /// <summary>
        /// The ScotsGaelic.
        /// </summary>
        public static readonly Language ScotsGaelic = new Language("ScotsGaelic", "gd");

        /// <summary>
        /// The Serbian.
        /// </summary>
        public static readonly Language Serbian = new Language("Serbian", "sr");

        /// <summary>
        /// The Sesotho.
        /// </summary>
        public static readonly Language Sesotho = new Language("Sesotho", "st");

        /// <summary>
        /// The Shona.
        /// </summary>
        public static readonly Language Shona = new Language("Shona", "sn");

        /// <summary>
        /// The Sindhi.
        /// </summary>
        public static readonly Language Sindhi = new Language("Sindhi", "sd");

        /// <summary>
        /// The Sinhala.
        /// </summary>
        public static readonly Language Sinhala = new Language("Sinhala", "si");

        /// <summary>
        /// The Sinhalese.
        /// </summary>
        public static readonly Language Sinhalese = new Language("Sinhalese", "si");

        /// <summary>
        /// The Slovak.
        /// </summary>
        public static readonly Language Slovak = new Language("Slovak", "sk");

        /// <summary>
        /// The Slovenian.
        /// </summary>
        public static readonly Language Slovenian = new Language("Slovenian", "sl");

        /// <summary>
        /// The Somali.
        /// </summary>
        public static readonly Language Somali = new Language("Somali", "so");

        /// <summary>
        /// The Spanish.
        /// </summary>
        public static readonly Language Spanish = new Language("Spanish", "es");

        /// <summary>
        /// The Sundanese.
        /// </summary>
        public static readonly Language Sundanese = new Language("Sundanese", "su");

        /// <summary>
        /// The Swahili.
        /// </summary>
        public static readonly Language Swahili = new Language("Swahili", "sw");

        /// <summary>
        /// The Swedish.
        /// </summary>
        public static readonly Language Swedish = new Language("Swedish", "sv");

        /// <summary>
        /// The Tajik.
        /// </summary>
        public static readonly Language Tajik = new Language("Tajik", "tg");

        /// <summary>
        /// The Tamil.
        /// </summary>
        public static readonly Language Tamil = new Language("Tamil", "ta");

        /// <summary>
        /// The Tagalog.
        /// </summary>
        public static readonly Language Tagalog = new Language("Tagalog", "tl");

        /// <summary>
        /// The Telugu.
        /// </summary>
        public static readonly Language Telugu = new Language("Telugu", "te");

        /// <summary>
        /// The Thai.
        /// </summary>
        public static readonly Language Thai = new Language("Thai", "th");

        /// <summary>
        /// The Tibetan.
        /// </summary>
        public static readonly Language Tibetan = new Language("Tibetan", "bo");

        /// <summary>
        /// The Turkish.
        /// </summary>
        public static readonly Language Turkish = new Language("Turkish", "tr");

        /// <summary>
        /// The Ukrainian.
        /// </summary>
        public static readonly Language Ukrainian = new Language("Ukrainian", "uk");

        /// <summary>
        /// The Urdu.
        /// </summary>
        public static readonly Language Urdu = new Language("Urdu", "ur");

        /// <summary>
        /// The Uzbek.
        /// </summary>
        public static readonly Language Uzbek = new Language("Uzbek", "uz");

        /// <summary>
        /// The Uighur.
        /// </summary>
        public static readonly Language Uighur = new Language("Uighur", "ug");

        /// <summary>
        /// The Vietnamese.
        /// </summary>
        public static readonly Language Vietnamese = new Language("Vietnamese", "vi");

        /// <summary>
        /// The Welsh.
        /// </summary>
        public static readonly Language Welsh = new Language("Welsh", "cy");

        /// <summary>
        /// The Yiddish.
        /// </summary>
        public static readonly Language Yiddish = new Language("Yiddish", "yi");

        /// <summary>
        /// The Yoruba.
        /// </summary>
        public static readonly Language Yoruba = new Language("Yoruba", "yo");

        /// <summary>
        /// The Zulu.
        /// </summary>
        public static readonly Language Zulu = new Language("Zulu", "zu");

        private static readonly ICollection<Language> translatableList = new[]
                {
                    Afrikaans,
                    Amharic,
                    Albanian,
                    Arabic,
                    Armenian,
                    Azerbaijani,
                    Basque,
                    Belarusian,
                    Bengali,
                    Bosnian,
                    Bulgarian,
                    Cebuano,
                    Chichewa,
                    ChineseSimplified,
                    ChineseTraditional,
                    Catalan,
                    Corsican,
                    Croatian,
                    Czech,
                    Danish,
                    Dutch,
                    English,
                    Esperanto,
                    Estonian,
                    Filipino,
                    Finnish,
                    French,
                    Frisian,
                    Galician,
                    Georgian,
                    German,
                    Greek,
                    Gujarati,
                    HaitianCreole,
                    Hausa,
                    Hawaiian,
                    Hebrew,
                    Hindi,
                    Hmong,
                    Hungarian,
                    Icelandic,
                    Igbo,
                    Indonesian,
                    Irish,
                    Italian,
                    Japanese,
                    Javanese,
                    Kannada,
                    Kazakh,
                    Khmer,
                    Korean,
                    Kurdish,
                    Kyrgyz,
                    Latin,
                    Latvian,
                    Lithuanian,
                    Luxembourgish,
                    Macedonian,
                    Malagasy,
                    Malay,
                    Malayalam,
                    Maltese,
                    Maori,
                    Marathi,
                    MyanmarBurmese,
                    Nepali,
                    Norwegian,
                    Pashto,
                    Persian,
                    Polish,
                    Portuguese,
                    Punjabi,
                    Romanian,
                    Russian,
                    Samoan,
                    ScotsGaelic,
                    Sesotho,
                    Shona,
                    Sindhi,
                    Sinhala,
                    Spanish,
                    Serbian,
                    Slovak,
                    Slovenian,
                    Somali,
                    Sundanese,
                    Swahili,
                    Swedish,
                    Tajik,
                    Tamil,
                    Telugu,
                    Thai,
                    Turkish,
                    Ukrainian,
                    Urdu,
                    Uzbek,
                    Vietnamese,
                    Welsh,
                    Yiddish,
                    Yoruba,
                    Zulu
                };

        private Language(string value)
            : base(value)
        {
        }

        private Language(string name, string value)
            : base(name, value)
        {
        }

        private Language(string name, string value, bool isDefault)
            : base(name, value, isDefault)
        {
        }

        /// <summary>
        /// Gets translatable language collection.
        /// </summary>
        public static ICollection<Language> TranslatableCollection
        {
            get
            {
                return translatableList;
            }
        }

        /// <summary>
        /// Gets a value indicating whether this language is translatable.
        /// </summary>
        /// <value>
        ///     <c>true</c> if this language is translatable; otherwise, <c>false</c>.
        /// </value>
        public bool IsTranslatable
        {
            get
            {
                return TranslatableCollection.Contains(this);
            }
        }

        /// <summary>
        /// Performs an implicit conversion from <see cref="System.String"/> to <see cref="Google.API.Translate.Language"/>.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>The result of the conversion.</returns>
        public static implicit operator Language(string value)
        {
            return Convert(value, s => new Language(s));
        }
    }
}