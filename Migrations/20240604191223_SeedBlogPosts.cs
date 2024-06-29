using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPortfolioBlog.Migrations
{
    /// <inheritdoc />
    public partial class SeedBlogPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Web geliştirme dünyasına hoş geldiniz! Bu yazıda, web geliştirmeye yeni başlayanlar için temel kavramları ve ilk adımları ele alacağız.Web geliştirme, modern teknolojinin en heyecan verici ve hızla gelişen alanlarından biridir. İnternet üzerindeki milyonlarca web sitesi, uygulama ve içerik, web geliştiriciler tarafından oluşturulur ve sürekli olarak güncellenir. Web geliştirme, birçok farklı beceri ve teknolojiyi içerir ve her gün yeni bir şey öğrenmeye olanak sağlar.\r\n\r\nİlk adımlarınızı atmaya başlamadan önce, web geliştirmeyle ilgili temel kavramları anlamak önemlidir. HTML, CSS ve JavaScript gibi temel web teknolojileri, her web geliştiricinin bilmesi gereken başlangıç noktalarıdır. HTML, web sayfalarının yapısal içeriğini tanımlamak için kullanılırken, CSS görünüm ve stili düzenlemek için kullanılır. JavaScript ise web sayfalarına etkileşim ve dinamizm kazandırmak için kullanılır.\r\n\r\nBir web geliştirici olarak, öğrenmeye ve denemeye istekli olmanız önemlidir. İnternetteki kaynaklardan yararlanarak, çevrimiçi kurslar alarak ve projeler geliştirerek becerilerinizi geliştirebilirsiniz. Ayrıca, web geliştirme topluluğuna katılarak diğer geliştiricilerle iletişim kurabilir, deneyimlerinizi paylaşabilir ve yeni şeyler öğrenebilirsiniz.\r\n\r\nWeb geliştirmeyle ilgili ilk adımlarınızı atarken, sabırlı olun ve her adımı öğrenme sürecinin bir parçası olarak görün. Unutmayın ki, her başarısızlık bir öğrenme fırsatıdır ve en önemlisi, kendinize güvenmeyi asla kaybetmemektir. İyi şanslar ve başarılar dilerim!");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Veri bilimi, günümüzün en heyecan verici ve hızla büyüyen alanlarından biridir. Python, veri bilimi projelerinde en çok kullanılan dillerden biridir. Python'un esnek ve güçlü yapısı, veri manipülasyonu, analizi ve makine öğrenmesi gibi çeşitli veri bilimi görevlerini kolayca gerçekleştirmeye olanak sağlar.\r\n\r\nPython'un veri bilimi alanında popülerliği, zengin bir kütüphane ekosistemiyle desteklenmektedir. Pandas, NumPy ve SciPy gibi kütüphaneler veri analizi ve işleme için temel araçlar sunarken, Scikit-learn ve TensorFlow gibi kütüphaneler makine öğrenmesi ve yapay zeka projeleri için güçlü araçlar sağlar.\r\n\r\nVeri bilimi, büyük miktarda veriye erişme, analiz etme ve bu veriden anlamlı bilgiler çıkarma sürecini içerir. Bu nedenle, veri bilimi becerileri, günümüzün rekabetçi iş piyasasında büyük bir talep görmektedir. Bir veri bilimcisi olarak, veri odaklı karar verme süreçlerine katkıda bulunabilir, işletmelerin performansını artırabilir ve değerli içgörüler sağlayabilirsiniz.\r\n\r\nVeri bilimi alanında kariyer yapmak isteyenler için, sürekli olarak öğrenme ve kendini geliştirme önemlidir. Yeni teknolojileri ve trendleri takip ederek, projeler geliştirerek ve topluluklarla etkileşime geçerek becerilerinizi ve bilginizi artırabilirsiniz. Ayrıca, pratik deneyim kazanmak için gerçek dünya veri setleriyle çalışmak da önemlidir.\r\n\r\nVeri bilimi, sadece bugünün değil, geleceğin de en önemli alanlarından biridir. Bu heyecan verici alanda kariyer yapmak istiyorsanız, şimdi harekete geçmek için harika bir zaman!");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Mobil uygulama geliştirme, teknoloji dünyasında önemli bir yer tutmaktadır. Bu yazıda, Android ve iOS platformları için nasıl mobil uygulama geliştirebileceğinizi keşfedeceğiz. Mobil uygulamalar, kullanıcıların akıllı telefonları ve tabletleri üzerinden çeşitli işlevleri gerçekleştirmelerini sağlar. Günümüzde birçok işletme ve bireysel geliştirici, mobil uygulama pazarından faydalanarak ürünlerini ve hizmetlerini kullanıcılara sunmaktadır.\r\n\r\nAndroid ve iOS, mobil uygulama geliştirme için en popüler platformlardan ikisidir. Android, Google tarafından desteklenen açık kaynaklı bir mobil işletim sistemidir ve dünya genelinde geniş bir kullanıcı kitlesi bulunmaktadır. iOS ise Apple tarafından geliştirilen ve iPhone ve iPad gibi cihazlarda çalışan bir mobil işletim sistemidir.\r\n\r\nMobil uygulama geliştirme süreci genellikle şu adımları içerir:\r\n\r\nİhtiyaç Analizi ve Tasarım: İlk adım, uygulamanın gereksinimlerini belirlemek ve kullanıcı deneyimini tasarlamaktır.\r\n\r\nGeliştirme Ortamının Kurulması: Mobil uygulama geliştirme için gerekli olan geliştirme ortamını (IDE) kurmak önemlidir. Android için Android Studio ve iOS için Xcode gibi IDE'ler kullanılabilir.\r\n\r\nProgramlama: Uygulamanın backend (sunucu tarafı) ve frontend (istemci tarafı) kodlaması yapılır. Android için Java veya Kotlin, iOS için Swift veya Objective-C gibi diller kullanılabilir.\r\n\r\nTest Etme ve Hata Ayıklama: Geliştirme aşamasında uygulama düzenli olarak test edilmeli ve hatalar giderilmelidir.\r\n\r\nDağıtım ve Yayınlama: Uygulama, ilgili uygulama mağazalarına (Google Play Store ve App Store) yüklenerek kullanıcılara sunulur.\r\n\r\nMobil uygulama geliştirme sürecinde, kullanıcı deneyimine ve performansa odaklanmak önemlidir. Ayrıca, güvenlik ve veri gizliliği konularına da dikkat edilmelidir. İyi bir mobil uygulama, kullanıcıların ihtiyaçlarını karşılayacak şekilde tasarlanmalı ve sürekli olarak güncellenmelidir.\r\n\r\nMobil uygulama geliştirme, geleceğin teknoloji trendlerinden biri olarak öne çıkmaktadır. Bu alanda kariyer yapmak isteyenler için, sürekli olarak yeni teknolojilere ve gelişmelere ayak uydurmak önemlidir. Ayrıca, kullanıcı ihtiyaçlarını anlamak ve kullanıcı dostu uygulamalar oluşturmak da başarılı bir mobil uygulama geliştirme sürecinin önemli bileşenleridir.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Content",
                value: "Web geliştirme dünyasına hoş geldiniz! Bu yazıda, web geliştirmeye yeni başlayanlar için temel kavramları ve ilk adımları ele alacağız...");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 2,
                column: "Content",
                value: "Veri bilimi, günümüzün en heyecan verici ve hızla büyüyen alanlarından biridir. Python, veri bilimi projelerinde en çok kullanılan dillerden biridir...");

            migrationBuilder.UpdateData(
                table: "BlogPosts",
                keyColumn: "Id",
                keyValue: 3,
                column: "Content",
                value: "Mobil uygulama geliştirme, teknoloji dünyasında önemli bir yer tutmaktadır. Bu yazıda, Android ve iOS platformları için nasıl mobil uygulama geliştirebileceğinizi keşfedeceğiz...");
        }
    }
}
