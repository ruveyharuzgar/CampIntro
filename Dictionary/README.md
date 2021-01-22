# Dictionary
### Explanation


class MyDictionary<T>
{
< pre >
//Satır 9:Tipini main de belirteceğim şimdilik de T ile adlandırdığım bir dizi yapısı tanımladım.Bunu fonksiyona iş yapması için göndericem,kullanıcağım dizim.
//Satır 14:Bir list yapısı oluşturduğum an bu satırı tekrar görücez ve dizi sıfırlanıcak.
 OUTPUT: 
        Constractur çalıştı.Dizi sıfırlandı.
//Satır 18:Her Add methodu çalıştığında yeni bir değer eklendi çıktısı aldık.Sadece hangi adımda olduğunu anlamak için.
//Satır 19:Dizimin referansı değiştiği an eski referansımı yeni bir adrese atayalım ki 
//Garbage Collector alıp yok etmesin.
 
//Satır 20:İşte burda ki new'leme ile referansım değişeceği için; yukarda ki satırı yazdık.

//Satır 24:Eski referansımızda ki değerleri alıp kendi list'imize topluyoruz.

//Satır 27:Methoda eklenmesi istediğimiz değeri tipini belirlediğim kendi dizim values[] in son indisine eklemesini istedim.

//Satır 32:T tipinde oluşturduğumuz Show methodu ile values'e gelen tüm değerleri get diyerek, okuyoruz.

}

Main
{
//Satır 9:Göndereceğim değer tipimi ve nesnemi oluşturdum.
//Methoduma ekleyeceğim değerleri gönderdim 
//Satır 14:Tüm değerleri yazdırması için oluşturduğum Show methodunu bir döngü ile yazdırması istedim.

 OUTPUT: 
Ekleme methodu çalıştı.

Ekleme methodu çalıştı.

Ekleme methodu çalıştı.

Eklendi->Ayşe

Eklendi->Ali

Eklendi->Ahmet

}
< /pre >