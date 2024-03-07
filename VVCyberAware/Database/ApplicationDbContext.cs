using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using VVCyberAware.Shared.Models.DbModels;

namespace VVCyberAware.Data
{

    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CategoryModel> Categories { get; set; }
        public DbSet<SegmentModel> Segments { get; set; }
        public DbSet<SubCategoryModel> SubCategories { get; set; }
        public DbSet<QuestionModel> Questions { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<QuestionModel>()
                .Property(q => q.AnswersJson)
                .HasColumnType("nvarchar(max)")
                .IsRequired();

            modelBuilder.Entity<CategoryModel>().HasData(

                new CategoryModel()
                {
                    Id = 1,
                    Name = "Att skydda sig mot bedrägerier",
                    Description = "Info om bedrägeri"
                },
                new CategoryModel()
                {
                    Id = 2,
                    Name = "Cybersäkerhet för företag",
                    Description = "Digital säkerhet på företag"
                },
                new CategoryModel()
                {
                    Id = 3,
                    Name = " Cyberspionage",
                    Description = "Allmänt om cyberspionage"
                });

                modelBuilder.Entity<SegmentModel>().HasData(
                new SegmentModel()
                {
                    Id = 1,
                    CategoryId = 1,
                    Name = "Del 1",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 2,
                    CategoryId = 1,
                    Name = "Del 2",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 3,
                    CategoryId = 1,
                    Name = "Del 3",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 4,
                    CategoryId = 2,
                    Name = "Del 1",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 5,
                    CategoryId = 2,
                    Name = "Del 2",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 6,
                    CategoryId = 2,
                    Name = "Del 3",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 7,
                    CategoryId = 2,
                    Name = "Del 4",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 8,
                    CategoryId = 3,
                    Name = "Del 1",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 9,
                    CategoryId = 3,
                    Name = "Del 2",
                    UserIsComplete = new List<string>()
                },
                new SegmentModel()
                {
                    Id = 10,
                    CategoryId = 3,
                    Name = "Del 3",
                    UserIsComplete = new List<string>()
                });


                modelBuilder.Entity<SubCategoryModel>().HasData(
                new SubCategoryModel()
                {
                    Id = 1,
                    Description = "Kreditkortsbedrägeri",
                    SegmentId = 1

                },
                new SubCategoryModel()
                {
                    Id = 2,
                    Description = "Romansbedrägeri",
                    SegmentId = 1
                },
                new SubCategoryModel()
                {
                    Id = 3,
                    Description = "Investeringsbedrägeri",
                    SegmentId = 1
                },
                new SubCategoryModel()
                {
                    Id = 4,
                    Description = "Telefonbedrägeri",
                    SegmentId = 1
                },
                new SubCategoryModel()
                {
                    Id = 5,
                    Description = "Bedrägerier i hemmet",
                    SegmentId = 2
                },
                new SubCategoryModel()
                {
                    Id = 6,
                    Description = "Identitetsstöld",
                    SegmentId = 2
                },
                new SubCategoryModel()
                {
                    Id = 7,
                    Description = "Nätfiske och bluffmejl",
                    SegmentId = 2
                },
                new SubCategoryModel()
                {
                    Id = 8,
                    Description = "Investeringsbedrägeri på nätet",
                    SegmentId = 2
                },
                new SubCategoryModel()
                {
                    Id = 9,
                    Description = "Abonnemangsfällor och falska fakturor",
                    SegmentId = 3
                },
                new SubCategoryModel()
                {
                    Id = 10,
                    Description = "Ransomware",
                    SegmentId = 3
                },
                new SubCategoryModel()
                {
                    Id = 11,
                    Description = "Statistik och förhållningssätt",
                    SegmentId = 3
                },
                new SubCategoryModel()
                {
                    Id = 12,
                    Description = "Digital säkerhet på företag",
                    SegmentId = 4 // börjar på del 1 igen
                },
                new SubCategoryModel()
                {
                    Id = 13,
                    Description = "Risker och beredskap",
                    SegmentId = 4
                },
                new SubCategoryModel()
                {
                    Id = 14,
                    Description = "Aktörer inom cyberbrott",
                    SegmentId = 4
                },
                new SubCategoryModel()
                {
                    Id = 15,
                    Description = "Ökad digital närvaro och distansarbete",
                    SegmentId = 4
                },
                new SubCategoryModel()
                {
                    Id = 16,
                    Description = "Cyberangrepp mot känsliga sektorer",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 17,
                    Description = "Cyberrånet mot Mersk",
                    SegmentId = 4,
                },
                new SubCategoryModel()
                {
                    Id = 18,
                    Description = "Social engineering",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 19,
                    Description = "Nätfiske och skräppost",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 20,
                    Description = "Vishing",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 21,
                    Description = "Varning för vishing",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 22,
                    Description = "Identifiera VD-mejl",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 23,
                    Description = "Öneangrepp och presentkortsbluffar",
                    SegmentId = 5,
                },
                new SubCategoryModel()
                {
                    Id = 24,
                    Description = "Virus, maskar och trojaner",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 25,
                    Description = "Nätverksintrång",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 26,
                    Description = "Dataintrång",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 27,
                    Description = "Hackad!",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 28,
                    Description = "Vägarna in",
                    SegmentId = 6,
                },
                new SubCategoryModel()
                {
                    Id = 29,
                    Description = "Utpressningsvirus",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 30,
                    Description = "Attacker mot servrar",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 31,
                    Description = "Cyberangrepp i Norden",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 32,
                    Description = "It-brottslingarnas verktyg",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 33,
                    Description = "Mirai, Wannacry och fallet Düsseldorf",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 34,
                    Description = "De sårbara molnen",
                    SegmentId = 7,
                },
                new SubCategoryModel()
                {
                    Id = 35,
                    Description = "Allmänt om cyberspionage",
                    SegmentId = 8
                },
                new SubCategoryModel()
                {
                    Id = 36,
                    Description = "Metoder för cyberspionage",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 37,
                    Description = "Säkerhetsskyddslagen",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 38,
                    Description = "Cyberspionagets aktörer",
                    SegmentId = 8,
                },
                new SubCategoryModel()
                {
                    Id = 39,
                    Description = "Värvningsförsök",
                    SegmentId = 9,
                },
                new SubCategoryModel()
                {
                    Id = 40,
                    Description = "Affärsspionage",
                    SegmentId = 9,
                },
                new SubCategoryModel()
                {
                    Id = 41,
                    Description = "Påverkanskampanjer",
                    SegmentId = 9,
                },
                new SubCategoryModel()
                {
                    Id = 42,
                    Description = "Svensk underrättelsetjänst och cyberförsvar",
                    SegmentId = 10,
                },
                new SubCategoryModel()
                {
                    Id = 43,
                    Description = "Signalspaning, informationssäkerhet och 5G",
                    SegmentId = 10,
                },
                new SubCategoryModel()
                {
                    Id = 44,
                    Description = "Samverkan mot cyberspionage",
                    SegmentId = 10,
                });

                modelBuilder.Entity<QuestionModel>().HasData(
                new QuestionModel()
                {
                    Id = 1,
                    QuestionText = "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?",
                    Answers = new Dictionary<string, bool>
                    {
                        {" A), Ett legitimt försök från banken att skydda ditt konto", false },
                        {" B), En informationsinsamling för en marknadsundersökning", false },
                        {" C), Ett potentiellt telefonbedrägeri", true }
                    },
                    SubCategoryId = 1,
                    Explanation = "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.",
                },
                new QuestionModel()
                {
                    Id = 2,
                    QuestionText = "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A), Ett legitimt försök från banken att skydda ditt konto", false },
                        {" B), En informationsinsamling för en marknadsundersökning", false },
                        {" C), Ett potentiellt telefonbedrägeri", true }
                    },
                    SubCategoryId = 2,
                    Explanation = "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.",
                },
                new QuestionModel()
                {
                    Id = 3,
                    QuestionText = "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?\r\n",
                    Answers = new Dictionary<string, bool>
                    {
                        {" A), Genomföra omedelbar investering för att inte missa möjligheten",false },
                        {" B),Investeringsbedrägeri",true },
                        {" C), Begära mer information för att utföra en noggrann ‘’due diligence",false  }
                    },
                    SubCategoryId = 3,
                    Explanation = "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden, är ofta tecken på investeringsbedrägerier"
                },
                new QuestionModel()
                {
                    Id = 4,
                    QuestionText = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Ett misstag av kreditkortsföretaget",false},
                        {"B) Kreditkortsbedrägeri",true },
                        {"C) Obehöriga köp av en familjemedlem", false }
                    },
                    SubCategoryId = 4,
                    Explanation = "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri."
                },
                new QuestionModel()
                {
                    Id = 5,
                    QuestionText = "Vad är de vanligaste tecknen på att du kan vara måltavla för ett bedrägeri i hemmet?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Någon erbjuder dig en gratis produkt i utbyte mot detaljerad personlig information.",true},
                        {"B) Din hund skäller mer än vanligt",false },
                        { "C) Din granns bil ser annorlunda ut än den brukade.",false },
                    },
                    SubCategoryId = 5,
                    Explanation = "Denna fråga syftar till att öka medvetenheten om hur bedragare kan försöka manipulera människor i sina egna hem, ofta genom att erbjuda något som verkar vara för bra för att vara sant, som gratisprodukter eller tjänster, i utbyte mot personlig information eller finansiell data."

                },
                new QuestionModel()
                {
                    Id = 6,
                    QuestionText = "Hur kan du upptäcka om någon har stulit din identitet?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Du får en större än väntad elräkning.",false },
                        {"B) Du märker oväntade transaktioner på ditt bankkontoutdrag eller att dina kreditupplysningar visar konton du inte känner till.",true },
                        {"C) Din favorit-TV-serie slutar plötsligt sändas.",false }
                    },
                    SubCategoryId = 6,
                    Explanation = " Denna fråga riktar in sig på att identifiera varningssignaler som kan tyda på att någon obehörigt använder din personliga information. Genom att känna till dessa tecken kan individer agera snabbt för att skydda sin finansiella hälsa och juridiska ställning."
                },
                new QuestionModel()
                {
                    Id = 7,
                    QuestionText = "Hur kan du känna igen ett nätfiske- eller bluffmejl?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Meddelandet erbjuder en kostnadsfri uppdatering till din programvara.",false},
                        {"B) Meddelandet innehåller specifik och relevant information som bara du skulle känna till.",false },
                        {"C) Meddelandet ber om omedelbar verifiering av personliga uppgifter via en länk eller ett bifogat formulär.",true }
                    },
                    SubCategoryId = 7,
                    Explanation = "Denna fråga varnar för ett vanligt trick i nätfiske- och bluffmejl där avsändaren försöker få mottagaren att avslöja känslig information."
                },
                new QuestionModel()
                {
                    Id = 8,
                    QuestionText = "Vilket av följande är en varningssignal för investeringsbedrägeri på nätet?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) En investering som erbjuder regelbundna utbetalningar utan risk.",true},
                        {"B) En investering som stöds av stora, välkända finansinstitut.",false },
                        {"C) En investering som kräver tid för forskning och övervägande innan du engagerar dig.",false }
                    },
                    SubCategoryId = 8,
                    Explanation = "Denna fråga belyser hur löften om riskfria vinster ofta är ett tecken på investeringsbedrägeri, vilket är viktigt att känna till för att undvika ekonomiska förluster."
                },
                new QuestionModel()
                {
                    Id = 10,
                    QuestionText = "Hur kan du bäst skydda dig mot ransomware-attacker?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Betala lösensumman så fort som möjligt.", false},
                        {"B) Hålla ditt operativsystem och alla program uppdaterade med de senaste säkerhetsuppdateringarna.", true},
                        {"C) Öppna alla bilagor du får via e-post för att kontrollera innehållet.", false}
                    },
                    SubCategoryId = 10,
                    Explanation = "Att hålla programvara uppdaterad är avgörande för att förebygga ransomware-attacker eftersom det säkerställer att kända säkerhetsbrister åtgärdas."
                },
                new QuestionModel()
                {
                    Id = 11,
                    QuestionText = "Vilka är de främsta tecknen på att du kan ha drabbats av en abonnemangsfälla eller mottagit en falsk faktura?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Du mottar en detaljerad faktura för en tjänst du regelbundet använder.", false},
                        {"B) Fakturan saknar detaljerad information och kontaktuppgifter.", true},
                        {"C) Du känner igen företagets namn och logotyp.", false}
                    },
                    SubCategoryId = 11,
                    Explanation = "En faktura som saknar detaljer eller kontaktuppgifter kan vara en indikation på en abonnemangsfälla eller en falsk faktura, vilket är en vanlig taktik bland bedragare."
                },
                new QuestionModel()
                {
                    Id = 12,
                    QuestionText = "På vilket sätt kan statistik över cyberbrott påverka ett företags förhållningssätt till cybersäkerhet?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Genom att ignorera statistiken för att fokusera på annan verksamhet.", false},
                        {"B) Genom att använda statistiken för att skrämma anställda till bättre efterlevnad.", false},
                        {"C) Genom att analysera trender och mönster för att förbättra säkerhetsåtgärderna.", true}
                    },
                    SubCategoryId = 12,
                    Explanation = "Användning av statistik för att förstå och åtgärda säkerhetshot kan hjälpa företag att utveckla mer effektiva cybersäkerhetsstrategier och minska risken för brott."
                },
                new QuestionModel()
                {
                    Id = 13,
                    QuestionText = "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Utbildning i digital säkerhet för alla anställda", true},
                        {"B) Installera en starkare brandvägg", false},
                        {"C) Byta ut all IT-utrustning", false}
                    },
                    SubCategoryId = 13,
                    Explanation = "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor."
                },
                new QuestionModel()
                {
                    Id = 14,
                    QuestionText = "Inom företaget upptäcks det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Informera alla användare om sårbarheten och rekommendera temporära skyddsåtgärder", true},
                        {"B) Ignorera problemet tills en patch kan utvecklas", false},
                        {"C) Stänga ner tjänsten tillfälligt", false}
                    },
                    SubCategoryId = 14,
                    Explanation = "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas."
                },
                new QuestionModel()
                {
                    Id = 15,
                    QuestionText = "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) En enskild hackare med ett personligt vendetta", false},
                        {"B) En konkurrerande företagsentitet", false},
                        {"C) Organiserade cyberbrottsliga grupper", true}
                    },
                    SubCategoryId = 15,
                    Explanation = "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper."
                },
                new QuestionModel()
                {
                    Id = 16,
                    QuestionText = "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Återgå till kontorsarbete", false},
                        {"B) Införa striktare lösenordspolicyer och tvåfaktorsautentisering för fjärråtkomst", true},
                        {"C) Förbjuda användning av personliga enheter för arbete", false}
                    },
                    SubCategoryId = 16,
                    Explanation = "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö."
                },
                new QuestionModel()
                {
                    Id = 17,
                    QuestionText = "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Phishing", false},
                        {"B) Ransomware", true},
                        {"C) Spyware", false}
                    },
                    SubCategoryId = 17,
                    Explanation = "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård."
                },
                new QuestionModel()
                {
                    Id = 18,
                    QuestionText = "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Spyware", false},
                        {"B) Ransomware", true},
                        {"C) Adware", false}
                    },
                    SubCategoryId = 18,
                    Explanation = "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera"
                },
                new QuestionModel()
                {
                    Id = 19,
                    QuestionText = "Vad är det primära målet med social engineering inom cybersäkerhet?",
                    Answers = new Dictionary<string, bool>
                {
                    {"A) Att förbättra företagets interna kommunikationsstrategier.", false},
                    {"B) Att manipulera individer till att avslöja konfidentiell information eller utföra handlingar som komprometterar säkerheten.", true},
                    {"C) Att uppgradera företagets hårdvara och mjukvara för att förbättra säkerheten.", false}
                },
                    SubCategoryId = 19,
                    Explanation = "Social engineering använder mänskliga interaktioner för att få tillgång till konfidentiell information eller system. Att förstå detta är viktigt för att skydda sig."
                },
                new QuestionModel()
                {
                    Id = 20,
                    QuestionText = "Vilken är den bästa metoden för att skydda sig mot nätfiske och skräppost?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Öppna alla e-postmeddelanden för att snabbt avgöra deras giltighet.", false},
                        {"B) Använda ett komplicerat lösenord för alla onlinekonton.", false},
                        {"C) Inte klicka på misstänkta länkar eller bilagor i e-postmeddelanden från okända avsändare.", true}
                    },
                    SubCategoryId = 20,
                    Explanation = "Att undvika att klicka på misstänkta länkar eller bilagor är en effektiv strategi för att skydda sig mot nätfiske och skräppost."
                },
                new QuestionModel()
                {
                    Id = 21,
                    QuestionText = "Vad karaktäriserar ett vishing-angrepp?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Att skicka virus genom e-postmeddelanden.", false},
                        {"B) Att genomföra bedrägliga telefonsamtal där avsändaren utger sig för att vara från en trovärdig organisation för att få tag på känslig information.", true},
                        {"C) Att använda fysisk säkerhetsutrustning för att skydda ett nätverk.", false}
                    },
                    SubCategoryId = 21,
                    Explanation = "Vishing involverar bedrägliga telefonsamtal för att lura mottagaren att avslöja personlig eller finansiell information."
                },
                new QuestionModel()
                {
                    Id = 22,
                    QuestionText = "Vilket är det bästa sättet att hantera ett misstänkt vishing-försök?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Ge ut personlig information för att verifiera avsändarens identitet.", false},
                        {"B) Notera avsändarens information och avsluta samtalet omedelbart; rapportera sedan försöket till lämpliga myndigheter.", true},
                        {"C) Försök att spåra samtalet själv och konfrontera avsändaren.", false}
                    },
                    SubCategoryId = 22,
                    Explanation = "Det bästa sättet att hantera ett vishing-försök är att notera avsändarens information, avsluta samtalet omedelbart och sedan rapportera försöket."
                },
                new QuestionModel()
                {
                    Id = 23,
                    QuestionText = "Vad bör du göra för att korrekt identifiera ett falskt VD-mejl?",
                    Answers = new Dictionary<string, bool>
                {
                    {"A) Omedelbart följa instruktionerna i mailet för att visa lydnad.", false},
                    {"B) Kontrollera avsändarens e-postadress noggrant och verifiera förfrågan genom en annan kommunikationskanal.", true},
                    {"C) Skicka konfidentiell information som begärs för att upprätthålla goda relationer med VD:n.", false}
                },
                    SubCategoryId = 23,
                    Explanation = "Att känna igen och reagera korrekt på försök till VD-bedrägerier är viktigt. Kontrollera avsändarens identitet och verifiera alla förfrågningar på ett säkert sätt för att undvika bedrägerier."
                },
                new QuestionModel()
                {
                    Id = 24,
                    QuestionText = "Vad är det bästa försvaret mot övertalningsangrepp och presentkortsbluffar?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Köp omedelbart presentkort och skicka koder till avsändaren för att snabbt svara på deras begäran.", false},
                        {"B) Ignorera alla förfrågningar om att köpa eller skicka presentkort som kommer via e-post eller telefon.", true},
                        {"C) Be om ytterligare personlig information från avsändaren för att bekräfta deras identitet.", false}
                    },
                    SubCategoryId = 24,
                    Explanation = "Övertalningsangrepp och presentkortsbluffar använder manipulation för att lura individer. Det bästa försvaret är att inte svara på dessa förfrågningar och rapportera dem till lämpliga myndigheter."
                },
                new QuestionModel()
                {
                    Id = 25,
                    QuestionText = "Vilket är det primära skiljetecknet mellan virus, maskar och trojaner?",
                    Answers = new Dictionary<string, bool>
                {
                    {"A) Virus behöver en värdfil för att spridas, medan maskar kan sprida sig självständigt och trojaner maskerar sig som legitima program.", true},
                    {"B) Trojaner sprider sig självständigt via nätverk, medan virus och maskar är ofarliga filer.", false},
                    {"C) Maskar är godartade program som hjälper till att skydda datorer mot virus.", false}
                },
                    SubCategoryId = 25,
                    Explanation = "Det primära skiljetecknet är att virus behöver en värdfil för att spridas, maskar sprider sig självständigt, och trojaner utger sig för att vara legitima program."
                },
                new QuestionModel()
                {
                    Id = 26,
                    QuestionText = "Vilken metod anses vara mest effektiv för att förebygga nätverksintrång?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Att endast använda trådlösa nätverk.", false},
                        {"B) Att genomföra regelbundna säkerhetsgranskningar och uppdatera säkerhetssystem.", true},
                        {"C) Att hålla nätverket öppet för att kunna spåra potentiella hackare.", false}
                    },
                    SubCategoryId = 26,
                    Explanation = "Regelbundna säkerhetsgranskningar och uppdateringar av säkerhetssystem är mest effektiva för att förebygga nätverksintrång."
                },
                new QuestionModel()
                {
                    Id = 27,
                    QuestionText = "Vilka är de första stegen du bör ta vid upptäckt av ett dataintrång?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Ignorera varningstecknen och hoppas att problemet löser sig självt.", false},
                        {"B) Isolera det drabbade systemet och bedöm omfattningen av intrånget.", true},
                        {"C) Omedelbart informera alla sociala medier om intrånget.", false}
                    },
                    SubCategoryId = 27,
                    Explanation = "De första stegen inkluderar att isolera det drabbade systemet och bedöma omfattningen av intrånget."
                },
                new QuestionModel()
                {
                    Id = 28,
                    QuestionText = "Vad bör vara ditt första steg om du upptäcker att ditt företags nätverk har blivit hackat?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Ändra alla lösenord omedelbart.", false},
                        {"B) Stäng av alla datorer och nätverksutrustning.", false},
                        {"C) Identifiera och isolera de drabbade delarna av nätverket.", true}
                    },
                    SubCategoryId = 28,
                    Explanation = "Det första steget bör vara att identifiera och isolera de drabbade delarna av nätverket för att förhindra ytterligare skada."
                },
                new QuestionModel()
                {
                    Id = 29,
                    QuestionText = "Vilka är de vanligaste vägarna in för cyberangripare?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Genom fysisk säkerhet och övervakningskameror.", false},
                        {"B) Genom phishing-e-post, svaga lösenord och osäkra nätverk.", true},
                        {"C) Genom att endast använda godkänd programvara.", false}
                    },
                    SubCategoryId = 29,
                    Explanation = "De vanligaste vägarna in för cyberangripare inkluderar phishing-e-post, svaga lösenord och osäkra nätverk."
                },
                new QuestionModel()
                {
                    Id = 30,
                    QuestionText = "Vad är den mest effektiva åtgärden för att skydda sig mot utpressningsvirus?",
                    Answers = new Dictionary<string, bool>
                {
                    {"A) Betala omedelbart lösensumman för att återfå tillgång till filerna.", false},
                    {"B) Ignorera alla misstänkta e-postmeddelanden och hålla alla system uppdaterade.", true},
                    {"C) Lagra känslig information på lättillgängliga offentliga servrar.", false}
                },
                    SubCategoryId = 30,
                    Explanation = "Den mest effektiva åtgärden för att skydda sig mot utpressningsvirus är att ignorera misstänkta e-postmeddelanden och hålla alla system uppdaterade."
                },
                new QuestionModel()
                {
                    Id = 31,
                    QuestionText = "Vilken är den vanligaste typen av attack mot servrar?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Fysisk skada på serverutrustning.", false},
                        {"B) DDoS-attacker som överväldigar serverns resurser.", true},
                        {"C) Attacker som endast riktar sig mot bärbara enheter.", false}
                    },
                    SubCategoryId = 31,
                    Explanation = "Den vanligaste typen av attack mot servrar är DDoS-attacker som överväldigar serverns resurser."
                },
                new QuestionModel()
                {
                    Id = 32,
                    QuestionText = "Vilket karaktärsdrag är vanligt för cyberangrepp i Norden?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) De involverar oftast fysiska inbrott i datamiljöer.", false},
                        {"B) De är vanligtvis riktade mot mobila betalningssystem.", false},
                        {"C) De utnyttjar ofta social engineering och phishing.", true}
                    },
                    SubCategoryId = 32,
                    Explanation = "Ett vanligt karaktärsdrag för cyberangrepp i Norden är att de ofta utnyttjar social engineering och phishing."
                },
                new QuestionModel()
                {
                    Id = 33,
                    QuestionText = "Vilka är de mest använda verktygen av IT-brottslingar?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Avancerade kryptografiska system.", false},
                        {"B) Phishing, malware och nätverkssniffning.", true},
                        {"C) Lagliga programvaror för databasadministration.", false}
                    },
                    SubCategoryId = 33,
                    Explanation = "De mest använda verktygen av IT-brottslingar inkluderar phishing, malware och nätverkssniffning."
                },
                new QuestionModel()
                {
                    Id = 34,
                    QuestionText = "Vad har Mirai, Wannacry och incidenten i Düsseldorf gemensamt?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) De är alla exempel på statligt sponsrade hackningsförsök.", false},
                        {"B) De involverar alla skadlig programvara som sprids automatiskt över nätverk.", true},
                        {"C) De är kända fall av dataintrång via sociala medier.", false}
                    },
                    SubCategoryId = 34,
                    Explanation = "Mirai, Wannacry och incidenten i Düsseldorf har gemensamt att de involverar skadlig programvara som sprids automatiskt över nätverk."
                },
                new QuestionModel()
                {
                    Id = 35,
                    QuestionText = "Vad är den största säkerhetsutmaningen med molntjänster?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Otillräcklig lokal lagring.", false},
                        {"B) Brister i fysisk säkerhet hos molnleverantörer.", false},
                        {"C) Otillräckliga åtkomstkontroller och datakryptering.", true}
                    },
                    SubCategoryId = 35,
                    Explanation = "Den största säkerhetsutmaningen med molntjänster är otillräckliga åtkomstkontroller och datakryptering."
                },
                new QuestionModel()
                {
                    Id = 36,
                    QuestionText = "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?",
                    Answers = new Dictionary<string, bool>
                {
                    {"A) Cyberkriminalitet", false},
                    {"B) Cyberspionage", true},
                    {"C) Cyberterrorism", false}
                },
                    SubCategoryId = 36,
                    Explanation = "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande."
                },
                new QuestionModel()
                {
                    Id = 37,
                    QuestionText = "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Social ingenjörskonst", false},
                        {"B) Massövervakning", false},
                        {"C) Riktade cyberattacker", true}
                    },
                    SubCategoryId = 37,
                    Explanation = "Riktade cyberattacker som utnyttjar Zero-day sårbarheter är en avancerad metod för cyberspionage, specifikt riktad för att komma åt känslig information genom att utnyttja tidigare okända sårbarheter."
                },
                new QuestionModel()
                {
                    Id = 38,
                    QuestionText = "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) GDPR", false},
                        {"B) Säkerhetsskyddslagen", true},
                        {"C) IT-säkerhetslagen", false}
                    },
                    SubCategoryId = 38,
                    Explanation = "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information och ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet."
                },
                new QuestionModel()
                {
                    Id = 39,
                    QuestionText = "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Oberoende hackare", false},
                        {"B) Aktivistgrupper", false},
                        {"C) Statssponsrade hackers", true}
                    },
                    SubCategoryId = 39,
                    Explanation = "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering, ofta riktat mot strategiska mål som forskningsdata för att få strategiska fördelar."
                },
                new QuestionModel()
                {
                    Id = 40,
                    QuestionText = "Vad avses med värvningsförsök inom cybersäkerhetskontexten?",
                    Answers = new Dictionary<string, bool>
                {
                    {"A) Att rekrytera nya medarbetare via digitala kanaler.", false},
                    {"B) Att övertyga befintliga anställda eller individer att medvetet läcka information eller ge tillgång till system.", true},
                    {"C) Att erbjuda gratis programvara till företag som en del av en marknadsföringskampanj.", false}
                },
                    SubCategoryId = 36,
                    Explanation = "Värvningsförsök innebär att övertyga befintliga anställda eller individer att medvetet läcka information eller ge tillgång till system."
                },
                new QuestionModel()
                {
                    Id = 41,
                    QuestionText = "Hur definieras affärsspionage i en digital miljö?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Utbyte av företagsinformation mellan konkurrerande företag.", false},
                        {"B) Användning av digital teknik för att otillbörligt inhämta konkurrenters företagshemligheter.", true},
                        {"C) Offentliggörande av företagsresultat på sociala medier.", false}
                    },
                    SubCategoryId = 37,
                    Explanation = "Affärsspionage i en digital miljö definieras som användningen av digital teknik för att otillbörligt inhämta konkurrenters företagshemligheter."
                },
                new QuestionModel()
                {
                    Id = 42,
                    QuestionText = "Vad är målet med digitala påverkanskampanjer?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Att öka försäljningen av en specifik produkt.", false},
                        {"B) Att sprida desinformation och påverka allmänhetens åsikter eller val.", true},
                        {"C) Att förbättra företagets varumärkesimage genom reklam.", false}
                    },
                    SubCategoryId = 38,
                    Explanation = "Målet med digitala påverkanskampanjer är att sprida desinformation och påverka allmänhetens åsikter eller val."
                },
                new QuestionModel()
                {
                    Id = 43,
                    QuestionText = "Vilken roll spelar den svenska underrättelsetjänsten i landets cyberförsvar?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Att marknadsföra Sverige som en turistdestination.", false},
                        {"B) Att samla in och analysera information om cyberhot och stärka nationens cyberförsvar.", true},
                        {"C) Att erbjuda IT-support till små och medelstora företag.", false}
                    },
                    SubCategoryId = 39,
                    Explanation = "Den svenska underrättelsetjänstens roll i landets cyberförsvar är att samla in och analysera information om cyberhot och därmed stärka nationens säkerhet."
                },
                new QuestionModel()
                {
                    Id = 44,
                    QuestionText = "Hur relaterar signalspaning och informationssäkerhet till utbyggnaden av 5G-nätverk?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) 5G-utbyggnaden är bara relevant för mobiloperatörer och påverkar inte signalspaning.", false},
                        {"B) Utbyggnaden av 5G ställer högre krav på informationssäkerhet och kan påverka metoder för signalspaning.", true},
                        {"C) 5G är endast viktigt för förbättrad spelupplevelse och har inget samband med signalspaning eller informationssäkerhet.", false}
                    },
                    SubCategoryId = 40,
                    Explanation = "Utbyggnaden av 5G ställer högre krav på informationssäkerhet och kan påverka metoder för signalspaning."
                });
        }
    }
}





