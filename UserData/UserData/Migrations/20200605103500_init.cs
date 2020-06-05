﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace UserData.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UsersData",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Street = table.Column<string>(nullable: false),
                    StreetNumber = table.Column<int>(nullable: false),
                    TelephoneNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersData", x => x.UserId);
                });

            migrationBuilder.InsertData(
                table: "UsersData",
                columns: new[] { "UserId", "Age", "FirstName", "LastName", "Street", "StreetNumber", "TelephoneNumber" },
                values: new object[,]
                {
                    { 1, 129382961, "AK6IMI8UTM9IHPGBG63PI51O2CDA2OA", "XPIVD1ZAFLD", "D5WTZLFI0JAZY7", 12, "709852888" },
                    { 73, 420484251, "YWHT6VTBLRLN", "HNFTYAB8NO8JT3W03", "4CAT7WCSACYJLZOYK", 18, "782952214" },
                    { 72, 2054394642, "F05CYCY4SC", "D4M0U43UUN0BU59QRK", "QOJV7S46", 22, "480584146" },
                    { 71, 662234103, "1FHLWYUFR5O9E7O0BCECQM6WOE4XBL", "T6Q506T9Z8W", "AOW5E5WOS1SBQSPHROWGDD", 8, "105220651" },
                    { 70, 9965844, "3FIN7HRS81", "JS4WZFWCKIH1ZVPGA9TUK46YSV", "Y4V2ETOT470QFIZUI8O", 13, "890950149" },
                    { 69, 1427244910, "V5428OPOS0BP0KVYKWVO8J", "STJKWFJ0T16Z2T0HCUASTMKT0OH4X0V", "TGQ9OBJN0KB96FJLA", 23, "383270722" },
                    { 68, 1798650034, "ZGA47BK7UVI98CMP95E0B", "0AQ616HJUID32BONKJ6J", "MCIHSF2F", 21, "360308752" },
                    { 67, 1003544836, "G4OMMMJHNUU3HCO7", "XX5RJ3EO10BIO", "PR9ILH5BKUOFVTRJDJ0W2AZIHC3N35", 19, "242221119" },
                    { 66, 646005423, "TVTKTMU9ZA72M3EXUR", "LLVW2KCOFR01WUR14DGLM14LSTUPWE", "WQ4YM3ATQM2PIPCBRC", 26, "455719979" },
                    { 65, 423573934, "LZSNR2CT3ZDND0UF027NG86R4APK", "UKBMWXEWFJ", "2U0ZPUR83ES0Q7NGW5HGNSQFPOI", 23, "883978069" },
                    { 64, 1002628625, "6YKEXHD6PB96OC2R0BOF0C60O72SPQ", "5OYW5DTPS8UZN", "PJF7QCC5U1G", 14, "253251530" },
                    { 63, 1556276690, "MUH056J5W8CP8JY5MFEAJZSQ", "O14VRAWM6NEEGHHL9U5JVRM2", "NLDO2J6U0YL6CDV4H3MBQVQS71XU", 22, "565536070" },
                    { 62, 1565289725, "17F5RC39F3V2ECM9ULN2NG", "ITYM8V4ZG95F2J69QZKU8B0MLSA", "1RTTJ02WSRN4A8TWA", 16, "222261938" },
                    { 61, 1349119587, "ZEMG5X4ALDN7OKLTMJ", "TA7X3XV7CO2W9COM26MX6V5C", "GNWM3B7ISTUQ6OJE1ACUMN1WK", 11, "786728049" },
                    { 60, 1178726306, "NPGLA4Q7TIVCQ5PQ4Q7QXFD7TEAH7X", "ZECIP3EJU4KLBAKVRXR1SQ9KIMI15", "HNK4I4DV9W59PKOLI5KWMCMC7V8OQ", 27, "209389460" },
                    { 59, 883794711, "I746Y1551IXIET342AY0WSWCBXNL9", "4NN5YZI3O30GIH122DZXQ", "6XTRJS8G", 19, "242737803" },
                    { 58, 852743589, "UV915RR7SCJMYSCQ", "TA5R2MLT1", "KMMOTBO21EAO1VISU1AL8H10", 30, "607056094" },
                    { 57, 1981487916, "8KF0883HX3DG3T6WIEST3HG", "LGNVZDBD54L", "YG4Y00X4RKPBWT5OJ8R1VR3J9XYU8", 11, "885950366" },
                    { 56, 1416057024, "Q4PNIDW0HPNEJFACFMBT", "2XUYSN860E8DWWFY6NT1AK", "FC9EJWXN1SJZ3D4PBJSZQ", 28, "368649016" },
                    { 55, 918933772, "0SSDPIZROO601Z54", "AYHCBYOIAHP8Z7N", "L3AJAAEK3GYEC8B314FQ8OQZ", 14, "925623996" },
                    { 54, 1937526334, "GDPCQ8BFY1U2UAPUIKWT3F8FIKJ6", "0Z1B059V4", "4IJMHWUWV5IUEW2", 28, "821640705" },
                    { 53, 418318731, "YC0L3UH0YN5Z0DU7YJH5M33", "9V8WEDSWFVR2CRG1365", "UROR0MI1", 26, "328385000" },
                    { 74, 2099495548, "SVCCD41W3M0UW", "CXAWN8A3WBV1TVFVGCH7ICGG", "KUGXZQ5FG0YIJLHIJM27KSBVRDJ28", 13, "346542783" },
                    { 52, 399992862, "OL9AHMSI0", "9JP0RIS59N9Y9FPAV3446J", "3BPWT7H6HE8LI9CO7WU03HHU1XXB", 11, "888930651" },
                    { 75, 1113351460, "45HDKSTYHZTDFZ5CKFLKTMH5SNJ", "OS5O2HWRDCGYW9", "CXOAIY8BRMKFRHFXNZR9R3OARNJG", 12, "098315912" },
                    { 77, 876240522, "AFBXFVQMPFZI1MNUNK16DADG", "9T3JSD44YPJ6I98NB", "AVGZZHM4", 26, "577228139" },
                    { 98, 1058617481, "EELGAV6J42OMJ7B1EOB5K4GYA", "G1LPZ9DX5DPKC19J2QPUUXI8SWM1QJ7", "21BBB1N0N9H1RDM5TXI363UJ0WBNW", 23, "104194042" },
                    { 97, 2045726725, "ULKLEE7W1VV6Z", "4T2U8QRTJIT1NTWT3D3M7L6U1CX", "8HZ159CURWG55GUTAEHODUYCIC5J", 29, "256537854" },
                    { 96, 441298972, "NSYO9M4WM7F5IZ5TV1NN5F36SAK", "EZ0J9CFLSQU8KL", "8VI5T4H5ULE74X3MN16D9HLI", 19, "764100534" },
                    { 95, 386726726, "VF80E06TUQSAV3QT90WO9OJOO93", "50EEJZ0QM", "MWKOVU6AKL7C1AFRV8S7", 24, "480478401" },
                    { 94, 1712438740, "VWQF96G5CJ5GIMAK", "H2L1KH4VD65TFHEFC4OMGK9Z", "K55QN1WAPZLNLOLX", 22, "347823306" },
                    { 93, 860499541, "V81SSN2T5M9Y2B", "BSYHHY8RWS", "J7W8ADRNQN6A4V", 22, "294548440" },
                    { 92, 48509856, "V8DU4ES7AIOL82X39CKSHDLC", "GOOEW9FNM3WZRZ4FKDQRVVQWWDVN", "20WZVYX40BOV3CT8YIDZ66UIKQCXYM", 28, "446076717" },
                    { 91, 72786650, "X272JGHU5PEZ6", "3VF8UOTCDK7TE29CMU0HSZ5JB", "HO3SQ09CGAWD0LB", 8, "126062142" },
                    { 90, 778156011, "510GZPAU92QODMAKBE", "VJM8Z5RBGBSBRM7LOGK23MVUB7VK", "T3OAOGWQEAWB", 27, "611974158" },
                    { 89, 1992666117, "6XEKY5NJ700TC6GIGX926Y3XWW0", "51T3CVX3CW4V2RSHGRVD8P61D56H3RX", "YAEXCPCY", 9, "133119442" },
                    { 88, 862664010, "66SDXUIWUKFR1CGVTXQBOZ8AWR31", "WJQQWPDGQ8XF1UXL1ET3960O", "8QJ5WAUPO4V", 21, "419541749" },
                    { 87, 694174073, "A96W8QUI", "GKCJYP337Q5MQ1JCX", "DFB3ZTWINL1773DAG5SXSBX0399", 15, "043075623" },
                    { 86, 1417095126, "FBY6I77MQCHD0LN8HHQRQG5EUP32LX", "YQR8CHKJXNPAAV662", "7VC7K5Y94OPDD6GSUL2QD3AXDRUBVG7", 10, "583644915" },
                    { 85, 1166331422, "RLJKD2E4PJKDJCFV6DSX", "PTAWF5T2S8PPKH0G29WRK4HIFCB", "R9HT3T2Q3ZCPDDPWFKQTJLEX0KUNB", 20, "144837072" },
                    { 84, 1031105553, "CKDLD2L6OIJYH8TTJW3P551K1LLR", "L2GU2MOJ2DUD", "TXQTAQV85RXPYMEHMOXVII6FISJJFZ6", 26, "209292979" },
                    { 83, 1728828246, "O6MH6QU4UTCP70QF1WH81IB999D1Y", "AUPOC9V1FW950OUKX9UMLM9GF", "G391UKQ689CDU0L7WZUZARC9GE", 12, "832938185" },
                    { 82, 865655509, "FDH6UDAWHYQIJOBONYE2WXJIYO066TN", "1ZQQZ25MV2XSXO8487QJMANS39IGME", "ZWT7ZQQWP5HDWHJAM38R2", 25, "635459675" },
                    { 81, 1763304634, "PQ11KER7WTUKPI", "PGKVY6DBHBYUTIGD85UA428AVMCEUOB", "KUZLZ3A1E9M8YK11KT7", 20, "433509233" },
                    { 80, 1242514962, "NU1X65PFKW8F7", "L7T8CDJYJA5VLR64G", "MI807T5JDE7KDBQ", 12, "362899447" },
                    { 79, 2135541125, "K8F214CE5WPNQ2Q21LO2KC9", "5H93B0ZEKOLIPGT05P", "V8USRUWZWLQFD8E", 23, "812288647" },
                    { 78, 1236642209, "GK6DOHB94608", "S4OFLYRHV1PS1ROXO0X905UQ9S7W", "UAB5JFBXD6B4ND7EXEL3SCITQV1LAD", 11, "487040615" },
                    { 76, 2043646683, "LXQ67D31SJPLZRG2VO", "E98ILHZM", "JSXMU7JKJY3FL7DO8I9WYUGH7WBF0", 19, "398158316" },
                    { 51, 508100787, "FF32W0VRP97ZG", "FTXMF6QL8", "SYLHBXSKEWBJ2R", 22, "280943567" },
                    { 50, 31765721, "NUENJA74I", "N2LQX9EYT44L6VCEO5UQPFWFX5NOD", "R1MCMZWE12KL4IOHIF", 9, "484230982" },
                    { 49, 1767575206, "XTE7IF4MC8AC49MZZSN53", "0KJ4NWLWRIZ1XXCU1UURDR5BVHT8BM", "Q6DQH6Y05IK", 28, "477886372" },
                    { 22, 1813576258, "LZQV09512NHX91D7PHPL22GJ01", "K9KU9KMRERP5GPD8INHC3AQE4Z28ST", "DPD238BWGL40WV4CUEOTCEE", 12, "890574823" },
                    { 21, 856845508, "7P1S8VPX4S4GSXLJIFXV9NX", "7FEAJ9501O4RLHTRKFWALCDT65Q3V", "599C17C0SD02QTGIWGIEY9JI", 23, "657868443" },
                    { 20, 1621323561, "STU5OJ9P597ANHVRPXY9U", "1W3Y06YCSO4FUPIL8Y", "HZ2P6484ZD83HM801X4EDT8604LU9", 25, "378101722" },
                    { 19, 653710571, "TJ2448IQNHFTVZDEA86RVPYB7WJQAQ", "GZ5WEL2V8141464D", "BBOYAXOW9TI", 14, "526067315" },
                    { 18, 1988482005, "WENGVU76D6GWKON04D95GGHN5QS5", "O5SHXP3S6UZDMLJEPDL", "I9GBF7HRB86DFKAIOFKBOZDYXJO9", 25, "981416490" },
                    { 17, 1245882411, "8HVC7LTGO5GGQLUSY5", "HRBDQ27CEBD32Q", "006TZ2VE5M40ETC2BOPSWYWC1J", 16, "692284536" },
                    { 16, 1371230683, "MY4V0SKQJRAAD2OZKKKXI8WEWOQGU1K", "PMCY21VRBDDJK5K6E105I7ZN", "LAMUN0K6NZSQBGTU", 9, "793019413" },
                    { 15, 1629002253, "DEN6R4YMCPYT627J2Y24T", "ZBJETY9RC7IAOH0MXWK93MNPS2", "8PVD93RIB", 12, "707420343" },
                    { 14, 1048731425, "5P0UREA8QLN853RKJNB3", "35XQDITE19LTGJ", "GA9Q9DLG5YF9I6VNFQPWJ07165MM5L", 21, "431214938" },
                    { 13, 458713478, "WRG6L66XCSXO9J4UR0ONRL", "LHF6Y1RER8TWU3", "LOXPR94MLEJBAQJNO3B7WDI010R04M", 21, "945194972" },
                    { 12, 1988022413, "8GE1WYX9ZTJPRUF06D2PU9QBI0EZ87", "8DKW3MJXKP0WF69YEIZTMFCM9Z", "DOOH6VHVARAK8DZMZGPGYOPQQ7R", 10, "585907733" },
                    { 11, 861634904, "VSE3XXC2CUVP5M3Q5P5CPQLQ64", "XO4YAHKMLPUR1ND0FAZGF", "B84UNEPP63ZWEBRBOJGNM", 13, "947523116" },
                    { 10, 1740291949, "IZEHR9EWD92ZPS1Y5D4UH4UZ1V", "P997KYAIUKSM", "BCOCDD2QKPZ3IGZE54OHWWCPF2P", 14, "000906718" },
                    { 9, 190376311, "CEBNOX7ZHO", "YGAC6GXHFYMK2GZSB52H9B", "XRHYBEEKWNJNIPZJPE9KPYP", 10, "590789451" },
                    { 8, 1718955588, "2XJJMWDVK", "JFOZEBL84", "1VDO6YAFPKRZOOWJQ4XJZ5XFIAVNS8", 20, "975289918" },
                    { 7, 1865904570, "WMEQLLBQL8V76GQG", "70SR9CPV", "8AEFC7FAFBI7PQM991NGXFUPU98", 24, "184750983" },
                    { 6, 1409009311, "EUR2PDQII403ZPE7FWNMPHE", "QPEY5CGV", "EXZ33VG5LWTN", 13, "281989029" },
                    { 5, 1778693994, "UJQAAIDXCNJPMHD", "3L8WX5PWP3N1BT9WL20KJZ50N", "ARGR81BDKU0Z58QRG9HOBXZE89F0", 27, "169964641" },
                    { 4, 863068366, "44S7JAT1GBL", "MI5SEMURGC2PWZJ45IU4UMBQQR", "TR6L9P7QC8DDP32CZNF419", 23, "452901048" },
                    { 3, 1241971615, "3Y2G9XTLEWH64ZD1", "KB1NN1MDATP6L3FGRUJAU", "TPECSNE17C", 11, "198443523" },
                    { 2, 1120289172, "KRVUHKFYDCV", "P5HU856SFW8JPVC", "FTRQJE71EL3U2GV8PH2J61UYZ", 13, "839871841" },
                    { 23, 1362841023, "GZJSO8VKU5D3MROE5PTC", "ESQ6IYVL", "8Q9MJ6Z476SYDJ", 15, "393221982" },
                    { 24, 650746995, "VFKA9IUESDGLFBHIY5YBL35LCTY", "PEZI6FICA", "FPQFCNMS1XITHSCH", 16, "119052126" },
                    { 25, 1337535289, "7PURZOO7PA2EILYRFKJWE48BBEVC50X", "2AP1WPLF5I2V36CH85", "KSXNFS2K", 8, "256804545" },
                    { 26, 1734099075, "IFCNDAZP7EFNJE9Z", "TGDIRT3MBALIO789", "CYMMMI575Z9D16C", 11, "225420994" },
                    { 48, 809381832, "T1RR2FU1OFVRQW7NNUG0ZLKS0NMPL", "CFKT7GSEJWCGGNKUT9MM", "YLQR89VC2X8VT6B9VJ05USB", 19, "032124974" },
                    { 47, 209680845, "66KQLFVXKX4GI5G0C8T65I662NMG", "6ZFE4ISOVQV6JGDJ323K27D5N9X9", "AYQT9BOJ", 17, "698473960" },
                    { 46, 609016402, "18WGSU7ZC8D2ZYXVUJJZGJBGOOU7AV", "E0KO2ZY92OAXO61UOZ", "UNPHHF0L4SNL00M9TJCM098LR", 11, "460774947" },
                    { 45, 404859870, "YSSG51XN07S40L2D", "HHPWMS963O7O", "CMBYQ4SBN8EN0B5CE8YUTF", 26, "609931966" },
                    { 44, 841211295, "OBKHDZ8DJDYMS377QWS", "K388FPIEUIZ0HED6CNRUAZJ3", "MVR7MUVK93T6K3OT6W7Y5F", 22, "497964034" },
                    { 43, 540934714, "450S19D8OVSS4", "685Y4T07TF7R9KPRKZDL5KBH2Y", "0F1ZUYGKK3QLW2DEKKGF", 10, "382987021" },
                    { 42, 784720149, "5DAKF45S", "5JCIN151RSGGO1ORC0VIS0BH", "MFCTOXDVE32OFRQPY3Q", 16, "621735758" },
                    { 41, 1212123176, "NXGFXKIQ7TA9WRK0", "KJ49HVW09HXLE1V4EA4B73J96", "ME4Q50FIFV9WM", 12, "248169486" },
                    { 40, 1213016534, "I0EZB3BCDN1QPYZDI", "NXF6WKIGD538214DMMPCVZN6Q", "RZVFDVQ24I", 24, "721435204" },
                    { 39, 1658925391, "5JSG0KRZQ6X3C9RT9N", "6J2XBN6CEQZ182I8PPVW", "HKY4Y72NM8KTQQRVOPDC5IR", 9, "450576549" },
                    { 99, 1308191296, "POTSN6DXLHVG2E", "N4MNOAM8", "7L3MJ5ABZ", 22, "267308422" },
                    { 38, 1727804660, "Q3ZFEVJMXXCC64VDAU1ALVLIVT3", "EM9HN9BI1BKIT5E04FQ105", "1O6IMVM95FDE", 28, "531484455" },
                    { 36, 1393831670, "WHN2KPG20BA3FFO19ID22HHVEBU2", "JH33JZ23VJORSG1S3", "B3DM9GOT3XK63SWVPA0NOI9", 18, "269411104" },
                    { 35, 628559705, "Z8PIWHKSVJ47P", "1GFP70ISU6P96NYCWJRO8N16", "WXMHFDKNSZBR7H2P2HJBC", 18, "010176971" },
                    { 34, 1968107261, "JDTGR2JH87U3V46C94", "FSBLENKTHE0", "07GQSUGW", 13, "533167428" },
                    { 33, 1310096969, "6HK6HU3KI3DI55EG9LZ69UTTIX", "I0L3MKYOWW3YKX5BNBQOVJ2191", "CE4YRL37Z64QGKHEZJQN90LRN", 19, "736765755" },
                    { 32, 465217671, "PD26UBY5HVGCWWXMDP", "C081884E3PAK876MH8DZ", "ZPZ0O32W4M2K19JIJJNP80UU683RX6", 13, "531876992" },
                    { 31, 14176930, "9YTO30XS95D6HP", "P2LZVA0PJBN27", "9UWZ91AT0BXN7YVR0ABD1UWRV", 30, "491077303" },
                    { 30, 202478344, "MHIM0D95UHNZ", "GIVYI9PZWHGJ8S", "QDTRJHF037JIBGXB", 16, "399407738" },
                    { 29, 1445122705, "0TCA1DKNIYX9WF95TUSBID7C", "ZANIWULSTVRVMP2HL4YAZC9G5OM92", "H5SYCMYZYEF187R3", 18, "660100916" },
                    { 28, 50489909, "KQHY02I5R8MELC6TFBRWGK5Z", "NV633VFJ3N3GRM3RAT62NT7GK0VN", "XKNFCVZ5B5ES59C36W51", 11, "595583130" },
                    { 27, 488020456, "1VIBC9NHTH", "NF40H7LDDLCL", "SX0ZJ1H09", 26, "832596720" },
                    { 37, 2145351278, "AYWGK2B7ATDEZ7L3T49ABHQ52NUY", "XUH9V3SMZF36P8EI", "XJ4OOQ4G96PW8N8YLJBPDLVKGP", 11, "357504138" },
                    { 100, 858220949, "2UP1N8ONNSH1", "OIPTESDA9G41T5FWG7N3LHHQXC3F", "X5WUS916OQ1TYL6BYYLIDQ7I0", 15, "938889969" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersData");
        }
    }
}
