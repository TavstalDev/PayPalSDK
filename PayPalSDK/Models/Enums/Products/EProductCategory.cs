using System.Text.Json.Serialization;

namespace Tavstal.PayPalSDK.Models.Enums.Products;
/// <summary>
/// The category of a product for PayPal classification.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<EProductCategory>))]
public enum EProductCategory
{
    /// <summary>Ac Refrigeration Repair</summary>
    AC_REFRIGERATION_REPAIR = 0,
    /// <summary>Academic Software</summary>
    ACADEMIC_SOFTWARE = 1,
    /// <summary>Accessories</summary>
    ACCESSORIES = 2,
    /// <summary>Accounting</summary>
    ACCOUNTING = 3,
    /// <summary>Adult</summary>
    ADULT = 4,
    /// <summary>Advertising</summary>
    ADVERTISING = 5,
    /// <summary>Affiliated Auto Rental</summary>
    AFFILIATED_AUTO_RENTAL = 6,
    /// <summary>Agencies</summary>
    AGENCIES = 7,
    /// <summary>Aggregators</summary>
    AGGREGATORS = 8,
    /// <summary>Agricultural Cooperative For Mail Order</summary>
    AGRICULTURAL_COOPERATIVE_FOR_MAIL_ORDER = 9,
    /// <summary>Air Carriers Airlines</summary>
    AIR_CARRIERS_AIRLINES = 10,
    /// <summary>Airlines</summary>
    AIRLINES = 11,
    /// <summary>Airports Flying Fields</summary>
    AIRPORTS_FLYING_FIELDS = 12,
    /// <summary>Alcoholic Beverages</summary>
    ALCOHOLIC_BEVERAGES = 13,
    /// <summary>Amusement Parks Carnivals</summary>
    AMUSEMENT_PARKS_CARNIVALS = 14,
    /// <summary>Animation</summary>
    ANIMATION = 15,
    /// <summary>Antiques</summary>
    ANTIQUES = 16,
    /// <summary>Appliances</summary>
    APPLIANCES = 17,
    /// <summary>Aquariams Seaquariums Dolphinariums</summary>
    AQUARIAMS_SEAQUARIUMS_DOLPHINARIUMS = 18,
    /// <summary>Architectural Engineering And Surveying Services</summary>
    ARCHITECTURAL_ENGINEERING_AND_SURVEYING_SERVICES = 19,
    /// <summary>Art And Craft Supplies</summary>
    ART_AND_CRAFT_SUPPLIES = 20,
    /// <summary>Art Dealers And Galleries</summary>
    ART_DEALERS_AND_GALLERIES = 21,
    /// <summary>Artifacts Grave Related And Native American Crafts</summary>
    ARTIFACTS_GRAVE_RELATED_AND_NATIVE_AMERICAN_CRAFTS = 22,
    /// <summary>Arts And Crafts</summary>
    ARTS_AND_CRAFTS = 23,
    /// <summary>Arts Crafts And Collectibles</summary>
    ARTS_CRAFTS_AND_COLLECTIBLES = 24,
    /// <summary>Audio Books</summary>
    AUDIO_BOOKS = 25,
    /// <summary>Auto Associations Clubs</summary>
    AUTO_ASSOCIATIONS_CLUBS = 26,
    /// <summary>Auto Dealer Used Only</summary>
    AUTO_DEALER_USED_ONLY = 27,
    /// <summary>Auto Rentals</summary>
    AUTO_RENTALS = 28,
    /// <summary>Auto Service</summary>
    AUTO_SERVICE = 29,
    /// <summary>Automated Fuel Dispensers</summary>
    AUTOMATED_FUEL_DISPENSERS = 30,
    /// <summary>Automobile Associations</summary>
    AUTOMOBILE_ASSOCIATIONS = 31,
    /// <summary>Automotive</summary>
    AUTOMOTIVE = 32,
    /// <summary>Automotive Repair Shops Non Dealer</summary>
    AUTOMOTIVE_REPAIR_SHOPS_NON_DEALER = 33,
    /// <summary>Automotive Top And Body Shops</summary>
    AUTOMOTIVE_TOP_AND_BODY_SHOPS = 34,
    /// <summary>Aviation</summary>
    AVIATION = 35,
    /// <summary>Babies Clothing And Supplies</summary>
    BABIES_CLOTHING_AND_SUPPLIES = 36,
    /// <summary>Baby</summary>
    BABY = 37,
    /// <summary>Bands Orchestras Entertainers</summary>
    BANDS_ORCHESTRAS_ENTERTAINERS = 38,
    /// <summary>Barbies</summary>
    BARBIES = 39,
    /// <summary>Bath And Body</summary>
    BATH_AND_BODY = 40,
    /// <summary>Batteries</summary>
    BATTERIES = 41,
    /// <summary>Bean Babies</summary>
    BEAN_BABIES = 42,
    /// <summary>Beauty</summary>
    BEAUTY = 43,
    /// <summary>Beauty And Fragrances</summary>
    BEAUTY_AND_FRAGRANCES = 44,
    /// <summary>Bed And Bath</summary>
    BED_AND_BATH = 45,
    /// <summary>Bicycle Shops Sales And Service</summary>
    BICYCLE_SHOPS_SALES_AND_SERVICE = 46,
    /// <summary>Bicycles And Accessories</summary>
    BICYCLES_AND_ACCESSORIES = 47,
    /// <summary>Billiard Pool Establishments</summary>
    BILLIARD_POOL_ESTABLISHMENTS = 48,
    /// <summary>Boat Dealers</summary>
    BOAT_DEALERS = 49,
    /// <summary>Boat Rentals And Leasing</summary>
    BOAT_RENTALS_AND_LEASING = 50,
    /// <summary>Boating Sailing And Accessories</summary>
    BOATING_SAILING_AND_ACCESSORIES = 51,
    /// <summary>Books</summary>
    BOOKS = 52,
    /// <summary>Books And Magazines</summary>
    BOOKS_AND_MAGAZINES = 53,
    /// <summary>Books Manuscripts</summary>
    BOOKS_MANUSCRIPTS = 54,
    /// <summary>Books Periodicals And Newspapers</summary>
    BOOKS_PERIODICALS_AND_NEWSPAPERS = 55,
    /// <summary>Bowling Alleys</summary>
    BOWLING_ALLEYS = 56,
    /// <summary>Bulletin Board</summary>
    BULLETIN_BOARD = 57,
    /// <summary>Bus Line</summary>
    BUS_LINE = 58,
    /// <summary>Bus Lines Charters Tour Buses</summary>
    BUS_LINES_CHARTERS_TOUR_BUSES = 59,
    /// <summary>Business</summary>
    BUSINESS = 60,
    /// <summary>Business And Secretarial Schools</summary>
    BUSINESS_AND_SECRETARIAL_SCHOOLS = 61,
    /// <summary>Buying And Shopping Services And Clubs</summary>
    BUYING_AND_SHOPPING_SERVICES_AND_CLUBS = 62,
    /// <summary>Cable Satellite And Other Pay Television And Radio Services</summary>
    CABLE_SATELLITE_AND_OTHER_PAY_TELEVISION_AND_RADIO_SERVICES = 63,
    /// <summary>Cable Satellite And Other Pay Tv And Radio</summary>
    CABLE_SATELLITE_AND_OTHER_PAY_TV_AND_RADIO = 64,
    /// <summary>Camera And Photographic Supplies</summary>
    CAMERA_AND_PHOTOGRAPHIC_SUPPLIES = 65,
    /// <summary>Cameras</summary>
    CAMERAS = 66,
    /// <summary>Cameras And Photography</summary>
    CAMERAS_AND_PHOTOGRAPHY = 67,
    /// <summary>Camper Recreational And Utility Trailer Dealers</summary>
    CAMPER_RECREATIONAL_AND_UTILITY_TRAILER_DEALERS = 68,
    /// <summary>Camping And Outdoors</summary>
    CAMPING_AND_OUTDOORS = 69,
    /// <summary>Camping And Survival</summary>
    CAMPING_AND_SURVIVAL = 70,
    /// <summary>Car And Truck Dealers</summary>
    CAR_AND_TRUCK_DEALERS = 71,
    /// <summary>Car And Truck Dealers Used Only</summary>
    CAR_AND_TRUCK_DEALERS_USED_ONLY = 72,
    /// <summary>Car Audio And Electronics</summary>
    CAR_AUDIO_AND_ELECTRONICS = 73,
    /// <summary>Car Rental Agency</summary>
    CAR_RENTAL_AGENCY = 74,
    /// <summary>Catalog Merchant</summary>
    CATALOG_MERCHANT = 75,
    /// <summary>Catalog Retail Merchant</summary>
    CATALOG_RETAIL_MERCHANT = 76,
    /// <summary>Catering Services</summary>
    CATERING_SERVICES = 77,
    /// <summary>Charity</summary>
    CHARITY = 78,
    /// <summary>Check Cashier</summary>
    CHECK_CASHIER = 79,
    /// <summary>Child Care Services</summary>
    CHILD_CARE_SERVICES = 80,
    /// <summary>Children Books</summary>
    CHILDREN_BOOKS = 81,
    /// <summary>Chiropodists Podiatrists</summary>
    CHIROPODISTS_PODIATRISTS = 82,
    /// <summary>Chiropractors</summary>
    CHIROPRACTORS = 83,
    /// <summary>Cigar Stores And Stands</summary>
    CIGAR_STORES_AND_STANDS = 84,
    /// <summary>Civic Social Fraternal Associations</summary>
    CIVIC_SOCIAL_FRATERNAL_ASSOCIATIONS = 85,
    /// <summary>Civil Social Frat Associations</summary>
    CIVIL_SOCIAL_FRAT_ASSOCIATIONS = 86,
    /// <summary>Clothing</summary>
    CLOTHING = 87,
    /// <summary>Clothing Accessories And Shoes</summary>
    CLOTHING_ACCESSORIES_AND_SHOES = 88,
    /// <summary>Clothing Rental</summary>
    CLOTHING_RENTAL = 89,
    /// <summary>Coffee And Tea</summary>
    COFFEE_AND_TEA = 90,
    /// <summary>Coin Operated Banks And Casinos</summary>
    COIN_OPERATED_BANKS_AND_CASINOS = 91,
    /// <summary>Collectibles</summary>
    COLLECTIBLES = 92,
    /// <summary>Collection Agency</summary>
    COLLECTION_AGENCY = 93,
    /// <summary>Colleges And Universities</summary>
    COLLEGES_AND_UNIVERSITIES = 94,
    /// <summary>Commercial Equipment</summary>
    COMMERCIAL_EQUIPMENT = 95,
    /// <summary>Commercial Footwear</summary>
    COMMERCIAL_FOOTWEAR = 96,
    /// <summary>Commercial Photography</summary>
    COMMERCIAL_PHOTOGRAPHY = 97,
    /// <summary>Commercial Photography Art And Graphics</summary>
    COMMERCIAL_PHOTOGRAPHY_ART_AND_GRAPHICS = 98,
    /// <summary>Commercial Sports Professiona</summary>
    COMMERCIAL_SPORTS_PROFESSIONA = 99,
    /// <summary>Commodities And Futures Exchange</summary>
    COMMODITIES_AND_FUTURES_EXCHANGE = 100,
    /// <summary>Computer And Data Processing Services</summary>
    COMPUTER_AND_DATA_PROCESSING_SERVICES = 101,
    /// <summary>Computer Hardware And Software</summary>
    COMPUTER_HARDWARE_AND_SOFTWARE = 102,
    /// <summary>Computer Maintenance Repair And Services Not Elsewhere Clas</summary>
    COMPUTER_MAINTENANCE_REPAIR_AND_SERVICES_NOT_ELSEWHERE_CLAS = 103,
    /// <summary>Construction</summary>
    CONSTRUCTION = 104,
    /// <summary>Construction Materials Not Elsewhere Classified</summary>
    CONSTRUCTION_MATERIALS_NOT_ELSEWHERE_CLASSIFIED = 105,
    /// <summary>Consulting Services</summary>
    CONSULTING_SERVICES = 106,
    /// <summary>Consumer Credit Reporting Agencies</summary>
    CONSUMER_CREDIT_REPORTING_AGENCIES = 107,
    /// <summary>Convalescent Homes</summary>
    CONVALESCENT_HOMES = 108,
    /// <summary>Cosmetic Stores</summary>
    COSMETIC_STORES = 109,
    /// <summary>Counseling Services Debt Marriage Personal</summary>
    COUNSELING_SERVICES_DEBT_MARRIAGE_PERSONAL = 110,
    /// <summary>Counterfeit Currency And Stamps</summary>
    COUNTERFEIT_CURRENCY_AND_STAMPS = 111,
    /// <summary>Counterfeit Items</summary>
    COUNTERFEIT_ITEMS = 112,
    /// <summary>Country Clubs</summary>
    COUNTRY_CLUBS = 113,
    /// <summary>Courier Services</summary>
    COURIER_SERVICES = 114,
    /// <summary>Courier Services Air And Ground And Freight Forwarders</summary>
    COURIER_SERVICES_AIR_AND_GROUND_AND_FREIGHT_FORWARDERS = 115,
    /// <summary>Court Costs Alimny Child Supt</summary>
    COURT_COSTS_ALIMNY_CHILD_SUPT = 116,
    /// <summary>Court Costs Including Alimony And Child Support Courts Of Law</summary>
    COURT_COSTS_INCLUDING_ALIMONY_AND_CHILD_SUPPORT_COURTS_OF_LAW = 117,
    /// <summary>Credit Cards</summary>
    CREDIT_CARDS = 118,
    /// <summary>Credit Union</summary>
    CREDIT_UNION = 119,
    /// <summary>Culture And Religion</summary>
    CULTURE_AND_RELIGION = 120,
    /// <summary>Dairy Products Stores</summary>
    DAIRY_PRODUCTS_STORES = 121,
    /// <summary>Dance Halls Studios And Schools</summary>
    DANCE_HALLS_STUDIOS_AND_SCHOOLS = 122,
    /// <summary>Decorative</summary>
    DECORATIVE = 123,
    /// <summary>Dental</summary>
    DENTAL = 124,
    /// <summary>Dentists And Orthodontists</summary>
    DENTISTS_AND_ORTHODONTISTS = 125,
    /// <summary>Department Stores</summary>
    DEPARTMENT_STORES = 126,
    /// <summary>Desktop Pcs</summary>
    DESKTOP_PCS = 127,
    /// <summary>Devices</summary>
    DEVICES = 128,
    /// <summary>Diecast Toys Vehicles</summary>
    DIECAST_TOYS_VEHICLES = 129,
    /// <summary>Digital Games</summary>
    DIGITAL_GAMES = 130,
    /// <summary>Digital Media Books Movies Music</summary>
    DIGITAL_MEDIA_BOOKS_MOVIES_MUSIC = 131,
    /// <summary>Direct Marketing</summary>
    DIRECT_MARKETING = 132,
    /// <summary>Direct Marketing Catalog Merchant</summary>
    DIRECT_MARKETING_CATALOG_MERCHANT = 133,
    /// <summary>Direct Marketing Inbound Tele</summary>
    DIRECT_MARKETING_INBOUND_TELE = 134,
    /// <summary>Direct Marketing Outbound Tele</summary>
    DIRECT_MARKETING_OUTBOUND_TELE = 135,
    /// <summary>Direct Marketing Subscription</summary>
    DIRECT_MARKETING_SUBSCRIPTION = 136,
    /// <summary>Discount Stores</summary>
    DISCOUNT_STORES = 137,
    /// <summary>Door To Door Sales</summary>
    DOOR_TO_DOOR_SALES = 138,
    /// <summary>Drapery Window Covering And Upholstery</summary>
    DRAPERY_WINDOW_COVERING_AND_UPHOLSTERY = 139,
    /// <summary>Drinking Places</summary>
    DRINKING_PLACES = 140,
    /// <summary>Drugstore</summary>
    DRUGSTORE = 141,
    /// <summary>Durable Goods</summary>
    DURABLE_GOODS = 142,
    /// <summary>Ecommerce Development</summary>
    ECOMMERCE_DEVELOPMENT = 143,
    /// <summary>Ecommerce Services</summary>
    ECOMMERCE_SERVICES = 144,
    /// <summary>Educational And Textbooks</summary>
    EDUCATIONAL_AND_TEXTBOOKS = 145,
    /// <summary>Electric Razor Stores</summary>
    ELECTRIC_RAZOR_STORES = 146,
    /// <summary>Electrical And Small Appliance Repair</summary>
    ELECTRICAL_AND_SMALL_APPLIANCE_REPAIR = 147,
    /// <summary>Electrical Contractors</summary>
    ELECTRICAL_CONTRACTORS = 148,
    /// <summary>Electrical Parts And Equipment</summary>
    ELECTRICAL_PARTS_AND_EQUIPMENT = 149,
    /// <summary>Electronic Cash</summary>
    ELECTRONIC_CASH = 150,
    /// <summary>Elementary And Secondary Schools</summary>
    ELEMENTARY_AND_SECONDARY_SCHOOLS = 151,
    /// <summary>Employment</summary>
    EMPLOYMENT = 152,
    /// <summary>Entertainers</summary>
    ENTERTAINERS = 153,
    /// <summary>Entertainment And Media</summary>
    ENTERTAINMENT_AND_MEDIA = 154,
    /// <summary>Equip Tool Furniture And Appliance Rental And Leasing</summary>
    EQUIP_TOOL_FURNITURE_AND_APPLIANCE_RENTAL_AND_LEASING = 155,
    /// <summary>Escrow</summary>
    ESCROW = 156,
    /// <summary>Event And Wedding Planning</summary>
    EVENT_AND_WEDDING_PLANNING = 157,
    /// <summary>Exercise And Fitness</summary>
    EXERCISE_AND_FITNESS = 158,
    /// <summary>Exercise Equipment</summary>
    EXERCISE_EQUIPMENT = 159,
    /// <summary>Exterminating And Disinfecting Services</summary>
    EXTERMINATING_AND_DISINFECTING_SERVICES = 160,
    /// <summary>Fabrics And Sewing</summary>
    FABRICS_AND_SEWING = 161,
    /// <summary>Family Clothing Stores</summary>
    FAMILY_CLOTHING_STORES = 162,
    /// <summary>Fashion Jewelry</summary>
    FASHION_JEWELRY = 163,
    /// <summary>Fast Food Restaurants</summary>
    FAST_FOOD_RESTAURANTS = 164,
    /// <summary>Fiction And Nonfiction</summary>
    FICTION_AND_NONFICTION = 165,
    /// <summary>Finance Company</summary>
    FINANCE_COMPANY = 166,
    /// <summary>Financial And Investment Advice</summary>
    FINANCIAL_AND_INVESTMENT_ADVICE = 167,
    /// <summary>Financial Institutions Merchandise And Services</summary>
    FINANCIAL_INSTITUTIONS_MERCHANDISE_AND_SERVICES = 168,
    /// <summary>Firearm Accessories</summary>
    FIREARM_ACCESSORIES = 169,
    /// <summary>Firearms Weapons And Knives</summary>
    FIREARMS_WEAPONS_AND_KNIVES = 170,
    /// <summary>Fireplace And Fireplace Screens</summary>
    FIREPLACE_AND_FIREPLACE_SCREENS = 171,
    /// <summary>Fireworks</summary>
    FIREWORKS = 172,
    /// <summary>Fishing</summary>
    FISHING = 173,
    /// <summary>Florists</summary>
    FLORISTS = 174,
    /// <summary>Flowers</summary>
    FLOWERS = 175,
    /// <summary>Food Drink And Nutrition</summary>
    FOOD_DRINK_AND_NUTRITION = 176,
    /// <summary>Food Products</summary>
    FOOD_PRODUCTS = 177,
    /// <summary>Food Retail And Service</summary>
    FOOD_RETAIL_AND_SERVICE = 178,
    /// <summary>Fragrances And Perfumes</summary>
    FRAGRANCES_AND_PERFUMES = 179,
    /// <summary>Freezer And Locker Meat Provisioners</summary>
    FREEZER_AND_LOCKER_MEAT_PROVISIONERS = 180,
    /// <summary>Fuel Dealers Fuel Oil Wood And Coal</summary>
    FUEL_DEALERS_FUEL_OIL_WOOD_AND_COAL = 181,
    /// <summary>Fuel Dealers Non Automotive</summary>
    FUEL_DEALERS_NON_AUTOMOTIVE = 182,
    /// <summary>Funeral Services And Crematories</summary>
    FUNERAL_SERVICES_AND_CREMATORIES = 183,
    /// <summary>Furnishing And Decorating</summary>
    FURNISHING_AND_DECORATING = 184,
    /// <summary>Furniture</summary>
    FURNITURE = 185,
    /// <summary>Furriers And Fur Shops</summary>
    FURRIERS_AND_FUR_SHOPS = 186,
    /// <summary>Gadgets And Other Electronics</summary>
    GADGETS_AND_OTHER_ELECTRONICS = 187,
    /// <summary>Gambling</summary>
    GAMBLING = 188,
    /// <summary>Game Software</summary>
    GAME_SOFTWARE = 189,
    /// <summary>Games</summary>
    GAMES = 190,
    /// <summary>Garden Supplies</summary>
    GARDEN_SUPPLIES = 191,
    /// <summary>General</summary>
    GENERAL = 192,
    /// <summary>General Contractors</summary>
    GENERAL_CONTRACTORS = 193,
    /// <summary>General Government</summary>
    GENERAL_GOVERNMENT = 194,
    /// <summary>General Software</summary>
    GENERAL_SOFTWARE = 195,
    /// <summary>General Telecom</summary>
    GENERAL_TELECOM = 196,
    /// <summary>Gifts And Flowers</summary>
    GIFTS_AND_FLOWERS = 197,
    /// <summary>Glass Paint And Wallpaper Stores</summary>
    GLASS_PAINT_AND_WALLPAPER_STORES = 198,
    /// <summary>Glassware Crystal Stores</summary>
    GLASSWARE_CRYSTAL_STORES = 199,
    /// <summary>Government</summary>
    GOVERNMENT = 200,
    /// <summary>Government Ids And Licenses</summary>
    GOVERNMENT_IDS_AND_LICENSES = 201,
    /// <summary>Government Licensed On Line Casinos On Line Gambling</summary>
    GOVERNMENT_LICENSED_ON_LINE_CASINOS_ON_LINE_GAMBLING = 202,
    /// <summary>Government Owned Lotteries</summary>
    GOVERNMENT_OWNED_LOTTERIES = 203,
    /// <summary>Government Services</summary>
    GOVERNMENT_SERVICES = 204,
    /// <summary>Graphic And Commercial Design</summary>
    GRAPHIC_AND_COMMERCIAL_DESIGN = 205,
    /// <summary>Greeting Cards</summary>
    GREETING_CARDS = 206,
    /// <summary>Grocery Stores And Supermarkets</summary>
    GROCERY_STORES_AND_SUPERMARKETS = 207,
    /// <summary>Hardware And Tools</summary>
    HARDWARE_AND_TOOLS = 208,
    /// <summary>Hardware Equipment And Supplies</summary>
    HARDWARE_EQUIPMENT_AND_SUPPLIES = 209,
    /// <summary>Hazardous Restricted And Perishable Items</summary>
    HAZARDOUS_RESTRICTED_AND_PERISHABLE_ITEMS = 210,
    /// <summary>Health And Beauty Spas</summary>
    HEALTH_AND_BEAUTY_SPAS = 211,
    /// <summary>Health And Nutrition</summary>
    HEALTH_AND_NUTRITION = 212,
    /// <summary>Health And Personal Care</summary>
    HEALTH_AND_PERSONAL_CARE = 213,
    /// <summary>Hearing Aids Sales And Supplies</summary>
    HEARING_AIDS_SALES_AND_SUPPLIES = 214,
    /// <summary>Heating Plumbing Ac</summary>
    HEATING_PLUMBING_AC = 215,
    /// <summary>High Risk Merchant</summary>
    HIGH_RISK_MERCHANT = 216,
    /// <summary>Hiring Services</summary>
    HIRING_SERVICES = 217,
    /// <summary>Hobbies Toys And Games</summary>
    HOBBIES_TOYS_AND_GAMES = 218,
    /// <summary>Home And Garden</summary>
    HOME_AND_GARDEN = 219,
    /// <summary>Home Audio</summary>
    HOME_AUDIO = 220,
    /// <summary>Home Decor</summary>
    HOME_DECOR = 221,
    /// <summary>Home Electronics</summary>
    HOME_ELECTRONICS = 222,
    /// <summary>Hospitals</summary>
    HOSPITALS = 223,
    /// <summary>Hotels Motels Inns Resorts</summary>
    HOTELS_MOTELS_INNS_RESORTS = 224,
    /// <summary>Housewares</summary>
    HOUSEWARES = 225,
    /// <summary>Human Parts And Remains</summary>
    HUMAN_PARTS_AND_REMAINS = 226,
    /// <summary>Humorous Gifts And Novelties</summary>
    HUMOROUS_GIFTS_AND_NOVELTIES = 227,
    /// <summary>Hunting</summary>
    HUNTING = 228,
    /// <summary>Ids Licenses And Passports</summary>
    IDS_LICENSES_AND_PASSPORTS = 229,
    /// <summary>Illegal Drugs And Paraphernalia</summary>
    ILLEGAL_DRUGS_AND_PARAPHERNALIA = 230,
    /// <summary>Industrial</summary>
    INDUSTRIAL = 231,
    /// <summary>Industrial And Manufacturing Supplies</summary>
    INDUSTRIAL_AND_MANUFACTURING_SUPPLIES = 232,
    /// <summary>Insurance Auto And Home</summary>
    INSURANCE_AUTO_AND_HOME = 233,
    /// <summary>Insurance Direct</summary>
    INSURANCE_DIRECT = 234,
    /// <summary>Insurance Life And Annuity</summary>
    INSURANCE_LIFE_AND_ANNUITY = 235,
    /// <summary>Insurance Sales Underwriting</summary>
    INSURANCE_SALES_UNDERWRITING = 236,
    /// <summary>Insurance Underwriting Premiums</summary>
    INSURANCE_UNDERWRITING_PREMIUMS = 237,
    /// <summary>Internet And Network Services</summary>
    INTERNET_AND_NETWORK_SERVICES = 238,
    /// <summary>Intra Company Purchases</summary>
    INTRA_COMPANY_PURCHASES = 239,
    /// <summary>Laboratories Dental Medical</summary>
    LABORATORIES_DENTAL_MEDICAL = 240,
    /// <summary>Landscaping</summary>
    LANDSCAPING = 241,
    /// <summary>Landscaping And Horticultural Services</summary>
    LANDSCAPING_AND_HORTICULTURAL_SERVICES = 242,
    /// <summary>Laundry Cleaning Services</summary>
    LAUNDRY_CLEANING_SERVICES = 243,
    /// <summary>Legal</summary>
    LEGAL = 244,
    /// <summary>Legal Services And Attorneys</summary>
    LEGAL_SERVICES_AND_ATTORNEYS = 245,
    /// <summary>Local Delivery Service</summary>
    LOCAL_DELIVERY_SERVICE = 246,
    /// <summary>Locksmith</summary>
    LOCKSMITH = 247,
    /// <summary>Lodging And Accommodations</summary>
    LODGING_AND_ACCOMMODATIONS = 248,
    /// <summary>Lottery And Contests</summary>
    LOTTERY_AND_CONTESTS = 249,
    /// <summary>Luggage And Leather Goods</summary>
    LUGGAGE_AND_LEATHER_GOODS = 250,
    /// <summary>Lumber And Building Materials</summary>
    LUMBER_AND_BUILDING_MATERIALS = 251,
    /// <summary>Magazines</summary>
    MAGAZINES = 252,
    /// <summary>Maintenance And Repair Services</summary>
    MAINTENANCE_AND_REPAIR_SERVICES = 253,
    /// <summary>Makeup And Cosmetics</summary>
    MAKEUP_AND_COSMETICS = 254,
    /// <summary>Manual Cash Disbursements</summary>
    MANUAL_CASH_DISBURSEMENTS = 255,
    /// <summary>Massage Parlors</summary>
    MASSAGE_PARLORS = 256,
    /// <summary>Medical</summary>
    MEDICAL = 257,
    /// <summary>Medical And Pharmaceutical</summary>
    MEDICAL_AND_PHARMACEUTICAL = 258,
    /// <summary>Medical Care</summary>
    MEDICAL_CARE = 259,
    /// <summary>Medical Equipment And Supplies</summary>
    MEDICAL_EQUIPMENT_AND_SUPPLIES = 260,
    /// <summary>Medical Services</summary>
    MEDICAL_SERVICES = 261,
    /// <summary>Meeting Planners</summary>
    MEETING_PLANNERS = 262,
    /// <summary>Membership Clubs And Organizations</summary>
    MEMBERSHIP_CLUBS_AND_ORGANIZATIONS = 263,
    /// <summary>Membership Country Clubs Golf</summary>
    MEMBERSHIP_COUNTRY_CLUBS_GOLF = 264,
    /// <summary>Memorabilia</summary>
    MEMORABILIA = 265,
    /// <summary>Men And Boy Clothing And Accessory Stores</summary>
    MEN_AND_BOY_CLOTHING_AND_ACCESSORY_STORES = 266,
    /// <summary>Men Clothing</summary>
    MEN_CLOTHING = 267,
    /// <summary>Merchandise</summary>
    MERCHANDISE = 268,
    /// <summary>Metaphysical</summary>
    METAPHYSICAL = 269,
    /// <summary>Militaria</summary>
    MILITARIA = 270,
    /// <summary>Military And Civil Service Uniforms</summary>
    MILITARY_AND_CIVIL_SERVICE_UNIFORMS = 271,
    /// <summary>Misc Automotive Aircraft And Farm Equipment Dealers</summary>
    [JsonPropertyName("MISC._AUTOMOTIVE_AIRCRAFT_AND_FARM_EQUIPMENT_DEALERS")]
    MISC_AUTOMOTIVE_AIRCRAFT_AND_FARM_EQUIPMENT_DEALERS = 272,
    /// <summary>Misc General Merchandise</summary>
    [JsonPropertyName("MISC._GENERAL_MERCHANDISE")]
    MISC_GENERAL_MERCHANDISE = 273,
    /// <summary>Miscellaneous General Services</summary>
    MISCELLANEOUS_GENERAL_SERVICES = 274,
    /// <summary>Miscellaneous Repair Shops And Related Services</summary>
    MISCELLANEOUS_REPAIR_SHOPS_AND_RELATED_SERVICES = 275,
    /// <summary>Model Kits</summary>
    MODEL_KITS = 276,
    /// <summary>Money Transfer Member Financial Institution</summary>
    MONEY_TRANSFER_MEMBER_FINANCIAL_INSTITUTION = 277,
    /// <summary>Money Transfer Merchant</summary>
    MONEY_TRANSFER_MERCHANT = 278,
    /// <summary>Motion Picture Theaters</summary>
    MOTION_PICTURE_THEATERS = 279,
    /// <summary>Motor Freight Carriers And Trucking</summary>
    MOTOR_FREIGHT_CARRIERS_AND_TRUCKING = 280,
    /// <summary>Motor Home And Recreational Vehicle Rental</summary>
    MOTOR_HOME_AND_RECREATIONAL_VEHICLE_RENTAL = 281,
    /// <summary>Motor Homes Dealers</summary>
    MOTOR_HOMES_DEALERS = 282,
    /// <summary>Motor Vehicle Supplies And New Parts</summary>
    MOTOR_VEHICLE_SUPPLIES_AND_NEW_PARTS = 283,
    /// <summary>Motorcycle Dealers</summary>
    MOTORCYCLE_DEALERS = 284,
    /// <summary>Motorcycles</summary>
    MOTORCYCLES = 285,
    /// <summary>Movie</summary>
    MOVIE = 286,
    /// <summary>Movie Tickets</summary>
    MOVIE_TICKETS = 287,
    /// <summary>Moving And Storage</summary>
    MOVING_AND_STORAGE = 288,
    /// <summary>Multi Level Marketing</summary>
    MULTI_LEVEL_MARKETING = 289,
    /// <summary>Music Cds Cassettes And Albums</summary>
    MUSIC_CDS_CASSETTES_AND_ALBUMS = 290,
    /// <summary>Music Store Instruments And Sheet Music</summary>
    MUSIC_STORE_INSTRUMENTS_AND_SHEET_MUSIC = 291,
    /// <summary>Networking</summary>
    NETWORKING = 292,
    /// <summary>New Age</summary>
    NEW_AGE = 293,
    /// <summary>New Parts And Supplies Motor Vehicle</summary>
    NEW_PARTS_AND_SUPPLIES_MOTOR_VEHICLE = 294,
    /// <summary>News Dealers And Newstands</summary>
    NEWS_DEALERS_AND_NEWSTANDS = 295,
    /// <summary>Non Durable Goods</summary>
    NON_DURABLE_GOODS = 296,
    /// <summary>Non Fiction</summary>
    NON_FICTION = 297,
    /// <summary>Non Profit Political And Religion</summary>
    NON_PROFIT_POLITICAL_AND_RELIGION = 298,
    /// <summary>Nonprofit</summary>
    NONPROFIT = 299,
    /// <summary>Novelties</summary>
    NOVELTIES = 300,
    /// <summary>Oem Software</summary>
    OEM_SOFTWARE = 301,
    /// <summary>Office Supplies And Equipment</summary>
    OFFICE_SUPPLIES_AND_EQUIPMENT = 302,
    /// <summary>Online Dating</summary>
    ONLINE_DATING = 303,
    /// <summary>Online Gaming</summary>
    ONLINE_GAMING = 304,
    /// <summary>Online Gaming Currency</summary>
    ONLINE_GAMING_CURRENCY = 305,
    /// <summary>Online Services</summary>
    ONLINE_SERVICES = 306,
    /// <summary>Ooutbound Telemarketing Merch</summary>
    OOUTBOUND_TELEMARKETING_MERCH = 307,
    /// <summary>Ophthalmologists Optometrist</summary>
    OPHTHALMOLOGISTS_OPTOMETRIST = 308,
    /// <summary>Opticians And Dispensing</summary>
    OPTICIANS_AND_DISPENSING = 309,
    /// <summary>Orthopedic Goods Prosthetics</summary>
    ORTHOPEDIC_GOODS_PROSTHETICS = 310,
    /// <summary>Osteopaths</summary>
    OSTEOPATHS = 311,
    /// <summary>Other</summary>
    OTHER = 312,
    /// <summary>Package Tour Operators</summary>
    PACKAGE_TOUR_OPERATORS = 313,
    /// <summary>Paintball</summary>
    PAINTBALL = 314,
    /// <summary>Paints Varnishes And Supplies</summary>
    PAINTS_VARNISHES_AND_SUPPLIES = 315,
    /// <summary>Parking Lots And Garages</summary>
    PARKING_LOTS_AND_GARAGES = 316,
    /// <summary>Parts And Accessories</summary>
    PARTS_AND_ACCESSORIES = 317,
    /// <summary>Pawn Shops</summary>
    PAWN_SHOPS = 318,
    /// <summary>Paycheck Lender Or Cash Advance</summary>
    PAYCHECK_LENDER_OR_CASH_ADVANCE = 319,
    /// <summary>Peripherals</summary>
    PERIPHERALS = 320,
    /// <summary>Personalized Gifts</summary>
    PERSONALIZED_GIFTS = 321,
    /// <summary>Pet Shops Pet Food And Supplies</summary>
    PET_SHOPS_PET_FOOD_AND_SUPPLIES = 322,
    /// <summary>Petroleum And Petroleum Products</summary>
    PETROLEUM_AND_PETROLEUM_PRODUCTS = 323,
    /// <summary>Pets And Animals</summary>
    PETS_AND_ANIMALS = 324,
    /// <summary>Photofinishing Laboratories Photo Developing</summary>
    PHOTOFINISHING_LABORATORIES_PHOTO_DEVELOPING = 325,
    /// <summary>Photographic Studios Portraits</summary>
    PHOTOGRAPHIC_STUDIOS_PORTRAITS = 326,
    /// <summary>Photography</summary>
    PHOTOGRAPHY = 327,
    /// <summary>Physical Good</summary>
    PHYSICAL_GOOD = 328,
    /// <summary>Picture Video Production</summary>
    PICTURE_VIDEO_PRODUCTION = 329,
    /// <summary>Piece Goods Notions And Other Dry Goods</summary>
    PIECE_GOODS_NOTIONS_AND_OTHER_DRY_GOODS = 330,
    /// <summary>Plants And Seeds</summary>
    PLANTS_AND_SEEDS = 331,
    /// <summary>Plumbing And Heating Equipments And Supplies</summary>
    PLUMBING_AND_HEATING_EQUIPMENTS_AND_SUPPLIES = 332,
    /// <summary>Police Related Items</summary>
    POLICE_RELATED_ITEMS = 333,
    /// <summary>Political Organizations</summary>
    POLITICAL_ORGANIZATIONS = 334,
    /// <summary>Postal Services Government Only</summary>
    POSTAL_SERVICES_GOVERNMENT_ONLY = 335,
    /// <summary>Posters</summary>
    POSTERS = 336,
    /// <summary>Prepaid And Stored Value Cards</summary>
    PREPAID_AND_STORED_VALUE_CARDS = 337,
    /// <summary>Prescription Drugs</summary>
    PRESCRIPTION_DRUGS = 338,
    /// <summary>Promotional Items</summary>
    PROMOTIONAL_ITEMS = 339,
    /// <summary>Public Warehousing And Storage</summary>
    PUBLIC_WAREHOUSING_AND_STORAGE = 340,
    /// <summary>Publishing And Printing</summary>
    PUBLISHING_AND_PRINTING = 341,
    /// <summary>Publishing Services</summary>
    PUBLISHING_SERVICES = 342,
    /// <summary>Radar Dectors</summary>
    RADAR_DECTORS = 343,
    /// <summary>Radio Television And Stereo Repair</summary>
    RADIO_TELEVISION_AND_STEREO_REPAIR = 344,
    /// <summary>Real Estate</summary>
    REAL_ESTATE = 345,
    /// <summary>Real Estate Agent</summary>
    REAL_ESTATE_AGENT = 346,
    /// <summary>Real Estate Agents And Managers Rentals</summary>
    REAL_ESTATE_AGENTS_AND_MANAGERS_RENTALS = 347,
    /// <summary>Religion And Spirituality For Profit</summary>
    RELIGION_AND_SPIRITUALITY_FOR_PROFIT = 348,
    /// <summary>Religious</summary>
    RELIGIOUS = 349,
    /// <summary>Religious Organizations</summary>
    RELIGIOUS_ORGANIZATIONS = 350,
    /// <summary>Remittance</summary>
    REMITTANCE = 351,
    /// <summary>Rental Property Management</summary>
    RENTAL_PROPERTY_MANAGEMENT = 352,
    /// <summary>Residential</summary>
    RESIDENTIAL = 353,
    /// <summary>Retail</summary>
    RETAIL = 354,
    /// <summary>Retail Fine Jewelry And Watches</summary>
    RETAIL_FINE_JEWELRY_AND_WATCHES = 355,
    /// <summary>Reupholstery And Furniture Repair</summary>
    REUPHOLSTERY_AND_FURNITURE_REPAIR = 356,
    /// <summary>Rings</summary>
    RINGS = 357,
    /// <summary>Roofing Siding Sheet Metal</summary>
    ROOFING_SIDING_SHEET_METAL = 358,
    /// <summary>Rugs And Carpets</summary>
    RUGS_AND_CARPETS = 359,
    /// <summary>Schools And Colleges</summary>
    SCHOOLS_AND_COLLEGES = 360,
    /// <summary>Science Fiction</summary>
    SCIENCE_FICTION = 361,
    /// <summary>Scrapbooking</summary>
    SCRAPBOOKING = 362,
    /// <summary>Sculptures</summary>
    SCULPTURES = 363,
    /// <summary>Securities Brokers And Dealers</summary>
    SECURITIES_BROKERS_AND_DEALERS = 364,
    /// <summary>Security And Surveillance</summary>
    SECURITY_AND_SURVEILLANCE = 365,
    /// <summary>Security And Surveillance Equipment</summary>
    SECURITY_AND_SURVEILLANCE_EQUIPMENT = 366,
    /// <summary>Security Brokers And Dealers</summary>
    SECURITY_BROKERS_AND_DEALERS = 367,
    /// <summary>Seminars</summary>
    SEMINARS = 368,
    /// <summary>Service Stations</summary>
    SERVICE_STATIONS = 369,
    /// <summary>Services</summary>
    SERVICES = 370,
    /// <summary>Sewing Needlework Fabric And Piece Goods Stores</summary>
    SEWING_NEEDLEWORK_FABRIC_AND_PIECE_GOODS_STORES = 371,
    /// <summary>Shipping And Packing</summary>
    SHIPPING_AND_PACKING = 372,
    /// <summary>Shoe Repair Hat Cleaning</summary>
    SHOE_REPAIR_HAT_CLEANING = 373,
    /// <summary>Shoe Stores</summary>
    SHOE_STORES = 374,
    /// <summary>Shoes</summary>
    SHOES = 375,
    /// <summary>Snowmobile Dealers</summary>
    SNOWMOBILE_DEALERS = 376,
    /// <summary>Software</summary>
    SOFTWARE = 377,
    /// <summary>Specialty And Misc Food Stores</summary>
    [JsonPropertyName("SPECIALTY_AND_MISC._FOOD_STORES")]
    SPECIALTY_AND_MISC_FOOD_STORES = 378,
    /// <summary>Specialty Cleaning Polishing And Sanitation Preparations</summary>
    SPECIALTY_CLEANING_POLISHING_AND_SANITATION_PREPARATIONS = 379,
    /// <summary>Specialty Or Rare Pets</summary>
    SPECIALTY_OR_RARE_PETS = 380,
    /// <summary>Sport Games And Toys</summary>
    SPORT_GAMES_AND_TOYS = 381,
    /// <summary>Sporting And Recreational Camps</summary>
    SPORTING_AND_RECREATIONAL_CAMPS = 382,
    /// <summary>Sporting Goods</summary>
    SPORTING_GOODS = 383,
    /// <summary>Sports And Outdoors</summary>
    SPORTS_AND_OUTDOORS = 384,
    /// <summary>Sports And Recreation</summary>
    SPORTS_AND_RECREATION = 385,
    /// <summary>Stamp And Coin</summary>
    STAMP_AND_COIN = 386,
    /// <summary>Stationary Printing And Writing Paper</summary>
    STATIONARY_PRINTING_AND_WRITING_PAPER = 387,
    /// <summary>Stenographic And Secretarial Support Services</summary>
    STENOGRAPHIC_AND_SECRETARIAL_SUPPORT_SERVICES = 388,
    /// <summary>Stocks Bonds Securities And Related Certificates</summary>
    STOCKS_BONDS_SECURITIES_AND_RELATED_CERTIFICATES = 389,
    /// <summary>Stored Value Cards</summary>
    STORED_VALUE_CARDS = 390,
    /// <summary>Supplies</summary>
    SUPPLIES = 391,
    /// <summary>Supplies And Toys</summary>
    SUPPLIES_AND_TOYS = 392,
    /// <summary>Surveillance Equipment</summary>
    SURVEILLANCE_EQUIPMENT = 393,
    /// <summary>Swimming Pools And Spas</summary>
    SWIMMING_POOLS_AND_SPAS = 394,
    /// <summary>Swimming Pools Sales Supplies Services</summary>
    SWIMMING_POOLS_SALES_SUPPLIES_SERVICES = 395,
    /// <summary>Tailors And Alterations</summary>
    TAILORS_AND_ALTERATIONS = 396,
    /// <summary>Tax Payments</summary>
    TAX_PAYMENTS = 397,
    /// <summary>Tax Payments Government Agencies</summary>
    TAX_PAYMENTS_GOVERNMENT_AGENCIES = 398,
    /// <summary>Taxicabs And Limousines</summary>
    TAXICABS_AND_LIMOUSINES = 399,
    /// <summary>Telecommunication Services</summary>
    TELECOMMUNICATION_SERVICES = 400,
    /// <summary>Telephone Cards</summary>
    TELEPHONE_CARDS = 401,
    /// <summary>Telephone Equipment</summary>
    TELEPHONE_EQUIPMENT = 402,
    /// <summary>Telephone Services</summary>
    TELEPHONE_SERVICES = 403,
    /// <summary>Theater</summary>
    THEATER = 404,
    /// <summary>Tire Retreading And Repair</summary>
    TIRE_RETREADING_AND_REPAIR = 405,
    /// <summary>Toll Or Bridge Fees</summary>
    TOLL_OR_BRIDGE_FEES = 406,
    /// <summary>Tools And Equipment</summary>
    TOOLS_AND_EQUIPMENT = 407,
    /// <summary>Tourist Attractions And Exhibits</summary>
    TOURIST_ATTRACTIONS_AND_EXHIBITS = 408,
    /// <summary>Towing Service</summary>
    TOWING_SERVICE = 409,
    /// <summary>Toys And Games</summary>
    TOYS_AND_GAMES = 410,
    /// <summary>Trade And Vocational Schools</summary>
    TRADE_AND_VOCATIONAL_SCHOOLS = 411,
    /// <summary>Trademark Infringement</summary>
    TRADEMARK_INFRINGEMENT = 412,
    /// <summary>Trailer Parks And Campgrounds</summary>
    TRAILER_PARKS_AND_CAMPGROUNDS = 413,
    /// <summary>Training Services</summary>
    TRAINING_SERVICES = 414,
    /// <summary>Transportation Services</summary>
    TRANSPORTATION_SERVICES = 415,
    /// <summary>Travel</summary>
    TRAVEL = 416,
    /// <summary>Truck And Utility Trailer Rentals</summary>
    TRUCK_AND_UTILITY_TRAILER_RENTALS = 417,
    /// <summary>Truck Stop</summary>
    TRUCK_STOP = 418,
    /// <summary>Typesetting Plate Making And Related Services</summary>
    TYPESETTING_PLATE_MAKING_AND_RELATED_SERVICES = 419,
    /// <summary>Used Merchandise And Secondhand Stores</summary>
    USED_MERCHANDISE_AND_SECONDHAND_STORES = 420,
    /// <summary>Used Parts Motor Vehicle</summary>
    USED_PARTS_MOTOR_VEHICLE = 421,
    /// <summary>Utilities</summary>
    UTILITIES = 422,
    /// <summary>Utilities Electric Gas Water Sanitary</summary>
    UTILITIES_ELECTRIC_GAS_WATER_SANITARY = 423,
    /// <summary>Variety Stores</summary>
    VARIETY_STORES = 424,
    /// <summary>Vehicle Sales</summary>
    VEHICLE_SALES = 425,
    /// <summary>Vehicle Service And Accessories</summary>
    VEHICLE_SERVICE_AND_ACCESSORIES = 426,
    /// <summary>Video Equipment</summary>
    VIDEO_EQUIPMENT = 427,
    /// <summary>Video Game Arcades Establish</summary>
    VIDEO_GAME_ARCADES_ESTABLISH = 428,
    /// <summary>Video Games And Systems</summary>
    VIDEO_GAMES_AND_SYSTEMS = 429,
    /// <summary>Video Tape Rental Stores</summary>
    VIDEO_TAPE_RENTAL_STORES = 430,
    /// <summary>Vintage And Collectible Vehicles</summary>
    VINTAGE_AND_COLLECTIBLE_VEHICLES = 431,
    /// <summary>Vintage And Collectibles</summary>
    VINTAGE_AND_COLLECTIBLES = 432,
    /// <summary>Vitamins And Supplements</summary>
    VITAMINS_AND_SUPPLEMENTS = 433,
    /// <summary>Vocational And Trade Schools</summary>
    VOCATIONAL_AND_TRADE_SCHOOLS = 434,
    /// <summary>Watch Clock And Jewelry Repair</summary>
    WATCH_CLOCK_AND_JEWELRY_REPAIR = 435,
    /// <summary>Web Hosting And Design</summary>
    WEB_HOSTING_AND_DESIGN = 436,
    /// <summary>Welding Repair</summary>
    WELDING_REPAIR = 437,
    /// <summary>Wholesale Clubs</summary>
    WHOLESALE_CLUBS = 438,
    /// <summary>Wholesale Florist Suppliers</summary>
    WHOLESALE_FLORIST_SUPPLIERS = 439,
    /// <summary>Wholesale Prescription Drugs</summary>
    WHOLESALE_PRESCRIPTION_DRUGS = 440,
    /// <summary>Wildlife Products</summary>
    WILDLIFE_PRODUCTS = 441,
    /// <summary>Wire Transfer</summary>
    WIRE_TRANSFER = 442,
    /// <summary>Wire Transfer And Money Order</summary>
    WIRE_TRANSFER_AND_MONEY_ORDER = 443,
    /// <summary>Women Accessory Speciality</summary>
    WOMEN_ACCESSORY_SPECIALITY = 444,
    /// <summary>Women Clothing</summary>
    WOMEN_CLOTHING = 445
}
