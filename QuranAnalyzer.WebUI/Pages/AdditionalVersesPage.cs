﻿using QuranAnalyzer.WebUI.Components;

namespace QuranAnalyzer.WebUI.Pages;

public class AdditionalVersesPage : ReactComponent
{
    protected override Element render()
    {
        var seperation = new FlexRowCentered(MarginTopBottom(10))
        {
            "* * *"
        };
        return new Article
        {
            new LargeTitle("Tevbe Suresi 128. ve 129. Meselesi"),

            new p
            {
                "19 sisteminin olması için Kurandan iki ayet atılması gerekiyormuş. Yoksa sistem çöküyormuş. ",
                new br(),
                "Konuyu pek araştırmayan insanlar üzerinde etki bırakan bir söz. " ,
                "Çünki insanlar bu sözü duyunca otomatikmen şöyle düşünürler, ",
                (b)" isterse dünyanın en süper bilgisi olsun bana ayeti dolayısıyla Kuranı reddettirecek bir şey ise benim için mesele başlamadan bitmiş demektir. Peşinen red ederim.",
                new br(),
                "Peki nedir bu meselenin aslı?"
            },
            new p
            {
                "Önce meselenin tarihi yönünü ele alalım. ",
                "Rivayetlerde şöyle nakledilir, Ebubekir zamanında Kuran mushaf haline getirilmesi için 5 kişilik bir ekip kurulur.",
                "İnsanlar elinde ne kadar deriye-kağıda yazılmış kuran var ise ortaya koyarlar. Her bir ayet için en az 3 kişinin şahitliği şart koşulur.",
                "Süveybe adında bir sahabe de, tevbe suresinin 128. ve 129. ayetlerini söyler. " ,
                "Fakat onun dışında hiç kimse bu iki sözün ayet olduğuna şahit olmaz. " ,
                "Süveybe ise taa mekke döneminde bir kişinin peygamberin deve satın alması konusunda problem yaşadığını görür ve peygamber ile ticaret yapan kişinin ilk anlaşması esnasında olmadığı halde  peygamberin doğru söylediğine şahitlik eder." ,
                "Hatta olaydan sonra peygamberimize gelerek şunu söyler ben senin Allahın resulu olduğuna şahitlik ediyorum buradaki şu ufak ticaretine nedne şahit olmayayım der." +
                "Bunun üzerine de peygamberimiz 'Süveybenin şahitliği iki kişinin şahitliği gibidir' der",
                "Hasılı bu sözü de delil getirerek Süveybenin şahitliği iki kişi gibi sayılır ve bu iki söz Kurana eklenir.",
                "Üstelik Tevbe suresindeki tüm ayetler Medine dönemine aitken sadece bu sonraki iki ayet mekke dönemine aittir.",
                
                new br(),
                new br(),
                "Tarihi rivayet olarak durum böyle. Elbetteki bu sözü şöyle yorumlayanlar da var. " ,
                "Aslında oradaki herkes bu iki sözün Kurandan olduğunu biliyordu fakat yazılı olarak ellerinde yoktu.",
                "Burada rivayet tenkidi-yorumlaması yapmayacağım ben sadece böyle bir rivayeti aktardım.",
                
                "Hatta başka bir rivayette Ali'nin evinden belli bir süre çıkmadığı bunun sebebini soranlara da Kurana söz eklendi diye durumu boykot ettiğine dair rivayetler var.",
                "İşine gelince rivayetlere sarılıyorsun gibi haklı bir eleştiri yapabilirsiniz ama benim burada aktarmak istediğim şey şu. Burada bir duman tütüyor.",
                "İlk toplanan muashafın yakılması vesaire ister istemez konu üzerinde soru işaretleri bırakmış olabilir.",
                "Herkim ki tevbe suresi 128.129 uncu ayetleri şu vakitlerde okur ise ona şöyle sevap yazılır şeklinde rivayetlerin olması da bir garip.",
                "Özellikle 128-129 un seçilmiş olması biraz garip.",
                new br(),
                "Hiç bir yerde Rahman Rahim gibi sıfatlar Allah dışında kullanılmaz iken sadece burada Muhammed peygamber için kullanılmış",
                new br(),
                "Hasılı iki kapak arasına girdikten sonra mesele kapanıyor."
            },
            seperation,
            
            "Peki konunun 19 sistemi ile ne ilgisi var?",
            new p
            {
                "19 sistemini ilk keşfeden kişi Reşad yaptığı ilk sayımlarda tevbe suresine 128-129 dahil ederek sayımları yapıyor.",
                "Ama bilgisayar Allah kelimesi sayımlarını bir fazla vermesi gerekirken bir eksik veriyor.",
                "Hatta ilk kitabın ilk baskısında bu haliyle çıkıyor. ",
                "Daha sonrasında Reşad bizzat Cebrail aracılığı ile bu bilgi kendisine veriliyor. Özetle Tevbe suresindeki 128. 129. sözler Kurana ait değildir bilgisini alıyor.",
                "Aynı zamanda sayımları tekrar gözden geçiriyor ve normalde bir fazla vermesi gereken Allah kelimesi bilgisayar tarafından bir eksik verildiğini görüyor. Kendisi de şaşırıyor.",
                "Bunun üzerine Bu iki sözün Kurandan olmadığına dair matemaiksel olarak da gösteriyor.",
                "Ben sadece bu örneklerden bir tanesini aşağıdaki link üzerinde gösterdim. Dileyen var ise inceleyebilir. aşağıdaki örnek gibi 50 den fazla örnek var.",
                new br(),
                new FlexRowCentered
                {
                    new a{href = "#", text = "Bir örnek"}
                },
                new br(),
                "Özetlemek gerekir ise ",(b)" Bu bilgi Cebrail aracılığı ile geliyor. Ardından matematikle destekleniyor.",
                new br(),
                "Dünyada hiç bir kimse kendi kutsal saydığı kitapdan matematiğe uymuyor diye ayet atmaz. Reşad o kadar da aptal biri değil. " ,
                "Burasını maalesef karıştırıyorlar."
            },
            seperation,
            new p
            {
                "Reşad Halife'nin elçilik meselesini zihninizde bir yere oturtmadıysanız bu meseleyi de bir yere oturtmanız oldukça zor.",
                "Ben burada meseleyi özetlemeye çalıştım. Karar vermek size kalan bir mesele."
            },
            seperation,
            
            new p
            {
                "Kuranda bu kitabın Allah tarfından korunduğuna dair net ifadeler var. Bu durumda haklı olarak şu soruyu sormalıyız.",
                "Hani Allah Kuranı korumuştu? Eğer Tevbe 128-129 Kurandan değil ise nasıl oldu da Kuran mushafları arasına girebildi? " +
                "Demekki mantık olarak çöküyor.",
                
                new br(),
                new br(),
                "İşte bu fikre karşı arguman olarak da şu söyleniyor. Aslında halihazırda ayet gerçekleşmiş durumda.",
                "Allah koruyacağını söyledi ve 19 kodu ile bunu koruduğunu bizzat gösterdi.",
                "Eğer bir odada 10 kişi olalım ve elimizde şöyle bir bilgi olsun 'Bu odaya giren olur ise dayak yer'.",
                "Eğer hiç kimse girmez ise kimse dayak yemez ve 'odaya giren dayak yer' bilgisi sadece kuru - emin olmadığımız bir bilgi olarak kalır.",
                "Ne zamanki biri odaya girer ve dayağı yer ancak bu durumda bu bilgi netlik kazanır. ",
                new br(),
                "Durum biraz buna benziyor. Allah bu kitabı koruyacağını söylüyor? Bu bilginin kaynağı ne ? Kim söylüyor? Cevap: Bu kitap",
                new br(),
                "Bu da mantık hatasına yol açıyor.",
                "Üstelik madem koruma olayını biz elimizdeki mushaf olarak görüyor isek, dünyada farklı farklı bir çok mushaf var. Her bir mushafda yazım farklılıkları var.",
                "Bu durumda Allah  Kuranı harf bazında koruyamadı gibi bir sonuca da gitmeliyiz."
            },
            seperation,
            new p
            {
                "Ben gene de Kurandan iki ayeti red etmeyeyim diye düşünebilirsiniz. " ,
                "Ama meseleyi tersden ele alır iseniz Kuranda olmayan iki cümleye Allah sözü muamelesi yapmış da olursunuz."
            },
            seperation,
            new p
            {
                "Mesele etrafında dönen tartışmayı aktarmaya çalıştım. Umarım faydalı olmuştur.",
                new br(),
                "Ufak da olsa kendi anlayışımı ifade istiyorum. " ,
                "Açıkcası hayatında Kuran olmayan birinin Tevbe 128-129 Kuran'dandır veya değildir demesinin bence bir anlamı yok. " ,
                "Yılan adamı yarı beline kadar yutmuş fakat adam az önce ensesinden ısıran sivri sineğin derdine düşmüş. O sivrisineğin kendisine hastalık bulaştırıp bulaştırmayacağının derdine düşmüş",
                new br(),
                "Örnek biraz saçma gelebilir ama malesef durum böyle.  "
            }
        };
    }
}