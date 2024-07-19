Console.WriteLine("Lutfen asagidaki bilgileri giriniz:");

Console.Write("T.C. Kimlik Numarasi: ");
string TcNo = Console.ReadLine(); // Karakterlerden oluşan metinsel veri olduğu için string kullanıldı.

Console.Write("Adi: ");
string adi = Console.ReadLine(); // Karakterlerden oluşan metinsel veri olduğu için string kullanıldı.

Console.Write("Soyadi: ");
string soyadi = Console.ReadLine(); // Karakterlerden oluşan metinsel veri olduğu için string kullanıldı.

Console.Write("Telefon Numarasi: ");
string telNo = Console.ReadLine(); // Matematiksel bir işlem olmayacağı için string kullanıldı.

Console.Write("Yas: ");
int yas = Convert.ToInt32(Console.ReadLine()); // Matematiksel değerler default olarak int türünde kullanıldığı için byte verme gereği duymadım. 

Console.Write("Ilk aldigi urun fiyati: ");
double fiyat1 = Convert.ToDouble(Console.ReadLine()); // ondalık değere sahip bir fiyat girilme durumuna karşılık double türü kullanıldı.

Console.Write("Ikinci aldigi urun fiyati: ");
double fiyat2 = Convert.ToDouble(Console.ReadLine()); // ondalık değere sahip bir fiyat girilme durumuna karşılık double türü kullanıldı.

double toplam = fiyat1 + fiyat2;
double puan = toplam * 0.1;


Console.WriteLine("-----------------------------------------------");

Console.WriteLine($"{TcNo} T.C. numaralı {adi} {soyadi} isimli kisi icin kayit olusturulmustur.");
Console.WriteLine($"{telNo} telefon numarasina bildirim gonderilmistir.");
Console.WriteLine($"{toplam} toplam harcama karsiligi kazanilan %10 Patika puan miktari : {puan}");

