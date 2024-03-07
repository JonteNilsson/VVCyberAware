using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VVCyberAware.Migrations
{
    /// <inheritdoc />
    public partial class seedadataa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Du mottar en detaljerad faktura f\\u00F6r en tj\\u00E4nst du regelbundet anv\\u00E4nder.\":false,\"B) Fakturan saknar detaljerad information och kontaktuppgifter.\":true,\"C) Du k\\u00E4nner igen f\\u00F6retagets namn och logotyp.\":false}", "En faktura som saknar detaljer eller kontaktuppgifter kan vara en indikation på en abonnemangsfälla eller en falsk faktura, vilket är en vanlig taktik bland bedragare.", "Vilka är de främsta tecknen på att du kan ha drabbats av en abonnemangsfälla eller mottagit en falsk faktura?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Genom att ignorera statistiken f\\u00F6r att fokusera p\\u00E5 annan verksamhet.\":false,\"B) Genom att anv\\u00E4nda statistiken f\\u00F6r att skr\\u00E4mma anst\\u00E4llda till b\\u00E4ttre efterlevnad.\":false,\"C) Genom att analysera trender och m\\u00F6nster f\\u00F6r att f\\u00F6rb\\u00E4ttra s\\u00E4kerhets\\u00E5tg\\u00E4rderna.\":true}", "Användning av statistik för att förstå och åtgärda säkerhetshot kan hjälpa företag att utveckla mer effektiva cybersäkerhetsstrategier och minska risken för brott.", "På vilket sätt kan statistik över cyberbrott påverka ett företags förhållningssätt till cybersäkerhet?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Utbildning i digital s\\u00E4kerhet f\\u00F6r alla anst\\u00E4llda\":true,\"B) Installera en starkare brandv\\u00E4gg\":false,\"C) Byta ut all IT-utrustning\":false}", "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.", "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Informera alla anv\\u00E4ndare om s\\u00E5rbarheten och rekommendera tempor\\u00E4ra skydds\\u00E5tg\\u00E4rder\":true,\"B) Ignorera problemet tills en patch kan utvecklas\":false,\"C) St\\u00E4nga ner tj\\u00E4nsten tillf\\u00E4lligt\":false}", "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.", "Inom företaget upptäcks det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) En enskild hackare med ett personligt vendetta\":false,\"B) En konkurrerande f\\u00F6retagsentitet\":false,\"C) Organiserade cyberbrottsliga grupper\":true}", "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.", "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) \\u00C5terg\\u00E5 till kontorsarbete\":false,\"B) Inf\\u00F6ra striktare l\\u00F6senordspolicyer och tv\\u00E5faktorsautentisering f\\u00F6r fj\\u00E4rr\\u00E5tkomst\":true,\"C) F\\u00F6rbjuda anv\\u00E4ndning av personliga enheter f\\u00F6r arbete\":false}", "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.", "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Phishing\":false,\"B) Ransomware\":true,\"C) Spyware\":false}", "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.", "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Spyware\":false,\"B) Ransomware\":true,\"C) Adware\":false}", "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera", "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Att f\\u00F6rb\\u00E4ttra f\\u00F6retagets interna kommunikationsstrategier.\":false,\"B) Att manipulera individer till att avsl\\u00F6ja konfidentiell information eller utf\\u00F6ra handlingar som komprometterar s\\u00E4kerheten.\":true,\"C) Att uppgradera f\\u00F6retagets h\\u00E5rdvara och mjukvara f\\u00F6r att f\\u00F6rb\\u00E4ttra s\\u00E4kerheten.\":false}", "Social engineering använder mänskliga interaktioner för att få tillgång till konfidentiell information eller system. Att förstå detta är viktigt för att skydda sig.", "Vad är det primära målet med social engineering inom cybersäkerhet?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) \\u00D6ppna alla e-postmeddelanden f\\u00F6r att snabbt avg\\u00F6ra deras giltighet.\":false,\"B) Anv\\u00E4nda ett komplicerat l\\u00F6senord f\\u00F6r alla onlinekonton.\":false,\"C) Inte klicka p\\u00E5 misst\\u00E4nkta l\\u00E4nkar eller bilagor i e-postmeddelanden fr\\u00E5n ok\\u00E4nda avs\\u00E4ndare.\":true}", "Att undvika att klicka på misstänkta länkar eller bilagor är en effektiv strategi för att skydda sig mot nätfiske och skräppost.", "Vilken är den bästa metoden för att skydda sig mot nätfiske och skräppost?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Att skicka virus genom e-postmeddelanden.\":false,\"B) Att genomf\\u00F6ra bedr\\u00E4gliga telefonsamtal d\\u00E4r avs\\u00E4ndaren utger sig f\\u00F6r att vara fr\\u00E5n en trov\\u00E4rdig organisation f\\u00F6r att f\\u00E5 tag p\\u00E5 k\\u00E4nslig information.\":true,\"C) Att anv\\u00E4nda fysisk s\\u00E4kerhetsutrustning f\\u00F6r att skydda ett n\\u00E4tverk.\":false}", "Vishing involverar bedrägliga telefonsamtal för att lura mottagaren att avslöja personlig eller finansiell information.", "Vad karaktäriserar ett vishing-angrepp?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Ge ut personlig information f\\u00F6r att verifiera avs\\u00E4ndarens identitet.\":false,\"B) Notera avs\\u00E4ndarens information och avsluta samtalet omedelbart; rapportera sedan f\\u00F6rs\\u00F6ket till l\\u00E4mpliga myndigheter.\":true,\"C) F\\u00F6rs\\u00F6k att sp\\u00E5ra samtalet sj\\u00E4lv och konfrontera avs\\u00E4ndaren.\":false}", "Det bästa sättet att hantera ett vishing-försök är att notera avsändarens information, avsluta samtalet omedelbart och sedan rapportera försöket.", "Vilket är det bästa sättet att hantera ett misstänkt vishing-försök?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Omedelbart f\\u00F6lja instruktionerna i mailet f\\u00F6r att visa lydnad.\":false,\"B) Kontrollera avs\\u00E4ndarens e-postadress noggrant och verifiera f\\u00F6rfr\\u00E5gan genom en annan kommunikationskanal.\":true,\"C) Skicka konfidentiell information som beg\\u00E4rs f\\u00F6r att uppr\\u00E4tth\\u00E5lla goda relationer med VD:n.\":false}", "Att känna igen och reagera korrekt på försök till VD-bedrägerier är viktigt. Kontrollera avsändarens identitet och verifiera alla förfrågningar på ett säkert sätt för att undvika bedrägerier.", "Vad bör du göra för att korrekt identifiera ett falskt VD-mejl?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) K\\u00F6p omedelbart presentkort och skicka koder till avs\\u00E4ndaren f\\u00F6r att snabbt svara p\\u00E5 deras beg\\u00E4ran.\":false,\"B) Ignorera alla f\\u00F6rfr\\u00E5gningar om att k\\u00F6pa eller skicka presentkort som kommer via e-post eller telefon.\":true,\"C) Be om ytterligare personlig information fr\\u00E5n avs\\u00E4ndaren f\\u00F6r att bekr\\u00E4fta deras identitet.\":false}", "Övertalningsangrepp och presentkortsbluffar använder manipulation för att lura individer. Det bästa försvaret är att inte svara på dessa förfrågningar och rapportera dem till lämpliga myndigheter.", "Vad är det bästa försvaret mot övertalningsangrepp och presentkortsbluffar?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Virus beh\\u00F6ver en v\\u00E4rdfil f\\u00F6r att spridas, medan maskar kan sprida sig sj\\u00E4lvst\\u00E4ndigt och trojaner maskerar sig som legitima program.\":true,\"B) Trojaner sprider sig sj\\u00E4lvst\\u00E4ndigt via n\\u00E4tverk, medan virus och maskar \\u00E4r ofarliga filer.\":false,\"C) Maskar \\u00E4r godartade program som hj\\u00E4lper till att skydda datorer mot virus.\":false}", "Det primära skiljetecknet är att virus behöver en värdfil för att spridas, maskar sprider sig självständigt, och trojaner utger sig för att vara legitima program.", "Vilket är det primära skiljetecknet mellan virus, maskar och trojaner?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Att endast anv\\u00E4nda tr\\u00E5dl\\u00F6sa n\\u00E4tverk.\":false,\"B) Att genomf\\u00F6ra regelbundna s\\u00E4kerhetsgranskningar och uppdatera s\\u00E4kerhetssystem.\":true,\"C) Att h\\u00E5lla n\\u00E4tverket \\u00F6ppet f\\u00F6r att kunna sp\\u00E5ra potentiella hackare.\":false}", "Regelbundna säkerhetsgranskningar och uppdateringar av säkerhetssystem är mest effektiva för att förebygga nätverksintrång.", "Vilken metod anses vara mest effektiv för att förebygga nätverksintrång?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Ignorera varningstecknen och hoppas att problemet l\\u00F6ser sig sj\\u00E4lvt.\":false,\"B) Isolera det drabbade systemet och bed\\u00F6m omfattningen av intr\\u00E5nget.\":true,\"C) Omedelbart informera alla sociala medier om intr\\u00E5nget.\":false}", "De första stegen inkluderar att isolera det drabbade systemet och bedöma omfattningen av intrånget.", "Vilka är de första stegen du bör ta vid upptäckt av ett dataintrång?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) \\u00C4ndra alla l\\u00F6senord omedelbart.\":false,\"B) St\\u00E4ng av alla datorer och n\\u00E4tverksutrustning.\":false,\"C) Identifiera och isolera de drabbade delarna av n\\u00E4tverket.\":true}", "Det första steget bör vara att identifiera och isolera de drabbade delarna av nätverket för att förhindra ytterligare skada.", "Vad bör vara ditt första steg om du upptäcker att ditt företags nätverk har blivit hackat?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Genom fysisk s\\u00E4kerhet och \\u00F6vervakningskameror.\":false,\"B) Genom phishing-e-post, svaga l\\u00F6senord och os\\u00E4kra n\\u00E4tverk.\":true,\"C) Genom att endast anv\\u00E4nda godk\\u00E4nd programvara.\":false}", "De vanligaste vägarna in för cyberangripare inkluderar phishing-e-post, svaga lösenord och osäkra nätverk.", "Vilka är de vanligaste vägarna in för cyberangripare?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Betala omedelbart l\\u00F6sensumman f\\u00F6r att \\u00E5terf\\u00E5 tillg\\u00E5ng till filerna.\":false,\"B) Ignorera alla misst\\u00E4nkta e-postmeddelanden och h\\u00E5lla alla system uppdaterade.\":true,\"C) Lagra k\\u00E4nslig information p\\u00E5 l\\u00E4ttillg\\u00E4ngliga offentliga servrar.\":false}", "Den mest effektiva åtgärden för att skydda sig mot utpressningsvirus är att ignorera misstänkta e-postmeddelanden och hålla alla system uppdaterade.", "Vad är den mest effektiva åtgärden för att skydda sig mot utpressningsvirus?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Fysisk skada p\\u00E5 serverutrustning.\":false,\"B) DDoS-attacker som \\u00F6verv\\u00E4ldigar serverns resurser.\":true,\"C) Attacker som endast riktar sig mot b\\u00E4rbara enheter.\":false}", "Den vanligaste typen av attack mot servrar är DDoS-attacker som överväldigar serverns resurser.", "Vilken är den vanligaste typen av attack mot servrar?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) De involverar oftast fysiska inbrott i datamilj\\u00F6er.\":false,\"B) De \\u00E4r vanligtvis riktade mot mobila betalningssystem.\":false,\"C) De utnyttjar ofta social engineering och phishing.\":true}", "Ett vanligt karaktärsdrag för cyberangrepp i Norden är att de ofta utnyttjar social engineering och phishing.", "Vilket karaktärsdrag är vanligt för cyberangrepp i Norden?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Avancerade kryptografiska system.\":false,\"B) Phishing, malware och n\\u00E4tverkssniffning.\":true,\"C) Lagliga programvaror f\\u00F6r databasadministration.\":false}", "De mest använda verktygen av IT-brottslingar inkluderar phishing, malware och nätverkssniffning.", "Vilka är de mest använda verktygen av IT-brottslingar?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) De \\u00E4r alla exempel p\\u00E5 statligt sponsrade hackningsf\\u00F6rs\\u00F6k.\":false,\"B) De involverar alla skadlig programvara som sprids automatiskt \\u00F6ver n\\u00E4tverk.\":true,\"C) De \\u00E4r k\\u00E4nda fall av dataintr\\u00E5ng via sociala medier.\":false}", "Mirai, Wannacry och incidenten i Düsseldorf har gemensamt att de involverar skadlig programvara som sprids automatiskt över nätverk.", "Vad har Mirai, Wannacry och incidenten i Düsseldorf gemensamt?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Otillr\\u00E4cklig lokal lagring.\":false,\"B) Brister i fysisk s\\u00E4kerhet hos molnleverant\\u00F6rer.\":false,\"C) Otillr\\u00E4ckliga \\u00E5tkomstkontroller och datakryptering.\":true}", "Den största säkerhetsutmaningen med molntjänster är otillräckliga åtkomstkontroller och datakryptering.", "Vad är den största säkerhetsutmaningen med molntjänster?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Cyberkriminalitet\":false,\"B) Cyberspionage\":true,\"C) Cyberterrorism\":false}", "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande.", "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Social ingenj\\u00F6rskonst\":false,\"B) Mass\\u00F6vervakning\":false,\"C) Riktade cyberattacker\":true}", "Riktade cyberattacker som utnyttjar Zero-day sårbarheter är en avancerad metod för cyberspionage, specifikt riktad för att komma åt känslig information genom att utnyttja tidigare okända sårbarheter.", "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) GDPR\":false,\"B) S\\u00E4kerhetsskyddslagen\":true,\"C) IT-s\\u00E4kerhetslagen\":false}", "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information och ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.", "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Oberoende hackare\":false,\"B) Aktivistgrupper\":false,\"C) Statssponsrade hackers\":true}", "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering, ofta riktat mot strategiska mål som forskningsdata för att få strategiska fördelar.", "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Att rekrytera nya medarbetare via digitala kanaler.\":false,\"B) Att \\u00F6vertyga befintliga anst\\u00E4llda eller individer att medvetet l\\u00E4cka information eller ge tillg\\u00E5ng till system.\":true,\"C) Att erbjuda gratis programvara till f\\u00F6retag som en del av en marknadsf\\u00F6ringskampanj.\":false}", "Värvningsförsök innebär att övertyga befintliga anställda eller individer att medvetet läcka information eller ge tillgång till system.", "Vad avses med värvningsförsök inom cybersäkerhetskontexten?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) Utbyte av f\\u00F6retagsinformation mellan konkurrerande f\\u00F6retag.\":false,\"B) Anv\\u00E4ndning av digital teknik f\\u00F6r att otillb\\u00F6rligt inh\\u00E4mta konkurrenters f\\u00F6retagshemligheter.\":true,\"C) Offentligg\\u00F6rande av f\\u00F6retagsresultat p\\u00E5 sociala medier.\":false}", "Affärsspionage i en digital miljö definieras som användningen av digital teknik för att otillbörligt inhämta konkurrenters företagshemligheter.", "Hur definieras affärsspionage i en digital miljö?", 40 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) Att \\u00F6ka f\\u00F6rs\\u00E4ljningen av en specifik produkt.\":false,\"B) Att sprida desinformation och p\\u00E5verka allm\\u00E4nhetens \\u00E5sikter eller val.\":true,\"C) Att f\\u00F6rb\\u00E4ttra f\\u00F6retagets varum\\u00E4rkesimage genom reklam.\":false}", "Målet med digitala påverkanskampanjer är att sprida desinformation och påverka allmänhetens åsikter eller val.", "Vad är målet med digitala påverkanskampanjer?", 41 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) Att marknadsf\\u00F6ra Sverige som en turistdestination.\":false,\"B) Att samla in och analysera information om cyberhot och st\\u00E4rka nationens cyberf\\u00F6rsvar.\":true,\"C) Att erbjuda IT-support till sm\\u00E5 och medelstora f\\u00F6retag.\":false}", "Den svenska underrättelsetjänstens roll i landets cyberförsvar är att samla in och analysera information om cyberhot och därmed stärka nationens säkerhet.", "Vilken roll spelar den svenska underrättelsetjänsten i landets cyberförsvar?", 42 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) 5G-utbyggnaden \\u00E4r bara relevant f\\u00F6r mobiloperat\\u00F6rer och p\\u00E5verkar inte signalspaning.\":false,\"B) Utbyggnaden av 5G st\\u00E4ller h\\u00F6gre krav p\\u00E5 informationss\\u00E4kerhet och kan p\\u00E5verka metoder f\\u00F6r signalspaning.\":true,\"C) 5G \\u00E4r endast viktigt f\\u00F6r f\\u00F6rb\\u00E4ttrad spelupplevelse och har inget samband med signalspaning eller informationss\\u00E4kerhet.\":false}", "Utbyggnaden av 5G ställer högre krav på informationssäkerhet och kan påverka metoder för signalspaning.", "Hur relaterar signalspaning och informationssäkerhet till utbyggnaden av 5G-nätverk?", 43 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) Anv\\u00E4nda endast antivirusprogram.\":false,\"B) Blockera all inkommande trafik fr\\u00E5n utlandet.\":false,\"C) Dela underr\\u00E4ttelseinformation med andra organisationer.\":true}", "Att dela underrättelseinformation hjälper organisationer att identifiera och motverka cyberspionage mer effektivt genom förbättrad medvetenhet och koordinerade försvarsåtgärder.", "Vilken åtgärd är mest effektiv för samverkan mot cyberspionage?", 44 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { 9, "{\"A) Betala l\\u00F6sensumman s\\u00E5 fort som m\\u00F6jligt.\":false,\"B) H\\u00E5lla ditt operativsystem och alla program uppdaterade med de senaste s\\u00E4kerhetsuppdateringarna.\":true,\"C) \\u00D6ppna alla bilagor du f\\u00E5r via e-post f\\u00F6r att kontrollera inneh\\u00E5llet.\":false}", "Att hålla programvara uppdaterad är avgörande för att förebygga ransomware-attacker eftersom det säkerställer att kända säkerhetsbrister åtgärdas.", "Hur kan du bäst skydda dig mot ransomware-attacker?", 9 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Betala l\\u00F6sensumman s\\u00E5 fort som m\\u00F6jligt.\":false,\"B) H\\u00E5lla ditt operativsystem och alla program uppdaterade med de senaste s\\u00E4kerhetsuppdateringarna.\":true,\"C) \\u00D6ppna alla bilagor du f\\u00E5r via e-post f\\u00F6r att kontrollera inneh\\u00E5llet.\":false}", "Att hålla programvara uppdaterad är avgörande för att förebygga ransomware-attacker eftersom det säkerställer att kända säkerhetsbrister åtgärdas.", "Hur kan du bäst skydda dig mot ransomware-attacker?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Du mottar en detaljerad faktura f\\u00F6r en tj\\u00E4nst du regelbundet anv\\u00E4nder.\":false,\"B) Fakturan saknar detaljerad information och kontaktuppgifter.\":true,\"C) Du k\\u00E4nner igen f\\u00F6retagets namn och logotyp.\":false}", "En faktura som saknar detaljer eller kontaktuppgifter kan vara en indikation på en abonnemangsfälla eller en falsk faktura, vilket är en vanlig taktik bland bedragare.", "Vilka är de främsta tecknen på att du kan ha drabbats av en abonnemangsfälla eller mottagit en falsk faktura?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Genom att ignorera statistiken f\\u00F6r att fokusera p\\u00E5 annan verksamhet.\":false,\"B) Genom att anv\\u00E4nda statistiken f\\u00F6r att skr\\u00E4mma anst\\u00E4llda till b\\u00E4ttre efterlevnad.\":false,\"C) Genom att analysera trender och m\\u00F6nster f\\u00F6r att f\\u00F6rb\\u00E4ttra s\\u00E4kerhets\\u00E5tg\\u00E4rderna.\":true}", "Användning av statistik för att förstå och åtgärda säkerhetshot kan hjälpa företag att utveckla mer effektiva cybersäkerhetsstrategier och minska risken för brott.", "På vilket sätt kan statistik över cyberbrott påverka ett företags förhållningssätt till cybersäkerhet?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Utbildning i digital s\\u00E4kerhet f\\u00F6r alla anst\\u00E4llda\":true,\"B) Installera en starkare brandv\\u00E4gg\":false,\"C) Byta ut all IT-utrustning\":false}", "Utbildning i digital säkerhet är avgörande för att hjälpa anställda att känna igen och undvika säkerhetshot som phishing, vilket är en vanlig attackvektor.", "Inom företaget märker man att konfidentiella dokument regelbundet läcker ut till konkurrenter. Efter en intern granskning upptäcks det att en anställd omedvetet har installerat skadlig programvara genom att klicka på en länk i ett phishing-e-postmeddelande. Vilken åtgärd bör prioriteras för att förhindra framtida incidenter?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Informera alla anv\\u00E4ndare om s\\u00E5rbarheten och rekommendera tempor\\u00E4ra skydds\\u00E5tg\\u00E4rder\":true,\"B) Ignorera problemet tills en patch kan utvecklas\":false,\"C) St\\u00E4nga ner tj\\u00E4nsten tillf\\u00E4lligt\":false}", "Transparent kommunikation och rådgivning om tillfälliga åtgärder är avgörande för att skydda användarna medan en permanent lösning utvecklas.", "Inom företaget upptäcks det en sårbarhet i vår programvara som kunde möjliggöra obehörig åtkomst till användardata. Företaget har inte omedelbart en lösning. Vilken är den mest lämpliga första åtgärden?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) En enskild hackare med ett personligt vendetta\":false,\"B) En konkurrerande f\\u00F6retagsentitet\":false,\"C) Organiserade cyberbrottsliga grupper\":true}", "DDoS-attacker kräver ofta betydande resurser och koordinering, vilket är karakteristiskt för organiserade cyberbrottsliga grupper.", "Vårt företag blir måltavla för en DDoS-attack som överväldigar våra servers och gör våra tjänster otillgängliga för kunder. Vilken typ av aktör är mest sannolikt ansvarig för denna typ av attack?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) \\u00C5terg\\u00E5 till kontorsarbete\":false,\"B) Inf\\u00F6ra striktare l\\u00F6senordspolicyer och tv\\u00E5faktorsautentisering f\\u00F6r fj\\u00E4rr\\u00E5tkomst\":true,\"C) F\\u00F6rbjuda anv\\u00E4ndning av personliga enheter f\\u00F6r arbete\":false}", "Stärkt autentisering är kritisk för att säkra fjärråtkomst och skydda mot obehörig åtkomst i en distribuerad arbetsmiljö.", "Med övergången till distansarbete upptäcker vårt företag en ökning av säkerhetsincidenter, inklusive obehörig åtkomst till företagsdata. Vilken åtgärd bör företaget vidta för att adressera denna nya riskmiljö?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Phishing\":false,\"B) Ransomware\":true,\"C) Spyware\":false}", "Ransomware-angrepp involverar kryptering av offerdata och kräver lösen för dekryptering, vilket är särskilt skadligt för kritiska sektorer som hälsovård.", "Hälsovårdsmyndigheten utsätts för ett cyberangrepp som krypterar patientdata och kräver lösen för att återställa åtkomsten. Vilken typ av angrepp har de sannolikt blivit utsatta för?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Spyware\":false,\"B) Ransomware\":true,\"C) Adware\":false}", "Maersk utsattes för NotPetya ransomware-angreppet, som ledde till omfattande störningar och förluster genom att kryptera", "Det globala fraktbolaget Maersk blev offer för ett omfattande cyberangrepp som avsevärt störde deras verksamhet världen över. Vilken typ av malware var primärt ansvarig för denna incident?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Att f\\u00F6rb\\u00E4ttra f\\u00F6retagets interna kommunikationsstrategier.\":false,\"B) Att manipulera individer till att avsl\\u00F6ja konfidentiell information eller utf\\u00F6ra handlingar som komprometterar s\\u00E4kerheten.\":true,\"C) Att uppgradera f\\u00F6retagets h\\u00E5rdvara och mjukvara f\\u00F6r att f\\u00F6rb\\u00E4ttra s\\u00E4kerheten.\":false}", "Social engineering använder mänskliga interaktioner för att få tillgång till konfidentiell information eller system. Att förstå detta är viktigt för att skydda sig.", "Vad är det primära målet med social engineering inom cybersäkerhet?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) \\u00D6ppna alla e-postmeddelanden f\\u00F6r att snabbt avg\\u00F6ra deras giltighet.\":false,\"B) Anv\\u00E4nda ett komplicerat l\\u00F6senord f\\u00F6r alla onlinekonton.\":false,\"C) Inte klicka p\\u00E5 misst\\u00E4nkta l\\u00E4nkar eller bilagor i e-postmeddelanden fr\\u00E5n ok\\u00E4nda avs\\u00E4ndare.\":true}", "Att undvika att klicka på misstänkta länkar eller bilagor är en effektiv strategi för att skydda sig mot nätfiske och skräppost.", "Vilken är den bästa metoden för att skydda sig mot nätfiske och skräppost?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Att skicka virus genom e-postmeddelanden.\":false,\"B) Att genomf\\u00F6ra bedr\\u00E4gliga telefonsamtal d\\u00E4r avs\\u00E4ndaren utger sig f\\u00F6r att vara fr\\u00E5n en trov\\u00E4rdig organisation f\\u00F6r att f\\u00E5 tag p\\u00E5 k\\u00E4nslig information.\":true,\"C) Att anv\\u00E4nda fysisk s\\u00E4kerhetsutrustning f\\u00F6r att skydda ett n\\u00E4tverk.\":false}", "Vishing involverar bedrägliga telefonsamtal för att lura mottagaren att avslöja personlig eller finansiell information.", "Vad karaktäriserar ett vishing-angrepp?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Ge ut personlig information f\\u00F6r att verifiera avs\\u00E4ndarens identitet.\":false,\"B) Notera avs\\u00E4ndarens information och avsluta samtalet omedelbart; rapportera sedan f\\u00F6rs\\u00F6ket till l\\u00E4mpliga myndigheter.\":true,\"C) F\\u00F6rs\\u00F6k att sp\\u00E5ra samtalet sj\\u00E4lv och konfrontera avs\\u00E4ndaren.\":false}", "Det bästa sättet att hantera ett vishing-försök är att notera avsändarens information, avsluta samtalet omedelbart och sedan rapportera försöket.", "Vilket är det bästa sättet att hantera ett misstänkt vishing-försök?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Omedelbart f\\u00F6lja instruktionerna i mailet f\\u00F6r att visa lydnad.\":false,\"B) Kontrollera avs\\u00E4ndarens e-postadress noggrant och verifiera f\\u00F6rfr\\u00E5gan genom en annan kommunikationskanal.\":true,\"C) Skicka konfidentiell information som beg\\u00E4rs f\\u00F6r att uppr\\u00E4tth\\u00E5lla goda relationer med VD:n.\":false}", "Att känna igen och reagera korrekt på försök till VD-bedrägerier är viktigt. Kontrollera avsändarens identitet och verifiera alla förfrågningar på ett säkert sätt för att undvika bedrägerier.", "Vad bör du göra för att korrekt identifiera ett falskt VD-mejl?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) K\\u00F6p omedelbart presentkort och skicka koder till avs\\u00E4ndaren f\\u00F6r att snabbt svara p\\u00E5 deras beg\\u00E4ran.\":false,\"B) Ignorera alla f\\u00F6rfr\\u00E5gningar om att k\\u00F6pa eller skicka presentkort som kommer via e-post eller telefon.\":true,\"C) Be om ytterligare personlig information fr\\u00E5n avs\\u00E4ndaren f\\u00F6r att bekr\\u00E4fta deras identitet.\":false}", "Övertalningsangrepp och presentkortsbluffar använder manipulation för att lura individer. Det bästa försvaret är att inte svara på dessa förfrågningar och rapportera dem till lämpliga myndigheter.", "Vad är det bästa försvaret mot övertalningsangrepp och presentkortsbluffar?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Virus beh\\u00F6ver en v\\u00E4rdfil f\\u00F6r att spridas, medan maskar kan sprida sig sj\\u00E4lvst\\u00E4ndigt och trojaner maskerar sig som legitima program.\":true,\"B) Trojaner sprider sig sj\\u00E4lvst\\u00E4ndigt via n\\u00E4tverk, medan virus och maskar \\u00E4r ofarliga filer.\":false,\"C) Maskar \\u00E4r godartade program som hj\\u00E4lper till att skydda datorer mot virus.\":false}", "Det primära skiljetecknet är att virus behöver en värdfil för att spridas, maskar sprider sig självständigt, och trojaner utger sig för att vara legitima program.", "Vilket är det primära skiljetecknet mellan virus, maskar och trojaner?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Att endast anv\\u00E4nda tr\\u00E5dl\\u00F6sa n\\u00E4tverk.\":false,\"B) Att genomf\\u00F6ra regelbundna s\\u00E4kerhetsgranskningar och uppdatera s\\u00E4kerhetssystem.\":true,\"C) Att h\\u00E5lla n\\u00E4tverket \\u00F6ppet f\\u00F6r att kunna sp\\u00E5ra potentiella hackare.\":false}", "Regelbundna säkerhetsgranskningar och uppdateringar av säkerhetssystem är mest effektiva för att förebygga nätverksintrång.", "Vilken metod anses vara mest effektiv för att förebygga nätverksintrång?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Ignorera varningstecknen och hoppas att problemet l\\u00F6ser sig sj\\u00E4lvt.\":false,\"B) Isolera det drabbade systemet och bed\\u00F6m omfattningen av intr\\u00E5nget.\":true,\"C) Omedelbart informera alla sociala medier om intr\\u00E5nget.\":false}", "De första stegen inkluderar att isolera det drabbade systemet och bedöma omfattningen av intrånget.", "Vilka är de första stegen du bör ta vid upptäckt av ett dataintrång?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) \\u00C4ndra alla l\\u00F6senord omedelbart.\":false,\"B) St\\u00E4ng av alla datorer och n\\u00E4tverksutrustning.\":false,\"C) Identifiera och isolera de drabbade delarna av n\\u00E4tverket.\":true}", "Det första steget bör vara att identifiera och isolera de drabbade delarna av nätverket för att förhindra ytterligare skada.", "Vad bör vara ditt första steg om du upptäcker att ditt företags nätverk har blivit hackat?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Genom fysisk s\\u00E4kerhet och \\u00F6vervakningskameror.\":false,\"B) Genom phishing-e-post, svaga l\\u00F6senord och os\\u00E4kra n\\u00E4tverk.\":true,\"C) Genom att endast anv\\u00E4nda godk\\u00E4nd programvara.\":false}", "De vanligaste vägarna in för cyberangripare inkluderar phishing-e-post, svaga lösenord och osäkra nätverk.", "Vilka är de vanligaste vägarna in för cyberangripare?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Betala omedelbart l\\u00F6sensumman f\\u00F6r att \\u00E5terf\\u00E5 tillg\\u00E5ng till filerna.\":false,\"B) Ignorera alla misst\\u00E4nkta e-postmeddelanden och h\\u00E5lla alla system uppdaterade.\":true,\"C) Lagra k\\u00E4nslig information p\\u00E5 l\\u00E4ttillg\\u00E4ngliga offentliga servrar.\":false}", "Den mest effektiva åtgärden för att skydda sig mot utpressningsvirus är att ignorera misstänkta e-postmeddelanden och hålla alla system uppdaterade.", "Vad är den mest effektiva åtgärden för att skydda sig mot utpressningsvirus?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Fysisk skada p\\u00E5 serverutrustning.\":false,\"B) DDoS-attacker som \\u00F6verv\\u00E4ldigar serverns resurser.\":true,\"C) Attacker som endast riktar sig mot b\\u00E4rbara enheter.\":false}", "Den vanligaste typen av attack mot servrar är DDoS-attacker som överväldigar serverns resurser.", "Vilken är den vanligaste typen av attack mot servrar?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) De involverar oftast fysiska inbrott i datamilj\\u00F6er.\":false,\"B) De \\u00E4r vanligtvis riktade mot mobila betalningssystem.\":false,\"C) De utnyttjar ofta social engineering och phishing.\":true}", "Ett vanligt karaktärsdrag för cyberangrepp i Norden är att de ofta utnyttjar social engineering och phishing.", "Vilket karaktärsdrag är vanligt för cyberangrepp i Norden?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Avancerade kryptografiska system.\":false,\"B) Phishing, malware och n\\u00E4tverkssniffning.\":true,\"C) Lagliga programvaror f\\u00F6r databasadministration.\":false}", "De mest använda verktygen av IT-brottslingar inkluderar phishing, malware och nätverkssniffning.", "Vilka är de mest använda verktygen av IT-brottslingar?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) De \\u00E4r alla exempel p\\u00E5 statligt sponsrade hackningsf\\u00F6rs\\u00F6k.\":false,\"B) De involverar alla skadlig programvara som sprids automatiskt \\u00F6ver n\\u00E4tverk.\":true,\"C) De \\u00E4r k\\u00E4nda fall av dataintr\\u00E5ng via sociala medier.\":false}", "Mirai, Wannacry och incidenten i Düsseldorf har gemensamt att de involverar skadlig programvara som sprids automatiskt över nätverk.", "Vad har Mirai, Wannacry och incidenten i Düsseldorf gemensamt?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Otillr\\u00E4cklig lokal lagring.\":false,\"B) Brister i fysisk s\\u00E4kerhet hos molnleverant\\u00F6rer.\":false,\"C) Otillr\\u00E4ckliga \\u00E5tkomstkontroller och datakryptering.\":true}", "Den största säkerhetsutmaningen med molntjänster är otillräckliga åtkomstkontroller och datakryptering.", "Vad är den största säkerhetsutmaningen med molntjänster?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Cyberkriminalitet\":false,\"B) Cyberspionage\":true,\"C) Cyberterrorism\":false}", "Cyberspionage avser aktiviteter där aktörer, ofta statliga, engagerar sig i övervakning och datainsamling genom cybermedel för att erhålla hemlig information utan målets medgivande.", "Regeringen upptäcker att känslig politisk kommunikation har läckt och misstänker elektronisk övervakning. Vilket fenomen beskriver bäst denna situation?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Social ingenj\\u00F6rskonst\":false,\"B) Mass\\u00F6vervakning\":false,\"C) Riktade cyberattacker\":true}", "Riktade cyberattacker som utnyttjar Zero-day sårbarheter är en avancerad metod för cyberspionage, specifikt riktad för att komma åt känslig information genom att utnyttja tidigare okända sårbarheter.", "Regeringen blir varse om en sofistikerad skadeprogramskampanj som utnyttjar Zero-day sårbarheter för att infiltrera deras nätverk och stjäla oerhört viktig data. Vilken metod för cyberspionage används sannolikt här?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) GDPR\":false,\"B) S\\u00E4kerhetsskyddslagen\":true,\"C) IT-s\\u00E4kerhetslagen\":false}", "Säkerhetsskyddslagen är en svensk lagstiftning som syftar till att skydda nationellt känslig information och ställer krav på säkerhetsskyddsåtgärder för verksamheter av betydelse för Sveriges säkerhet.", "Regeringen i Sverige ökar sitt interna säkerhetsprotokoll för att skydda sig mot utländska underrättelsetjänsters infiltration. Vilken lagstiftning ger ramverket för detta skydd?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText" },
                values: new object[] { "{\"A) Oberoende hackare\":false,\"B) Aktivistgrupper\":false,\"C) Statssponsrade hackers\":true}", "Statssponsrade hackers är aktörer som arbetar på uppdrag av eller med stöd från en regering, ofta riktat mot strategiska mål som forskningsdata för att få strategiska fördelar.", "Lunds universitet upptäcker att forskningsdata om ny teknologi har stulits. Undersökningar tyder på en välorganiserad grupp med kopplingar till en utländsk stat. Vilken typ av aktör ligger sannolikt bakom detta?" });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) Att rekrytera nya medarbetare via digitala kanaler.\":false,\"B) Att \\u00F6vertyga befintliga anst\\u00E4llda eller individer att medvetet l\\u00E4cka information eller ge tillg\\u00E5ng till system.\":true,\"C) Att erbjuda gratis programvara till f\\u00F6retag som en del av en marknadsf\\u00F6ringskampanj.\":false}", "Värvningsförsök innebär att övertyga befintliga anställda eller individer att medvetet läcka information eller ge tillgång till system.", "Vad avses med värvningsförsök inom cybersäkerhetskontexten?", 36 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) Utbyte av f\\u00F6retagsinformation mellan konkurrerande f\\u00F6retag.\":false,\"B) Anv\\u00E4ndning av digital teknik f\\u00F6r att otillb\\u00F6rligt inh\\u00E4mta konkurrenters f\\u00F6retagshemligheter.\":true,\"C) Offentligg\\u00F6rande av f\\u00F6retagsresultat p\\u00E5 sociala medier.\":false}", "Affärsspionage i en digital miljö definieras som användningen av digital teknik för att otillbörligt inhämta konkurrenters företagshemligheter.", "Hur definieras affärsspionage i en digital miljö?", 37 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) Att \\u00F6ka f\\u00F6rs\\u00E4ljningen av en specifik produkt.\":false,\"B) Att sprida desinformation och p\\u00E5verka allm\\u00E4nhetens \\u00E5sikter eller val.\":true,\"C) Att f\\u00F6rb\\u00E4ttra f\\u00F6retagets varum\\u00E4rkesimage genom reklam.\":false}", "Målet med digitala påverkanskampanjer är att sprida desinformation och påverka allmänhetens åsikter eller val.", "Vad är målet med digitala påverkanskampanjer?", 38 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) Att marknadsf\\u00F6ra Sverige som en turistdestination.\":false,\"B) Att samla in och analysera information om cyberhot och st\\u00E4rka nationens cyberf\\u00F6rsvar.\":true,\"C) Att erbjuda IT-support till sm\\u00E5 och medelstora f\\u00F6retag.\":false}", "Den svenska underrättelsetjänstens roll i landets cyberförsvar är att samla in och analysera information om cyberhot och därmed stärka nationens säkerhet.", "Vilken roll spelar den svenska underrättelsetjänsten i landets cyberförsvar?", 39 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AnswersJson", "Explanation", "QuestionText", "SubCategoryId" },
                values: new object[] { "{\"A) 5G-utbyggnaden \\u00E4r bara relevant f\\u00F6r mobiloperat\\u00F6rer och p\\u00E5verkar inte signalspaning.\":false,\"B) Utbyggnaden av 5G st\\u00E4ller h\\u00F6gre krav p\\u00E5 informationss\\u00E4kerhet och kan p\\u00E5verka metoder f\\u00F6r signalspaning.\":true,\"C) 5G \\u00E4r endast viktigt f\\u00F6r f\\u00F6rb\\u00E4ttrad spelupplevelse och har inget samband med signalspaning eller informationss\\u00E4kerhet.\":false}", "Utbyggnaden av 5G ställer högre krav på informationssäkerhet och kan påverka metoder för signalspaning.", "Hur relaterar signalspaning och informationssäkerhet till utbyggnaden av 5G-nätverk?", 40 });
        }
    }
}
