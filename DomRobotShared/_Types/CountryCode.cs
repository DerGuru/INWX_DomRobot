using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomRobot
{
    public class Country
    {
        public enum Code
        {
            CW,
            SX,
            BQ,
            AF,
            AX,
            AL,
            DZ,
            AS,
            AD,
            AO,
            AI,
            AQ,
            AG,
            AR,
            AM,
            AW,
            AC,
            AU,
            AT,
            AZ,
            BS,
            BH,
            BD,
            BB,
            BY,
            BE,
            BZ,
            BJ,
            BM,
            BT,
            BO,
            BA,
            BW,
            BV,
            BR,
            IO,
            BN,
            BG,
            BF,
            BI,
            KH,
            CM,
            CA,
            CV,
            KY,
            CF,
            TD,
            CL,
            CN,
            CX,
            CC,
            CO,
            KM,
            CG,
            CD,
            CK,
            CR,
            CI,
            HR,
            CU,
            CY,
            CZ,
            DK,
            DJ,
            DM,
            DO,
            EC,
            EG,
            SV,
            GQ,
            ER,
            EE,
            ET,
            FK,
            FO,
            FJ,
            FI,
            FR,
            GF,
            PF,
            TF,
            GA,
            GM,
            GE,
            DE,
            GH,
            GI,
            GR,
            GL,
            GD,
            GP,
            GU,
            GT,
            GG,
            GN,
            GW,
            GY,
            HT,
            HM,
            VA,
            HN,
            HK,
            HU,
            IS,
            IN,
            ID,
            IR,
            IQ,
            IE,
            IM,
            IL,
            IT,
            JM,
            JP,
            JE,
            JO,
            KZ,
            KE,
            KI,
            KP,
            KR,
            KW,
            KG,
            LA,
            LV,
            LB,
            LS,
            LR,
            LY,
            LI,
            LT,
            LU,
            MO,
            MK,
            MG,
            MW,
            MY,
            MV,
            ML,
            MT,
            MH,
            MQ,
            MR,
            MU,
            YT,
            MX,
            FM,
            MD,
            MC,
            MN,
            ME,
            MS,
            MA,
            MZ,
            MM,
            NA,
            NR,
            NP,
            NL,
            NC,
            NZ,
            NI,
            NE,
            NG,
            NU,
            NF,
            MP,
            NO,
            OM,
            PK,
            PW,
            PS,
            PA,
            PG,
            PY,
            PE,
            PH,
            PN,
            PL,
            PT,
            PR,
            QA,
            RE,
            RO,
            RU,
            RW,
            BL,
            SH,
            KN,
            LC,
            MF,
            PM,
            VC,
            WS,
            SM,
            ST,
            SA,
            SN,
            RS,
            SC,
            SL,
            SG,
            SK,
            SI,
            SB,
            SO,
            ZA,
            GS,
            ES,
            LK,
            SD,
            SR,
            SJ,
            SZ,
            SE,
            CH,
            SY,
            TW,
            TJ,
            TZ,
            TH,
            TL,
            TG,
            TK,
            TO,
            TT,
            TN,
            TR,
            TM,
            TC,
            TV,
            UG,
            UA,
            AE,
            GB,
            US,
            UM,
            UY,
            UZ,
            VU,
            VE,
            VN,
            VG,
            VI,
            WO,
            WF,
            EH,
            YE,
            ZM,
            ZW
        }
        public static Dictionary<string, Code> LandCodeMapping { get; } = InitLandCodeMapping();

        private static Dictionary<string, Code> InitLandCodeMapping()
        {
            var dic = new Dictionary<string, Code>();
            Type t = typeof(Country);
            foreach (var prop in t.GetProperties(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).Where(x => x.PropertyType == typeof(String)))
            {
                dic[prop.Name] = (Code)prop.GetValue(null);
            }
            return dic;
        }

        public static Dictionary<Code, string> CodeLandMapping { get; } = InitCodeLandMapping();

        private static Dictionary<Code, string> InitCodeLandMapping()
        {
            var dic = new Dictionary<Code, string>();
            Type t = typeof(Country);
            foreach (var prop in t.GetProperties(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).Where(x => x.PropertyType == typeof(String)))
            {
                var value = (Code)prop.GetValue(null);
                dic[value] = prop.Name;
            }
            return dic;
        }

        public static Code CURAÇAO => Code.CW;
        public static Code SINT_MAARTEN => Code.SX;
        public static Code BONAIRE_SINT_EUSTATIUS_AND_SABA => Code.BQ;
        public static Code AFGHANISTAN => Code.AF;
        public static Code ALAND_ISLANDS => Code.AX;
        public static Code ALBANIA => Code.AL;
        public static Code ALGERIA => Code.DZ;
        public static Code AMERICAN_SAMOA => Code.AS;
        public static Code ANDORRA => Code.AD;
        public static Code ANGOLA => Code.AO;
        public static Code ANGUILLA => Code.AI;
        public static Code ANTARCTICA => Code.AQ;
        public static Code ANTIGUA_AND_BARBUDA => Code.AG;
        public static Code ARGENTINA => Code.AR;
        public static Code ARMENIA => Code.AM;
        public static Code ARUBA => Code.AW;
        public static Code ASCENSION_ISLAND => Code.AC;
        public static Code AUSTRALIA => Code.AU;
        public static Code AUSTRIA => Code.AT;
        public static Code AZERBAIJAN => Code.AZ;
        public static Code BAHAMAS => Code.BS;
        public static Code BAHRAIN => Code.BH;
        public static Code BANGLADESH => Code.BD;
        public static Code BARBADOS => Code.BB;
        public static Code BELARUS => Code.BY;
        public static Code BELGIUM => Code.BE;
        public static Code BELIZE => Code.BZ;
        public static Code BENIN => Code.BJ;
        public static Code BERMUDA => Code.BM;
        public static Code BHUTAN => Code.BT;
        public static Code BOLIVIA => Code.BO;
        public static Code BOSNIA_AND_HERZEGOVINA => Code.BA;
        public static Code BOTSWANA => Code.BW;
        public static Code BOUVET_ISLAND => Code.BV;
        public static Code BRAZIL => Code.BR;
        public static Code BRITISH_INDIAN_OCEAN_TERRITORY => Code.IO;
        public static Code BRUNEI_DARUSSALAM => Code.BN;
        public static Code BULGARIA => Code.BG;
        public static Code BURKINA_FASO => Code.BF;
        public static Code BURUNDI => Code.BI;
        public static Code CAMBODIA => Code.KH;
        public static Code CAMEROON => Code.CM;
        public static Code CANADA => Code.CA;
        public static Code CAPE_VERDE => Code.CV;
        public static Code CAYMAN_ISLANDS => Code.KY;
        public static Code CENTRAL_AFRICAN_REPUBLIC => Code.CF;
        public static Code CHAD => Code.TD;
        public static Code CHILE => Code.CL;
        public static Code CHINA => Code.CN;
        public static Code CHRISTMAS_ISLAND => Code.CX;
        public static Code COCOS_KEELING_ISLANDS => Code.CC;
        public static Code COLOMBIA => Code.CO;
        public static Code COMOROS => Code.KM;
        public static Code CONGO => Code.CG;
        public static Code CONGO_THE_DEMOCRATIC_REPUBLIC_OF_THE => Code.CD;
        public static Code COOK_ISLANDS => Code.CK;
        public static Code COSTA_RICA => Code.CR;
        public static Code COTE_D_IVOIRE => Code.CI;
        public static Code CROATIA => Code.HR;
        public static Code CUBA => Code.CU;
        public static Code CYPRUS => Code.CY;
        public static Code CZECH_REPUBLIC => Code.CZ;
        public static Code DENMARK => Code.DK;
        public static Code DJIBOUTI => Code.DJ;
        public static Code DOMINICA => Code.DM;
        public static Code DOMINICAN_REPUBLIC => Code.DO;
        public static Code ECUADOR => Code.EC;
        public static Code EGYPT => Code.EG;
        public static Code EL_SALVADOR => Code.SV;
        public static Code EQUATORIAL_GUINEA => Code.GQ;
        public static Code ERITREA => Code.ER;
        public static Code ESTONIA => Code.EE;
        public static Code ETHIOPIA => Code.ET;
        public static Code FALKLAND_ISLANDS_MALVINAS => Code.FK;
        public static Code FAROE_ISLANDS => Code.FO;
        public static Code FIJI => Code.FJ;
        public static Code FINLAND => Code.FI;
        public static Code FRANCE => Code.FR;
        public static Code FRENCH_GUIANA => Code.GF;
        public static Code FRENCH_POLYNESIA => Code.PF;
        public static Code FRENCH_SOUTHERN_TERRITORIES => Code.TF;
        public static Code GABON => Code.GA;
        public static Code GAMBIA => Code.GM;
        public static Code GEORGIA => Code.GE;
        public static Code GERMANY => Code.DE;
        public static Code GHANA => Code.GH;
        public static Code GIBRALTAR => Code.GI;
        public static Code GREECE => Code.GR;
        public static Code GREENLAND => Code.GL;
        public static Code GRENADA => Code.GD;
        public static Code GUADELOUPE => Code.GP;
        public static Code GUAM => Code.GU;
        public static Code GUATEMALA => Code.GT;
        public static Code GUERNSEY => Code.GG;
        public static Code GUINEA => Code.GN;
        public static Code GUINEA_BISSAU => Code.GW;
        public static Code GUYANA => Code.GY;
        public static Code HAITI => Code.HT;
        public static Code HEARD_ISLAND_AND_MCDONALD_ISLANDS => Code.HM;
        public static Code HOLY_SEE_VATICAN_CITY_STATE => Code.VA;
        public static Code HONDURAS => Code.HN;
        public static Code HONG_KONG => Code.HK;
        public static Code HUNGARY => Code.HU;
        public static Code ICELAND => Code.IS;
        public static Code INDIA => Code.IN;
        public static Code INDONESIA => Code.ID;
        public static Code IRAN_ISLAMIC_REPUBLIC_OF => Code.IR;
        public static Code IRAQ => Code.IQ;
        public static Code IRELAND => Code.IE;
        public static Code ISLE_OF_MAN => Code.IM;
        public static Code ISRAEL => Code.IL;
        public static Code ITALY => Code.IT;
        public static Code JAMAICA => Code.JM;
        public static Code JAPAN => Code.JP;
        public static Code JERSEY => Code.JE;
        public static Code JORDAN => Code.JO;
        public static Code KAZAKHSTAN => Code.KZ;
        public static Code KENYA => Code.KE;
        public static Code KIRIBATI => Code.KI;
        public static Code KOREA_DEMOCRATIC_PEOPLES_REPUBLIC_OF => Code.KP;
        public static Code KOREA_REPUBLIC_OF => Code.KR;
        public static Code KUWAIT => Code.KW;
        public static Code KYRGYZSTAN => Code.KG;
        public static Code LAO_PEOPLES_DEMOCRATIC_REPUBLIC => Code.LA;
        public static Code LATVIA => Code.LV;
        public static Code LEBANON => Code.LB;
        public static Code LESOTHO => Code.LS;
        public static Code LIBERIA => Code.LR;
        public static Code LIBYAN_ARAB_JAMAHIRIYA => Code.LY;
        public static Code LIECHTENSTEIN => Code.LI;
        public static Code LITHUANIA => Code.LT;
        public static Code LUXEMBOURG => Code.LU;
        public static Code MACAO => Code.MO;
        public static Code MACEDONIA_THE_FORMER_YUGOSLAV_REPUBLIC_OF => Code.MK;
        public static Code MADAGASCAR => Code.MG;
        public static Code MALAWI => Code.MW;
        public static Code MALAYSIA => Code.MY;
        public static Code MALDIVES => Code.MV;
        public static Code MALI => Code.ML;
        public static Code MALTA => Code.MT;
        public static Code MARSHALL_ISLANDS => Code.MH;
        public static Code MARTINIQUE => Code.MQ;
        public static Code MAURITANIA => Code.MR;
        public static Code MAURITIUS => Code.MU;
        public static Code MAYOTTE => Code.YT;
        public static Code MEXICO => Code.MX;
        public static Code MICRONESIA_FEDERATED_STATES_OF => Code.FM;
        public static Code MOLDOVA_REPUBLIC_OF => Code.MD;
        public static Code MONACO => Code.MC;
        public static Code MONGOLIA => Code.MN;
        public static Code MONTENEGRO => Code.ME;
        public static Code MONTSERRAT => Code.MS;
        public static Code MOROCCO => Code.MA;
        public static Code MOZAMBIQUE => Code.MZ;
        public static Code MYANMAR => Code.MM;
        public static Code NAMIBIA => Code.NA;
        public static Code NAURU => Code.NR;
        public static Code NEPAL => Code.NP;
        public static Code NETHERLANDS => Code.NL;
        public static Code NEW_CALEDONIA => Code.NC;
        public static Code NEW_ZEALAND => Code.NZ;
        public static Code NICARAGUA => Code.NI;
        public static Code NIGER => Code.NE;
        public static Code NIGERIA => Code.NG;
        public static Code NIUE => Code.NU;
        public static Code NORFOLK_ISLAND => Code.NF;
        public static Code NORTHERN_MARIANA_ISLANDS => Code.MP;
        public static Code NORWAY => Code.NO;
        public static Code OMAN => Code.OM;
        public static Code PAKISTAN => Code.PK;
        public static Code PALAU => Code.PW;
        public static Code PALESTINIAN_TERRITORY_OCCUPIED => Code.PS;
        public static Code PANAMA => Code.PA;
        public static Code PAPUA_NEW_GUINEA => Code.PG;
        public static Code PARAGUAY => Code.PY;
        public static Code PERU => Code.PE;
        public static Code PHILIPPINES => Code.PH;
        public static Code PITCAIRN => Code.PN;
        public static Code POLAND => Code.PL;
        public static Code PORTUGAL => Code.PT;
        public static Code PUERTO_RICO => Code.PR;
        public static Code QATAR => Code.QA;
        public static Code REUNION => Code.RE;
        public static Code ROMANIA => Code.RO;
        public static Code RUSSIAN_FEDERATION => Code.RU;
        public static Code RWANDA => Code.RW;
        public static Code SAINT_BARTHELEMY => Code.BL;
        public static Code SAINT_HELENA => Code.SH;
        public static Code SAINT_KITTS_AND_NEVIS => Code.KN;
        public static Code SAINT_LUCIA => Code.LC;
        public static Code SAINT_MARTIN => Code.MF;
        public static Code SAINT_PIERRE_AND_MIQUELON => Code.PM;
        public static Code SAINT_VINCENT_AND_THE_GRENADINES => Code.VC;
        public static Code SAMOA => Code.WS;
        public static Code SAN_MARINO => Code.SM;
        public static Code SAO_TOME_AND_PRINCIPE => Code.ST;
        public static Code SAUDI_ARABIA => Code.SA;
        public static Code SENEGAL => Code.SN;
        public static Code SERBIA => Code.RS;
        public static Code SEYCHELLES => Code.SC;
        public static Code SIERRA_LEONE => Code.SL;
        public static Code SINGAPORE => Code.SG;
        public static Code SLOVAKIA => Code.SK;
        public static Code SLOVENIA => Code.SI;
        public static Code SOLOMON_ISLANDS => Code.SB;
        public static Code SOMALIA => Code.SO;
        public static Code SOUTH_AFRICA => Code.ZA;
        public static Code SOUTH_GEORGIA_AND_THE_SOUTH_SANDWICH_ISLANDS => Code.GS;
        public static Code SPAIN => Code.ES;
        public static Code SRI_LANKA => Code.LK;
        public static Code SUDAN => Code.SD;
        public static Code SURINAME => Code.SR;
        public static Code SVALBARD_AND_JAN_MAYEN => Code.SJ;
        public static Code SWAZILAND => Code.SZ;
        public static Code SWEDEN => Code.SE;
        public static Code SWITZERLAND => Code.CH;
        public static Code SYRIAN_ARAB_REPUBLIC => Code.SY;
        public static Code TAIWAN_PROVINCE_OF_CHINA => Code.TW;
        public static Code TAJIKISTAN => Code.TJ;
        public static Code TANZANIA_UNITED_REPUBLIC_OF => Code.TZ;
        public static Code THAILAND => Code.TH;
        public static Code TIMOR_LESTE => Code.TL;
        public static Code TOGO => Code.TG;
        public static Code TOKELAU => Code.TK;
        public static Code TONGA => Code.TO;
        public static Code TRINIDAD_AND_TOBAGO => Code.TT;
        public static Code TUNISIA => Code.TN;
        public static Code TURKEY => Code.TR;
        public static Code TURKMENISTAN => Code.TM;
        public static Code TURKS_AND_CAICOS_ISLANDS => Code.TC;
        public static Code TUVALU => Code.TV;
        public static Code UGANDA => Code.UG;
        public static Code UKRAINE => Code.UA;
        public static Code UNITED_ARAB_EMIRATES => Code.AE;
        public static Code UNITED_KINGDOM => Code.GB;
        public static Code UNITED_STATES => Code.US;
        public static Code UNITED_STATES_MINOR_OUTLYING_ISLANDS => Code.UM;
        public static Code URUGUAY => Code.UY;
        public static Code UZBEKISTAN => Code.UZ;
        public static Code VANUATU => Code.VU;
        public static Code VENEZUELA_BOLIVARIAN_REPUBLIC_OF => Code.VE;
        public static Code VIET_NAM => Code.VN;
        public static Code VIRGIN_ISLANDS_BRITISH => Code.VG;
        public static Code VIRGIN_ISLANDS_U_S => Code.VI;
        public static Code Indeterminately_reserved => Code.WO;
        public static Code WALLIS_AND_FUTUNA => Code.WF;
        public static Code WESTERN_SAHARA => Code.EH;
        public static Code YEMEN => Code.YE;
        public static Code ZAMBIA => Code.ZM;
        public static Code ZIMBABWE => Code.ZW;
    }
}
