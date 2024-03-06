using Humanizer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
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
                    Id= 12,
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
                    Id =4,
                    QuestionText = "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?",
                    Answers = new Dictionary<string, bool>
                    {
                        {"A) Ett misstag av kreditkortsföretaget",false},
                        {"B) Kreditkortsbedrägeri",true },
                        {"C) Obehöriga köp av en familjemedlem", false }
                    },
                    SubCategoryId= 4,
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
                    SubCategoryId= 6,
                    Explanation = " Denna fråga riktar in sig på att identifiera varningssignaler som kan tyda på att någon obehörigt använder din personliga information. Genom att känna till dessa tecken kan individer agera snabbt för att skydda sin finansiella hälsa och juridiska ställning."
                }
                //new QuestionModel()
                //{
                //    //Id = 7,
                //    //QuestionText = "Hur kan du känna igen ett nätfiske- eller bluffmejl?",
                //    //Answers = new Dictionary<string, bool>
                //    //{
                //    //    {}
                //    //}

                
                );
        }
    }
}





