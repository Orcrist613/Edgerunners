using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bilgiyazisi : MonoBehaviour
{
    // Unity sahnesindeki metin nesnesi
    public Text metinNesnesi;

    // Yazýlacak kýsa kýsa metinlerin listesi
    private string[] kisaYazilar = {
        "Doðayý korumak hepimizin görevidir.",
        "Geri dönüþüm, geleceðe yapýlan bir yatýrýmdýr.",
        "Suyu israf etmeyin, gelecek nesillere býrakýn.",
        "Atýklarý ayrýþtýrmak çevreye verilen önemli bir hediyedir.",
        "Doða dostu olmak, geleceðimizi güvence altýna almaktýr.",
        "Plastik kullanýmýný azaltmak, okyanuslara verdiðimiz zararý azaltýr.",
        "Yeniden kullan, geri dönüþüm yap, dünyayý koru!",
        "Her adýmýnýz çevrenizdeki dünyayý etkiler, bilinçli adýmlar atýn.",
        "Sürdürülebilirlik bir seçenek deðil, bir zorunluluktur.",
        "Gelecek nesillere yaþanabilir bir dünya býrakmak için bugün adým atýn."
    };

    // Son gösterilen kýsa yazýnýn indeksi
    private int sonIndex = -1;

    void Start()
    {
        // Baþlangýçta ilk kýsa yazýyý göster
        MetniGuncelle();
    }

    void Update()
    {
        // Sol týk algýlama
        if (Input.GetMouseButtonDown(0))
        {
            // Rastgele bir kýsa yazý indeksi seç ve ekrana yazdýr
            int randomIndex = Random.Range(0, kisaYazilar.Length);

            // Rastgele indeksin son indeksle ayný olmadýðýndan emin ol
            while (randomIndex == sonIndex)
            {
                randomIndex = Random.Range(0, kisaYazilar.Length);
            }

            MetniGuncelle();
        }
    }

    // Metni ekrana yazdýran fonksiyon
    void MetniGuncelle()
    {
        // Rastgele bir indeks seç
        int randomIndex = Random.Range(0, kisaYazilar.Length);

        // Seçilen indeksin son indeksle ayný olmadýðýndan emin ol
        while (randomIndex == sonIndex)
        {
            randomIndex = Random.Range(0, kisaYazilar.Length);
        }

        // Belirtilen indeksteki kýsa yazýyý göster
        metinNesnesi.text = kisaYazilar[randomIndex];

        // Son indeksi güncelle
        sonIndex = randomIndex;
    }
}
