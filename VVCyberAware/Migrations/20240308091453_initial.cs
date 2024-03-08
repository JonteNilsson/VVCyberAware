using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace VVCyberAware.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Segments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    UserIsComplete = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Segments_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SegmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCategories_Segments_SegmentId",
                        column: x => x.SegmentId,
                        principalTable: "Segments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnswersJson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_SubCategories_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Info om bedrägeri", "Att skydda sig mot bedrägerier" },
                    { 2, "Digital säkerhet på företag", "Cybersäkerhet för företag" },
                    { 3, "Allmänt om cyberspionage", " Cyberspionage" }
                });

            migrationBuilder.InsertData(
                table: "Segments",
                columns: new[] { "Id", "CategoryId", "Name", "UserIsComplete" },
                values: new object[,]
                {
                    { 1, 1, "Del 1", "[]" },
                    { 2, 1, "Del 2", "[]" },
                    { 3, 1, "Del 3", "[]" },
                    { 4, 2, "Del 1", "[]" },
                    { 5, 2, "Del 2", "[]" },
                    { 6, 2, "Del 3", "[]" },
                    { 7, 2, "Del 4", "[]" },
                    { 8, 3, "Del 1", "[]" },
                    { 9, 3, "Del 2", "[]" },
                    { 10, 3, "Del 3", "[]" }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "Description", "SegmentId" },
                values: new object[,]
                {
                    { 1, "Kreditkortsbedrägeri", 1 },
                    { 2, "Romansbedrägeri", 1 },
                    { 3, "Investeringsbedrägeri", 1 },
                    { 4, "Telefonbedrägeri", 1 },
                    { 5, "Bedrägerier i hemmet", 2 },
                    { 6, "Identitetsstöld", 2 },
                    { 7, "Nätfiske och bluffmejl", 2 },
                    { 8, "Investeringsbedrägeri på nätet", 2 },
                    { 9, "Abonnemangsfällor och falska fakturor", 3 },
                    { 10, "Ransomware", 3 },
                    { 11, "Statistik och förhållningssätt", 3 },
                    { 12, "Digital säkerhet på företag", 4 },
                    { 13, "Risker och beredskap", 4 },
                    { 14, "Aktörer inom cyberbrott", 4 },
                    { 15, "Ökad digital närvaro och distansarbete", 4 },
                    { 16, "Cyberangrepp mot känsliga sektorer", 4 },
                    { 17, "Cyberrånet mot Mersk", 4 },
                    { 18, "Social engineering", 5 },
                    { 19, "Nätfiske och skräppost", 5 },
                    { 20, "Vishing", 5 },
                    { 21, "Varning för vishing", 5 },
                    { 22, "Identifiera VD-mejl", 5 },
                    { 23, "Öneangrepp och presentkortsbluffar", 5 },
                    { 24, "Virus, maskar och trojaner", 6 },
                    { 25, "Nätverksintrång", 6 },
                    { 26, "Dataintrång", 6 },
                    { 27, "Hackad!", 6 },
                    { 28, "Vägarna in", 6 },
                    { 29, "Utpressningsvirus", 7 },
                    { 30, "Attacker mot servrar", 7 },
                    { 31, "Cyberangrepp i Norden", 7 },
                    { 32, "It-brottslingarnas verktyg", 7 },
                    { 33, "Mirai, Wannacry och fallet Düsseldorf", 7 },
                    { 34, "De sårbara molnen", 7 },
                    { 35, "Allmänt om cyberspionage", 8 },
                    { 36, "Metoder för cyberspionage", 8 },
                    { 37, "Säkerhetsskyddslagen", 8 },
                    { 38, "Cyberspionagets aktörer", 8 },
                    { 39, "Värvningsförsök", 9 },
                    { 40, "Affärsspionage", 9 },
                    { 41, "Påverkanskampanjer", 9 },
                    { 42, "Svensk underrättelsetjänst och cyberförsvar", 10 },
                    { 43, "Signalspaning, informationssäkerhet och 5G", 10 },
                    { 44, "Samverkan mot cyberspionage", 10 }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[,]
                {
                    { 1, "{\"A) Ett legitimt f\\u00F6rs\\u00F6k fr\\u00E5n banken att skydda ditt konto\":false,\"B) En informationsinsamling f\\u00F6r en marknadsunders\\u00F6kning\":false,\"C) Ett potentiellt telefonbedr\\u00E4geri\":true}", "Banker och andra finansiella institutioner begär aldrig känslig information såsom kontonummer eller lösenord via telefon. Detta är ett klassiskt tecken på telefonbedrägeri.", "Du får ett oväntat telefonsamtal från någon som påstår sig vara från din bank. Personen ber dig bekräfta ditt kontonummer och lösenord för att \"säkerställa din kontos säkerhet\" efter en påstådd säkerhetsincident. Hur bör du tolka denna situation?", 1 },
                    { 2, "{\"A) Ett legitimt f\\u00F6rs\\u00F6k fr\\u00E5n banken att skydda ditt konto\":false,\"B) En informationsinsamling f\\u00F6r en marknadsunders\\u00F6kning\":false,\"C) Ett potentiellt telefonbedr\\u00E4geri\":true}", "Begäran om pengar, särskilt under omständigheter där två personer aldrig har träffats fysiskt, är ett vanligt tecken på romansbedrägeri.", "Efter flera månader av daglig kommunikation med någon du träffade på en datingsida, börjar personen berätta om en plötslig finansiell kris och ber om din hjälp genom att överföra pengar. Vad indikerar detta mest sannolikt?", 2 },
                    { 3, "{\"A) Genomf\\u00F6ra omedelbar investering f\\u00F6r att inte missa m\\u00F6jligheten\":false,\"B) Investeringsbedr\\u00E4geri\":true,\"C) Beg\\u00E4ra mer information f\\u00F6r att utf\\u00F6ra en noggrann \\u2018\\u2019due diligence\":false}", "Erbjudanden som lovar hög avkastning med liten eller ingen risk, särskilt via oönskade e-postmeddelanden, är ofta tecken på investeringsbedrägerier", "Du får ett e-postmeddelande/samtal om ett exklusivt erbjudande att investera i ett startup-företag som påstås ha en revolutionerande ny teknologi, med garantier om exceptionellt hög avkastning på mycket kort tid. Hur bör du förhålla dig till erbjudandet?\r\n", 3 },
                    { 4, "{\"A) Ett misstag av kreditkortsf\\u00F6retaget\":false,\"B) Kreditkortsbedr\\u00E4geri\":true,\"C) Obeh\\u00F6riga k\\u00F6p av en familjemedlem\":false}", "Oidentifierade transaktioner på ditt kreditkortsutdrag är en stark indikation på att ditt kortnummer har komprometterats och använts för obehöriga köp, vilket är typiskt för kreditkortsbedrägeri.", "Efter en online-shoppingrunda märker du oidentifierade transaktioner på ditt kreditkortsutdrag från företag du aldrig handlat från. Vad indikerar detta mest sannolikt?", 4 },
                    { 5, "{\"A) N\\u00E5gon erbjuder dig en gratis produkt i utbyte mot detaljerad personlig information.\":true,\"B) Din hund sk\\u00E4ller mer \\u00E4n vanligt\":false,\"C) Din granns bil ser annorlunda ut \\u00E4n den brukade.\":false}", "Denna fråga syftar till att öka medvetenheten om hur bedragare kan försöka manipulera människor i sina egna hem, ofta genom att erbjuda något som verkar vara för bra för att vara sant, som gratisprodukter eller tjänster, i utbyte mot personlig information eller finansiell data.", "Vad är de vanligaste tecknen på att du kan vara måltavla för ett bedrägeri i hemmet?", 5 },
                    { 6, "{\"A) Du f\\u00E5r en st\\u00F6rre \\u00E4n v\\u00E4ntad elr\\u00E4kning.\":false,\"B) Du m\\u00E4rker ov\\u00E4ntade transaktioner p\\u00E5 ditt bankkontoutdrag eller att dina kreditupplysningar visar konton du inte k\\u00E4nner till.\":true,\"C) Din favorit-TV-serie slutar pl\\u00F6tsligt s\\u00E4ndas.\":false}", " Denna fråga riktar in sig på att identifiera varningssignaler som kan tyda på att någon obehörigt använder din personliga information. Genom att känna till dessa tecken kan individer agera snabbt för att skydda sin finansiella hälsa och juridiska ställning.", "Hur kan du upptäcka om någon har stulit din identitet?", 6 },
                    { 7, "{\"A) Meddelandet erbjuder en kostnadsfri uppdatering till din programvara.\":false,\"B) Meddelandet inneh\\u00E5ller specifik och relevant information som bara du skulle k\\u00E4nna till.\":false,\"C) Meddelandet ber om omedelbar verifiering av personliga uppgifter via en l\\u00E4nk eller ett bifogat formul\\u00E4r.\":true}", "Denna fråga varnar för ett vanligt trick i nätfiske- och bluffmejl där avsändaren försöker få mottagaren att avslöja känslig information.", "Hur kan du känna igen ett nätfiske- eller bluffmejl?", 7 },
                    { 8, "{\"A) En investering som erbjuder regelbundna utbetalningar utan risk.\":true,\"B) En investering som st\\u00F6ds av stora, v\\u00E4lk\\u00E4nda finansinstitut.\":false,\"C) En investering som kr\\u00E4ver tid f\\u00F6r forskning och \\u00F6verv\\u00E4gande innan du engagerar dig.\":false}", "Denna fråga belyser hur löften om riskfria vinster ofta är ett tecken på investeringsbedrägeri, vilket är viktigt att känna till för att undvika ekonomiska förluster.", "Vilket av följande är en varningssignal för investeringsbedrägeri på nätet?", 8 },
                    { 9, "{\"A) Betala l\\u00F6sensumman s\\u00E5 fort som m\\u00F6jligt.\":false,\"B) H\\u00E5lla ditt operativsystem och alla program uppdaterade med de senaste s\\u00E4kerhetsuppdateringarna.\":true,\"C) \\u00D6ppna alla bilagor du f\\u00E5r via e-post f\\u00F6r att kontrollera inneh\\u00E5llet.\":false}", "Att hålla programvara uppdaterad är avgörande för att förebygga ransomware-attacker eftersom det säkerställer att kända säkerhetsbrister åtgärdas.", "Hur kan du bäst skydda dig mot ransomware-attacker?", 9 },
                    { 10, "{\"A) Du mottar en detaljerad faktura f\\u00F6r en tj\\u00E4nst du regelbundet anv\\u00E4nder.\":false,\"B) Fakturan saknar detaljerad information och kontaktuppgifter.\":true,\"C) Du k\\u00E4nner igen f\\u00F6retagets namn och logotyp.\":false}", "En faktura som saknar detaljer eller kontaktuppgifter kan vara en indikation på en abonnemangsfälla eller en falsk faktura, vilket är en vanlig taktik bland bedragare.", "Vilka är de främsta tecknen på att du kan ha drabbats av en abonnemangsfälla eller mottagit en falsk faktura?", 10 },
                    { 11, "{\"A) Genom att ignorera statistiken f\\u00F6r att fokusera p\\u00E5 annan verksamhet.\":false,\"B) Genom att anv\\u00E4nda statistiken f\\u00F6r att skr\\u00E4mma anst\\u00E4llda till b\\u00E4ttre efterlevnad.\":false,\"C) Genom att analysera trender och m\\u00F6nster f\\u00F6r att f\\u00F6rb\\u00E4ttra s\\u00E4kerhets\\u00E5tg\\u00E4rderna.\":true}", "Användning av statistik för att förstå och åtgärda säkerhetshot kan hjälpa företag att utveckla mer effektiva cybersäkerhetsstrategier och minska risken för brott.", "På vilket sätt kan statistik över cyberbrott påverka ett företags förhållningssätt till cybersäkerhet?", 11 },
                    { 12, "{\"A) Utbildning i digital s\\u00E4kerhet f\\u00F6r alla anst\\u00E4llda\":true,\"B) Installera en starkare brandv\\u00E4gg\":false,\"C) Byta ut all IT-utrustning\":false}", "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.", "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?", 12 },
                    { 13, "{\"A) Informera alla anv\\u00E4ndare om s\\u00E5rbarheten och rekommendera tempor\\u00E4ra skydds\\u00E5tg\\u00E4rder\":true,\"B) Ignorera problemet tills en patch kan utvecklas\":false,\"C) St\\u00E4nga ner tj\\u00E4nsten tillf\\u00E4lligt\":false}", "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.", "Inom företaget upptäcks det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?", 13 },
                    { 14, "{\"A) En enskild hackare med ett personligt vendetta\":false,\"B) En konkurrerande f\\u00F6retagsentitet\":false,\"C) Organiserade cyberbrottsliga grupper\":true}", "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.", "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?", 14 },
                    { 15, "{\"A) \\u00C5terg\\u00E5 till kontorsarbete\":false,\"B) Inf\\u00F6ra striktare l\\u00F6senordspolicyer och tv\\u00E5faktorsautentisering f\\u00F6r fj\\u00E4rr\\u00E5tkomst\":true,\"C) F\\u00F6rbjuda anv\\u00E4ndning av personliga enheter f\\u00F6r arbete\":false}", "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.", "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?", 15 },
                    { 16, "{\"A) Phishing\":false,\"B) Ransomware\":true,\"C) Spyware\":false}", "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.", "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?", 16 },
                    { 17, "{\"A) Spyware\":false,\"B) Ransomware\":true,\"C) Adware\":false}", "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera", "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?", 17 },
                    { 18, "{\"A) Att f\\u00F6rb\\u00E4ttra f\\u00F6retagets interna kommunikationsstrategier.\":false,\"B) Att manipulera individer till att avsl\\u00F6ja konfidentiell information eller utf\\u00F6ra handlingar som komprometterar s\\u00E4kerheten.\":true,\"C) Att uppgradera f\\u00F6retagets h\\u00E5rdvara och mjukvara f\\u00F6r att f\\u00F6rb\\u00E4ttra s\\u00E4kerheten.\":false}", "Social engineering använder mänskliga interaktioner för att få tillgång till konfidentiell information eller system. Att förstå detta är viktigt för att skydda sig.", "Vad är det primära målet med social engineering inom cybersäkerhet?", 18 },
                    { 19, "{\"A) \\u00D6ppna alla e-postmeddelanden f\\u00F6r att snabbt avg\\u00F6ra deras giltighet.\":false,\"B) Anv\\u00E4nda ett komplicerat l\\u00F6senord f\\u00F6r alla onlinekonton.\":false,\"C) Inte klicka p\\u00E5 misst\\u00E4nkta l\\u00E4nkar eller bilagor i e-postmeddelanden fr\\u00E5n ok\\u00E4nda avs\\u00E4ndare.\":true}", "Att undvika att klicka på misstänkta länkar eller bilagor är en effektiv strategi för att skydda sig mot nätfiske och skräppost.", "Vilken är den bästa metoden för att skydda sig mot nätfiske och skräppost?", 19 },
                    { 20, "{\"A) Att skicka virus genom e-postmeddelanden.\":false,\"B) Att genomf\\u00F6ra bedr\\u00E4gliga telefonsamtal d\\u00E4r avs\\u00E4ndaren utger sig f\\u00F6r att vara fr\\u00E5n en trov\\u00E4rdig organisation f\\u00F6r att f\\u00E5 tag p\\u00E5 k\\u00E4nslig information.\":true,\"C) Att anv\\u00E4nda fysisk s\\u00E4kerhetsutrustning f\\u00F6r att skydda ett n\\u00E4tverk.\":false}", "Vishing involverar bedrägliga telefonsamtal för att lura mottagaren att avslöja personlig eller finansiell information.", "Vad karaktäriserar ett vishing-angrepp?", 20 },
                    { 21, "{\"A) Ge ut personlig information f\\u00F6r att verifiera avs\\u00E4ndarens identitet.\":false,\"B) Notera avs\\u00E4ndarens information och avsluta samtalet omedelbart; rapportera sedan f\\u00F6rs\\u00F6ket till l\\u00E4mpliga myndigheter.\":true,\"C) F\\u00F6rs\\u00F6k att sp\\u00E5ra samtalet sj\\u00E4lv och konfrontera avs\\u00E4ndaren.\":false}", "Det bästa sättet att hantera ett vishing-försök är att notera avsändarens information, avsluta samtalet omedelbart och sedan rapportera försöket.", "Vilket är det bästa sättet att hantera ett misstänkt vishing-försök?", 21 },
                    { 22, "{\"A) Omedelbart f\\u00F6lja instruktionerna i mailet f\\u00F6r att visa lydnad.\":false,\"B) Kontrollera avs\\u00E4ndarens e-postadress noggrant och verifiera f\\u00F6rfr\\u00E5gan genom en annan kommunikationskanal.\":true,\"C) Skicka konfidentiell information som beg\\u00E4rs f\\u00F6r att uppr\\u00E4tth\\u00E5lla goda relationer med VD:n.\":false}", "Att känna igen och reagera korrekt på försök till VD-bedrägerier är viktigt. Kontrollera avsändarens identitet och verifiera alla förfrågningar på ett säkert sätt för att undvika bedrägerier.", "Vad bör du göra för att korrekt identifiera ett falskt VD-mejl?", 22 },
                    { 23, "{\"A) K\\u00F6p omedelbart presentkort och skicka koder till avs\\u00E4ndaren f\\u00F6r att snabbt svara p\\u00E5 deras beg\\u00E4ran.\":false,\"B) Ignorera alla f\\u00F6rfr\\u00E5gningar om att k\\u00F6pa eller skicka presentkort som kommer via e-post eller telefon.\":true,\"C) Be om ytterligare personlig information fr\\u00E5n avs\\u00E4ndaren f\\u00F6r att bekr\\u00E4fta deras identitet.\":false}", "Övertalningsangrepp och presentkortsbluffar använder manipulation för att lura individer. Det bästa försvaret är att inte svara på dessa förfrågningar och rapportera dem till lämpliga myndigheter.", "Vad är det bästa försvaret mot övertalningsangrepp och presentkortsbluffar?", 23 },
                    { 24, "{\"A) Virus beh\\u00F6ver en v\\u00E4rdfil f\\u00F6r att spridas, medan maskar kan sprida sig sj\\u00E4lvst\\u00E4ndigt och trojaner maskerar sig som legitima program.\":true,\"B) Trojaner sprider sig sj\\u00E4lvst\\u00E4ndigt via n\\u00E4tverk, medan virus och maskar \\u00E4r ofarliga filer.\":false,\"C) Maskar \\u00E4r godartade program som hj\\u00E4lper till att skydda datorer mot virus.\":false}", "Det primära skiljetecknet är att virus behöver en värdfil för att spridas, maskar sprider sig självständigt, och trojaner utger sig för att vara legitima program.", "Vilket är det primära skiljetecknet mellan virus, maskar och trojaner?", 24 },
                    { 25, "{\"A) Att endast anv\\u00E4nda tr\\u00E5dl\\u00F6sa n\\u00E4tverk.\":false,\"B) Att genomf\\u00F6ra regelbundna s\\u00E4kerhetsgranskningar och uppdatera s\\u00E4kerhetssystem.\":true,\"C) Att h\\u00E5lla n\\u00E4tverket \\u00F6ppet f\\u00F6r att kunna sp\\u00E5ra potentiella hackare.\":false}", "Regelbundna säkerhetsgranskningar och uppdateringar av säkerhetssystem är mest effektiva för att förebygga nätverksintrång.", "Vilken metod anses vara mest effektiv för att förebygga nätverksintrång?", 25 },
                    { 26, "{\"A) Ignorera varningstecknen och hoppas att problemet l\\u00F6ser sig sj\\u00E4lvt.\":false,\"B) Isolera det drabbade systemet och bed\\u00F6m omfattningen av intr\\u00E5nget.\":true,\"C) Omedelbart informera alla sociala medier om intr\\u00E5nget.\":false}", "De första stegen inkluderar att isolera det drabbade systemet och bedöma omfattningen av intrånget.", "Vilka är de första stegen du bör ta vid upptäckt av ett dataintrång?", 26 },
                    { 27, "{\"A) \\u00C4ndra alla l\\u00F6senord omedelbart.\":false,\"B) St\\u00E4ng av alla datorer och n\\u00E4tverksutrustning.\":false,\"C) Identifiera och isolera de drabbade delarna av n\\u00E4tverket.\":true}", "Det första steget bör vara att identifiera och isolera de drabbade delarna av nätverket för att förhindra ytterligare skada.", "Vad bör vara ditt första steg om du upptäcker att ditt företags nätverk har blivit hackat?", 27 },
                    { 28, "{\"A) Genom fysisk s\\u00E4kerhet och \\u00F6vervakningskameror.\":false,\"B) Genom phishing-e-post, svaga l\\u00F6senord och os\\u00E4kra n\\u00E4tverk.\":true,\"C) Genom att endast anv\\u00E4nda godk\\u00E4nd programvara.\":false}", "De vanligaste vägarna in för cyberangripare inkluderar phishing-e-post, svaga lösenord och osäkra nätverk.", "Vilka är de vanligaste vägarna in för cyberangripare?", 28 },
                    { 29, "{\"A) Betala omedelbart l\\u00F6sensumman f\\u00F6r att \\u00E5terf\\u00E5 tillg\\u00E5ng till filerna.\":false,\"B) Ignorera alla misst\\u00E4nkta e-postmeddelanden och h\\u00E5lla alla system uppdaterade.\":true,\"C) Lagra k\\u00E4nslig information p\\u00E5 l\\u00E4ttillg\\u00E4ngliga offentliga servrar.\":false}", "Den mest effektiva åtgärden för att skydda sig mot utpressningsvirus är att ignorera misstänkta e-postmeddelanden och hålla alla system uppdaterade.", "Vad är den mest effektiva åtgärden för att skydda sig mot utpressningsvirus?", 29 },
                    { 30, "{\"A) Fysisk skada p\\u00E5 serverutrustning.\":false,\"B) DDoS-attacker som \\u00F6verv\\u00E4ldigar serverns resurser.\":true,\"C) Attacker som endast riktar sig mot b\\u00E4rbara enheter.\":false}", "Den vanligaste typen av attack mot servrar är DDoS-attacker som överväldigar serverns resurser.", "Vilken är den vanligaste typen av attack mot servrar?", 30 },
                    { 31, "{\"A) De involverar oftast fysiska inbrott i datamilj\\u00F6er.\":false,\"B) De \\u00E4r vanligtvis riktade mot mobila betalningssystem.\":false,\"C) De utnyttjar ofta social engineering och phishing.\":true}", "Ett vanligt karaktärsdrag för cyberangrepp i Norden är att de ofta utnyttjar social engineering och phishing.", "Vilket karaktärsdrag är vanligt för cyberangrepp i Norden?", 31 },
                    { 32, "{\"A) Avancerade kryptografiska system.\":false,\"B) Phishing, malware och n\\u00E4tverkssniffning.\":true,\"C) Lagliga programvaror f\\u00F6r databasadministration.\":false}", "De mest använda verktygen av IT-brottslingar inkluderar phishing, malware och nätverkssniffning.", "Vilka är de mest använda verktygen av IT-brottslingar?", 32 },
                    { 33, "{\"A) De \\u00E4r alla exempel p\\u00E5 statligt sponsrade hackningsf\\u00F6rs\\u00F6k.\":false,\"B) De involverar alla skadlig programvara som sprids automatiskt \\u00F6ver n\\u00E4tverk.\":true,\"C) De \\u00E4r k\\u00E4nda fall av dataintr\\u00E5ng via sociala medier.\":false}", "Mirai, Wannacry och incidenten i Düsseldorf har gemensamt att de involverar skadlig programvara som sprids automatiskt över nätverk.", "Vad har Mirai, Wannacry och incidenten i Düsseldorf gemensamt?", 33 },
                    { 34, "{\"A) Otillr\\u00E4cklig lokal lagring.\":false,\"B) Brister i fysisk s\\u00E4kerhet hos molnleverant\\u00F6rer.\":false,\"C) Otillr\\u00E4ckliga \\u00E5tkomstkontroller och datakryptering.\":true}", "Den största säkerhetsutmaningen med molntjänster är otillräckliga åtkomstkontroller och datakryptering.", "Vad är den största säkerhetsutmaningen med molntjänster?", 34 },
                    { 35, "{\"A) Cyberkriminalitet\":false,\"B) Cyberspionage\":true,\"C) Cyberterrorism\":false}", "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande.", "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?", 35 },
                    { 36, "{\"A) Social ingenj\\u00F6rskonst\":false,\"B) Mass\\u00F6vervakning\":false,\"C) Riktade cyberattacker\":true}", "Riktade cyberattacker som utnyttjar Zero-day sårbarheter är en avancerad metod för cyberspionage, specifikt riktad för att komma åt känslig information genom att utnyttja tidigare okända sårbarheter.", "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?", 36 },
                    { 37, "{\"A) GDPR\":false,\"B) S\\u00E4kerhetsskyddslagen\":true,\"C) IT-s\\u00E4kerhetslagen\":false}", "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information och ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.", "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?", 37 },
                    { 38, "{\"A) Oberoende hackare\":false,\"B) Aktivistgrupper\":false,\"C) Statssponsrade hackers\":true}", "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering, ofta riktat mot strategiska mål som forskningsdata för att få strategiska fördelar.", "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?", 38 },
                    { 39, "{\"A) Att rekrytera nya medarbetare via digitala kanaler.\":false,\"B) Att \\u00F6vertyga befintliga anst\\u00E4llda eller individer att medvetet l\\u00E4cka information eller ge tillg\\u00E5ng till system.\":true,\"C) Att erbjuda gratis programvara till f\\u00F6retag som en del av en marknadsf\\u00F6ringskampanj.\":false}", "Värvningsförsök innebär att övertyga befintliga anställda eller individer att medvetet läcka information eller ge tillgång till system.", "Vad avses med värvningsförsök inom cybersäkerhetskontexten?", 39 },
                    { 40, "{\"A) Utbyte av f\\u00F6retagsinformation mellan konkurrerande f\\u00F6retag.\":false,\"B) Anv\\u00E4ndning av digital teknik f\\u00F6r att otillb\\u00F6rligt inh\\u00E4mta konkurrenters f\\u00F6retagshemligheter.\":true,\"C) Offentligg\\u00F6rande av f\\u00F6retagsresultat p\\u00E5 sociala medier.\":false}", "Affärsspionage i en digital miljö definieras som användningen av digital teknik för att otillbörligt inhämta konkurrenters företagshemligheter.", "Hur definieras affärsspionage i en digital miljö?", 40 },
                    { 41, "{\"A) Att \\u00F6ka f\\u00F6rs\\u00E4ljningen av en specifik produkt.\":false,\"B) Att sprida desinformation och p\\u00E5verka allm\\u00E4nhetens \\u00E5sikter eller val.\":true,\"C) Att f\\u00F6rb\\u00E4ttra f\\u00F6retagets varum\\u00E4rkesimage genom reklam.\":false}", "Målet med digitala påverkanskampanjer är att sprida desinformation och påverka allmänhetens åsikter eller val.", "Vad är målet med digitala påverkanskampanjer?", 41 },
                    { 42, "{\"A) Att marknadsf\\u00F6ra Sverige som en turistdestination.\":false,\"B) Att samla in och analysera information om cyberhot och st\\u00E4rka nationens cyberf\\u00F6rsvar.\":true,\"C) Att erbjuda IT-support till sm\\u00E5 och medelstora f\\u00F6retag.\":false}", "Den svenska underrättelsetjänstens roll i landets cyberförsvar är att samla in och analysera information om cyberhot och därmed stärka nationens säkerhet.", "Vilken roll spelar den svenska underrättelsetjänsten i landets cyberförsvar?", 42 },
                    { 43, "{\"A) 5G-utbyggnaden \\u00E4r bara relevant f\\u00F6r mobiloperat\\u00F6rer och p\\u00E5verkar inte signalspaning.\":false,\"B) Utbyggnaden av 5G st\\u00E4ller h\\u00F6gre krav p\\u00E5 informationss\\u00E4kerhet och kan p\\u00E5verka metoder f\\u00F6r signalspaning.\":true,\"C) 5G \\u00E4r endast viktigt f\\u00F6r f\\u00F6rb\\u00E4ttrad spelupplevelse och har inget samband med signalspaning eller informationss\\u00E4kerhet.\":false}", "Utbyggnaden av 5G ställer högre krav på informationssäkerhet och kan påverka metoder för signalspaning.", "Hur relaterar signalspaning och informationssäkerhet till utbyggnaden av 5G-nätverk?", 43 },
                    { 44, "{\"A) Anv\\u00E4nda endast antivirusprogram.\":false,\"B) Blockera all inkommande trafik fr\\u00E5n utlandet.\":false,\"C) Dela underr\\u00E4ttelseinformation med andra organisationer.\":true}", "Att dela underrättelseinformation hjälper organisationer att identifiera och motverka cyberspionage mer effektivt genom förbättrad medvetenhet och koordinerade försvarsåtgärder.", "Vilken åtgärd är mest effektiv för samverkan mot cyberspionage?", 44 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SubCategoryId",
                table: "Questions",
                column: "SubCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Segments_CategoryId",
                table: "Segments",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_SegmentId",
                table: "SubCategories",
                column: "SegmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "SubCategories");

            migrationBuilder.DropTable(
                name: "Segments");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
