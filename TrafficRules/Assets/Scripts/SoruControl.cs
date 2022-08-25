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

        soru[0].Soru = "A�a��dakilerden hangisi, yolcu ta��mac�l���nda kullan�lan ve s�r�c�s� dahil dokuzdan fazla oturma yeri olan motorlu ta��tt�r?";
        soru[0].Cevap = "�ekici";
        soru[0].Cevap2 = "Otob�s";
        soru[0].Cevap3 = "Otomobil";
        soru[0].Cevap4 = "Kamyonet";
        soru[0].dogruIndex = 2;
        SoruList.Add(soru[0]);
        soru[1].Soru = "Otomobilinin muayene zaman�n� ��renmek isteyen s�r�c�, a�a��daki belgelerden hangisini kontrol etmelidir?";
        soru[1].Cevap = "Ara� imalat belgesi";
        soru[1].Cevap2 = "Motorlu ara� trafik belgesi";
        soru[1].Cevap3 = "Ara� tescil belgesi";
        soru[1].Cevap4 = "S�r�c� belgesi";
        soru[1].dogruIndex = 2;
        SoruList.Add(soru[1]);
        soru[2].Soru = "Zorunlu h�ller d���nda otoyollarda motorlu ara�lar�n asgari h�z s�n�r� saatte ka� kilometredir?";
        soru[2].Cevap = "15";
        soru[2].Cevap2 = "35";
        soru[2].Cevap3 = "40";
        soru[2].Cevap4 = "50";
        soru[2].dogruIndex = 3;
        SoruList.Add(soru[2]);
        soru[3].Soru = "I- �dari para cezas� verilir." +
                       "II - S�r�c� belgesi 6 ay s�re ile geri al�n�r." +
                       "III - Kara yolunda ara� s�rmesine izin verilir." +
                       "Yap�lan �l��m sonucunda, yasal s�n�rlar�n �zerinde alkoll� olarak ara� kulland��� birinci defa tespit edilen s�r�c�ye yukar�daki i�lemlerden hangileri uygulan�r?";
        soru[3].Cevap = "Yaln�z I";
        soru[3].Cevap2 = "I ve II";
        soru[3].Cevap3 = "II ve III";
        soru[3].Cevap4 = "I, II ve III";
        soru[3].dogruIndex = 2;
        SoruList.Add(soru[3]);
        soru[4].Soru = "A�a��dakilerden hangisi, kara yolunda bozulup kalan ara�lar�n tehlikeye meydan vermemesi i�in yap�lmas� gereken i�lemlerdendir?";
        soru[4].Cevap = "Vitesin bo�a al�nmas�";
        soru[4].Cevap2 = "Arac�n kap�lar�n�n a��k tutulmas�";
        soru[4].Cevap3 = "Uza�� g�steren ���klar�n a��k tutulmas�";
        soru[4].Cevap4 = "Arac�n �n ve arkas�na birer k�rm�z� yans�t�c� konulmas�";
        soru[4].dogruIndex = 4;
        SoruList.Add(soru[4]);
        soru[5].Soru = "B s�n�f� s�r�c� belgesi ile a�a��daki ara�lardan hangisi kullan�lamaz?";
        soru[5].Cevap = "Trakt�r";
        soru[5].Cevap2 = "Motosiklet";
        soru[5].Cevap3 = "Minib�s";
        soru[5].Cevap4 = "Kamyonet";
        soru[5].dogruIndex = 2;
        SoruList.Add(soru[5]);
        soru[6].Soru = "Aksine bir i�aret yoksa, yerle�im yeri d���ndaki b�l�nm�� yollarda otomobil i�in azami h�z s�n�r� saatte ka� kilometredir?";
        soru[6].Cevap = "90";
        soru[6].Cevap2 = "100";
        soru[6].Cevap3 = "110";
        soru[6].Cevap4 = "120";
        soru[6].dogruIndex = 3;
        SoruList.Add(soru[6]);
        soru[7].Soru = "Aksine bir i�aret yoksa kamyonun yerle�im yeri i�indeki azami h�z� saatte ka� kilometredir?";
        soru[7].Cevap = "30";
        soru[7].Cevap2 = "50";
        soru[7].Cevap3 = "70";
        soru[7].Cevap4 = "80";
        soru[7].dogruIndex = 2;
        SoruList.Add(soru[7]);
        soru[8].Soru = "A�a��daki ta��tlardan hangisinin otoyolda s�r�lmesi yasakt�r?";
        soru[8].Cevap = "T�r";
        soru[8].Cevap2 = "Trakt�r";
        soru[8].Cevap3 = "Kamyonet";
        soru[8].Cevap4 = "Otomobil";
        soru[8].dogruIndex = 2;
        SoruList.Add(soru[8]);
        soru[9].Soru = "Belirli ara�lar�n, can ve mal g�venli�ini tehlikeye sokmamak �art�yla, g�rev s�ras�nda trafik k�s�tlama veya yasaklar�na ba�l� olmamalar� durumuna ne denir?";
        soru[9].Cevap = "Gabari";
        soru[9].Cevap2 = "Ge�i� hakk�";
        soru[9].Cevap3 = "Ge�i� kolayl���";
        soru[9].Cevap4 = "Ge�i� �st�nl���";
        soru[9].dogruIndex = 4;
        SoruList.Add(soru[9]);
        soru[10].Soru = "A�a��daki s�r�c� belgelerinden hangisine sahip olan bir ki�i motosiklet kullan�labilir?";
        soru[10].Cevap = "A2";
        soru[10].Cevap2 = "B";
        soru[10].Cevap3 = "C";
        soru[10].Cevap4 = "F";
        soru[10].dogruIndex = 1;
        SoruList.Add(soru[10]);
        soru[11].Soru = "G�revli ki�i veya ���kl� trafik i�areti bulunmayan, ancak trafik i�aretleri ile belirlenmi� yaya ve okul ge�itlerinin bulundu�u yerlerde ge�i� �nceli�i a�a��dakilerden hangisine aittir?";
        soru[11].Cevap = "Yayalara";
        soru[11].Cevap2 = "Otomobillere";
        soru[11].Cevap3 = "Okul ta��tlar�na";
        soru[11].Cevap4 = "Kamp ta��tlar�na";
        soru[11].dogruIndex = 1;
        SoruList.Add(soru[11]);
        soru[12].Soru = "Aksine bir i�aret yoksa otob�s�n yerle�im yeri i�indeki azami h�z� saatte ka� kilometredir?";
        soru[12].Cevap = "50";
        soru[12].Cevap2 = "70";
        soru[12].Cevap3 = "80";
        soru[12].Cevap4 = "90";
        soru[12].dogruIndex = 1;
        SoruList.Add(soru[12]);
        soru[13].Soru = "E�imli iki y�nl� dar yollarda kar��la�an ara� s�r�c�leri i�in a�a��dakilerden hangisi do�rudur?";
        soru[13].Cevap = "�nen ara� s�r�c�s�n�n ��kan ara� s�r�c�s�ne yol vermesi";
        soru[13].Cevap2 = "��kan ara� s�r�c�s�n�n inen ara� s�r�c�s�ne yol vermesi";
        soru[13].Cevap3 = "�nen ara� s�r�c�s�n�n ��kan ara� s�r�c�s�n� ikaz edip durdurmas�";
        soru[13].Cevap4 = "�nen ara� s�r�c�s�n�n arac�n motorunu durdurup, vitesi bo�a almas�";
        soru[13].dogruIndex = 1;
        SoruList.Add(soru[13]);
        soru[14].Soru = "Ticari ama�la y�k ta��mac�l��� yapan ve azami a��rl��� 3,5 tonu ge�en ara� �of�rlerinin; s�rekli 4,5 saatlik ara� kullanma s�resi sonunda, e�er istirahata �ekilmiyor ise en az ka� dakika mola almas� mecburidir?";
        soru[14].Cevap = "20";
        soru[14].Cevap2 = "25";
        soru[14].Cevap3 = "35";
        soru[14].Cevap4 = "45";
        soru[14].dogruIndex = 4;
        SoruList.Add(soru[14]);






        soruIlk[0].Soru =
            "Yeti�kinlere ve bebeklere yap�lan temel ya�am deste�i uygulamas�nda, g���s kemi�i ka� cm a�a�� inecek �ekilde kalp bas�s� uygulan�r?";
        soruIlk[0].Cevap = "Yeti�kin = 2    Bebek = 1 ";
        soruIlk[0].Cevap2 = "Yeti�kin = 3    Bebek = 2 ";
        soruIlk[0].Cevap3 = "Yeti�kin = 5    Bebek = 4 ";
        soruIlk[0].Cevap4 = "Yeti�kin = 7    Bebek = 6 ";
        soruIlk[0].dogruIndex = 3;
        soruIlk[1].Soru =
            "Kalp-damar sisteminin ya�amsal organlara uygun oranda kanlanma yapamamas� nedeniyle ortaya ��kan, tansiyon d���kl��� ile seyreden ve ani geli�en dola��m yetmezli�ine - - - - denir." +
            "Bu ifadede bo� b�rak�lan yere a�a��dakilerden hangisi yaz�lmal�d�r?";
        soruIlk[1].Cevap = "�ok";
        soruIlk[1].Cevap2 = "Epilepsi";
        soruIlk[1].Cevap3 = "Bay�lma";
        soruIlk[1].Cevap4 = "Havale";
        soruIlk[1].dogruIndex = 1;
        soruIlk[2].Soru =
            "�ok pozisyonunda, kazazedenin bacaklar� ka� cm kadar yukar� kald�r�l�r?";
        soruIlk[2].Cevap = "30";
        soruIlk[2].Cevap2 = "40";
        soruIlk[2].Cevap3 = "50";
        soruIlk[2].Cevap4 = "60";
        soruIlk[2].dogruIndex = 1; 
        soruIlk[3].Soru =
            "A�a��dakilerden hangisi, delici g���s yaralanmalar�nda kazazedeye yap�lan do�ru bir ilk yard�m uygulamas�d�r?";
        soruIlk[3].Cevap = "Batan cismin ��kar�lmas�";
        soruIlk[3].Cevap2 = "A��zdan �l�k i�ecekler verilmesi";
        soruIlk[3].Cevap3 = "Bilinci a��k ise yar� oturur duruma getirilmesi";
        soruIlk[3].Cevap4 = "Ayaklar�n�n y�ksekte tutulup s�rt�st� yat�r�lmas�";
        soruIlk[3].dogruIndex = 3;
        soruIlk[4].Soru =
            "Yaral� ta��mada sedye kullan�m� ile ilgili olarak a�a��dakilerden hangisi do�rudur?";
        soruIlk[4].Cevap = "Sedye kullan�m� her zaman tercih edilmelidir.";
        soruIlk[4].Cevap2 = "Sadece baca�� k�r�lanlar� yat�rarak ta��mak i�in tercih edilir.";
        soruIlk[4].Cevap3 = "Sadece zehirlenme vakalar�n�n ta��nmas�nda kullan�lmal�d�r.";
        soruIlk[4].Cevap4 = "K�pr�c�k kemi�i k�r�klar�nda hastan�n sedye ile ta��nmas� hayati �nem ta��r.";
        soruIlk[4].dogruIndex = 1;
        soruIlk[5].Soru =
            "Ba�, boyun ve g�vde ekseninin korunmas�na hangi yaralanmalarda daha �ok dikkat edilmesi gerekir?";
        soruIlk[5].Cevap = "Kar�n yaralanmalar�nda";
        soruIlk[5].Cevap2 = "Bacak yaralanmalar�nda";
        soruIlk[5].Cevap3 = "G���s yaralanmalar�nda";
        soruIlk[5].Cevap4 = "Omurga yaralanmalar�nda";
        soruIlk[5].dogruIndex = 4;
        soruIlk[6].Soru =
            "Bacakta turnike uygulama b�lgesi neresidir?";
        soruIlk[6].Cevap = "Diz ile kal�a aras�";
        soruIlk[6].Cevap2 = "Ayak bile�inin alt k�sm�";
        soruIlk[6].Cevap3 = "Ayak bile�inin �st k�sm�";
        soruIlk[6].Cevap4 = "Diz kapa��n�n oldu�u b�lge";
        soruIlk[6].dogruIndex = 1;
        soruIlk[7].Soru =
            "Yeti�kinde uygulanan kalp masaj� uygulama b�lgesi ve bas� derinli�i a�a��dakilerin hangisinde do�ru olarak verilmi�tir?";
        soruIlk[7].Cevap = "Kaburgan�n sa� alt b�lgesi ---> 1 cm";
        soruIlk[7].Cevap2 = "Karn�n sol �st b�lgesi ---> 3 cm";
        soruIlk[7].Cevap3 = "G���s kemi�inin ortas� ---> 5 cm";
        soruIlk[7].Cevap4 = "Kaburgan�n sol alt b�lgesi ---> 7 cm";
        soruIlk[7].dogruIndex = 3;
        soruIlk[8].Soru =
            "T�bbi yard�m haberle�mesinde iletilecek mesaj nas�l olmal�d�r?";
        soruIlk[8].Cevap = "Gizli";
        soruIlk[8].Cevap2 = "�ifreli";
        soruIlk[8].Cevap3 = "Ayr�nt�l� ve uzun";
        soruIlk[8].Cevap4 = "K�sa, �z ve anla��l�r";
        soruIlk[8].dogruIndex = 4;
        soruIlk[9].Soru =
            "Egzoz gaz�na maruz kalman�n sonucu olarak yetersiz soluyan kazazedeye a�a��dakilerden hangisi uygulan�r?";
        soruIlk[9].Cevap = "A��k havaya ��karmak";
        soruIlk[9].Cevap2 = "Yo�urt yedirmek";
        soruIlk[9].Cevap3 = "Tuzlu su i�irmek";
        soruIlk[9].Cevap4 = "Kusturmak";
        soruIlk[9].dogruIndex = 1;
        soruIlk[10].Soru =
            "A�a��daki kazazedelerden hangisi kaza yerinden ilk �nce ta��nmal�d�r?";
        soruIlk[10].Cevap = "�lm�� olan";
        soruIlk[10].Cevap2 = "Aya��nda ��k�k olan";
        soruIlk[10].Cevap3 = "Solunum zorlu�u �eken";
        soruIlk[10].Cevap4 = "Birinci derece yan��� olan";
        soruIlk[10].dogruIndex = 3;
        soruIlk[11].Soru =
            "Yaral�n�n ara�tan ��kar�lmas� esnas�nda en �ok hangisine dikkat edilmelidir?";
        soruIlk[11].Cevap = "Yaral�da yeni bir yaralanma meydana gelmemesine";
        soruIlk[11].Cevap2 = "Kazay� seyredenlerin uzakla�t�r�lmas�na";
        soruIlk[11].Cevap3 = "Kaza yapan araca hasar verilmemesine";
        soruIlk[11].Cevap4 = "H�zl� ve aceleci davranmaya";
        soruIlk[11].dogruIndex = 1;
        soruIlk[12].Soru =
            "Diz ile ayak aras�ndaki kemik k�r�klar�nda d��tan uygulanacak olan atelin boyu ne kadar olmal�d�r?";
        soruIlk[12].Cevap = "Topuktan dize kadar";
        soruIlk[12].Cevap2 = "Dizden kal�aya kadar";
        soruIlk[12].Cevap3 = "Topuktan kal�aya kadar";
        soruIlk[12].Cevap4 = "Topuktan koltuk alt�na kadar";
        soruIlk[12].dogruIndex = 3;
        soruIlk[13].Soru =
            "Belli bir g�revi yapan farkl� dokular�n bir araya gelmesiyle olu�an v�cut birimine ne ad verilir?";
        soruIlk[13].Cevap = "H�cre";
        soruIlk[13].Cevap2 = "Organ";
        soruIlk[13].Cevap3 = "Sistem";
        soruIlk[13].Cevap4 = "Destek doku";
        soruIlk[13].dogruIndex = 2;
        soruIlk[14].Soru =
            "Suni solunum i�lemleri �ncesinde ilk olarak yap�lmas� gereken a�a��dakilerden hangisidir?";
        soruIlk[14].Cevap = "Hastan�n ayaklar�n�n y�kseltilmesi";
        soruIlk[14].Cevap2 = "Suni solunuma ba�lamadan 5 dakika beklenilmesi";
        soruIlk[14].Cevap3 = "A��z i�inin temizlenerek hava yolu a��kl���n�n sa�lanmas�";
        soruIlk[14].Cevap4 = "Solunumu uyarmak i�in g���s b�lgesine yumruk at�lmas�";
        soruIlk[14].dogruIndex = 3;
        for (int i = 0; i < 15; i++)
        {
            IlkList.Add(soruIlk[i]);
        }

        motor[0].Soru =
            "Ara�lar�n orijinal sistemlerinde yer alan egzoz borusu ve susturucunun korunmas� ile a�a��dakilerden hangisi ama�lan�r?";
        motor[0].Cevap = "Kazalara kar�� g�venli�in art�r�lmas�";
        motor[0].Cevap2 = "Kazalara kar�� g�venli�in art�r�lmas�";
        motor[0].Cevap3 = "Trafik yo�unlu�unun azalt�lmas�";
        motor[0].Cevap4 = "G�r�lt� kirlili�inin azalt�lmas�";
        motor[0].dogruIndex = 4;
        motor[1].Soru =
            "Ak� �zerinde bulunan kontrol g�z�nde, ak� �arj�n�n iyi durumda oldu�unu g�steren renk hangisidir?";
        motor[1].Cevap = "Sar�";
        motor[1].Cevap2 = "Ye�il";
        motor[1].Cevap3 = "Siyah";
        motor[1].Cevap4 = "K�rm�z�";
        motor[1].dogruIndex = 2;
        motor[2].Soru =
            "Motor kompresyon freninin etkisi a�a��dakilerden hangisidir?";
        motor[2].Cevap = "Ta��t� yava�lat�r.";
        motor[2].Cevap2 = "Ta��t� h�zland�r�r.";
        motor[2].Cevap3 = "Ara� bir tarafa �eker.";
        motor[2].Cevap4 = "Frenleme �ok zay�flar.";
        motor[2].dogruIndex = 1;
        motor[3].Soru =
            "Ara� hareket h�lindeyken, kontak kapat�lmamal� veya kontak anahtar� kontaktan ��kart�lmamal�d�r.Buna ra�men kontak anahtar� kontaktan ��kart�ld���nda a�a��dakilerden hangisi olur ? ";
        motor[3].Cevap = "Direksiyon daha rahat d�ner.";
        motor[3].Cevap2 = "Direksiyon kilitlenir.";
        motor[3].Cevap3 = "Ak� tam �arj olur.";
        motor[3].Cevap4 = "S�r�� kolayla��r.";
        motor[3].dogruIndex = 2;
        motor[4].Soru =
            "A�a��dakilerden hangisi, duran arac� g�venli bir �ekilde bulundu�u yere tespit etmek amac�yla kullan�l�r?";
        motor[4].Cevap = "El freni";
        motor[4].Cevap2 = "Motor freni";
        motor[4].Cevap3 = "Egzoz freni";
        motor[4].Cevap4 = "Kompresyon freni";
        motor[4].dogruIndex = 1;
        motor[5].Soru =
            "A�a��dakilerden hangisinin periyodik bak�m� yap�lmad���nda motorun i�ine giren hava ak��� zorla��r, motor �eki�ten d��er ve yak�t sarfiyat� artar?";
        motor[5].Cevap = "Ya� filtresi";
        motor[5].Cevap2 = "Hava filtresi";
        motor[5].Cevap3 = "Yak�t filtresi";
        motor[5].Cevap4 = "Polen filtresi";
        motor[5].dogruIndex = 2;
        motor[6].Soru =
            "Mar� motorunun g�revi nedir?";
        motor[6].Cevap = "Motoru �al��ma s�cakl���nda tutmak";
        motor[6].Cevap2 = "Motora ilk hareketi vermek";
        motor[6].Cevap3 = "Araca ilk hareketi vermek";
        motor[6].Cevap4 = "Ak�y� �arj etmek";
        motor[6].dogruIndex = 2;
        motor[7].Soru =
            "A�a��dakilerden hangisi balanss�z tekerle�in ara� �zerindeki etkilerindendir?";
        motor[7].Cevap = "Direksiyonun titremesi";
        motor[7].Cevap2 = "S�r�� konforunun artmas�";
        motor[7].Cevap3 = "Motor yak�t�na ya� kar��mas�";
        motor[7].Cevap4 = "Fren disk y�zeyinin �abuk so�umas�";
        motor[7].dogruIndex = 1; 
        motor[8].Soru =
            "A�a��dakilerden hangisi s�spansiyon sisteminin eleman�d�r?";
        motor[8].Cevap = "�aft";
        motor[8].Cevap2 = "Direksiyon";
        motor[8].Cevap3 = "Helezon yaylar";
        motor[8].Cevap4 = "Vites kutusu";
        motor[8].dogruIndex = 3;
        motor[9].Soru =
            "I- Ak� kontrol�" +
            "II - Lastik kontrol�" +
            "III - Antifriz kontrol�" +
            "Yukar�dakilerden hangileri arac�n k�� ko�ullar�na haz�rlanmas�nda al�nmas� gereken �nlemlerdendir";
        motor[9].Cevap = "Yaln�z I";
        motor[9].Cevap2 = "I ve II";
        motor[9].Cevap3 = "II ve III";
        motor[9].Cevap4 = "I, II ve III";
        motor[9].dogruIndex = 4;
        motor[10].Soru =
            "A�a��dakilerden hangisi motora giren havay� temizler?";
        motor[10].Cevap = "Su filtresi";
        motor[10].Cevap2 = "Ya� filtresi";
        motor[10].Cevap3 = "Hava filtresi";
        motor[10].Cevap4 = "Benzin filtresi";
        motor[10].dogruIndex = 3;
        motor[11].Soru =
            "A�a��dakilerden hangisi ara�larda egzoz gaz emisyonlar�n� azaltmak i�in kullan�l�r?";
        motor[11].Cevap = "Egzoz supab�";
        motor[11].Cevap2 = "Egzoz supab�";
        motor[11].Cevap3 = "Egzoz manifoldu";
        motor[11].Cevap4 = "Katalitik konvert�r";
        motor[11].dogruIndex = 4;
        motor[12].Soru =
            "Ak�den gelen d���k gerilimi, buji t�rnaklar� aras�nda k�v�lc�m olu�turacak �ekilde y�ksek gerilime d�n��t�ren ate�leme sistemi eleman�na ne ad verilir?";
        motor[12].Cevap = "Kontak anahtar�";
        motor[12].Cevap2 = "End�ksiyon bobini";
        motor[12].Cevap3 = "Konjekt�r";
        motor[12].Cevap4 = "Sigorta";
        motor[12].dogruIndex = 2;
        motor[13].Soru =
            "A�a��dakilerden hangisi ak�n�n kendili�inden bo�almas�na neden olur?";
        motor[13].Cevap = "Kutup ba�lar�n�n s�k� olmas�";
        motor[13].Cevap2 = "Kutup ba�lar�n�n temiz olmas�";
        motor[13].Cevap3 = "Ak� reklam etiketinin y�rt�lmas�";
        motor[13].Cevap4 = "�st k�sm�nda pisliklerin birikmesi";
        motor[13].dogruIndex = 4;
        motor[14].Soru =
            "Arac�n elektrik devresinde, ak�m y�ksek oldu�unda eriyerek g�venli�i sa�layan par�a a�a��dakilerden hangisidir?";
        motor[14].Cevap = "Ak�";
        motor[14].Cevap2 = "Platin";
        motor[14].Cevap3 = "Alternat�r";
        motor[14].Cevap4 = "Sigorta";
        motor[14].dogruIndex = 4;

        for (int i = 0; i < 15; i++)
        {
            motorList.Add(motor[i]);
        }


        adab[0].Soru =
            "Geceleyin �n�ndeki arac� ge�mek isteyen s�r�c�, bu ara�la yan yana gelinceye kadar hangi ���klar� kullanmal�d�r?";
        adab[0].Cevap = "Yak�n� g�steren ���klar�";
        adab[0].Cevap2 = "Uza�� g�steren ���klar�";
        adab[0].Cevap3 = "Acil uyar� ���klar�n�";
        adab[0].Cevap4 = "Sis ���klar�n�";
        adab[0].dogruIndex = 1;
        adab[1].Soru =
            "Park h�lindeki araca �arpan s�r�c�n�n a�a��dakilerden hangisini yapmas� yanl��t�r?";
        adab[1].Cevap = "Trafik g�revlisine haber vermesi";
        adab[1].Cevap2 = "Zarar verdi�i arac�n sahibini bulmas�";
        adab[1].Cevap3 = "Zarar fazla de�ilse olay yerinden uzakla�mas�";
        adab[1].Cevap4 = "Arac�n sahibini bulamaz ise yaz�l� bilgi b�rakmas�";
        adab[1].dogruIndex = 3; 
        adab[2].Soru =
            "A�a��dakilerden hangisi �zel ara�lar�n gereksiz kullan�lmas�n�n sonu�lar�ndand�r?";
        adab[2].Cevap = "Trafik yo�unlu�unun azalmas�";
        adab[2].Cevap2 = "Trafik yo�unlu�unun artmas�";
        adab[2].Cevap3 = "G�r�lt� kirlili�inin �nlenmesi";
        adab[2].Cevap4 = "Yak�t t�ketiminin azalmas�";
        adab[2].dogruIndex = 2;
        adab[3].Soru =
            "S�r�c�lerin ta��t yolunun sol �eridinde a�a��dakilerden hangisini yapmas� yasakt�r?";
        adab[3].Cevap = "Yava�lamas�";
        adab[3].Cevap2 = "Vites k���ltmesi";
        adab[3].Cevap3 = "Yolcu indirip bindirmesi";
        adab[3].Cevap4 = "Uygun h�zla seyretmesi";
        adab[3].dogruIndex = 3;
        adab[4].Soru =
            "A�a��dakilerden hangisi �evre kirlili�ine yol a�ar?";
        adab[4].Cevap = "M�mk�n oldu�unca otob�s, vapur, tren, metro gibi toplu ta��ma ara�lar�n�n kullan�lmas�";
        adab[4].Cevap2 = "Bak�ms�z ara�lardan yere (ya�, su vb.) s�z�nt� olmas�";
        adab[4].Cevap3 = "Tehlikeli maddelerin usul�ne uygun ta��nmas�";
        adab[4].Cevap4 = "Ara� bak�mlar�n�n s�relerinde yap�lmas�";
        adab[4].dogruIndex = 2;
        adab[5].Soru =
            "A�a��dakilerden hangisi g�zl�k veya lens kullanarak g�rme yeterlili�ine sahip olan s�r�c�ler i�in do�rudur?";
        adab[5].Cevap = "Bu t�r adaylara s�r�c� belgesi verilmez.";
        adab[5].Cevap2 = "Ara� kullan�rken g�zl�k veya lenslerini kullanmak zorundad�rlar.";
        adab[5].Cevap3 = "Yaln�zca �ehir d��� yollarda g�zl�k veya lens kullanmak zorundad�rlar.";
        adab[5].Cevap4 = "Yaln�zca gece ara� kullan�rken g�zl�k veya lens kullanmak zorundad�rlar.";
        adab[5].dogruIndex = 2;
        adab[6].Soru =
            "I- Korkutmak veya �a��rtmak" +
            "II - Su, �amur ve benzerlerini s��ratmak, atmak ve d�kmek" +
            "III - Keyfi davran��larda bulunmak suretiyle yaya veya ara� trafi�ini tehlikeye d���rmek" +
            "S�r�c�lerin yukar�daki davran��lar�ndan hangileri, ki�ilere zarar verecek tedbirsiz ve sayg�s�z davran��lar kapsam�na girer ? ";
        adab[6].Cevap = "Yaln�z I";
        adab[6].Cevap2 = "I ve II";
        adab[6].Cevap3 = "II ve III";
        adab[6].Cevap4 = "I, II ve III";
        adab[6].dogruIndex = 4;
        adab[7].Soru =
            "�zerinde de�i�iklik yap�l�p da s�resi i�inde bildirilmeyen ara�lara, de�i�iklik belgeledirilip tescil kurulu�unda tescil edilinceye kadar a�a��dakilerden hangisi uygulan�r?";
        adab[7].Cevap = "Trafikten men";
        adab[7].Cevap2 = "Hurdaya ay�rma";
        adab[7].Cevap3 = "S�r�c�s�ne a��r hapis";
        adab[7].Cevap4 = "Ba�kas�na devir etme �art�";
        adab[7].dogruIndex = 1;
        adab[8].Soru =
            "A�a��dakilerden hangisi �evre kirlili�ini �nleme a��s�ndan olumlu bir davran��t�r?";
        adab[8].Cevap = "�ni� e�imli yollarda motorun durdurulmas�";
        adab[8].Cevap2 = "Bak�m s�ras�nda ��kan eski par�a ve malzemelerin �evreye bilin�sizce b�rak�lmamas�";
        adab[8].Cevap3 = "Ta��tlarda kalitesiz yak�tlar�n kullan�lmas�";
        adab[8].Cevap4 = "Ta��tlardan d��ar�ya malzeme at�lmas�";
        adab[8].dogruIndex = 2;

        for (int i = 0; i < 9; i++)
        {
            adabList.Add(adab[i]);
        }
    }

}
