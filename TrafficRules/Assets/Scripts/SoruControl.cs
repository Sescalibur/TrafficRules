using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoruControl : MonoBehaviour
{
    public Sorular[] soru;
    public Sorular[] soruIlk;
    public Sorular[] adab;
    public Sorular[] motor;
    public static SoruControl instance;
    public static List<Sorular> SoruList;
    public static List<Sorular> IlkList;
    public static List<Sorular> adabList;
    public static List<Sorular> motorList;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        SoruList = new List<Sorular>();
        IlkList = new List<Sorular>();
        adabList = new List<Sorular>();
        motorList = new List<Sorular>();

        soru[0].Soru = "Aþaðýdakilerden hangisi, yolcu taþýmacýlýðýnda kullanýlan ve sürücüsü dahil dokuzdan fazla oturma yeri olan motorlu taþýttýr?";
        soru[0].Cevap = "Çekici";
        soru[0].Cevap2 = "Otobüs";
        soru[0].Cevap3 = "Otomobil";
        soru[0].Cevap4 = "Kamyonet";
        soru[0].dogruIndex = 2;
        SoruList.Add(soru[0]);
        soru[1].Soru = "Otomobilinin muayene zamanýný öðrenmek isteyen sürücü, aþaðýdaki belgelerden hangisini kontrol etmelidir?";
        soru[1].Cevap = "Araç imalat belgesi";
        soru[1].Cevap2 = "Motorlu araç trafik belgesi";
        soru[1].Cevap3 = "Araç tescil belgesi";
        soru[1].Cevap4 = "Sürücü belgesi";
        soru[1].dogruIndex = 2;
        SoruList.Add(soru[1]);
        soru[2].Soru = "Zorunlu hâller dýþýnda otoyollarda motorlu araçlarýn asgari hýz sýnýrý saatte kaç kilometredir?";
        soru[2].Cevap = "15";
        soru[2].Cevap2 = "35";
        soru[2].Cevap3 = "40";
        soru[2].Cevap4 = "50";
        soru[2].dogruIndex = 3;
        SoruList.Add(soru[2]);
        soru[3].Soru = "I- Ýdari para cezasý verilir." +
                       "II - Sürücü belgesi 6 ay süre ile geri alýnýr." +
                       "III - Kara yolunda araç sürmesine izin verilir." +
                       "Yapýlan ölçüm sonucunda, yasal sýnýrlarýn üzerinde alkollü olarak araç kullandýðý birinci defa tespit edilen sürücüye yukarýdaki iþlemlerden hangileri uygulanýr?";
        soru[3].Cevap = "Yalnýz I";
        soru[3].Cevap2 = "I ve II";
        soru[3].Cevap3 = "II ve III";
        soru[3].Cevap4 = "I, II ve III";
        soru[3].dogruIndex = 2;
        SoruList.Add(soru[3]);
        soru[4].Soru = "Aþaðýdakilerden hangisi, kara yolunda bozulup kalan araçlarýn tehlikeye meydan vermemesi için yapýlmasý gereken iþlemlerdendir?";
        soru[4].Cevap = "Vitesin boþa alýnmasý";
        soru[4].Cevap2 = "Aracýn kapýlarýnýn açýk tutulmasý";
        soru[4].Cevap3 = "Uzaðý gösteren ýþýklarýn açýk tutulmasý";
        soru[4].Cevap4 = "Aracýn ön ve arkasýna birer kýrmýzý yansýtýcý konulmasý";
        soru[4].dogruIndex = 4;
        SoruList.Add(soru[4]);
        soru[5].Soru = "B sýnýfý sürücü belgesi ile aþaðýdaki araçlardan hangisi kullanýlamaz?";
        soru[5].Cevap = "Traktör";
        soru[5].Cevap2 = "Motosiklet";
        soru[5].Cevap3 = "Minibüs";
        soru[5].Cevap4 = "Kamyonet";
        soru[5].dogruIndex = 2;
        SoruList.Add(soru[5]);
        soru[6].Soru = "Aksine bir iþaret yoksa, yerleþim yeri dýþýndaki bölünmüþ yollarda otomobil için azami hýz sýnýrý saatte kaç kilometredir?";
        soru[6].Cevap = "90";
        soru[6].Cevap2 = "100";
        soru[6].Cevap3 = "110";
        soru[6].Cevap4 = "120";
        soru[6].dogruIndex = 3;
        SoruList.Add(soru[6]);
        soru[7].Soru = "Aksine bir iþaret yoksa kamyonun yerleþim yeri içindeki azami hýzý saatte kaç kilometredir?";
        soru[7].Cevap = "30";
        soru[7].Cevap2 = "50";
        soru[7].Cevap3 = "70";
        soru[7].Cevap4 = "80";
        soru[7].dogruIndex = 2;
        SoruList.Add(soru[7]);
        soru[8].Soru = "Aþaðýdaki taþýtlardan hangisinin otoyolda sürülmesi yasaktýr?";
        soru[8].Cevap = "Týr";
        soru[8].Cevap2 = "Traktör";
        soru[8].Cevap3 = "Kamyonet";
        soru[8].Cevap4 = "Otomobil";
        soru[8].dogruIndex = 2;
        SoruList.Add(soru[8]);
        soru[9].Soru = "Belirli araçlarýn, can ve mal güvenliðini tehlikeye sokmamak þartýyla, görev sýrasýnda trafik kýsýtlama veya yasaklarýna baðlý olmamalarý durumuna ne denir?";
        soru[9].Cevap = "Gabari";
        soru[9].Cevap2 = "Geçiþ hakký";
        soru[9].Cevap3 = "Geçiþ kolaylýðý";
        soru[9].Cevap4 = "Geçiþ üstünlüðü";
        soru[9].dogruIndex = 4;
        SoruList.Add(soru[9]);
        soru[10].Soru = "Aþaðýdaki sürücü belgelerinden hangisine sahip olan bir kiþi motosiklet kullanýlabilir?";
        soru[10].Cevap = "A2";
        soru[10].Cevap2 = "B";
        soru[10].Cevap3 = "C";
        soru[10].Cevap4 = "F";
        soru[10].dogruIndex = 1;
        SoruList.Add(soru[10]);
        soru[11].Soru = "Görevli kiþi veya ýþýklý trafik iþareti bulunmayan, ancak trafik iþaretleri ile belirlenmiþ yaya ve okul geçitlerinin bulunduðu yerlerde geçiþ önceliði aþaðýdakilerden hangisine aittir?";
        soru[11].Cevap = "Yayalara";
        soru[11].Cevap2 = "Otomobillere";
        soru[11].Cevap3 = "Okul taþýtlarýna";
        soru[11].Cevap4 = "Kamp taþýtlarýna";
        soru[11].dogruIndex = 1;
        SoruList.Add(soru[11]);
        soru[12].Soru = "Aksine bir iþaret yoksa otobüsün yerleþim yeri içindeki azami hýzý saatte kaç kilometredir?";
        soru[12].Cevap = "50";
        soru[12].Cevap2 = "70";
        soru[12].Cevap3 = "80";
        soru[12].Cevap4 = "90";
        soru[12].dogruIndex = 1;
        SoruList.Add(soru[12]);
        soru[13].Soru = "Eðimli iki yönlü dar yollarda karþýlaþan araç sürücüleri için aþaðýdakilerden hangisi doðrudur?";
        soru[13].Cevap = "Ýnen araç sürücüsünün çýkan araç sürücüsüne yol vermesi";
        soru[13].Cevap2 = "Çýkan araç sürücüsünün inen araç sürücüsüne yol vermesi";
        soru[13].Cevap3 = "Ýnen araç sürücüsünün çýkan araç sürücüsünü ikaz edip durdurmasý";
        soru[13].Cevap4 = "Ýnen araç sürücüsünün aracýn motorunu durdurup, vitesi boþa almasý";
        soru[13].dogruIndex = 1;
        SoruList.Add(soru[13]);
        soru[14].Soru = "Ticari amaçla yük taþýmacýlýðý yapan ve azami aðýrlýðý 3,5 tonu geçen araç þoförlerinin; sürekli 4,5 saatlik araç kullanma süresi sonunda, eðer istirahata çekilmiyor ise en az kaç dakika mola almasý mecburidir?";
        soru[14].Cevap = "20";
        soru[14].Cevap2 = "25";
        soru[14].Cevap3 = "35";
        soru[14].Cevap4 = "45";
        soru[14].dogruIndex = 4;
        SoruList.Add(soru[14]);






        soruIlk[0].Soru =
            "Yetiþkinlere ve bebeklere yapýlan temel yaþam desteði uygulamasýnda, göðüs kemiði kaç cm aþaðý inecek þekilde kalp basýsý uygulanýr?";
        soruIlk[0].Cevap = "Yetiþkin = 2    Bebek = 1 ";
        soruIlk[0].Cevap2 = "Yetiþkin = 3    Bebek = 2 ";
        soruIlk[0].Cevap3 = "Yetiþkin = 5    Bebek = 4 ";
        soruIlk[0].Cevap4 = "Yetiþkin = 7    Bebek = 6 ";
        soruIlk[0].dogruIndex = 3;
        soruIlk[1].Soru =
            "Kalp-damar sisteminin yaþamsal organlara uygun oranda kanlanma yapamamasý nedeniyle ortaya çýkan, tansiyon düþüklüðü ile seyreden ve ani geliþen dolaþým yetmezliðine - - - - denir." +
            "Bu ifadede boþ býrakýlan yere aþaðýdakilerden hangisi yazýlmalýdýr?";
        soruIlk[1].Cevap = "Þok";
        soruIlk[1].Cevap2 = "Epilepsi";
        soruIlk[1].Cevap3 = "Bayýlma";
        soruIlk[1].Cevap4 = "Havale";
        soruIlk[1].dogruIndex = 1;
        soruIlk[2].Soru =
            "Þok pozisyonunda, kazazedenin bacaklarý kaç cm kadar yukarý kaldýrýlýr?";
        soruIlk[2].Cevap = "30";
        soruIlk[2].Cevap2 = "40";
        soruIlk[2].Cevap3 = "50";
        soruIlk[2].Cevap4 = "60";
        soruIlk[2].dogruIndex = 1; 
        soruIlk[3].Soru =
            "Aþaðýdakilerden hangisi, delici göðüs yaralanmalarýnda kazazedeye yapýlan doðru bir ilk yardým uygulamasýdýr?";
        soruIlk[3].Cevap = "Batan cismin çýkarýlmasý";
        soruIlk[3].Cevap2 = "Aðýzdan ýlýk içecekler verilmesi";
        soruIlk[3].Cevap3 = "Bilinci açýk ise yarý oturur duruma getirilmesi";
        soruIlk[3].Cevap4 = "Ayaklarýnýn yüksekte tutulup sýrtüstü yatýrýlmasý";
        soruIlk[3].dogruIndex = 3;
        soruIlk[4].Soru =
            "Yaralý taþýmada sedye kullanýmý ile ilgili olarak aþaðýdakilerden hangisi doðrudur?";
        soruIlk[4].Cevap = "Sedye kullanýmý her zaman tercih edilmelidir.";
        soruIlk[4].Cevap2 = "Sadece bacaðý kýrýlanlarý yatýrarak taþýmak için tercih edilir.";
        soruIlk[4].Cevap3 = "Sadece zehirlenme vakalarýnýn taþýnmasýnda kullanýlmalýdýr.";
        soruIlk[4].Cevap4 = "Köprücük kemiði kýrýklarýnda hastanýn sedye ile taþýnmasý hayati önem taþýr.";
        soruIlk[4].dogruIndex = 1;
        soruIlk[5].Soru =
            "Baþ, boyun ve gövde ekseninin korunmasýna hangi yaralanmalarda daha çok dikkat edilmesi gerekir?";
        soruIlk[5].Cevap = "Karýn yaralanmalarýnda";
        soruIlk[5].Cevap2 = "Bacak yaralanmalarýnda";
        soruIlk[5].Cevap3 = "Göðüs yaralanmalarýnda";
        soruIlk[5].Cevap4 = "Omurga yaralanmalarýnda";
        soruIlk[5].dogruIndex = 4;
        soruIlk[6].Soru =
            "Bacakta turnike uygulama bölgesi neresidir?";
        soruIlk[6].Cevap = "Diz ile kalça arasý";
        soruIlk[6].Cevap2 = "Ayak bileðinin alt kýsmý";
        soruIlk[6].Cevap3 = "Ayak bileðinin üst kýsmý";
        soruIlk[6].Cevap4 = "Diz kapaðýnýn olduðu bölge";
        soruIlk[6].dogruIndex = 1;
        soruIlk[7].Soru =
            "Yetiþkinde uygulanan kalp masajý uygulama bölgesi ve basý derinliði aþaðýdakilerin hangisinde doðru olarak verilmiþtir?";
        soruIlk[7].Cevap = "Kaburganýn sað alt bölgesi ---> 1 cm";
        soruIlk[7].Cevap2 = "Karnýn sol üst bölgesi ---> 3 cm";
        soruIlk[7].Cevap3 = "Göðüs kemiðinin ortasý ---> 5 cm";
        soruIlk[7].Cevap4 = "Kaburganýn sol alt bölgesi ---> 7 cm";
        soruIlk[7].dogruIndex = 3;
        soruIlk[8].Soru =
            "Týbbi yardým haberleþmesinde iletilecek mesaj nasýl olmalýdýr?";
        soruIlk[8].Cevap = "Gizli";
        soruIlk[8].Cevap2 = "Þifreli";
        soruIlk[8].Cevap3 = "Ayrýntýlý ve uzun";
        soruIlk[8].Cevap4 = "Kýsa, öz ve anlaþýlýr";
        soruIlk[8].dogruIndex = 4;
        soruIlk[9].Soru =
            "Egzoz gazýna maruz kalmanýn sonucu olarak yetersiz soluyan kazazedeye aþaðýdakilerden hangisi uygulanýr?";
        soruIlk[9].Cevap = "Açýk havaya çýkarmak";
        soruIlk[9].Cevap2 = "Yoðurt yedirmek";
        soruIlk[9].Cevap3 = "Tuzlu su içirmek";
        soruIlk[9].Cevap4 = "Kusturmak";
        soruIlk[9].dogruIndex = 1;
        soruIlk[10].Soru =
            "Aþaðýdaki kazazedelerden hangisi kaza yerinden ilk önce taþýnmalýdýr?";
        soruIlk[10].Cevap = "Ölmüþ olan";
        soruIlk[10].Cevap2 = "Ayaðýnda çýkýk olan";
        soruIlk[10].Cevap3 = "Solunum zorluðu çeken";
        soruIlk[10].Cevap4 = "Birinci derece yanýðý olan";
        soruIlk[10].dogruIndex = 3;
        soruIlk[11].Soru =
            "Yaralýnýn araçtan çýkarýlmasý esnasýnda en çok hangisine dikkat edilmelidir?";
        soruIlk[11].Cevap = "Yaralýda yeni bir yaralanma meydana gelmemesine";
        soruIlk[11].Cevap2 = "Kazayý seyredenlerin uzaklaþtýrýlmasýna";
        soruIlk[11].Cevap3 = "Kaza yapan araca hasar verilmemesine";
        soruIlk[11].Cevap4 = "Hýzlý ve aceleci davranmaya";
        soruIlk[11].dogruIndex = 1;
        soruIlk[12].Soru =
            "Diz ile ayak arasýndaki kemik kýrýklarýnda dýþtan uygulanacak olan atelin boyu ne kadar olmalýdýr?";
        soruIlk[12].Cevap = "Topuktan dize kadar";
        soruIlk[12].Cevap2 = "Dizden kalçaya kadar";
        soruIlk[12].Cevap3 = "Topuktan kalçaya kadar";
        soruIlk[12].Cevap4 = "Topuktan koltuk altýna kadar";
        soruIlk[12].dogruIndex = 3;
        soruIlk[13].Soru =
            "Belli bir görevi yapan farklý dokularýn bir araya gelmesiyle oluþan vücut birimine ne ad verilir?";
        soruIlk[13].Cevap = "Hücre";
        soruIlk[13].Cevap2 = "Organ";
        soruIlk[13].Cevap3 = "Sistem";
        soruIlk[13].Cevap4 = "Destek doku";
        soruIlk[13].dogruIndex = 2;
        soruIlk[14].Soru =
            "Suni solunum iþlemleri öncesinde ilk olarak yapýlmasý gereken aþaðýdakilerden hangisidir?";
        soruIlk[14].Cevap = "Hastanýn ayaklarýnýn yükseltilmesi";
        soruIlk[14].Cevap2 = "Suni solunuma baþlamadan 5 dakika beklenilmesi";
        soruIlk[14].Cevap3 = "Aðýz içinin temizlenerek hava yolu açýklýðýnýn saðlanmasý";
        soruIlk[14].Cevap4 = "Solunumu uyarmak için göðüs bölgesine yumruk atýlmasý";
        soruIlk[14].dogruIndex = 3;
        for (int i = 0; i < 15; i++)
        {
            IlkList.Add(soruIlk[i]);
        }

        motor[0].Soru =
            "Araçlarýn orijinal sistemlerinde yer alan egzoz borusu ve susturucunun korunmasý ile aþaðýdakilerden hangisi amaçlanýr?";
        motor[0].Cevap = "Kazalara karþý güvenliðin artýrýlmasý";
        motor[0].Cevap2 = "Kazalara karþý güvenliðin artýrýlmasý";
        motor[0].Cevap3 = "Trafik yoðunluðunun azaltýlmasý";
        motor[0].Cevap4 = "Gürültü kirliliðinin azaltýlmasý";
        motor[0].dogruIndex = 4;
        motor[1].Soru =
            "Akü üzerinde bulunan kontrol gözünde, akü þarjýnýn iyi durumda olduðunu gösteren renk hangisidir?";
        motor[1].Cevap = "Sarý";
        motor[1].Cevap2 = "Yeþil";
        motor[1].Cevap3 = "Siyah";
        motor[1].Cevap4 = "Kýrmýzý";
        motor[1].dogruIndex = 2;
        motor[2].Soru =
            "Motor kompresyon freninin etkisi aþaðýdakilerden hangisidir?";
        motor[2].Cevap = "Taþýtý yavaþlatýr.";
        motor[2].Cevap2 = "Taþýtý hýzlandýrýr.";
        motor[2].Cevap3 = "Araç bir tarafa çeker.";
        motor[2].Cevap4 = "Frenleme çok zayýflar.";
        motor[2].dogruIndex = 1;
        motor[3].Soru =
            "Araç hareket hâlindeyken, kontak kapatýlmamalý veya kontak anahtarý kontaktan çýkartýlmamalýdýr.Buna raðmen kontak anahtarý kontaktan çýkartýldýðýnda aþaðýdakilerden hangisi olur ? ";
        motor[3].Cevap = "Direksiyon daha rahat döner.";
        motor[3].Cevap2 = "Direksiyon kilitlenir.";
        motor[3].Cevap3 = "Akü tam þarj olur.";
        motor[3].Cevap4 = "Sürüþ kolaylaþýr.";
        motor[3].dogruIndex = 2;
        motor[4].Soru =
            "Aþaðýdakilerden hangisi, duran aracý güvenli bir þekilde bulunduðu yere tespit etmek amacýyla kullanýlýr?";
        motor[4].Cevap = "El freni";
        motor[4].Cevap2 = "Motor freni";
        motor[4].Cevap3 = "Egzoz freni";
        motor[4].Cevap4 = "Kompresyon freni";
        motor[4].dogruIndex = 1;
        motor[5].Soru =
            "Aþaðýdakilerden hangisinin periyodik bakýmý yapýlmadýðýnda motorun içine giren hava akýþý zorlaþýr, motor çekiþten düþer ve yakýt sarfiyatý artar?";
        motor[5].Cevap = "Yað filtresi";
        motor[5].Cevap2 = "Hava filtresi";
        motor[5].Cevap3 = "Yakýt filtresi";
        motor[5].Cevap4 = "Polen filtresi";
        motor[5].dogruIndex = 2;
        motor[6].Soru =
            "Marþ motorunun görevi nedir?";
        motor[6].Cevap = "Motoru çalýþma sýcaklýðýnda tutmak";
        motor[6].Cevap2 = "Motora ilk hareketi vermek";
        motor[6].Cevap3 = "Araca ilk hareketi vermek";
        motor[6].Cevap4 = "Aküyü þarj etmek";
        motor[6].dogruIndex = 2;
        motor[7].Soru =
            "Aþaðýdakilerden hangisi balanssýz tekerleðin araç üzerindeki etkilerindendir?";
        motor[7].Cevap = "Direksiyonun titremesi";
        motor[7].Cevap2 = "Sürüþ konforunun artmasý";
        motor[7].Cevap3 = "Motor yakýtýna yað karýþmasý";
        motor[7].Cevap4 = "Fren disk yüzeyinin çabuk soðumasý";
        motor[7].dogruIndex = 1; 
        motor[8].Soru =
            "Aþaðýdakilerden hangisi süspansiyon sisteminin elemanýdýr?";
        motor[8].Cevap = "Þaft";
        motor[8].Cevap2 = "Direksiyon";
        motor[8].Cevap3 = "Helezon yaylar";
        motor[8].Cevap4 = "Vites kutusu";
        motor[8].dogruIndex = 3;
        motor[9].Soru =
            "I- Akü kontrolü" +
            "II - Lastik kontrolü" +
            "III - Antifriz kontrolü" +
            "Yukarýdakilerden hangileri aracýn kýþ koþullarýna hazýrlanmasýnda alýnmasý gereken önlemlerdendir";
        motor[9].Cevap = "Yalnýz I";
        motor[9].Cevap2 = "I ve II";
        motor[9].Cevap3 = "II ve III";
        motor[9].Cevap4 = "I, II ve III";
        motor[9].dogruIndex = 4;
        motor[10].Soru =
            "Aþaðýdakilerden hangisi motora giren havayý temizler?";
        motor[10].Cevap = "Su filtresi";
        motor[10].Cevap2 = "Yað filtresi";
        motor[10].Cevap3 = "Hava filtresi";
        motor[10].Cevap4 = "Benzin filtresi";
        motor[10].dogruIndex = 3;
        motor[11].Soru =
            "Aþaðýdakilerden hangisi araçlarda egzoz gaz emisyonlarýný azaltmak için kullanýlýr?";
        motor[11].Cevap = "Egzoz supabý";
        motor[11].Cevap2 = "Egzoz supabý";
        motor[11].Cevap3 = "Egzoz manifoldu";
        motor[11].Cevap4 = "Katalitik konvertör";
        motor[11].dogruIndex = 4;
        motor[12].Soru =
            "Aküden gelen düþük gerilimi, buji týrnaklarý arasýnda kývýlcým oluþturacak þekilde yüksek gerilime dönüþtüren ateþleme sistemi elemanýna ne ad verilir?";
        motor[12].Cevap = "Kontak anahtarý";
        motor[12].Cevap2 = "Endüksiyon bobini";
        motor[12].Cevap3 = "Konjektör";
        motor[12].Cevap4 = "Sigorta";
        motor[12].dogruIndex = 2;
        motor[13].Soru =
            "Aþaðýdakilerden hangisi akünün kendiliðinden boþalmasýna neden olur?";
        motor[13].Cevap = "Kutup baþlarýnýn sýký olmasý";
        motor[13].Cevap2 = "Kutup baþlarýnýn temiz olmasý";
        motor[13].Cevap3 = "Akü reklam etiketinin yýrtýlmasý";
        motor[13].Cevap4 = "Üst kýsmýnda pisliklerin birikmesi";
        motor[13].dogruIndex = 4;
        motor[14].Soru =
            "Aracýn elektrik devresinde, akým yüksek olduðunda eriyerek güvenliði saðlayan parça aþaðýdakilerden hangisidir?";
        motor[14].Cevap = "Akü";
        motor[14].Cevap2 = "Platin";
        motor[14].Cevap3 = "Alternatör";
        motor[14].Cevap4 = "Sigorta";
        motor[14].dogruIndex = 4;

        for (int i = 0; i < 15; i++)
        {
            motorList.Add(motor[i]);
        }


        adab[0].Soru =
            "Geceleyin önündeki aracý geçmek isteyen sürücü, bu araçla yan yana gelinceye kadar hangi ýþýklarý kullanmalýdýr?";
        adab[0].Cevap = "Yakýný gösteren ýþýklarý";
        adab[0].Cevap2 = "Uzaðý gösteren ýþýklarý";
        adab[0].Cevap3 = "Acil uyarý ýþýklarýný";
        adab[0].Cevap4 = "Sis ýþýklarýný";
        adab[0].dogruIndex = 1;
        adab[1].Soru =
            "Park hâlindeki araca çarpan sürücünün aþaðýdakilerden hangisini yapmasý yanlýþtýr?";
        adab[1].Cevap = "Trafik görevlisine haber vermesi";
        adab[1].Cevap2 = "Zarar verdiði aracýn sahibini bulmasý";
        adab[1].Cevap3 = "Zarar fazla deðilse olay yerinden uzaklaþmasý";
        adab[1].Cevap4 = "Aracýn sahibini bulamaz ise yazýlý bilgi býrakmasý";
        adab[1].dogruIndex = 3; 
        adab[2].Soru =
            "Aþaðýdakilerden hangisi özel araçlarýn gereksiz kullanýlmasýnýn sonuçlarýndandýr?";
        adab[2].Cevap = "Trafik yoðunluðunun azalmasý";
        adab[2].Cevap2 = "Trafik yoðunluðunun artmasý";
        adab[2].Cevap3 = "Gürültü kirliliðinin önlenmesi";
        adab[2].Cevap4 = "Yakýt tüketiminin azalmasý";
        adab[2].dogruIndex = 2;
        adab[3].Soru =
            "Sürücülerin taþýt yolunun sol þeridinde aþaðýdakilerden hangisini yapmasý yasaktýr?";
        adab[3].Cevap = "Yavaþlamasý";
        adab[3].Cevap2 = "Vites küçültmesi";
        adab[3].Cevap3 = "Yolcu indirip bindirmesi";
        adab[3].Cevap4 = "Uygun hýzla seyretmesi";
        adab[3].dogruIndex = 3;
        adab[4].Soru =
            "Aþaðýdakilerden hangisi çevre kirliliðine yol açar?";
        adab[4].Cevap = "Mümkün olduðunca otobüs, vapur, tren, metro gibi toplu taþýma araçlarýnýn kullanýlmasý";
        adab[4].Cevap2 = "Bakýmsýz araçlardan yere (yað, su vb.) sýzýntý olmasý";
        adab[4].Cevap3 = "Tehlikeli maddelerin usulüne uygun taþýnmasý";
        adab[4].Cevap4 = "Araç bakýmlarýnýn sürelerinde yapýlmasý";
        adab[4].dogruIndex = 2;
        adab[5].Soru =
            "Aþaðýdakilerden hangisi gözlük veya lens kullanarak görme yeterliliðine sahip olan sürücüler için doðrudur?";
        adab[5].Cevap = "Bu tür adaylara sürücü belgesi verilmez.";
        adab[5].Cevap2 = "Araç kullanýrken gözlük veya lenslerini kullanmak zorundadýrlar.";
        adab[5].Cevap3 = "Yalnýzca þehir dýþý yollarda gözlük veya lens kullanmak zorundadýrlar.";
        adab[5].Cevap4 = "Yalnýzca gece araç kullanýrken gözlük veya lens kullanmak zorundadýrlar.";
        adab[5].dogruIndex = 2;
        adab[6].Soru =
            "I- Korkutmak veya þaþýrtmak" +
            "II - Su, çamur ve benzerlerini sýçratmak, atmak ve dökmek" +
            "III - Keyfi davranýþlarda bulunmak suretiyle yaya veya araç trafiðini tehlikeye düþürmek" +
            "Sürücülerin yukarýdaki davranýþlarýndan hangileri, kiþilere zarar verecek tedbirsiz ve saygýsýz davranýþlar kapsamýna girer ? ";
        adab[6].Cevap = "Yalnýz I";
        adab[6].Cevap2 = "I ve II";
        adab[6].Cevap3 = "II ve III";
        adab[6].Cevap4 = "I, II ve III";
        adab[6].dogruIndex = 4;
        adab[7].Soru =
            "Üzerinde deðiþiklik yapýlýp da süresi içinde bildirilmeyen araçlara, deðiþiklik belgeledirilip tescil kuruluþunda tescil edilinceye kadar aþaðýdakilerden hangisi uygulanýr?";
        adab[7].Cevap = "Trafikten men";
        adab[7].Cevap2 = "Hurdaya ayýrma";
        adab[7].Cevap3 = "Sürücüsüne aðýr hapis";
        adab[7].Cevap4 = "Baþkasýna devir etme þartý";
        adab[7].dogruIndex = 1;
        adab[8].Soru =
            "Aþaðýdakilerden hangisi çevre kirliliðini önleme açýsýndan olumlu bir davranýþtýr?";
        adab[8].Cevap = "Ýniþ eðimli yollarda motorun durdurulmasý";
        adab[8].Cevap2 = "Bakým sýrasýnda çýkan eski parça ve malzemelerin çevreye bilinçsizce býrakýlmamasý";
        adab[8].Cevap3 = "Taþýtlarda kalitesiz yakýtlarýn kullanýlmasý";
        adab[8].Cevap4 = "Taþýtlardan dýþarýya malzeme atýlmasý";
        adab[8].dogruIndex = 2;

        for (int i = 0; i < 9; i++)
        {
            adabList.Add(adab[i]);
        }
    }

}
