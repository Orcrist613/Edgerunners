using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BodyCollider : MonoBehaviour
{
    public Slider HPBar;
    public GameObject OzetEkrani, Ses, BaslaT;
    public TextMeshProUGUI MesafeT, EngelT, CanT, DusmanT;
    public AttackCollider ACollider;
    public SpikeCounter Spike;
    public PlayerMovement Character;
    int Engeller, Can = 0;
    bool basla = false;
    public AudioSource Cit;
    public AudioSource HasarAlma;
    void Start()
    {
        HPBar.maxValue = Character.HP;
        HPBar.value = Character.HP;
        Time.timeScale = 0f;
    }
    void Update()
    {
        if (!basla)
        {
            if (Input.anyKeyDown)
            {
                BaslaT.SetActive(false);
                Time.timeScale = 1f;
                Ses.SetActive(true);
                basla = true;
            }
        }
        if (HPBar.value == 0)
        {
            //isAlive = false;

            Time.timeScale = 0;
            OzetEkrani.SetActive(true);
            Engeller = ACollider.Engel + Spike.Engel;
            MesafeT.text = "Koþulan Mesafe : " + ((int)Character.score).ToString("") + "m";
            EngelT.text = "Atlatýlan Engeller : " + Engeller.ToString("");
            //CanT.text = "Ýyileþilen Can : " + Can.ToString("");
            DusmanT.text = "Öldürülen Düþmanlar : " + ACollider.Dusman.ToString("");
            Ses.SetActive(false);
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Spike"))
        {
            HPBar.value -= 10;
            Cit.Play();
            Destroy(collision.gameObject);
            
            
        }
        /*if(collision.gameObject.CompareTag("Can"))
        {
            HPBar.value += 30;
            Can+=30;
        }*/
        if (collision.gameObject.CompareTag("Enemy"))
        {
            HPBar.value -= 15;
            HasarAlma.Play();
        }
    }
}
