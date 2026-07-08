using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Shipping;

/// <summary>
/// Represents a shipping carrier for tracking purposes.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<ECarrier>))]
public enum ECarrier
{
    /// <summary>DPD Ru.</summary>
    DPD_RU = 0,
    /// <summary>Bg Bulgarian Post.</summary>
    BG_BULGARIAN_POST = 1,
    /// <summary>KR Korea Post.</summary>
    KR_KOREA_POST = 2,
    /// <summary>ZA Courierit.</summary>
    ZA_COURIERIT = 3,
    /// <summary>FR Exapaq.</summary>
    FR_EXAPAQ = 4,
    /// <summary>Are Emirates Post.</summary>
    ARE_EMIRATES_POST = 5,
    /// <summary>Gac.</summary>
    GAC = 6,
    /// <summary>Geis.</summary>
    GEIS = 7,
    /// <summary>Sf Ex.</summary>
    SF_EX = 8,
    /// <summary>Pago.</summary>
    PAGO = 9,
    /// <summary>Myhermes.</summary>
    MYHERMES = 10,
    /// <summary>Diamond Eurogistics.</summary>
    DIAMOND_EUROGISTICS = 11,
    /// <summary>Corporatecouriers Webhook.</summary>
    CORPORATECOURIERS_WEBHOOK = 12,
    /// <summary>Bond.</summary>
    BOND = 13,
    /// <summary>Omniparcel.</summary>
    OMNIPARCEL = 14,
    /// <summary>Sk Posta.</summary>
    SK_POSTA = 15,
    /// <summary>Purolator.</summary>
    PUROLATOR = 16,
    /// <summary>Fetchr Webhook.</summary>
    FETCHR_WEBHOOK = 17,
    /// <summary>Thedeliverygroup.</summary>
    THEDELIVERYGROUP = 18,
    /// <summary>Cello Square.</summary>
    CELLO_SQUARE = 19,
    /// <summary>Tarrive.</summary>
    TARRIVE = 20,
    /// <summary>Collivery.</summary>
    COLLIVERY = 21,
    /// <summary>Mainfreight.</summary>
    MAINFREIGHT = 22,
    /// <summary>Ind Firstflight.</summary>
    IND_FIRSTFLIGHT = 23,
    /// <summary>Acsworldwide.</summary>
    ACSWORLDWIDE = 24,
    /// <summary>Amstan.</summary>
    AMSTAN = 25,
    /// <summary>Okayparcel.</summary>
    OKAYPARCEL = 26,
    /// <summary>Envialia Reference.</summary>
    ENVIALIA_REFERENCE = 27,
    /// <summary>Seur ES.</summary>
    SEUR_ES = 28,
    /// <summary>Continental.</summary>
    CONTINENTAL = 29,
    /// <summary>Fdsexpress.</summary>
    FDSEXPRESS = 30,
    /// <summary>Amazon Fba Swiship.</summary>
    AMAZON_FBA_SWISHIP = 31,
    /// <summary>Wyngs.</summary>
    WYNGS = 32,
    /// <summary>DHL Active Tracing.</summary>
    DHL_ACTIVE_TRACING = 33,
    /// <summary>Zyllem.</summary>
    ZYLLEM = 34,
    /// <summary>Ruston.</summary>
    RUSTON = 35,
    /// <summary>Xpost.</summary>
    XPOST = 36,
    /// <summary>Correos ES.</summary>
    CORREOS_ES = 37,
    /// <summary>DHL FR.</summary>
    DHL_FR = 38,
    /// <summary>Pan Asia.</summary>
    PAN_ASIA = 39,
    /// <summary>Brt IT.</summary>
    BRT_IT = 40,
    /// <summary>Sre Korea.</summary>
    SRE_KOREA = 41,
    /// <summary>Speedee.</summary>
    SPEEDEE = 42,
    /// <summary>TNT Uk.</summary>
    TNT_UK = 43,
    /// <summary>Venipak.</summary>
    VENIPAK = 44,
    /// <summary>Shreenandancourier.</summary>
    SHREENANDANCOURIER = 45,
    /// <summary>Croshot.</summary>
    CROSHOT = 46,
    /// <summary>Nipost Ng.</summary>
    NIPOST_NG = 47,
    /// <summary>Epst Glbl.</summary>
    EPST_GLBL = 48,
    /// <summary>Newgistics.</summary>
    NEWGISTICS = 49,
    /// <summary>Post Slovenia.</summary>
    POST_SLOVENIA = 50,
    /// <summary>Jersey Post.</summary>
    JERSEY_POST = 51,
    /// <summary>Bombinoexp.</summary>
    BOMBINOEXP = 52,
    /// <summary>Wmg.</summary>
    WMG = 53,
    /// <summary>Xq Express.</summary>
    XQ_EXPRESS = 54,
    /// <summary>Furdeco.</summary>
    FURDECO = 55,
    /// <summary>Lht Express.</summary>
    LHT_EXPRESS = 56,
    /// <summary>South African Post Office.</summary>
    SOUTH_AFRICAN_POST_OFFICE = 57,
    /// <summary>Spoton.</summary>
    SPOTON = 58,
    /// <summary>Dimerco.</summary>
    DIMERCO = 59,
    /// <summary>Cyprus Post Cyp.</summary>
    CYPRUS_POST_CYP = 60,
    /// <summary>Abcustom.</summary>
    ABCUSTOM = 61,
    /// <summary>Ind DElivree.</summary>
    IND_DELIVREE = 62,
    /// <summary>CN BEstexpress.</summary>
    CN_BESTEXPRESS = 63,
    /// <summary>Dx SFTP.</summary>
    DX_SFTP = 64,
    /// <summary>Pickupp MYs.</summary>
    PICKUPP_MYS = 65,
    /// <summary>Fmx.</summary>
    FMX = 66,
    /// <summary>Hellmann.</summary>
    HELLMANN = 67,
    /// <summary>Ship IT Asia.</summary>
    SHIP_IT_ASIA = 68,
    /// <summary>Kerry Ecommerce.</summary>
    KERRY_ECOMMERCE = 69,
    /// <summary>Freterapido.</summary>
    FRETERAPIDO = 70,
    /// <summary>Pitney Bowes.</summary>
    PITNEY_BOWES = 71,
    /// <summary>Xpressen Dk.</summary>
    XPRESSEN_DK = 72,
    /// <summary>Seur Sp API.</summary>
    SEUR_SP_API = 73,
    /// <summary>Deliveryontime.</summary>
    DELIVERYONTIME = 74,
    /// <summary>Jinsung.</summary>
    JINSUNG = 75,
    /// <summary>Trans Kargo.</summary>
    TRANS_KARGO = 76,
    /// <summary>Swiship DE.</summary>
    SWISHIP_DE = 77,
    /// <summary>Ivoy Webhook.</summary>
    IVOY_WEBHOOK = 78,
    /// <summary>Airmee Webhook.</summary>
    AIRMEE_WEBHOOK = 79,
    /// <summary>DHL BEnelux.</summary>
    DHL_BENELUX = 80,
    /// <summary>Firstmile.</summary>
    FIRSTMILE = 81,
    /// <summary>Fastway Ir.</summary>
    FASTWAY_IR = 82,
    /// <summary>Hh Exp.</summary>
    HH_EXP = 83,
    /// <summary>Mys MYpost Online.</summary>
    MYS_MYPOST_ONLINE = 84,
    /// <summary>TNT NL.</summary>
    TNT_NL = 85,
    /// <summary>Tipsa.</summary>
    TIPSA = 86,
    /// <summary>Taqbin MY.</summary>
    TAQBIN_MY = 87,
    /// <summary>Kgmhub.</summary>
    KGMHUB = 88,
    /// <summary>Intexpress.</summary>
    INTEXPRESS = 89,
    /// <summary>Overse Exp.</summary>
    OVERSE_EXP = 90,
    /// <summary>Oneclick.</summary>
    ONECLICK = 91,
    /// <summary>Roadrunner FReight.</summary>
    ROADRUNNER_FREIGHT = 92,
    /// <summary>GLS Crotia.</summary>
    GLS_CROTIA = 93,
    /// <summary>Mrw FTP.</summary>
    MRW_FTP = 94,
    /// <summary>Bluex.</summary>
    BLUEX = 95,
    /// <summary>Dylt.</summary>
    DYLT = 96,
    /// <summary>DPD Ir.</summary>
    DPD_IR = 97,
    /// <summary>Sin Glbl.</summary>
    SIN_GLBL = 98,
    /// <summary>Tuffnells Reference.</summary>
    TUFFNELLS_REFERENCE = 99,
    /// <summary>Cjpacket.</summary>
    CJPACKET = 100,
    /// <summary>Milkman.</summary>
    MILKMAN = 101,
    /// <summary>Asigna.</summary>
    ASIGNA = 102,
    /// <summary>Oneworldexpress.</summary>
    ONEWORLDEXPRESS = 103,
    /// <summary>Royal Mail.</summary>
    ROYAL_MAIL = 104,
    /// <summary>Via Express.</summary>
    VIA_EXPRESS = 105,
    /// <summary>Tigfreight.</summary>
    TIGFREIGHT = 106,
    /// <summary>Zto Express.</summary>
    ZTO_EXPRESS = 107,
    /// <summary>Two Go.</summary>
    TWO_GO = 108,
    /// <summary>Iml.</summary>
    IML = 109,
    /// <summary>Intel Valley.</summary>
    INTEL_VALLEY = 110,
    /// <summary>Efs.</summary>
    EFS = 111,
    /// <summary>Uk Uk Mail.</summary>
    UK_UK_MAIL = 112,
    /// <summary>Ram.</summary>
    RAM = 113,
    /// <summary>Alliedexpress.</summary>
    ALLIEDEXPRESS = 114,
    /// <summary>APC Overnight.</summary>
    APC_OVERNIGHT = 115,
    /// <summary>Shippit.</summary>
    SHIPPIT = 116,
    /// <summary>Tfm.</summary>
    TFM = 117,
    /// <summary>M Xpress.</summary>
    M_XPRESS = 118,
    /// <summary>Hdb Box.</summary>
    HDB_BOX = 119,
    /// <summary>Clevy Links.</summary>
    CLEVY_LINKS = 120,
    /// <summary>Ibeone.</summary>
    IBEONE = 121,
    /// <summary>Fiege NL.</summary>
    FIEGE_NL = 122,
    /// <summary>Kwe Global.</summary>
    KWE_GLOBAL = 123,
    /// <summary>Ctc Express.</summary>
    CTC_EXPRESS = 124,
    /// <summary>Amazon.</summary>
    AMAZON = 125,
    /// <summary>More Link.</summary>
    MORE_LINK = 126,
    /// <summary>Jx.</summary>
    JX = 127,
    /// <summary>Easy Mail.</summary>
    EASY_MAIL = 128,
    /// <summary>Aduiepyle.</summary>
    ADUIEPYLE = 129,
    /// <summary>GB Panther.</summary>
    GB_PANTHER = 130,
    /// <summary>Expresssale.</summary>
    EXPRESSSALE = 131,
    /// <summary>SG DEtrack.</summary>
    SG_DETRACK = 132,
    /// <summary>Trunkrs Webhook.</summary>
    TRUNKRS_WEBHOOK = 133,
    /// <summary>Matdespatch.</summary>
    MATDESPATCH = 134,
    /// <summary>Dicom.</summary>
    DICOM = 135,
    /// <summary>Mbw.</summary>
    MBW = 136,
    /// <summary>Khm Cambodia Post.</summary>
    KHM_CAMBODIA_POST = 137,
    /// <summary>Sinotrans.</summary>
    SINOTRANS = 138,
    /// <summary>Brt IT Parcelid.</summary>
    BRT_IT_PARCELID = 139,
    /// <summary>DHL Supply Chain.</summary>
    DHL_SUPPLY_CHAIN = 140,
    /// <summary>DHL PL.</summary>
    DHL_PL = 141,
    /// <summary>Topyou.</summary>
    TOPYOU = 142,
    /// <summary>Palexpress.</summary>
    PALEXPRESS = 143,
    /// <summary>DHL SG.</summary>
    DHL_SG = 144,
    /// <summary>CN Wedo.</summary>
    CN_WEDO = 145,
    /// <summary>Fulfillme.</summary>
    FULFILLME = 146,
    /// <summary>DPD DElistrack.</summary>
    DPD_DELISTRACK = 147,
    /// <summary>UPS Reference.</summary>
    UPS_REFERENCE = 148,
    /// <summary>Caribou.</summary>
    CARIBOU = 149,
    /// <summary>Locus Webhook.</summary>
    LOCUS_WEBHOOK = 150,
    /// <summary>Dsv.</summary>
    DSV = 151,
    /// <summary>P2P Trc.</summary>
    P2P_TRC = 152,
    /// <summary>Directparcels.</summary>
    DIRECTPARCELS = 153,
    /// <summary>Nova Poshta Int.</summary>
    NOVA_POSHTA_INT = 154,
    /// <summary>FedEx Poland.</summary>
    FEDEX_POLAND = 155,
    /// <summary>CN Jcex.</summary>
    CN_JCEX = 156,
    /// <summary>Far International.</summary>
    FAR_INTERNATIONAL = 157,
    /// <summary>Idexpress.</summary>
    IDEXPRESS = 158,
    /// <summary>Gangbao.</summary>
    GANGBAO = 159,
    /// <summary>Neway.</summary>
    NEWAY = 160,
    /// <summary>Postnl Int 3 S.</summary>
    POSTNL_INT_3_S = 161,
    /// <summary>Rpx ID.</summary>
    RPX_ID = 162,
    /// <summary>Designertransport Webhook.</summary>
    DESIGNERTRANSPORT_WEBHOOK = 163,
    /// <summary>GLS Sloven.</summary>
    GLS_SLOVEN = 164,
    /// <summary>Parcelled In.</summary>
    PARCELLED_IN = 165,
    /// <summary>Gsi Express.</summary>
    GSI_EXPRESS = 166,
    /// <summary>Con Way.</summary>
    CON_WAY = 167,
    /// <summary>Brouwer Transport.</summary>
    BROUWER_TRANSPORT = 168,
    /// <summary>Cpex.</summary>
    CPEX = 169,
    /// <summary>Israel Post.</summary>
    ISRAEL_POST = 170,
    /// <summary>Dtdc In.</summary>
    DTDC_IN = 171,
    /// <summary>Ptt Post.</summary>
    PTT_POST = 172,
    /// <summary>Xde Webhook.</summary>
    XDE_WEBHOOK = 173,
    /// <summary>Tolos.</summary>
    TOLOS = 174,
    /// <summary>Giao Hang.</summary>
    GIAO_HANG = 175,
    /// <summary>Geodis ESpace.</summary>
    GEODIS_ESPACE = 176,
    /// <summary>Magyar Hu.</summary>
    MAGYAR_HU = 177,
    /// <summary>Doordash Webhook.</summary>
    DOORDASH_WEBHOOK = 178,
    /// <summary>Tiki ID.</summary>
    TIKI_ID = 179,
    /// <summary>Cj HK International.</summary>
    CJ_HK_INTERNATIONAL = 180,
    /// <summary>Star Track Express.</summary>
    STAR_TRACK_EXPRESS = 181,
    /// <summary>Helthjem.</summary>
    HELTHJEM = 182,
    /// <summary>Sfb2C.</summary>
    SFB2C = 183,
    /// <summary>Freightquote.</summary>
    FREIGHTQUOTE = 184,
    /// <summary>Landmark Global Reference.</summary>
    LANDMARK_GLOBAL_REFERENCE = 185,
    /// <summary>Parcel2Go.</summary>
    PARCEL2GO = 186,
    /// <summary>Delnext.</summary>
    DELNEXT = 187,
    /// <summary>Rcl.</summary>
    RCL = 188,
    /// <summary>Cgs Express.</summary>
    CGS_EXPRESS = 189,
    /// <summary>HK Post.</summary>
    HK_POST = 190,
    /// <summary>Sap Express.</summary>
    SAP_EXPRESS = 191,
    /// <summary>Parcelpost SG.</summary>
    PARCELPOST_SG = 192,
    /// <summary>Hermes.</summary>
    HERMES = 193,
    /// <summary>Ind Safeexpress.</summary>
    IND_SAFEEXPRESS = 194,
    /// <summary>Tophatterexpress.</summary>
    TOPHATTEREXPRESS = 195,
    /// <summary>Mglobal.</summary>
    MGLOBAL = 196,
    /// <summary>Averitt.</summary>
    AVERITT = 197,
    /// <summary>Leader.</summary>
    LEADER = 198,
    /// <summary> 2Ebox.</summary>
    _2EBOX = 199,
    /// <summary>SG Speedpost.</summary>
    SG_SPEEDPOST = 200,
    /// <summary>Dbschenker Se.</summary>
    DBSCHENKER_SE = 201,
    /// <summary>Isr Post Domestic.</summary>
    ISR_POST_DOMESTIC = 202,
    /// <summary>Bestwayparcel.</summary>
    BESTWAYPARCEL = 203,
    /// <summary>Asendia DE.</summary>
    ASENDIA_DE = 204,
    /// <summary>Nightline Uk.</summary>
    NIGHTLINE_UK = 205,
    /// <summary>Taqbin SG.</summary>
    TAQBIN_SG = 206,
    /// <summary>Tck Express.</summary>
    TCK_EXPRESS = 207,
    /// <summary>Endeavour DElivery.</summary>
    ENDEAVOUR_DELIVERY = 208,
    /// <summary>Nanjingwoyuan.</summary>
    NANJINGWOYUAN = 209,
    /// <summary>Heppner FR.</summary>
    HEPPNER_FR = 210,
    /// <summary>Emps CN.</summary>
    EMPS_CN = 211,
    /// <summary>Fonsen.</summary>
    FONSEN = 212,
    /// <summary>Pickrr.</summary>
    PICKRR = 213,
    /// <summary>APC Overnight Connum.</summary>
    APC_OVERNIGHT_CONNUM = 214,
    /// <summary>Star Track Next Flight.</summary>
    STAR_TRACK_NEXT_FLIGHT = 215,
    /// <summary>Dajin.</summary>
    DAJIN = 216,
    /// <summary>UPS FReight.</summary>
    UPS_FREIGHT = 217,
    /// <summary>Posta PLus.</summary>
    POSTA_PLUS = 218,
    /// <summary>Ceva.</summary>
    CEVA = 219,
    /// <summary>Anserx.</summary>
    ANSERX = 220,
    /// <summary>Js Express.</summary>
    JS_EXPRESS = 221,
    /// <summary>Padtf.</summary>
    PADTF = 222,
    /// <summary>UPS Mail Innovations.</summary>
    UPS_MAIL_INNOVATIONS = 223,
    /// <summary>Sypost.</summary>
    SYPOST = 224,
    /// <summary>Amazon Ship Mcf.</summary>
    AMAZON_SHIP_MCF = 225,
    /// <summary>Yusen.</summary>
    YUSEN = 226,
    /// <summary>Bring.</summary>
    BRING = 227,
    /// <summary>Sda IT.</summary>
    SDA_IT = 228,
    /// <summary>Gba.</summary>
    GBA = 229,
    /// <summary>Neweggexpress.</summary>
    NEWEGGEXPRESS = 230,
    /// <summary>Speedcouriers Gr.</summary>
    SPEEDCOURIERS_GR = 231,
    /// <summary>Forrun.</summary>
    FORRUN = 232,
    /// <summary>Pickup.</summary>
    PICKUP = 233,
    /// <summary>Ecms.</summary>
    ECMS = 234,
    /// <summary>Intelipost.</summary>
    INTELIPOST = 235,
    /// <summary>Flashexpress.</summary>
    FLASHEXPRESS = 236,
    /// <summary>CN Sto.</summary>
    CN_STO = 237,
    /// <summary>Seko SFTP.</summary>
    SEKO_SFTP = 238,
    /// <summary>Home DElivery Solutions.</summary>
    HOME_DELIVERY_SOLUTIONS = 239,
    /// <summary>DPD Hgry.</summary>
    DPD_HGRY = 240,
    /// <summary>Kerryttc VN.</summary>
    KERRYTTC_VN = 241,
    /// <summary>Joying Box.</summary>
    JOYING_BOX = 242,
    /// <summary>Total Express.</summary>
    TOTAL_EXPRESS = 243,
    /// <summary>Zjs Express.</summary>
    ZJS_EXPRESS = 244,
    /// <summary>Starken.</summary>
    STARKEN = 245,
    /// <summary>Demandship.</summary>
    DEMANDSHIP = 246,
    /// <summary>CN Dpex.</summary>
    CN_DPEX = 247,
    /// <summary>Aupost CN.</summary>
    AUPOST_CN = 248,
    /// <summary>Logisters.</summary>
    LOGISTERS = 249,
    /// <summary>Goglobalpost.</summary>
    GOGLOBALPOST = 250,
    /// <summary>GLS Cz.</summary>
    GLS_CZ = 251,
    /// <summary>Paack Webhook.</summary>
    PAACK_WEBHOOK = 252,
    /// <summary>Grab Webhook.</summary>
    GRAB_WEBHOOK = 253,
    /// <summary>Parcelpoint.</summary>
    PARCELPOINT = 254,
    /// <summary>Icumulus.</summary>
    ICUMULUS = 255,
    /// <summary>Daiglobaltrack.</summary>
    DAIGLOBALTRACK = 256,
    /// <summary>Global Iparcel.</summary>
    GLOBAL_IPARCEL = 257,
    /// <summary>Yurtici Kargo.</summary>
    YURTICI_KARGO = 258,
    /// <summary>CN PayPal Package.</summary>
    CN_PAYPAL_PACKAGE = 259,
    /// <summary>Parcel 2 Post.</summary>
    PARCEL_2_POST = 260,
    /// <summary>GLS IT.</summary>
    GLS_IT = 261,
    /// <summary>Pil Logistics.</summary>
    PIL_LOGISTICS = 262,
    /// <summary>Heppner.</summary>
    HEPPNER = 263,
    /// <summary>General Overnight.</summary>
    GENERAL_OVERNIGHT = 264,
    /// <summary>Happy2Point.</summary>
    HAPPY2POINT = 265,
    /// <summary>Chitchats.</summary>
    CHITCHATS = 266,
    /// <summary>Smooth.</summary>
    SMOOTH = 267,
    /// <summary>Cle Logistics.</summary>
    CLE_LOGISTICS = 268,
    /// <summary>Fiege.</summary>
    FIEGE = 269,
    /// <summary>MX Cargo.</summary>
    MX_CARGO = 270,
    /// <summary>Ziingfinalmile.</summary>
    ZIINGFINALMILE = 271,
    /// <summary>Dayton FReight.</summary>
    DAYTON_FREIGHT = 272,
    /// <summary>Tcs.</summary>
    TCS = 273,
    /// <summary>Aex.</summary>
    AEX = 274,
    /// <summary>Hermes DE.</summary>
    HERMES_DE = 275,
    /// <summary>Routific Webhook.</summary>
    ROUTIFIC_WEBHOOK = 276,
    /// <summary>Globavend.</summary>
    GLOBAVEND = 277,
    /// <summary>Cj Logistics.</summary>
    CJ_LOGISTICS = 278,
    /// <summary>Pallet Network.</summary>
    PALLET_NETWORK = 279,
    /// <summary>Raf PH.</summary>
    RAF_PH = 280,
    /// <summary>Uk Xdp.</summary>
    UK_XDP = 281,
    /// <summary>Paper Express.</summary>
    PAPER_EXPRESS = 282,
    /// <summary>La Poste Suivi.</summary>
    LA_POSTE_SUIVI = 283,
    /// <summary>Paquetexpress.</summary>
    PAQUETEXPRESS = 284,
    /// <summary>Liefery.</summary>
    LIEFERY = 285,
    /// <summary>Streck Transport.</summary>
    STRECK_TRANSPORT = 286,
    /// <summary>Pony Express.</summary>
    PONY_EXPRESS = 287,
    /// <summary>Always Express.</summary>
    ALWAYS_EXPRESS = 288,
    /// <summary>Gbs BRoker.</summary>
    GBS_BROKER = 289,
    /// <summary>Citylink MY.</summary>
    CITYLINK_MY = 290,
    /// <summary>Alljoy.</summary>
    ALLJOY = 291,
    /// <summary>Yodel.</summary>
    YODEL = 292,
    /// <summary>Yodel Dir.</summary>
    YODEL_DIR = 293,
    /// <summary>Stone3Pl.</summary>
    STONE3PL = 294,
    /// <summary>Parcelpal Webhook.</summary>
    PARCELPAL_WEBHOOK = 295,
    /// <summary>DHL Ecomerce Asa.</summary>
    DHL_ECOMERCE_ASA = 296,
    /// <summary>Simplypost.</summary>
    SIMPLYPOST = 297,
    /// <summary>Ky Express.</summary>
    KY_EXPRESS = 298,
    /// <summary>Shenzhen.</summary>
    SHENZHEN = 299,
    /// <summary>Us Lasership.</summary>
    US_LASERSHIP = 300,
    /// <summary>Uc Expre.</summary>
    UC_EXPRE = 301,
    /// <summary>Didadi.</summary>
    DIDADI = 302,
    /// <summary>Cj KR.</summary>
    CJ_KR = 303,
    /// <summary>Dbschenker B2B.</summary>
    DBSCHENKER_B2B = 304,
    /// <summary>Mxe.</summary>
    MXE = 305,
    /// <summary>Cae DElivers.</summary>
    CAE_DELIVERS = 306,
    /// <summary>Pfcexpress.</summary>
    PFCEXPRESS = 307,
    /// <summary>Whistl.</summary>
    WHISTL = 308,
    /// <summary>Wepost.</summary>
    WEPOST = 309,
    /// <summary>DHL Parcel ES.</summary>
    DHL_PARCEL_ES = 310,
    /// <summary>Ddexpress.</summary>
    DDEXPRESS = 311,
    /// <summary>Aramex AU.</summary>
    ARAMEX_AU = 312,
    /// <summary>Bneed.</summary>
    BNEED = 313,
    /// <summary>HK Tgx.</summary>
    HK_TGX = 314,
    /// <summary>Latvijas Pasts.</summary>
    LATVIJAS_PASTS = 315,
    /// <summary>Viaeurope.</summary>
    VIAEUROPE = 316,
    /// <summary>Correo Uy.</summary>
    CORREO_UY = 317,
    /// <summary>Chronopost FR.</summary>
    CHRONOPOST_FR = 318,
    /// <summary>J Net.</summary>
    J_NET = 319,
    /// <summary> 6Ls.</summary>
    _6LS = 320,
    /// <summary>Blr BElpost.</summary>
    BLR_BELPOST = 321,
    /// <summary>Birdsystem.</summary>
    BIRDSYSTEM = 322,
    /// <summary>Dobropost.</summary>
    DOBROPOST = 323,
    /// <summary>Wahana ID.</summary>
    WAHANA_ID = 324,
    /// <summary>Weaship.</summary>
    WEASHIP = 325,
    /// <summary>Sonictl.</summary>
    SONICTL = 326,
    /// <summary>Kwt.</summary>
    KWT = 327,
    /// <summary>Afllog FTP.</summary>
    AFLLOG_FTP = 328,
    /// <summary>Skynet Worldwide.</summary>
    SKYNET_WORLDWIDE = 329,
    /// <summary>Nova Poshta.</summary>
    NOVA_POSHTA = 330,
    /// <summary>Seino.</summary>
    SEINO = 331,
    /// <summary>Szendex.</summary>
    SZENDEX = 332,
    /// <summary>Bpost Int.</summary>
    BPOST_INT = 333,
    /// <summary>Dbschenker Sv.</summary>
    DBSCHENKER_SV = 334,
    /// <summary>Ao DEutschland.</summary>
    AO_DEUTSCHLAND = 335,
    /// <summary>Eu Fleet Solutions.</summary>
    EU_FLEET_SOLUTIONS = 336,
    /// <summary>Pcfcorp.</summary>
    PCFCORP = 337,
    /// <summary>Linkbridge.</summary>
    LINKBRIDGE = 338,
    /// <summary>Primamulticipta.</summary>
    PRIMAMULTICIPTA = 339,
    /// <summary>Courex.</summary>
    COUREX = 340,
    /// <summary>Zajil Express.</summary>
    ZAJIL_EXPRESS = 341,
    /// <summary>Collectco.</summary>
    COLLECTCO = 342,
    /// <summary>Jtexpress.</summary>
    JTEXPRESS = 343,
    /// <summary>FedEx Uk.</summary>
    FEDEX_UK = 344,
    /// <summary>Uship.</summary>
    USHIP = 345,
    /// <summary>Pixsell.</summary>
    PIXSELL = 346,
    /// <summary>Shiptor.</summary>
    SHIPTOR = 347,
    /// <summary>Cdek.</summary>
    CDEK = 348,
    /// <summary>Vnm Viettelpost.</summary>
    VNM_VIETTELPOST = 349,
    /// <summary>Cj Century.</summary>
    CJ_CENTURY = 350,
    /// <summary>Gso.</summary>
    GSO = 351,
    /// <summary>Viwo.</summary>
    VIWO = 352,
    /// <summary>Skybox.</summary>
    SKYBOX = 353,
    /// <summary>Kerrytj.</summary>
    KERRYTJ = 354,
    /// <summary>Ntlogistics VN.</summary>
    NTLOGISTICS_VN = 355,
    /// <summary>Sdh Scm.</summary>
    SDH_SCM = 356,
    /// <summary>Zinc.</summary>
    ZINC = 357,
    /// <summary>Dpe South Afrc.</summary>
    DPE_SOUTH_AFRC = 358,
    /// <summary>Ceska Cz.</summary>
    CESKA_CZ = 359,
    /// <summary>Acs Gr.</summary>
    ACS_GR = 360,
    /// <summary>Dealersend.</summary>
    DEALERSEND = 361,
    /// <summary>Jocom.</summary>
    JOCOM = 362,
    /// <summary>Cse.</summary>
    CSE = 363,
    /// <summary>Tforce Finalmile.</summary>
    TFORCE_FINALMILE = 364,
    /// <summary>Ship Gate.</summary>
    SHIP_GATE = 365,
    /// <summary>Shipter.</summary>
    SHIPTER = 366,
    /// <summary>National Sameday.</summary>
    NATIONAL_SAMEDAY = 367,
    /// <summary>Yunexpress.</summary>
    YUNEXPRESS = 368,
    /// <summary>Cainiao.</summary>
    CAINIAO = 369,
    /// <summary>Dms Matrix.</summary>
    DMS_MATRIX = 370,
    /// <summary>Directlog.</summary>
    DIRECTLOG = 371,
    /// <summary>Asendia Us.</summary>
    ASENDIA_US = 372,
    /// <summary> 3Jmslogistics.</summary>
    _3JMSLOGISTICS = 373,
    /// <summary>Liccardi Express.</summary>
    LICCARDI_EXPRESS = 374,
    /// <summary>Sky Postal.</summary>
    SKY_POSTAL = 375,
    /// <summary>Cnwangtong.</summary>
    CNWANGTONG = 376,
    /// <summary>Postnord Logistics Dk.</summary>
    POSTNORD_LOGISTICS_DK = 377,
    /// <summary>Logistika.</summary>
    LOGISTIKA = 378,
    /// <summary>Celeritas.</summary>
    CELERITAS = 379,
    /// <summary>Pressiode.</summary>
    PRESSIODE = 380,
    /// <summary>Shree Maruti.</summary>
    SHREE_MARUTI = 381,
    /// <summary>Logisticsworldwide HK.</summary>
    LOGISTICSWORLDWIDE_HK = 382,
    /// <summary>Efex.</summary>
    EFEX = 383,
    /// <summary>Lotte.</summary>
    LOTTE = 384,
    /// <summary>Lonestar.</summary>
    LONESTAR = 385,
    /// <summary>Aprisaexpress.</summary>
    APRISAEXPRESS = 386,
    /// <summary>Bel Rs.</summary>
    BEL_RS = 387,
    /// <summary>Osm Worldwide.</summary>
    OSM_WORLDWIDE = 388,
    /// <summary>Westgate Gl.</summary>
    WESTGATE_GL = 389,
    /// <summary>Fastrack.</summary>
    FASTRACK = 390,
    /// <summary>Dtd Expr.</summary>
    DTD_EXPR = 391,
    /// <summary>Alfatrex.</summary>
    ALFATREX = 392,
    /// <summary>Promeddelivery.</summary>
    PROMEDDELIVERY = 393,
    /// <summary>Thabit Logistics.</summary>
    THABIT_LOGISTICS = 394,
    /// <summary>Hct Logistics.</summary>
    HCT_LOGISTICS = 395,
    /// <summary>Carry Flap.</summary>
    CARRY_FLAP = 396,
    /// <summary>Us Old Dominion.</summary>
    US_OLD_DOMINION = 397,
    /// <summary>Anicam Box.</summary>
    ANICAM_BOX = 398,
    /// <summary>Wanbexpress.</summary>
    WANBEXPRESS = 399,
    /// <summary>An Post.</summary>
    AN_POST = 400,
    /// <summary>DPD Local.</summary>
    DPD_LOCAL = 401,
    /// <summary>Stallionexpress.</summary>
    STALLIONEXPRESS = 402,
    /// <summary>Raiderex.</summary>
    RAIDEREX = 403,
    /// <summary>Shopfans.</summary>
    SHOPFANS = 404,
    /// <summary>Kyungdong Parcel.</summary>
    KYUNGDONG_PARCEL = 405,
    /// <summary>Champion Logistics.</summary>
    CHAMPION_LOGISTICS = 406,
    /// <summary>Pickupp SGp.</summary>
    PICKUPP_SGP = 407,
    /// <summary>Morning Express.</summary>
    MORNING_EXPRESS = 408,
    /// <summary>Nacex.</summary>
    NACEX = 409,
    /// <summary>Thenile Webhook.</summary>
    THENILE_WEBHOOK = 410,
    /// <summary>Holisol.</summary>
    HOLISOL = 411,
    /// <summary>Lbcexpress FTP.</summary>
    LBCEXPRESS_FTP = 412,
    /// <summary>Kurasi.</summary>
    KURASI = 413,
    /// <summary>Usf Reddaway.</summary>
    USF_REDDAWAY = 414,
    /// <summary>Apg.</summary>
    APG = 415,
    /// <summary>CN Boxc.</summary>
    CN_BOXC = 416,
    /// <summary>Ecoscooting.</summary>
    ECOSCOOTING = 417,
    /// <summary>Mainway.</summary>
    MAINWAY = 418,
    /// <summary>Paperfly.</summary>
    PAPERFLY = 419,
    /// <summary>Houndexpress.</summary>
    HOUNDEXPRESS = 420,
    /// <summary>Box BErry.</summary>
    BOX_BERRY = 421,
    /// <summary>Ep Box.</summary>
    EP_BOX = 422,
    /// <summary>Plus Log Uk.</summary>
    PLUS_LOG_UK = 423,
    /// <summary>Fulfilla.</summary>
    FULFILLA = 424,
    /// <summary>Ase.</summary>
    ASE = 425,
    /// <summary>Mail PLus.</summary>
    MAIL_PLUS = 426,
    /// <summary>Xpo Logistics.</summary>
    XPO_LOGISTICS = 427,
    /// <summary>Wndirect.</summary>
    WNDIRECT = 428,
    /// <summary>Cloudwish Asia.</summary>
    CLOUDWISH_ASIA = 429,
    /// <summary>Zeleris.</summary>
    ZELERIS = 430,
    /// <summary>Gio Express.</summary>
    GIO_EXPRESS = 431,
    /// <summary>Ocs Worldwide.</summary>
    OCS_WORLDWIDE = 432,
    /// <summary>Ark Logistics.</summary>
    ARK_LOGISTICS = 433,
    /// <summary>Aquiline.</summary>
    AQUILINE = 434,
    /// <summary>Pilot FReight.</summary>
    PILOT_FREIGHT = 435,
    /// <summary>Qwintry.</summary>
    QWINTRY = 436,
    /// <summary>Danske FRagt.</summary>
    DANSKE_FRAGT = 437,
    /// <summary>Carriers.</summary>
    CARRIERS = 438,
    /// <summary>Air Canada Global.</summary>
    AIR_CANADA_GLOBAL = 439,
    /// <summary>President Trans.</summary>
    PRESIDENT_TRANS = 440,
    /// <summary>Stepforwardfs.</summary>
    STEPFORWARDFS = 441,
    /// <summary>Skynet Uk.</summary>
    SKYNET_UK = 442,
    /// <summary>Pittohio.</summary>
    PITTOHIO = 443,
    /// <summary>Correos Express.</summary>
    CORREOS_EXPRESS = 444,
    /// <summary>Rl Us.</summary>
    RL_US = 445,
    /// <summary>Destiny.</summary>
    DESTINY = 446,
    /// <summary>Uk Yodel.</summary>
    UK_YODEL = 447,
    /// <summary>Comet Tech.</summary>
    COMET_TECH = 448,
    /// <summary>DHL Parcel Ru.</summary>
    DHL_PARCEL_RU = 449,
    /// <summary>TNT Refr.</summary>
    TNT_REFR = 450,
    /// <summary>Shree Anjani Courier.</summary>
    SHREE_ANJANI_COURIER = 451,
    /// <summary>Mikropakket BE.</summary>
    MIKROPAKKET_BE = 452,
    /// <summary>Ets Express.</summary>
    ETS_EXPRESS = 453,
    /// <summary>Colis Prive.</summary>
    COLIS_PRIVE = 454,
    /// <summary>CN Yunda.</summary>
    CN_YUNDA = 455,
    /// <summary>Aaa Cooper.</summary>
    AAA_COOPER = 456,
    /// <summary>Rocket Parcel.</summary>
    ROCKET_PARCEL = 457,
    /// <summary> 360Lion.</summary>
    _360LION = 458,
    /// <summary>Pandu.</summary>
    PANDU = 459,
    /// <summary>Professional Couriers.</summary>
    PROFESSIONAL_COURIERS = 460,
    /// <summary>Flytexpress.</summary>
    FLYTEXPRESS = 461,
    /// <summary>Logisticsworldwide MY.</summary>
    LOGISTICSWORLDWIDE_MY = 462,
    /// <summary>Correos DE ESpana.</summary>
    CORREOS_DE_ESPANA = 463,
    /// <summary>Imx.</summary>
    IMX = 464,
    /// <summary>Four Px Express.</summary>
    FOUR_PX_EXPRESS = 465,
    /// <summary>Xpressbees.</summary>
    XPRESSBEES = 466,
    /// <summary>Pickupp VNm.</summary>
    PICKUPP_VNM = 467,
    /// <summary>Startrack Express.</summary>
    STARTRACK_EXPRESS = 468,
    /// <summary>FR Colissimo.</summary>
    FR_COLISSIMO = 469,
    /// <summary>Nacex Spain Reference.</summary>
    NACEX_SPAIN_REFERENCE = 470,
    /// <summary>DHL Supply Chain AU.</summary>
    DHL_SUPPLY_CHAIN_AU = 471,
    /// <summary>Eshipping.</summary>
    ESHIPPING = 472,
    /// <summary>Shreetirupati.</summary>
    SHREETIRUPATI = 473,
    /// <summary>Hx Express.</summary>
    HX_EXPRESS = 474,
    /// <summary>Indopaket.</summary>
    INDOPAKET = 475,
    /// <summary>CN 17Post.</summary>
    CN_17POST = 476,
    /// <summary>K1 Express.</summary>
    K1_EXPRESS = 477,
    /// <summary>Cj GLS.</summary>
    CJ_GLS = 478,
    /// <summary>Mys Gdex.</summary>
    MYS_GDEX = 479,
    /// <summary>Nationex.</summary>
    NATIONEX = 480,
    /// <summary>Anjun.</summary>
    ANJUN = 481,
    /// <summary>Fargood.</summary>
    FARGOOD = 482,
    /// <summary>Smg Express.</summary>
    SMG_EXPRESS = 483,
    /// <summary>Rzyexpress.</summary>
    RZYEXPRESS = 484,
    /// <summary>Sefl.</summary>
    SEFL = 485,
    /// <summary>TNT Click IT.</summary>
    TNT_CLICK_IT = 486,
    /// <summary>Hdb.</summary>
    HDB = 487,
    /// <summary>Hipshipper.</summary>
    HIPSHIPPER = 488,
    /// <summary>Rpxlogistics.</summary>
    RPXLOGISTICS = 489,
    /// <summary>Kuehne.</summary>
    KUEHNE = 490,
    /// <summary>IT Nexive.</summary>
    IT_NEXIVE = 491,
    /// <summary>Pts.</summary>
    PTS = 492,
    /// <summary>Swiss Post FTP.</summary>
    SWISS_POST_FTP = 493,
    /// <summary>Fastrk Serv.</summary>
    FASTRK_SERV = 494,
    /// <summary> 4 72.</summary>
    _4_72 = 495,
    /// <summary>Us Yrc.</summary>
    US_YRC = 496,
    /// <summary>Postnl Intl 3S.</summary>
    POSTNL_INTL_3S = 497,
    /// <summary>Elian Post.</summary>
    ELIAN_POST = 498,
    /// <summary>Cubyn.</summary>
    CUBYN = 499,
    /// <summary>Sau Saudi Post.</summary>
    SAU_SAUDI_POST = 500,
    /// <summary>Abxexpress MY.</summary>
    ABXEXPRESS_MY = 501,
    /// <summary>Huahan Express.</summary>
    HUAHAN_EXPRESS = 502,
    /// <summary>Zes Express.</summary>
    ZES_EXPRESS = 503,
    /// <summary>Zepto Express.</summary>
    ZEPTO_EXPRESS = 504,
    /// <summary>Skynet ZA.</summary>
    SKYNET_ZA = 505,
    /// <summary>Zeek 2 Door.</summary>
    ZEEK_2_DOOR = 506,
    /// <summary>Blinklastmile.</summary>
    BLINKLASTMILE = 507,
    /// <summary>Posta Ukr.</summary>
    POSTA_UKR = 508,
    /// <summary>Chrobinson.</summary>
    CHROBINSON = 509,
    /// <summary>CN Post56.</summary>
    CN_POST56 = 510,
    /// <summary>Courant PLus.</summary>
    COURANT_PLUS = 511,
    /// <summary>Scudex Express.</summary>
    SCUDEX_EXPRESS = 512,
    /// <summary>Shipentegra.</summary>
    SHIPENTEGRA = 513,
    /// <summary>B Two C Europe.</summary>
    B_TWO_C_EUROPE = 514,
    /// <summary>Cope.</summary>
    COPE = 515,
    /// <summary>Ind Gati.</summary>
    IND_GATI = 516,
    /// <summary>CN Wishpost.</summary>
    CN_WISHPOST = 517,
    /// <summary>Nacex ES.</summary>
    NACEX_ES = 518,
    /// <summary>Taqbin HK.</summary>
    TAQBIN_HK = 519,
    /// <summary>Globaltranz.</summary>
    GLOBALTRANZ = 520,
    /// <summary>Hkd.</summary>
    HKD = 521,
    /// <summary>Bjshomedelivery.</summary>
    BJSHOMEDELIVERY = 522,
    /// <summary>Omniva.</summary>
    OMNIVA = 523,
    /// <summary>Sutton.</summary>
    SUTTON = 524,
    /// <summary>Panther Reference.</summary>
    PANTHER_REFERENCE = 525,
    /// <summary>Sfcservice.</summary>
    SFCSERVICE = 526,
    /// <summary>Ltl.</summary>
    LTL = 527,
    /// <summary>Parknparcel.</summary>
    PARKNPARCEL = 528,
    /// <summary>Spring Gds.</summary>
    SPRING_GDS = 529,
    /// <summary>Ecexpress.</summary>
    ECEXPRESS = 530,
    /// <summary>Interparcel AU.</summary>
    INTERPARCEL_AU = 531,
    /// <summary>Agility.</summary>
    AGILITY = 532,
    /// <summary>Xl Express.</summary>
    XL_EXPRESS = 533,
    /// <summary>Aderonline.</summary>
    ADERONLINE = 534,
    /// <summary>Directcouriers.</summary>
    DIRECTCOURIERS = 535,
    /// <summary>Planzer.</summary>
    PLANZER = 536,
    /// <summary>Sending.</summary>
    SENDING = 537,
    /// <summary>Ninjavan Wb.</summary>
    NINJAVAN_WB = 538,
    /// <summary>Nationwide MY.</summary>
    NATIONWIDE_MY = 539,
    /// <summary>Sendit.</summary>
    SENDIT = 540,
    /// <summary>GB Arrow.</summary>
    GB_ARROW = 541,
    /// <summary>Ind Gojavas.</summary>
    IND_GOJAVAS = 542,
    /// <summary>Kpost.</summary>
    KPOST = 543,
    /// <summary>DHL FReight.</summary>
    DHL_FREIGHT = 544,
    /// <summary>Bluecare.</summary>
    BLUECARE = 545,
    /// <summary>Jindouyun.</summary>
    JINDOUYUN = 546,
    /// <summary>Trackon.</summary>
    TRACKON = 547,
    /// <summary>GB Tuffnells.</summary>
    GB_TUFFNELLS = 548,
    /// <summary>Trumpcard.</summary>
    TRUMPCARD = 549,
    /// <summary>Etotal.</summary>
    ETOTAL = 550,
    /// <summary>Sfplus Webhook.</summary>
    SFPLUS_WEBHOOK = 551,
    /// <summary>Sekologistics.</summary>
    SEKOLOGISTICS = 552,
    /// <summary>Hermes 2Mann Handling.</summary>
    HERMES_2MANN_HANDLING = 553,
    /// <summary>DPD Local Ref.</summary>
    DPD_LOCAL_REF = 554,
    /// <summary>Uds.</summary>
    UDS = 555,
    /// <summary>ZA Specialised FReight.</summary>
    ZA_SPECIALISED_FREIGHT = 556,
    /// <summary>Tha Kerry.</summary>
    THA_KERRY = 557,
    /// <summary>Prt Int Seur.</summary>
    PRT_INT_SEUR = 558,
    /// <summary>Bra Correios.</summary>
    BRA_CORREIOS = 559,
    /// <summary>NZ NZ Post.</summary>
    NZ_NZ_POST = 560,
    /// <summary>CN Equick.</summary>
    CN_EQUICK = 561,
    /// <summary>Mys Ems.</summary>
    MYS_EMS = 562,
    /// <summary>GB Norsk.</summary>
    GB_NORSK = 563,
    /// <summary>Esp Mrw.</summary>
    ESP_MRW = 564,
    /// <summary>Esp Packlink.</summary>
    ESP_PACKLINK = 565,
    /// <summary>Kangaroo MY.</summary>
    KANGAROO_MY = 566,
    /// <summary>Rpx.</summary>
    RPX = 567,
    /// <summary>Xdp Uk Reference.</summary>
    XDP_UK_REFERENCE = 568,
    /// <summary>Ninjavan MY.</summary>
    NINJAVAN_MY = 569,
    /// <summary>Adicional.</summary>
    ADICIONAL = 570,
    /// <summary>Roadbull.</summary>
    ROADBULL = 571,
    /// <summary>Yakit.</summary>
    YAKIT = 572,
    /// <summary>Mailamericas.</summary>
    MAILAMERICAS = 573,
    /// <summary>Mikropakket.</summary>
    MIKROPAKKET = 574,
    /// <summary>Dynalogic.</summary>
    DYNALOGIC = 575,
    /// <summary>DHL ES.</summary>
    DHL_ES = 576,
    /// <summary>DHL Parcel NL.</summary>
    DHL_PARCEL_NL = 577,
    /// <summary>DHL Global Mail Asia.</summary>
    DHL_GLOBAL_MAIL_ASIA = 578,
    /// <summary>Dawn Wing.</summary>
    DAWN_WING = 579,
    /// <summary>Geniki Gr.</summary>
    GENIKI_GR = 580,
    /// <summary>Hermesworld Uk.</summary>
    HERMESWORLD_UK = 581,
    /// <summary>Alphafast.</summary>
    ALPHAFAST = 582,
    /// <summary>Buylogic.</summary>
    BUYLOGIC = 583,
    /// <summary>Ekart.</summary>
    EKART = 584,
    /// <summary>Mex Senda.</summary>
    MEX_SENDA = 585,
    /// <summary>Sfc Logistics.</summary>
    SFC_LOGISTICS = 586,
    /// <summary>Post Serbia.</summary>
    POST_SERBIA = 587,
    /// <summary>Ind DElhivery.</summary>
    IND_DELHIVERY = 588,
    /// <summary>DE DPD DElistrack.</summary>
    DE_DPD_DELISTRACK = 589,
    /// <summary>Rpd2Man.</summary>
    RPD2MAN = 590,
    /// <summary>CN Sf Express.</summary>
    CN_SF_EXPRESS = 591,
    /// <summary>Yanwen.</summary>
    YANWEN = 592,
    /// <summary>Mys Skynet.</summary>
    MYS_SKYNET = 593,
    /// <summary>Correos DE Mexico.</summary>
    CORREOS_DE_MEXICO = 594,
    /// <summary>Cbl Logistica.</summary>
    CBL_LOGISTICA = 595,
    /// <summary>Mex EStafeta.</summary>
    MEX_ESTAFETA = 596,
    /// <summary>AU AUstrian Post.</summary>
    AU_AUSTRIAN_POST = 597,
    /// <summary>Rincos.</summary>
    RINCOS = 598,
    /// <summary>Nld DHL.</summary>
    NLD_DHL = 599,
    /// <summary>Russian Post.</summary>
    RUSSIAN_POST = 600,
    /// <summary>Couriers PLease.</summary>
    COURIERS_PLEASE = 601,
    /// <summary>Postnord Logistics.</summary>
    POSTNORD_LOGISTICS = 602,
    /// <summary>FedEx.</summary>
    FEDEX = 603,
    /// <summary>Dpe Express.</summary>
    DPE_EXPRESS = 604,
    /// <summary>DPD.</summary>
    DPD = 605,
    /// <summary>Adsone.</summary>
    ADSONE = 606,
    /// <summary>Idn Jne.</summary>
    IDN_JNE = 607,
    /// <summary>Thecourierguy.</summary>
    THECOURIERGUY = 608,
    /// <summary>Cnexps.</summary>
    CNEXPS = 609,
    /// <summary>Prt Chronopost.</summary>
    PRT_CHRONOPOST = 610,
    /// <summary>Landmark Global.</summary>
    LANDMARK_GLOBAL = 611,
    /// <summary>IT DHL Ecommerce.</summary>
    IT_DHL_ECOMMERCE = 612,
    /// <summary>Esp Nacex.</summary>
    ESP_NACEX = 613,
    /// <summary>Prt Ctt.</summary>
    PRT_CTT = 614,
    /// <summary>BE Kiala.</summary>
    BE_KIALA = 615,
    /// <summary>Asendia Uk.</summary>
    ASENDIA_UK = 616,
    /// <summary>Global TNT.</summary>
    GLOBAL_TNT = 617,
    /// <summary>Postur Is.</summary>
    POSTUR_IS = 618,
    /// <summary>Eparcel KR.</summary>
    EPARCEL_KR = 619,
    /// <summary>Inpost Paczkomaty.</summary>
    INPOST_PACZKOMATY = 620,
    /// <summary>IT Poste ITalia.</summary>
    IT_POSTE_ITALIA = 621,
    /// <summary>BE Bpost.</summary>
    BE_BPOST = 622,
    /// <summary>PL Poczta Polska.</summary>
    PL_POCZTA_POLSKA = 623,
    /// <summary>Mys MYs Post.</summary>
    MYS_MYS_POST = 624,
    /// <summary>SG SG Post.</summary>
    SG_SG_POST = 625,
    /// <summary>Tha THailand Post.</summary>
    THA_THAILAND_POST = 626,
    /// <summary>Lexship.</summary>
    LEXSHIP = 627,
    /// <summary>Fastway NZ.</summary>
    FASTWAY_NZ = 628,
    /// <summary>DHL AU.</summary>
    DHL_AU = 629,
    /// <summary>Costmeticsnow.</summary>
    COSTMETICSNOW = 630,
    /// <summary>Pflogistics.</summary>
    PFLOGISTICS = 631,
    /// <summary>Loomis Express.</summary>
    LOOMIS_EXPRESS = 632,
    /// <summary>GLS ITaly.</summary>
    GLS_ITALY = 633,
    /// <summary>Line.</summary>
    LINE = 634,
    /// <summary>Gel Express.</summary>
    GEL_EXPRESS = 635,
    /// <summary>Huodull.</summary>
    HUODULL = 636,
    /// <summary>Ninjavan SG.</summary>
    NINJAVAN_SG = 637,
    /// <summary>Janio.</summary>
    JANIO = 638,
    /// <summary>Ao Courier.</summary>
    AO_COURIER = 639,
    /// <summary>Brt IT Sender Ref.</summary>
    BRT_IT_SENDER_REF = 640,
    /// <summary>Sailpost.</summary>
    SAILPOST = 641,
    /// <summary>Lalamove.</summary>
    LALAMOVE = 642,
    /// <summary>Newzealand Couriers.</summary>
    NEWZEALAND_COURIERS = 643,
    /// <summary>Etomars.</summary>
    ETOMARS = 644,
    /// <summary>Virtransport.</summary>
    VIRTRANSPORT = 645,
    /// <summary>Wizmo.</summary>
    WIZMO = 646,
    /// <summary>Palletways.</summary>
    PALLETWAYS = 647,
    /// <summary>I Dika.</summary>
    I_DIKA = 648,
    /// <summary>Cfl Logistics.</summary>
    CFL_LOGISTICS = 649,
    /// <summary>Gemworldwide.</summary>
    GEMWORLDWIDE = 650,
    /// <summary>Global Express.</summary>
    GLOBAL_EXPRESS = 651,
    /// <summary>Logistyx Transgroup.</summary>
    LOGISTYX_TRANSGROUP = 652,
    /// <summary>Westbank Courier.</summary>
    WESTBANK_COURIER = 653,
    /// <summary>Arco Spedizioni.</summary>
    ARCO_SPEDIZIONI = 654,
    /// <summary>Ydh Express.</summary>
    YDH_EXPRESS = 655,
    /// <summary>Parcelinklogistics.</summary>
    PARCELINKLOGISTICS = 656,
    /// <summary>Cndexpress.</summary>
    CNDEXPRESS = 657,
    /// <summary>Nox Night Time Express.</summary>
    NOX_NIGHT_TIME_EXPRESS = 658,
    /// <summary>Aeronet.</summary>
    AERONET = 659,
    /// <summary>Ltianexp.</summary>
    LTIANEXP = 660,
    /// <summary>Integra2 FTP.</summary>
    INTEGRA2_FTP = 661,
    /// <summary>Parcelone.</summary>
    PARCELONE = 662,
    /// <summary>Nox Nachtexpress.</summary>
    NOX_NACHTEXPRESS = 663,
    /// <summary>CN China Post Ems.</summary>
    CN_CHINA_POST_EMS = 664,
    /// <summary>Chukou1.</summary>
    CHUKOU1 = 665,
    /// <summary>GLS Slov.</summary>
    GLS_SLOV = 666,
    /// <summary>Orange Ds.</summary>
    ORANGE_DS = 667,
    /// <summary>Joom Logis.</summary>
    JOOM_LOGIS = 668,
    /// <summary>Aus Startrack.</summary>
    AUS_STARTRACK = 669,
    /// <summary>DHL.</summary>
    DHL = 670,
    /// <summary>GB APC.</summary>
    GB_APC = 671,
    /// <summary>Bondscouriers.</summary>
    BONDSCOURIERS = 672,
    /// <summary>Jpn Japan Post.</summary>
    JPN_JAPAN_POST = 673,
    /// <summary>USPS.</summary>
    USPS = 674,
    /// <summary>Winit.</summary>
    WINIT = 675,
    /// <summary>Arg Oca.</summary>
    ARG_OCA = 676,
    /// <summary>Tw Taiwan Post.</summary>
    TW_TAIWAN_POST = 677,
    /// <summary>Dmm Network.</summary>
    DMM_NETWORK = 678,
    /// <summary>TNT.</summary>
    TNT = 679,
    /// <summary>Bh Posta.</summary>
    BH_POSTA = 680,
    /// <summary>Swe Postnord.</summary>
    SWE_POSTNORD = 681,
    /// <summary>Ca Canada Post.</summary>
    CA_CANADA_POST = 682,
    /// <summary>Wiseloads.</summary>
    WISELOADS = 683,
    /// <summary>Asendia HK.</summary>
    ASENDIA_HK = 684,
    /// <summary>Nld GLS.</summary>
    NLD_GLS = 685,
    /// <summary>Mex Redpack.</summary>
    MEX_REDPACK = 686,
    /// <summary>Jet Ship.</summary>
    JET_SHIP = 687,
    /// <summary>DE DHL Express.</summary>
    DE_DHL_EXPRESS = 688,
    /// <summary>Ninjavan THai.</summary>
    NINJAVAN_THAI = 689,
    /// <summary>Raben Group.</summary>
    RABEN_GROUP = 690,
    /// <summary>Esp Asm.</summary>
    ESP_ASM = 691,
    /// <summary>Hrv Hrvatska.</summary>
    HRV_HRVATSKA = 692,
    /// <summary>Global EStes.</summary>
    GLOBAL_ESTES = 693,
    /// <summary>Ltu Lietuvos.</summary>
    LTU_LIETUVOS = 694,
    /// <summary>Bel DHL.</summary>
    BEL_DHL = 695,
    /// <summary>AU AU Post.</summary>
    AU_AU_POST = 696,
    /// <summary>Speedexcourier.</summary>
    SPEEDEXCOURIER = 697,
    /// <summary>FR Colis.</summary>
    FR_COLIS = 698,
    /// <summary>Aramex.</summary>
    ARAMEX = 699,
    /// <summary>Dpex.</summary>
    DPEX = 700,
    /// <summary>Mys Airpak.</summary>
    MYS_AIRPAK = 701,
    /// <summary>Cuckooexpress.</summary>
    CUCKOOEXPRESS = 702,
    /// <summary>DPD Poland.</summary>
    DPD_POLAND = 703,
    /// <summary>Nld Postnl.</summary>
    NLD_POSTNL = 704,
    /// <summary>Nim Express.</summary>
    NIM_EXPRESS = 705,
    /// <summary>Quantium.</summary>
    QUANTIUM = 706,
    /// <summary>Sendle.</summary>
    SENDLE = 707,
    /// <summary>Esp Redur.</summary>
    ESP_REDUR = 708,
    /// <summary>Matkahuolto.</summary>
    MATKAHUOLTO = 709,
    /// <summary>Cpacket.</summary>
    CPACKET = 710,
    /// <summary>Posti.</summary>
    POSTI = 711,
    /// <summary>Hunter Express.</summary>
    HUNTER_EXPRESS = 712,
    /// <summary>Choir Exp.</summary>
    CHOIR_EXP = 713,
    /// <summary>Legion Express.</summary>
    LEGION_EXPRESS = 714,
    /// <summary>Austrian Post Express.</summary>
    AUSTRIAN_POST_EXPRESS = 715,
    /// <summary>Grupo.</summary>
    GRUPO = 716,
    /// <summary>Posta Ro.</summary>
    POSTA_RO = 717,
    /// <summary>Interparcel Uk.</summary>
    INTERPARCEL_UK = 718,
    /// <summary>Global Abf.</summary>
    GLOBAL_ABF = 719,
    /// <summary>Posten Norge.</summary>
    POSTEN_NORGE = 720,
    /// <summary>Xpert DElivery.</summary>
    XPERT_DELIVERY = 721,
    /// <summary>DHL Refr.</summary>
    DHL_REFR = 722,
    /// <summary>DHL HK.</summary>
    DHL_HK = 723,
    /// <summary>Skynet Uae.</summary>
    SKYNET_UAE = 724,
    /// <summary>Gojek.</summary>
    GOJEK = 725,
    /// <summary>Yodel Intnl.</summary>
    YODEL_INTNL = 726,
    /// <summary>Janco.</summary>
    JANCO = 727,
    /// <summary>Yto.</summary>
    YTO = 728,
    /// <summary>Wise Express.</summary>
    WISE_EXPRESS = 729,
    /// <summary>Jtexpress VN.</summary>
    JTEXPRESS_VN = 730,
    /// <summary>FedEx Intl Mlserv.</summary>
    FEDEX_INTL_MLSERV = 731,
    /// <summary>Vamox.</summary>
    VAMOX = 732,
    /// <summary>Ams Grp.</summary>
    AMS_GRP = 733,
    /// <summary>DHL JP.</summary>
    DHL_JP = 734,
    /// <summary>Hrparcel.</summary>
    HRPARCEL = 735,
    /// <summary>Geswl.</summary>
    GESWL = 736,
    /// <summary>Bluestar.</summary>
    BLUESTAR = 737,
    /// <summary>Cdek Tr.</summary>
    CDEK_TR = 738,
    /// <summary>Descartes.</summary>
    DESCARTES = 739,
    /// <summary>Deltec Uk.</summary>
    DELTEC_UK = 740,
    /// <summary>Dtdc Express.</summary>
    DTDC_EXPRESS = 741,
    /// <summary>Tourline.</summary>
    TOURLINE = 742,
    /// <summary>Bh Worldwide.</summary>
    BH_WORLDWIDE = 743,
    /// <summary>Ocs.</summary>
    OCS = 744,
    /// <summary>Yingnuo Logistics.</summary>
    YINGNUO_LOGISTICS = 745,
    /// <summary>UPS.</summary>
    UPS = 746,
    /// <summary>Toll.</summary>
    TOLL = 747,
    /// <summary>Prt Seur.</summary>
    PRT_SEUR = 748,
    /// <summary>Dtdc AU.</summary>
    DTDC_AU = 749,
    /// <summary>Tha Dynamic Logistics.</summary>
    THA_DYNAMIC_LOGISTICS = 750,
    /// <summary>Ubi Logistics.</summary>
    UBI_LOGISTICS = 751,
    /// <summary>FedEx Crossborder.</summary>
    FEDEX_CROSSBORDER = 752,
    /// <summary>A1Post.</summary>
    A1POST = 753,
    /// <summary>Tazmanian FReight.</summary>
    TAZMANIAN_FREIGHT = 754,
    /// <summary>Cj Int MY.</summary>
    CJ_INT_MY = 755,
    /// <summary>Saia FReight.</summary>
    SAIA_FREIGHT = 756,
    /// <summary>SG Qxpress.</summary>
    SG_QXPRESS = 757,
    /// <summary>Nhans Solutions.</summary>
    NHANS_SOLUTIONS = 758,
    /// <summary>DPD FR.</summary>
    DPD_FR = 759,
    /// <summary>Coordinadora.</summary>
    COORDINADORA = 760,
    /// <summary>Andreani.</summary>
    ANDREANI = 761,
    /// <summary>Doora.</summary>
    DOORA = 762,
    /// <summary>Interparcel NZ.</summary>
    INTERPARCEL_NZ = 763,
    /// <summary>Phl Jamexpress.</summary>
    PHL_JAMEXPRESS = 764,
    /// <summary>Bel BElgium Post.</summary>
    BEL_BELGIUM_POST = 765,
    /// <summary>Us APC.</summary>
    US_APC = 766,
    /// <summary>Idn Pos.</summary>
    IDN_POS = 767,
    /// <summary>FR Mondial.</summary>
    FR_MONDIAL = 768,
    /// <summary>DE DHL.</summary>
    DE_DHL = 769,
    /// <summary>HK Rpx.</summary>
    HK_RPX = 770,
    /// <summary>DHL Pieceid.</summary>
    DHL_PIECEID = 771,
    /// <summary>Vnpost Ems.</summary>
    VNPOST_EMS = 772,
    /// <summary>Rrdonnelley.</summary>
    RRDONNELLEY = 773,
    /// <summary>DPD DE.</summary>
    DPD_DE = 774,
    /// <summary>Delcart In.</summary>
    DELCART_IN = 775,
    /// <summary>Imexglobalsolutions.</summary>
    IMEXGLOBALSOLUTIONS = 776,
    /// <summary>Acommerce.</summary>
    ACOMMERCE = 777,
    /// <summary>Eurodis.</summary>
    EURODIS = 778,
    /// <summary>Canpar.</summary>
    CANPAR = 779,
    /// <summary>GLS.</summary>
    GLS = 780,
    /// <summary>Ind Ecom.</summary>
    IND_ECOM = 781,
    /// <summary>Esp Envialia.</summary>
    ESP_ENVIALIA = 782,
    /// <summary>DHL Uk.</summary>
    DHL_UK = 783,
    /// <summary>Smsa Express.</summary>
    SMSA_EXPRESS = 784,
    /// <summary>TNT FR.</summary>
    TNT_FR = 785,
    /// <summary>Dex I.</summary>
    DEX_I = 786,
    /// <summary>Budbee Webhook.</summary>
    BUDBEE_WEBHOOK = 787,
    /// <summary>Copa Courier.</summary>
    COPA_COURIER = 788,
    /// <summary>Vnm Vietnam Post.</summary>
    VNM_VIETNAM_POST = 789,
    /// <summary>DPD HK.</summary>
    DPD_HK = 790,
    /// <summary>Toll NZ.</summary>
    TOLL_NZ = 791,
    /// <summary>Echo.</summary>
    ECHO = 792,
    /// <summary>FedEx FR.</summary>
    FEDEX_FR = 793,
    /// <summary>Borderexpress.</summary>
    BORDEREXPRESS = 794,
    /// <summary>Mailplus JPn.</summary>
    MAILPLUS_JPN = 795,
    /// <summary>TNT Uk Refr.</summary>
    TNT_UK_REFR = 796,
    /// <summary>Kec.</summary>
    KEC = 797,
    /// <summary>DPD Ro.</summary>
    DPD_RO = 798,
    /// <summary>TNT JP.</summary>
    TNT_JP = 799,
    /// <summary>TH Cj.</summary>
    TH_CJ = 800,
    /// <summary>Ec CN.</summary>
    EC_CN = 801,
    /// <summary>Fastway Uk.</summary>
    FASTWAY_UK = 802,
    /// <summary>Fastway Us.</summary>
    FASTWAY_US = 803,
    /// <summary>GLS DE.</summary>
    GLS_DE = 804,
    /// <summary>GLS ES.</summary>
    GLS_ES = 805,
    /// <summary>GLS FR.</summary>
    GLS_FR = 806,
    /// <summary>Mondial BE.</summary>
    MONDIAL_BE = 807,
    /// <summary>Sgt IT.</summary>
    SGT_IT = 808,
    /// <summary>TNT CN.</summary>
    TNT_CN = 809,
    /// <summary>TNT DE.</summary>
    TNT_DE = 810,
    /// <summary>TNT ES.</summary>
    TNT_ES = 811,
    /// <summary>TNT PL.</summary>
    TNT_PL = 812,
    /// <summary>Parcelforce.</summary>
    PARCELFORCE = 813,
    /// <summary>Swiss Post.</summary>
    SWISS_POST = 814,
    /// <summary>Toll Ipec.</summary>
    TOLL_IPEC = 815,
    /// <summary>Air 21.</summary>
    AIR_21 = 816,
    /// <summary>Airspeed.</summary>
    AIRSPEED = 817,
    /// <summary>Bert.</summary>
    BERT = 818,
    /// <summary>Bluedart.</summary>
    BLUEDART = 819,
    /// <summary>Collectplus.</summary>
    COLLECTPLUS = 820,
    /// <summary>Courierplus.</summary>
    COURIERPLUS = 821,
    /// <summary>Courier Post.</summary>
    COURIER_POST = 822,
    /// <summary>DHL Global Mail.</summary>
    DHL_GLOBAL_MAIL = 823,
    /// <summary>DPD Uk.</summary>
    DPD_UK = 824,
    /// <summary>Deltec DE.</summary>
    DELTEC_DE = 825,
    /// <summary>Deutsche DE.</summary>
    DEUTSCHE_DE = 826,
    /// <summary>Dotzot.</summary>
    DOTZOT = 827,
    /// <summary>Elta Gr.</summary>
    ELTA_GR = 828,
    /// <summary>Ems CN.</summary>
    EMS_CN = 829,
    /// <summary>Ecargo.</summary>
    ECARGO = 830,
    /// <summary>Ensenda.</summary>
    ENSENDA = 831,
    /// <summary>Fercam IT.</summary>
    FERCAM_IT = 832,
    /// <summary>Fastway ZA.</summary>
    FASTWAY_ZA = 833,
    /// <summary>Fastway AU.</summary>
    FASTWAY_AU = 834,
    /// <summary>First Logisitcs.</summary>
    FIRST_LOGISITCS = 835,
    /// <summary>Geodis.</summary>
    GEODIS = 836,
    /// <summary>Globegistics.</summary>
    GLOBEGISTICS = 837,
    /// <summary>Greyhound.</summary>
    GREYHOUND = 838,
    /// <summary>Jetship MY.</summary>
    JETSHIP_MY = 839,
    /// <summary>Lion Parcel.</summary>
    LION_PARCEL = 840,
    /// <summary>Aeroflash.</summary>
    AEROFLASH = 841,
    /// <summary>Ontrac.</summary>
    ONTRAC = 842,
    /// <summary>Sagawa.</summary>
    SAGAWA = 843,
    /// <summary>Siodemka.</summary>
    SIODEMKA = 844,
    /// <summary>Startrack.</summary>
    STARTRACK = 845,
    /// <summary>TNT AU.</summary>
    TNT_AU = 846,
    /// <summary>TNT IT.</summary>
    TNT_IT = 847,
    /// <summary>Transmission.</summary>
    TRANSMISSION = 848,
    /// <summary>Yamato.</summary>
    YAMATO = 849,
    /// <summary>DHL IT.</summary>
    DHL_IT = 850,
    /// <summary>DHL AT.</summary>
    DHL_AT = 851,
    /// <summary>Logisticsworldwide KR.</summary>
    LOGISTICSWORLDWIDE_KR = 852,
    /// <summary>GLS Spain.</summary>
    GLS_SPAIN = 853,
    /// <summary>Amazon Uk API.</summary>
    AMAZON_UK_API = 854,
    /// <summary>DPD FR Reference.</summary>
    DPD_FR_REFERENCE = 855,
    /// <summary>DHLparcel Uk.</summary>
    DHLPARCEL_UK = 856,
    /// <summary>Megasave.</summary>
    MEGASAVE = 857,
    /// <summary>Qualitypost.</summary>
    QUALITYPOST = 858,
    /// <summary>Ids Logistics.</summary>
    IDS_LOGISTICS = 859,
    /// <summary>Joyingbox.</summary>
    JOYINGBOX = 860,
    /// <summary>Panther Order Number.</summary>
    PANTHER_ORDER_NUMBER = 861,
    /// <summary>Watkins Shepard.</summary>
    WATKINS_SHEPARD = 862,
    /// <summary>Fasttrack.</summary>
    FASTTRACK = 863,
    /// <summary>Up Express.</summary>
    UP_EXPRESS = 864,
    /// <summary>Elogistica.</summary>
    ELOGISTICA = 865,
    /// <summary>Ecourier.</summary>
    ECOURIER = 866,
    /// <summary>Cj PHilippines.</summary>
    CJ_PHILIPPINES = 867,
    /// <summary>Speedex.</summary>
    SPEEDEX = 868,
    /// <summary>Orangeconnex.</summary>
    ORANGECONNEX = 869,
    /// <summary>Tecor.</summary>
    TECOR = 870,
    /// <summary>Saee.</summary>
    SAEE = 871,
    /// <summary>GLS ITaly FTP.</summary>
    GLS_ITALY_FTP = 872,
    /// <summary>Delivere.</summary>
    DELIVERE = 873,
    /// <summary>Yycom.</summary>
    YYCOM = 874,
    /// <summary>Adicional Pt.</summary>
    ADICIONAL_PT = 875,
    /// <summary>Dksh.</summary>
    DKSH = 876,
    /// <summary>Nippon Express FTP.</summary>
    NIPPON_EXPRESS_FTP = 877,
    /// <summary>Gols.</summary>
    GOLS = 878,
    /// <summary>Fujexp.</summary>
    FUJEXP = 879,
    /// <summary>Qtrack.</summary>
    QTRACK = 880,
    /// <summary>Omlogistics API.</summary>
    OMLOGISTICS_API = 881,
    /// <summary>Gdpharm.</summary>
    GDPHARM = 882,
    /// <summary>Misumi CN.</summary>
    MISUMI_CN = 883,
    /// <summary>Air Canada.</summary>
    AIR_CANADA = 884,
    /// <summary>City56 Webhook.</summary>
    CITY56_WEBHOOK = 885,
    /// <summary>Sagawa API.</summary>
    SAGAWA_API = 886,
    /// <summary>Kedaex.</summary>
    KEDAEX = 887,
    /// <summary>Pgeon API.</summary>
    PGEON_API = 888,
    /// <summary>Weworldexpress.</summary>
    WEWORLDEXPRESS = 889,
    /// <summary>Jt Logistics.</summary>
    JT_LOGISTICS = 890,
    /// <summary>Trusk.</summary>
    TRUSK = 891,
    /// <summary>Viaxpress.</summary>
    VIAXPRESS = 892,
    /// <summary>DHL Supplychain ID.</summary>
    DHL_SUPPLYCHAIN_ID = 893,
    /// <summary>Zuelligpharma SFTP.</summary>
    ZUELLIGPHARMA_SFTP = 894,
    /// <summary>Meest.</summary>
    MEEST = 895,
    /// <summary>Toll Priority.</summary>
    TOLL_PRIORITY = 896,
    /// <summary>Mothership API.</summary>
    MOTHERSHIP_API = 897,
    /// <summary>Capital.</summary>
    CAPITAL = 898,
    /// <summary>Europaket API.</summary>
    EUROPAKET_API = 899,
    /// <summary>Hfd.</summary>
    HFD = 900,
    /// <summary>Tourline Reference.</summary>
    TOURLINE_REFERENCE = 901,
    /// <summary>Gio Ecourier.</summary>
    GIO_ECOURIER = 902,
    /// <summary>CN Logistics.</summary>
    CN_LOGISTICS = 903,
    /// <summary>Pandion.</summary>
    PANDION = 904,
    /// <summary>Bpost API.</summary>
    BPOST_API = 905,
    /// <summary>Passportshipping.</summary>
    PASSPORTSHIPPING = 906,
    /// <summary>Pakajo.</summary>
    PAKAJO = 907,
    /// <summary>Dachser.</summary>
    DACHSER = 908,
    /// <summary>Yusen SFTP.</summary>
    YUSEN_SFTP = 909,
    /// <summary>Shyplite.</summary>
    SHYPLITE = 910,
    /// <summary>Xyy.</summary>
    XYY = 911,
    /// <summary>Mwd.</summary>
    MWD = 912,
    /// <summary>Faxecargo.</summary>
    FAXECARGO = 913,
    /// <summary>Mazet.</summary>
    MAZET = 914,
    /// <summary>First Logistics API.</summary>
    FIRST_LOGISTICS_API = 915,
    /// <summary>Sprint Pack.</summary>
    SPRINT_PACK = 916,
    /// <summary>Hermes DE FTP.</summary>
    HERMES_DE_FTP = 917,
    /// <summary>Concise.</summary>
    CONCISE = 918,
    /// <summary>Kerry Express Tw API.</summary>
    KERRY_EXPRESS_TW_API = 919,
    /// <summary>Ewe.</summary>
    EWE = 920,
    /// <summary>Fastdespatch.</summary>
    FASTDESPATCH = 921,
    /// <summary>Abcustom SFTP.</summary>
    ABCUSTOM_SFTP = 922,
    /// <summary>Chazki.</summary>
    CHAZKI = 923,
    /// <summary>Shippie.</summary>
    SHIPPIE = 924,
    /// <summary>Geodis API.</summary>
    GEODIS_API = 925,
    /// <summary>Naqel Express.</summary>
    NAQEL_EXPRESS = 926,
    /// <summary>Papa Webhook.</summary>
    PAPA_WEBHOOK = 927,
    /// <summary>Forwardair.</summary>
    FORWARDAIR = 928,
    /// <summary>Dialogo Logistica API.</summary>
    DIALOGO_LOGISTICA_API = 929,
    /// <summary>Lalamove API.</summary>
    LALAMOVE_API = 930,
    /// <summary>Tomydoor.</summary>
    TOMYDOOR = 931,
    /// <summary>Kronos Webhook.</summary>
    KRONOS_WEBHOOK = 932,
    /// <summary>Jtcargo.</summary>
    JTCARGO = 933,
    /// <summary>T Cat.</summary>
    T_CAT = 934,
    /// <summary>Concise Webhook.</summary>
    CONCISE_WEBHOOK = 935,
    /// <summary>Teleport Webhook.</summary>
    TELEPORT_WEBHOOK = 936,
    /// <summary>Customco API.</summary>
    CUSTOMCO_API = 937,
    /// <summary>Spx TH.</summary>
    SPX_TH = 938,
    /// <summary>Bollore Logistics.</summary>
    BOLLORE_LOGISTICS = 939,
    /// <summary>Clicklink SFTP.</summary>
    CLICKLINK_SFTP = 940,
    /// <summary>M3Logistics.</summary>
    M3LOGISTICS = 941,
    /// <summary>Vnpost API.</summary>
    VNPOST_API = 942,
    /// <summary>Axlehire FTP.</summary>
    AXLEHIRE_FTP = 943,
    /// <summary>Shadowfax.</summary>
    SHADOWFAX = 944,
    /// <summary>Myhermes Uk API.</summary>
    MYHERMES_UK_API = 945,
    /// <summary>Daiichi.</summary>
    DAIICHI = 946,
    /// <summary>Mensajerosurbanos API.</summary>
    MENSAJEROSURBANOS_API = 947,
    /// <summary>Polarspeed.</summary>
    POLARSPEED = 948,
    /// <summary>Idexpress ID.</summary>
    IDEXPRESS_ID = 949,
    /// <summary>Payo.</summary>
    PAYO = 950,
    /// <summary>Whistl SFTP.</summary>
    WHISTL_SFTP = 951,
    /// <summary>Intex DE.</summary>
    INTEX_DE = 952,
    /// <summary>Trans2U.</summary>
    TRANS2U = 953,
    /// <summary>Productcaregroup SFTP.</summary>
    PRODUCTCAREGROUP_SFTP = 954,
    /// <summary>Bigsmart.</summary>
    BIGSMART = 955,
    /// <summary>Expeditors API Ref.</summary>
    EXPEDITORS_API_REF = 956,
    /// <summary>Aitworldwide API.</summary>
    AITWORLDWIDE_API = 957,
    /// <summary>Worldcourier.</summary>
    WORLDCOURIER = 958,
    /// <summary>Quiqup.</summary>
    QUIQUP = 959,
    /// <summary>Agediss SFTP.</summary>
    AGEDISS_SFTP = 960,
    /// <summary>Andreani API.</summary>
    ANDREANI_API = 961,
    /// <summary>Crlexpress.</summary>
    CRLEXPRESS = 962,
    /// <summary>Smartcat.</summary>
    SMARTCAT = 963,
    /// <summary>Crossflight.</summary>
    CROSSFLIGHT = 964,
    /// <summary>Procarrier.</summary>
    PROCARRIER = 965,
    /// <summary>DHL Reference API.</summary>
    DHL_REFERENCE_API = 966,
    /// <summary>Seino API.</summary>
    SEINO_API = 967,
    /// <summary>Wspexpress.</summary>
    WSPEXPRESS = 968,
    /// <summary>Kronos.</summary>
    KRONOS = 969,
    /// <summary>Total Express API.</summary>
    TOTAL_EXPRESS_API = 970,
    /// <summary>Parcll.</summary>
    PARCLL = 971,
    /// <summary>Xpedigo.</summary>
    XPEDIGO = 972,
    /// <summary>Star Track Webhook.</summary>
    STAR_TRACK_WEBHOOK = 973,
    /// <summary>Gpost.</summary>
    GPOST = 974,
    /// <summary>Ucs.</summary>
    UCS = 975,
    /// <summary>Dmfgroup.</summary>
    DMFGROUP = 976,
    /// <summary>Coordinadora API.</summary>
    COORDINADORA_API = 977,
    /// <summary>Marken.</summary>
    MARKEN = 978,
    /// <summary>Ntl.</summary>
    NTL = 979,
    /// <summary>Redjepakketje.</summary>
    REDJEPAKKETJE = 980,
    /// <summary>Allied Express FTP.</summary>
    ALLIED_EXPRESS_FTP = 981,
    /// <summary>Mondialrelay ES.</summary>
    MONDIALRELAY_ES = 982,
    /// <summary>Naeko FTP.</summary>
    NAEKO_FTP = 983,
    /// <summary>Mhi.</summary>
    MHI = 984,
    /// <summary>Shippify.</summary>
    SHIPPIFY = 985,
    /// <summary>Malca Amit API.</summary>
    MALCA_AMIT_API = 986,
    /// <summary>Jtexpress SG API.</summary>
    JTEXPRESS_SG_API = 987,
    /// <summary>Dachser Web.</summary>
    DACHSER_WEB = 988,
    /// <summary>Flightlg.</summary>
    FLIGHTLG = 989,
    /// <summary>Cago.</summary>
    CAGO = 990,
    /// <summary>Com1Express.</summary>
    COM1EXPRESS = 991,
    /// <summary>Tonami FTP.</summary>
    TONAMI_FTP = 992,
    /// <summary>Packfleet.</summary>
    PACKFLEET = 993,
    /// <summary>Purolator International.</summary>
    PUROLATOR_INTERNATIONAL = 994,
    /// <summary>Wineshipping Webhook.</summary>
    WINESHIPPING_WEBHOOK = 995,
    /// <summary>DHL ES SFTP.</summary>
    DHL_ES_SFTP = 996,
    /// <summary>Pchome API.</summary>
    PCHOME_API = 997,
    /// <summary>Ceskaposta API.</summary>
    CESKAPOSTA_API = 998,
    /// <summary>Gorush.</summary>
    GORUSH = 999,
    /// <summary>Homerunner.</summary>
    HOMERUNNER = 1000,
    /// <summary>Amazon Order.</summary>
    AMAZON_ORDER = 1001,
    /// <summary>Efwnow API.</summary>
    EFWNOW_API = 1002,
    /// <summary>Cbl Logistica API.</summary>
    CBL_LOGISTICA_API = 1003,
    /// <summary>Nimbuspost.</summary>
    NIMBUSPOST = 1004,
    /// <summary>Logwin Logistics.</summary>
    LOGWIN_LOGISTICS = 1005,
    /// <summary>Nowlog API.</summary>
    NOWLOG_API = 1006,
    /// <summary>DPD NL.</summary>
    DPD_NL = 1007,
    /// <summary>Godependable.</summary>
    GODEPENDABLE = 1008,
    /// <summary>Esdex.</summary>
    ESDEX = 1009,
    /// <summary>Logisystems SFTP.</summary>
    LOGISYSTEMS_SFTP = 1010,
    /// <summary>Expeditors.</summary>
    EXPEDITORS = 1011,
    /// <summary>Sntglobal API.</summary>
    SNTGLOBAL_API = 1012,
    /// <summary>Shipx.</summary>
    SHIPX = 1013,
    /// <summary>Qintl API.</summary>
    QINTL_API = 1014,
    /// <summary>Packs.</summary>
    PACKS = 1015,
    /// <summary>Postnl International.</summary>
    POSTNL_INTERNATIONAL = 1016,
    /// <summary>Amazon Email Push.</summary>
    AMAZON_EMAIL_PUSH = 1017,
    /// <summary>DHL API.</summary>
    DHL_API = 1018,
    /// <summary>Spx.</summary>
    SPX = 1019,
    /// <summary>Axlehire.</summary>
    AXLEHIRE = 1020,
    /// <summary>Icscourier.</summary>
    ICSCOURIER = 1021,
    /// <summary>Dialogo Logistica.</summary>
    DIALOGO_LOGISTICA = 1022,
    /// <summary>Shunbang Express.</summary>
    SHUNBANG_EXPRESS = 1023,
    /// <summary>Tcs API.</summary>
    TCS_API = 1024,
    /// <summary>Sf Express CN.</summary>
    SF_EXPRESS_CN = 1025,
    /// <summary>Packeta.</summary>
    PACKETA = 1026,
    /// <summary>Sic Teliway.</summary>
    SIC_TELIWAY = 1027,
    /// <summary>Mondialrelay FR.</summary>
    MONDIALRELAY_FR = 1028,
    /// <summary>Intime FTP.</summary>
    INTIME_FTP = 1029,
    /// <summary>Jd Express.</summary>
    JD_EXPRESS = 1030,
    /// <summary>Fastbox.</summary>
    FASTBOX = 1031,
    /// <summary>Patheon.</summary>
    PATHEON = 1032,
    /// <summary>India Post.</summary>
    INDIA_POST = 1033,
    /// <summary>Tipsa Ref.</summary>
    TIPSA_REF = 1034,
    /// <summary>Ecofreight.</summary>
    ECOFREIGHT = 1035,
    /// <summary>Vox.</summary>
    VOX = 1036,
    /// <summary>Directfreight AU Ref.</summary>
    DIRECTFREIGHT_AU_REF = 1037,
    /// <summary>Besttransport SFTP.</summary>
    BESTTRANSPORT_SFTP = 1038,
    /// <summary>Australia Post API.</summary>
    AUSTRALIA_POST_API = 1039,
    /// <summary>Fragilepak SFTP.</summary>
    FRAGILEPAK_SFTP = 1040,
    /// <summary>Flipxp.</summary>
    FLIPXP = 1041,
    /// <summary>Value Webhook.</summary>
    VALUE_WEBHOOK = 1042,
    /// <summary>Daeshin.</summary>
    DAESHIN = 1043,
    /// <summary>Sherpa.</summary>
    SHERPA = 1044,
    /// <summary>Mwd API.</summary>
    MWD_API = 1045,
    /// <summary>Smartkargo.</summary>
    SMARTKARGO = 1046,
    /// <summary>Dnj Express.</summary>
    DNJ_EXPRESS = 1047,
    /// <summary>Gopeople.</summary>
    GOPEOPLE = 1048,
    /// <summary>Mysendle API.</summary>
    MYSENDLE_API = 1049,
    /// <summary>Aramex API.</summary>
    ARAMEX_API = 1050,
    /// <summary>Pidge.</summary>
    PIDGE = 1051,
    /// <summary>Thaiparcels.</summary>
    THAIPARCELS = 1052,
    /// <summary>Panther Reference API.</summary>
    PANTHER_REFERENCE_API = 1053,
    /// <summary>Postaplus.</summary>
    POSTAPLUS = 1054,
    /// <summary>Buffalo.</summary>
    BUFFALO = 1055,
    /// <summary>U Envios.</summary>
    U_ENVIOS = 1056,
    /// <summary>Elite Co.</summary>
    ELITE_CO = 1057,
    /// <summary>Roche Internal SFTP.</summary>
    ROCHE_INTERNAL_SFTP = 1058,
    /// <summary>Dbschenker Iceland.</summary>
    DBSCHENKER_ICELAND = 1059,
    /// <summary>TNT FR Reference.</summary>
    TNT_FR_REFERENCE = 1060,
    /// <summary>Newgisticsapi.</summary>
    NEWGISTICSAPI = 1061,
    /// <summary>Glovo.</summary>
    GLOVO = 1062,
    /// <summary>Gwlogis API.</summary>
    GWLOGIS_API = 1063,
    /// <summary>Spreetail API.</summary>
    SPREETAIL_API = 1064,
    /// <summary>Moova.</summary>
    MOOVA = 1065,
    /// <summary>Plycongroup.</summary>
    PLYCONGROUP = 1066,
    /// <summary>USPS Webhook.</summary>
    USPS_WEBHOOK = 1067,
    /// <summary>Reimaginedelivery.</summary>
    REIMAGINEDELIVERY = 1068,
    /// <summary>Edf FTP.</summary>
    EDF_FTP = 1069,
    /// <summary>Dao365.</summary>
    DAO365 = 1070,
    /// <summary>Biocair FTP.</summary>
    BIOCAIR_FTP = 1071,
    /// <summary>Ransa Webhook.</summary>
    RANSA_WEBHOOK = 1072,
    /// <summary>Shipxpres.</summary>
    SHIPXPRES = 1073,
    /// <summary>Courant PLus API.</summary>
    COURANT_PLUS_API = 1074,
    /// <summary>Shipa.</summary>
    SHIPA = 1075,
    /// <summary>Homelogistics.</summary>
    HOMELOGISTICS = 1076,
    /// <summary>Dx.</summary>
    DX = 1077,
    /// <summary>Poste ITaliane Paccocelere.</summary>
    POSTE_ITALIANE_PACCOCELERE = 1078,
    /// <summary>Toll Webhook.</summary>
    TOLL_WEBHOOK = 1079,
    /// <summary>Lctbr API.</summary>
    LCTBR_API = 1080,
    /// <summary>Dx FReight.</summary>
    DX_FREIGHT = 1081,
    /// <summary>DHL SFTP.</summary>
    DHL_SFTP = 1082,
    /// <summary>Shiprocket.</summary>
    SHIPROCKET = 1083,
    /// <summary>Uber Webhook.</summary>
    UBER_WEBHOOK = 1084,
    /// <summary>Statovernight.</summary>
    STATOVERNIGHT = 1085,
    /// <summary>Burd.</summary>
    BURD = 1086,
    /// <summary>Fastship.</summary>
    FASTSHIP = 1087,
    /// <summary>Ibventure Webhook.</summary>
    IBVENTURE_WEBHOOK = 1088,
    /// <summary>Gati Kwe API.</summary>
    GATI_KWE_API = 1089,
    /// <summary>Cryopdp FTP.</summary>
    CRYOPDP_FTP = 1090,
    /// <summary>Hubbed.</summary>
    HUBBED = 1091,
    /// <summary>Tipsa API.</summary>
    TIPSA_API = 1092,
    /// <summary>Araskargo.</summary>
    ARASKARGO = 1093,
    /// <summary>Thijs NL.</summary>
    THIJS_NL = 1094,
    /// <summary>Atshealthcare Reference.</summary>
    ATSHEALTHCARE_REFERENCE = 1095,
    /// <summary>Nintynineminutos.</summary>
    NINTYNINEMINUTOS = 1096,
    /// <summary>Hellenic Post.</summary>
    HELLENIC_POST = 1097,
    /// <summary>Hsm Global.</summary>
    HSM_GLOBAL = 1098,
    /// <summary>Mnx.</summary>
    MNX = 1099,
    /// <summary>Nmtransfer.</summary>
    NMTRANSFER = 1100,
    /// <summary>Logysto.</summary>
    LOGYSTO = 1101,
    /// <summary>India Post Int.</summary>
    INDIA_POST_INT = 1102,
    /// <summary>Amazon Fba Swiship In.</summary>
    AMAZON_FBA_SWISHIP_IN = 1103,
    /// <summary>Srt Transport.</summary>
    SRT_TRANSPORT = 1104,
    /// <summary>Bomi.</summary>
    BOMI = 1105,
    /// <summary>Deliverr SFTP.</summary>
    DELIVERR_SFTP = 1106,
    /// <summary>Hsdexpress.</summary>
    HSDEXPRESS = 1107,
    /// <summary>Simpletire Webhook.</summary>
    SIMPLETIRE_WEBHOOK = 1108,
    /// <summary>Hunter Express SFTP.</summary>
    HUNTER_EXPRESS_SFTP = 1109,
    /// <summary>UPS API.</summary>
    UPS_API = 1110,
    /// <summary>Wooyoung Logistics SFTP.</summary>
    WOOYOUNG_LOGISTICS_SFTP = 1111,
    /// <summary>Phse API.</summary>
    PHSE_API = 1112,
    /// <summary>Wish Email Push.</summary>
    WISH_EMAIL_PUSH = 1113,
    /// <summary>Northline.</summary>
    NORTHLINE = 1114,
    /// <summary>Medafrica.</summary>
    MEDAFRICA = 1115,
    /// <summary>DPD AT SFTP.</summary>
    DPD_AT_SFTP = 1116,
    /// <summary>Anteraja.</summary>
    ANTERAJA = 1117,
    /// <summary>DHL Global Forwarding API.</summary>
    DHL_GLOBAL_FORWARDING_API = 1118,
    /// <summary>Lbcexpress API.</summary>
    LBCEXPRESS_API = 1119,
    /// <summary>Simsglobal.</summary>
    SIMSGLOBAL = 1120,
    /// <summary>Cdldelivers.</summary>
    CDLDELIVERS = 1121,
    /// <summary>Typ.</summary>
    TYP = 1122,
    /// <summary>Testing Courier Webhook.</summary>
    TESTING_COURIER_WEBHOOK = 1123,
    /// <summary>Pandago API.</summary>
    PANDAGO_API = 1124,
    /// <summary>Royal Mail FTP.</summary>
    ROYAL_MAIL_FTP = 1125,
    /// <summary>Thunderexpress.</summary>
    THUNDEREXPRESS = 1126,
    /// <summary>Secretlab Webhook.</summary>
    SECRETLAB_WEBHOOK = 1127,
    /// <summary>Setel.</summary>
    SETEL = 1128,
    /// <summary>Jd Worldwide.</summary>
    JD_WORLDWIDE = 1129,
    /// <summary>DPD Ru API.</summary>
    DPD_RU_API = 1130,
    /// <summary>Argents Webhook.</summary>
    ARGENTS_WEBHOOK = 1131,
    /// <summary>Postone.</summary>
    POSTONE = 1132,
    /// <summary>Tusklogistics.</summary>
    TUSKLOGISTICS = 1133,
    /// <summary>Rhenus Uk API.</summary>
    RHENUS_UK_API = 1134,
    /// <summary>Taqbin SG API.</summary>
    TAQBIN_SG_API = 1135,
    /// <summary>Inntralog SFTP.</summary>
    INNTRALOG_SFTP = 1136,
    /// <summary>Dayross.</summary>
    DAYROSS = 1137,
    /// <summary>Correosexpress API.</summary>
    CORREOSEXPRESS_API = 1138,
    /// <summary>International Seur API.</summary>
    INTERNATIONAL_SEUR_API = 1139,
    /// <summary>Yodel API.</summary>
    YODEL_API = 1140,
    /// <summary>Heroexpress.</summary>
    HEROEXPRESS = 1141,
    /// <summary>DHL Supplychain In.</summary>
    DHL_SUPPLYCHAIN_IN = 1142,
    /// <summary>Urgent Cargus.</summary>
    URGENT_CARGUS = 1143,
    /// <summary>Frontdoorcorp.</summary>
    FRONTDOORCORP = 1144,
    /// <summary>Jtexpress PH.</summary>
    JTEXPRESS_PH = 1145,
    /// <summary>Parcelstars Webhook.</summary>
    PARCELSTARS_WEBHOOK = 1146,
    /// <summary>DPD Sk SFTP.</summary>
    DPD_SK_SFTP = 1147,
    /// <summary>Movianto.</summary>
    MOVIANTO = 1148,
    /// <summary>Ozeparts Shipping.</summary>
    OZEPARTS_SHIPPING = 1149,
    /// <summary>Kargomkolay.</summary>
    KARGOMKOLAY = 1150,
    /// <summary>Trunkrs.</summary>
    TRUNKRS = 1151,
    /// <summary>Omnirps Webhook.</summary>
    OMNIRPS_WEBHOOK = 1152,
    /// <summary>Chilexpress.</summary>
    CHILEXPRESS = 1153,
    /// <summary>Testing Courier.</summary>
    TESTING_COURIER = 1154,
    /// <summary>Jne API.</summary>
    JNE_API = 1155,
    /// <summary>Bjshomedelivery FTP.</summary>
    BJSHOMEDELIVERY_FTP = 1156,
    /// <summary>Dexpress Webhook.</summary>
    DEXPRESS_WEBHOOK = 1157,
    /// <summary>USPS API.</summary>
    USPS_API = 1158,
    /// <summary>Transvirtual.</summary>
    TRANSVIRTUAL = 1159,
    /// <summary>Solistica API.</summary>
    SOLISTICA_API = 1160,
    /// <summary>Chienventure Webhook.</summary>
    CHIENVENTURE_WEBHOOK = 1161,
    /// <summary>DPD Uk SFTP.</summary>
    DPD_UK_SFTP = 1162,
    /// <summary>Inpost Uk.</summary>
    INPOST_UK = 1163,
    /// <summary>Javit.</summary>
    JAVIT = 1164,
    /// <summary>Zto Domestic.</summary>
    ZTO_DOMESTIC = 1165,
    /// <summary>DHL Gt API.</summary>
    DHL_GT_API = 1166,
    /// <summary>Ceva Tracking.</summary>
    CEVA_TRACKING = 1167,
    /// <summary>Komon Express.</summary>
    KOMON_EXPRESS = 1168,
    /// <summary>Eastwestcourier FTP.</summary>
    EASTWESTCOURIER_FTP = 1169,
    /// <summary>Danniao.</summary>
    DANNIAO = 1170,
    /// <summary>Spectran.</summary>
    SPECTRAN = 1171,
    /// <summary>Deliver IT.</summary>
    DELIVER_IT = 1172,
    /// <summary>Relaiscolis.</summary>
    RELAISCOLIS = 1173,
    /// <summary>GLS Spain API.</summary>
    GLS_SPAIN_API = 1174,
    /// <summary>Postplus.</summary>
    POSTPLUS = 1175,
    /// <summary>Airterra.</summary>
    AIRTERRA = 1176,
    /// <summary>Gio Ecourier API.</summary>
    GIO_ECOURIER_API = 1177,
    /// <summary>DPD Ch SFTP.</summary>
    DPD_CH_SFTP = 1178,
    /// <summary>FedEx API.</summary>
    FEDEX_API = 1179,
    /// <summary>Intersmarttrans.</summary>
    INTERSMARTTRANS = 1180,
    /// <summary>Hermes Uk SFTP.</summary>
    HERMES_UK_SFTP = 1181,
    /// <summary>Exelot FTP.</summary>
    EXELOT_FTP = 1182,
    /// <summary>DHL Pa API.</summary>
    DHL_PA_API = 1183,
    /// <summary>Virtransport SFTP.</summary>
    VIRTRANSPORT_SFTP = 1184,
    /// <summary>Worldnet.</summary>
    WORLDNET = 1185,
    /// <summary>Instabox Webhook.</summary>
    INSTABOX_WEBHOOK = 1186,
    /// <summary>Kng.</summary>
    KNG = 1187,
    /// <summary>Flashexpress Webhook.</summary>
    FLASHEXPRESS_WEBHOOK = 1188,
    /// <summary>Magyar Posta API.</summary>
    MAGYAR_POSTA_API = 1189,
    /// <summary>Weship API.</summary>
    WESHIP_API = 1190,
    /// <summary>Ohi Webhook.</summary>
    OHI_WEBHOOK = 1191,
    /// <summary>Mudita.</summary>
    MUDITA = 1192,
    /// <summary>Bluedart API.</summary>
    BLUEDART_API = 1193,
    /// <summary>T Cat API.</summary>
    T_CAT_API = 1194,
    /// <summary>Ads.</summary>
    ADS = 1195,
    /// <summary>Hermes IT.</summary>
    HERMES_IT = 1196,
    /// <summary>Fitzmark API.</summary>
    FITZMARK_API = 1197,
    /// <summary>Posti API.</summary>
    POSTI_API = 1198,
    /// <summary>Smsa Express Webhook.</summary>
    SMSA_EXPRESS_WEBHOOK = 1199,
    /// <summary>Tamergroup Webhook.</summary>
    TAMERGROUP_WEBHOOK = 1200,
    /// <summary>Livrapide.</summary>
    LIVRAPIDE = 1201,
    /// <summary>Nippon Express.</summary>
    NIPPON_EXPRESS = 1202,
    /// <summary>Bettertrucks.</summary>
    BETTERTRUCKS = 1203,
    /// <summary>Fan.</summary>
    FAN = 1204,
    /// <summary>Pb USPSflats FTP.</summary>
    PB_USPSFLATS_FTP = 1205,
    /// <summary>Parcelright.</summary>
    PARCELRIGHT = 1206,
    /// <summary>Ithinklogistics.</summary>
    ITHINKLOGISTICS = 1207,
    /// <summary>Kerry Express TH Webhook.</summary>
    KERRY_EXPRESS_TH_WEBHOOK = 1208,
    /// <summary>Ecoutier.</summary>
    ECOUTIER = 1209,
    /// <summary>Showl.</summary>
    SHOWL = 1210,
    /// <summary>Brt IT API.</summary>
    BRT_IT_API = 1211,
    /// <summary>Rixonhk API.</summary>
    RIXONHK_API = 1212,
    /// <summary>Dbschenker API.</summary>
    DBSCHENKER_API = 1213,
    /// <summary>Ilyanglogis.</summary>
    ILYANGLOGIS = 1214,
    /// <summary>Mail Box Etc.</summary>
    MAIL_BOX_ETC = 1215,
    /// <summary>Weship.</summary>
    WESHIP = 1216,
    /// <summary>DHL Global Mail API.</summary>
    DHL_GLOBAL_MAIL_API = 1217,
    /// <summary>Activos24 API.</summary>
    ACTIVOS24_API = 1218,
    /// <summary>Atshealthcare.</summary>
    ATSHEALTHCARE = 1219,
    /// <summary>Luwjistik.</summary>
    LUWJISTIK = 1220,
    /// <summary>Gw World.</summary>
    GW_WORLD = 1221,
    /// <summary>Fairsenden API.</summary>
    FAIRSENDEN_API = 1222,
    /// <summary>Servip Webhook.</summary>
    SERVIP_WEBHOOK = 1223,
    /// <summary>Swiship.</summary>
    SWISHIP = 1224,
    /// <summary>Tanet.</summary>
    TANET = 1225,
    /// <summary>Hotsin Cargo.</summary>
    HOTSIN_CARGO = 1226,
    /// <summary>Direx.</summary>
    DIREX = 1227,
    /// <summary>Huantong.</summary>
    HUANTONG = 1228,
    /// <summary>Imile API.</summary>
    IMILE_API = 1229,
    /// <summary>Auexpress.</summary>
    AUEXPRESS = 1230,
    /// <summary>Nytlogistics.</summary>
    NYTLOGISTICS = 1231,
    /// <summary>Dsv Reference.</summary>
    DSV_REFERENCE = 1232,
    /// <summary>Novofarma Webhook.</summary>
    NOVOFARMA_WEBHOOK = 1233,
    /// <summary>Aitworldwide SFTP.</summary>
    AITWORLDWIDE_SFTP = 1234,
    /// <summary>Shopolive.</summary>
    SHOPOLIVE = 1235,
    /// <summary>Fnf ZA.</summary>
    FNF_ZA = 1236,
    /// <summary>DHL Ecommerce Gc.</summary>
    DHL_ECOMMERCE_GC = 1237,
    /// <summary>Fetchr.</summary>
    FETCHR = 1238,
    /// <summary>Starlinks API.</summary>
    STARLINKS_API = 1239,
    /// <summary>Yyexpress.</summary>
    YYEXPRESS = 1240,
    /// <summary>Servientrega.</summary>
    SERVIENTREGA = 1241,
    /// <summary>Hanjin.</summary>
    HANJIN = 1242,
    /// <summary>Spanish Seur FTP.</summary>
    SPANISH_SEUR_FTP = 1243,
    /// <summary>Dx B2B Connum.</summary>
    DX_B2B_CONNUM = 1244,
    /// <summary>Helthjem API.</summary>
    HELTHJEM_API = 1245,
    /// <summary>Inexpost.</summary>
    INEXPOST = 1246,
    /// <summary>A2B Ba.</summary>
    A2B_BA = 1247,
    /// <summary>Rhenus Group.</summary>
    RHENUS_GROUP = 1248,
    /// <summary>Sberlogistics Ru.</summary>
    SBERLOGISTICS_RU = 1249,
    /// <summary>Malca Amit.</summary>
    MALCA_AMIT = 1250,
    /// <summary>Ppl.</summary>
    PPL = 1251,
    /// <summary>Osm Worldwide SFTP.</summary>
    OSM_WORLDWIDE_SFTP = 1252,
    /// <summary>Acilogistix.</summary>
    ACILOGISTIX = 1253,
    /// <summary>Optimacourier.</summary>
    OPTIMACOURIER = 1254,
    /// <summary>Nova Poshta API.</summary>
    NOVA_POSHTA_API = 1255,
    /// <summary>Loggi.</summary>
    LOGGI = 1256,
    /// <summary>Yifan.</summary>
    YIFAN = 1257,
    /// <summary>Mydynalogic.</summary>
    MYDYNALOGIC = 1258,
    /// <summary>Morninglobal.</summary>
    MORNINGLOBAL = 1259,
    /// <summary>Concise API.</summary>
    CONCISE_API = 1260,
    /// <summary>Fxtran.</summary>
    FXTRAN = 1261,
    /// <summary>Deliveryourparcel ZA.</summary>
    DELIVERYOURPARCEL_ZA = 1262,
    /// <summary>Uparcel.</summary>
    UPARCEL = 1263,
    /// <summary>Mobi BR.</summary>
    MOBI_BR = 1264,
    /// <summary>Loginext Webhook.</summary>
    LOGINEXT_WEBHOOK = 1265,
    /// <summary>Ems.</summary>
    EMS = 1266,
    /// <summary>Speedy.</summary>
    SPEEDY = 1267,
    /// <summary>Zoom Red.</summary>
    ZOOM_RED = 1268,
    /// <summary>Navlungo.</summary>
    NAVLUNGO = 1269,
    /// <summary>Castleparcels.</summary>
    CASTLEPARCELS = 1270,
    /// <summary>Weee.</summary>
    WEEE = 1271,
    /// <summary>Packaly.</summary>
    PACKALY = 1272,
    /// <summary>Yunhuipost.</summary>
    YUNHUIPOST = 1273,
    /// <summary>Youparcel.</summary>
    YOUPARCEL = 1274,
    /// <summary>Leman.</summary>
    LEMAN = 1275,
    /// <summary>Moovin.</summary>
    MOOVIN = 1276,
    /// <summary>Urb IT.</summary>
    URB_IT = 1277,
    /// <summary>Multientregapanama.</summary>
    MULTIENTREGAPANAMA = 1278,
    /// <summary>Jusdasr.</summary>
    JUSDASR = 1279,
    /// <summary>Discountpost.</summary>
    DISCOUNTPOST = 1280,
    /// <summary>Rhenus Uk.</summary>
    RHENUS_UK = 1281,
    /// <summary>Swiship JP.</summary>
    SWISHIP_JP = 1282,
    /// <summary>GLS Us.</summary>
    GLS_US = 1283,
    /// <summary>Smtl.</summary>
    SMTL = 1284,
    /// <summary>Emega.</summary>
    EMEGA = 1285,
    /// <summary>Expressone Sv.</summary>
    EXPRESSONE_SV = 1286,
    /// <summary>Hepsijet.</summary>
    HEPSIJET = 1287,
    /// <summary>Welivery.</summary>
    WELIVERY = 1288,
    /// <summary>Bringer.</summary>
    BRINGER = 1289,
    /// <summary>Easyroutes.</summary>
    EASYROUTES = 1290,
    /// <summary>Mrw.</summary>
    MRW = 1291,
    /// <summary>Rpm.</summary>
    RPM = 1292,
    /// <summary>DPD Prt.</summary>
    DPD_PRT = 1293,
    /// <summary>GLS Romania.</summary>
    GLS_ROMANIA = 1294,
    /// <summary>Lmparcel.</summary>
    LMPARCEL = 1295,
    /// <summary>Gtagsm.</summary>
    GTAGSM = 1296,
    /// <summary>Domino.</summary>
    DOMINO = 1297,
    /// <summary>Eshipper.</summary>
    ESHIPPER = 1298,
    /// <summary>Transpak.</summary>
    TRANSPAK = 1299,
    /// <summary>Xindus.</summary>
    XINDUS = 1300,
    /// <summary>Aoyue.</summary>
    AOYUE = 1301,
    /// <summary>Easyparcel.</summary>
    EASYPARCEL = 1302,
    /// <summary>Expressone.</summary>
    EXPRESSONE = 1303,
    /// <summary>Sendeo Kargo.</summary>
    SENDEO_KARGO = 1304,
    /// <summary>Speedaf.</summary>
    SPEEDAF = 1305,
    /// <summary>Etower.</summary>
    ETOWER = 1306,
    /// <summary>Gcx.</summary>
    GCX = 1307,
    /// <summary>Ninjavan VN.</summary>
    NINJAVAN_VN = 1308,
    /// <summary>Allegro.</summary>
    ALLEGRO = 1309,
    /// <summary>Jumppoint.</summary>
    JUMPPOINT = 1310,
    /// <summary>Shipglobal Us.</summary>
    SHIPGLOBAL_US = 1311,
    /// <summary>Kinisi.</summary>
    KINISI = 1312,
    /// <summary>Oakh.</summary>
    OAKH = 1313,
    /// <summary>Awest.</summary>
    AWEST = 1314,
    /// <summary>Barsan.</summary>
    BARSAN = 1315,
    /// <summary>Energologistic.</summary>
    ENERGOLOGISTIC = 1316,
    /// <summary>Madrooex.</summary>
    MADROOEX = 1317,
    /// <summary>Gobolt.</summary>
    GOBOLT = 1318,
    /// <summary>Swiss Universal Express.</summary>
    SWISS_UNIVERSAL_EXPRESS = 1319,
    /// <summary>Iordirect.</summary>
    IORDIRECT = 1320,
    /// <summary>Xmszm.</summary>
    XMSZM = 1321,
    /// <summary>GLS Hun.</summary>
    GLS_HUN = 1322,
    /// <summary>Sendy.</summary>
    SENDY = 1323,
    /// <summary>Braunsexpress.</summary>
    BRAUNSEXPRESS = 1324,
    /// <summary>Grandslamexpress.</summary>
    GRANDSLAMEXPRESS = 1325,
    /// <summary>Xgs.</summary>
    XGS = 1326,
    /// <summary>Otschile.</summary>
    OTSCHILE = 1327,
    /// <summary>Pack Up.</summary>
    PACK_UP = 1328,
    /// <summary>Parcelstars.</summary>
    PARCELSTARS = 1329,
    /// <summary>Teamexpressllc.</summary>
    TEAMEXPRESSLLC = 1330,
    /// <summary>Asyadexpress.</summary>
    ASYADEXPRESS = 1331,
    /// <summary>Tdn.</summary>
    TDN = 1332,
    /// <summary>Earlybird.</summary>
    EARLYBIRD = 1333,
    /// <summary>Cacesa.</summary>
    CACESA = 1334,
    /// <summary>Parceljet.</summary>
    PARCELJET = 1335,
    /// <summary>Mng Kargo.</summary>
    MNG_KARGO = 1336,
    /// <summary>Superpackline.</summary>
    SUPERPACKLINE = 1337,
    /// <summary>Speedx.</summary>
    SPEEDX = 1338,
    /// <summary>Vesyl.</summary>
    VESYL = 1339,
    /// <summary>Skyking.</summary>
    SKYKING = 1340,
    /// <summary>Dirmensajeria.</summary>
    DIRMENSAJERIA = 1341,
    /// <summary>Netlogixgroup.</summary>
    NETLOGIXGROUP = 1342,
    /// <summary>Zyou.</summary>
    ZYOU = 1343,
    /// <summary>Jawar.</summary>
    JAWAR = 1344,
    /// <summary>Agsystems.</summary>
    AGSYSTEMS = 1345,
    /// <summary>Gps.</summary>
    GPS = 1346,
    /// <summary>Ptt Kargo.</summary>
    PTT_KARGO = 1347,
    /// <summary>Maergo.</summary>
    MAERGO = 1348,
    /// <summary>Arihantcourier.</summary>
    ARIHANTCOURIER = 1349,
    /// <summary>Vtfe.</summary>
    VTFE = 1350,
    /// <summary>Yunant.</summary>
    YUNANT = 1351,
    /// <summary>Urbify.</summary>
    URBIFY = 1352,
    /// <summary>Pack Man.</summary>
    PACK_MAN = 1353,
    /// <summary>Liefergrun.</summary>
    LIEFERGRUN = 1354,
    /// <summary>Obibox.</summary>
    OBIBOX = 1355,
    /// <summary>Paikeda.</summary>
    PAIKEDA = 1356,
    /// <summary>Scotty.</summary>
    SCOTTY = 1357,
    /// <summary>Intelcom Ca.</summary>
    INTELCOM_CA = 1358,
    /// <summary>Swe.</summary>
    SWE = 1359,
    /// <summary>Asendia.</summary>
    ASENDIA = 1360,
    /// <summary>DPD AT.</summary>
    DPD_AT = 1361,
    /// <summary>Relay.</summary>
    RELAY = 1362,
    /// <summary>Ata.</summary>
    ATA = 1363,
    /// <summary>Skyexpress International.</summary>
    SKYEXPRESS_INTERNATIONAL = 1364,
    /// <summary>Surat Kargo.</summary>
    SURAT_KARGO = 1365,
    /// <summary>Sglink.</summary>
    SGLINK = 1366,
    /// <summary>Fleetopticsinc.</summary>
    FLEETOPTICSINC = 1367,
    /// <summary>Shopline.</summary>
    SHOPLINE = 1368,
    /// <summary>Piggyship.</summary>
    PIGGYSHIP = 1369,
    /// <summary>Logoix.</summary>
    LOGOIX = 1370,
    /// <summary>Kolay Gelsin.</summary>
    KOLAY_GELSIN = 1371,
    /// <summary>Associated Couriers.</summary>
    ASSOCIATED_COURIERS = 1372,
    /// <summary>UPS Checker.</summary>
    UPS_CHECKER = 1373,
    /// <summary>Wineshipping.</summary>
    WINESHIPPING = 1374,
    /// <summary>Spedisci.</summary>
    SPEDISCI = 1375,
    /// <summary>Fourkites.</summary>
    FOURKITES = 1376,
    /// <summary>Etonas.</summary>
    ETONAS = 1377,
    /// <summary>Finmile.</summary>
    FINMILE = 1378,
    /// <summary>Uniuni.</summary>
    UNIUNI = 1379,
    /// <summary>Rodonaves.</summary>
    RODONAVES = 1380,
    /// <summary>Inpost IT.</summary>
    INPOST_IT = 1381,
    /// <summary>Tforce FReight.</summary>
    TFORCE_FREIGHT = 1382,
    /// <summary>Richmom.</summary>
    RICHMOM = 1383,
    /// <summary>Franco.</summary>
    FRANCO = 1384,
    /// <summary>Ecparcel.</summary>
    ECPARCEL = 1385,
    /// <summary>FedEx China.</summary>
    FEDEX_CHINA = 1386,
    /// <summary>Gofo Express.</summary>
    GOFO_EXPRESS = 1387,
    /// <summary>Shipbob.</summary>
    SHIPBOB = 1388,
    /// <summary>Jerseypost ATlas.</summary>
    JERSEYPOST_ATLAS = 1389,
    /// <summary>Coretrails.</summary>
    CORETRAILS = 1390,
    /// <summary>Rhenus ITaly.</summary>
    RHENUS_ITALY = 1391,
    /// <summary>Jadlog.</summary>
    JADLOG = 1392,
    /// <summary>Jitsu.</summary>
    JITSU = 1393,
    /// <summary>Yanwen Express.</summary>
    YANWEN_EXPRESS = 1394,
    /// <summary>Dashlink.</summary>
    DASHLINK = 1395,
    /// <summary>Seino Super Express.</summary>
    SEINO_SUPER_EXPRESS = 1396,
    /// <summary>Floship.</summary>
    FLOSHIP = 1397,
    /// <summary>Metroscg.</summary>
    METROSCG = 1398,
    /// <summary>Sendparcel.</summary>
    SENDPARCEL = 1399,
    /// <summary>P2P.</summary>
    P2P = 1400,
    /// <summary>CN Express.</summary>
    CN_EXPRESS = 1401,
    /// <summary>Cirrotrack.</summary>
    CIRROTRACK = 1402,
    /// <summary>Land Logistics.</summary>
    LAND_LOGISTICS = 1403,
    /// <summary>Veho.</summary>
    VEHO = 1404,
    /// <summary>Medline.</summary>
    MEDLINE = 1405,
    /// <summary>Vdtrack.</summary>
    VDTRACK = 1406,
    /// <summary>Sino Scm.</summary>
    SINO_SCM = 1407,
    /// <summary>Threepe Express.</summary>
    THREEPE_EXPRESS = 1408,
    /// <summary>Swiftx.</summary>
    SWIFTX = 1409,
    /// <summary>Sfydexpress.</summary>
    SFYDEXPRESS = 1410,
    /// <summary>Toptrans.</summary>
    TOPTRANS = 1411,
    /// <summary>Other.</summary>
    OTHER = 1412
}
