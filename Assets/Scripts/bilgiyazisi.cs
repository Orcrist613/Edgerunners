using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bilgiyazisi : MonoBehaviour
{
    // Unity sahnesindeki metin nesnesi
    public Text metinNesnesi;

    // Yaz�lacak k�sa k�sa metinlerin listesi
    private string[] kisaYazilar = {
        "Do�ay� korumak hepimizin g�revidir.",
        "Geri d�n���m, gelece�e yap�lan bir yat�r�md�r.",
        "Suyu israf etmeyin, gelecek nesillere b�rak�n.",
        "At�klar� ayr��t�rmak �evreye verilen �nemli bir hediyedir.",
        "Do�a dostu olmak, gelece�imizi g�vence alt�na almakt�r.",
        "Plastik kullan�m�n� azaltmak, okyanuslara verdi�imiz zarar� azalt�r.",
        "Yeniden kullan, geri d�n���m yap, d�nyay� koru!",
        "Her ad�m�n�z �evrenizdeki d�nyay� etkiler, bilin�li ad�mlar at�n.",
        "S�rd�r�lebilirlik bir se�enek de�il, bir zorunluluktur.",
        "Gelecek nesillere ya�anabilir bir d�nya b�rakmak i�in bug�n ad�m at�n."
    };

    // Son g�sterilen k�sa yaz�n�n indeksi
    private int sonIndex = -1;

    void Start()
    {
        // Ba�lang��ta ilk k�sa yaz�y� g�ster
        MetniGuncelle();
    }

    void Update()
    {
        // Sol t�k alg�lama
        if (Input.GetMouseButtonDown(0))
        {
            // Rastgele bir k�sa yaz� indeksi se� ve ekrana yazd�r
            int randomIndex = Random.Range(0, kisaYazilar.Length);

            // Rastgele indeksin son indeksle ayn� olmad���ndan emin ol
            while (randomIndex == sonIndex)
            {
                randomIndex = Random.Range(0, kisaYazilar.Length);
            }

            MetniGuncelle();
        }
    }

    // Metni ekrana yazd�ran fonksiyon
    void MetniGuncelle()
    {
        // Rastgele bir indeks se�
        int randomIndex = Random.Range(0, kisaYazilar.Length);

        // Se�ilen indeksin son indeksle ayn� olmad���ndan emin ol
        while (randomIndex == sonIndex)
        {
            randomIndex = Random.Range(0, kisaYazilar.Length);
        }

        // Belirtilen indeksteki k�sa yaz�y� g�ster
        metinNesnesi.text = kisaYazilar[randomIndex];

        // Son indeksi g�ncelle
        sonIndex = randomIndex;
    }
}
