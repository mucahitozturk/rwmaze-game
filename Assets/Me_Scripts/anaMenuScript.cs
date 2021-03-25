using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Sahneler arası geçiş yapabilmek için bu kütüphaneyi ekliyoruz.
using UnityEngine.UI;
public class anaMenuScript : MonoBehaviour
{
    [Header("MenüSayfalari")]
    public GameObject ayarlarEkran;
    public GameObject hakkindaEkran;
    public GameObject anaEkran;
    public GameObject oyunAmaciEkran;
    public GameObject yapimcilarEkran;
    public GameObject oyunEkrani;

    [SerializeField]
    public AudioSource audioSource;
    public AudioClip butonClick;



    public void YeniOyun()
    {
        if (PlayerPrefs.GetInt("sesDurumu") == 1)
            audioSource.PlayOneShot(butonClick);

        // Oyunu başlatmak için oluşturduk.
        SceneManager.LoadScene("Level1");
    }

    public void Oyun()
    {
        anaEkran.SetActive(false);
        oyunEkrani.SetActive(true);
    }

    public void OyunBackMenu()
    {
        anaEkran.SetActive(true);
        oyunEkrani.SetActive(false);
    }

    public void Ayarlar()
    {
        anaEkran.SetActive(false);
        ayarlarEkran.SetActive(true);
    }

    public void ayarBackMenu()
    {
        anaEkran.SetActive(true);
        ayarlarEkran.SetActive(false);
    }

    public void Hakkinda()
    {
        anaEkran.SetActive(false);
        hakkindaEkran.SetActive(true);
    }

    public void hakkindaBackMenu()
    {
        anaEkran.SetActive(true);
        hakkindaEkran.SetActive(false);
    }

    public void OyunAmaci()
    {
        hakkindaEkran.SetActive(false);
        oyunAmaciEkran.SetActive(true);
    }

    public void OyunAmaciBackMenu()
    {
        hakkindaEkran.SetActive(true);
        oyunAmaciEkran.SetActive(false);
    }

    public void Yapimcilar()
    {
        hakkindaEkran.SetActive(false);
        yapimcilarEkran.SetActive(true);
    }

    public void YapimcilarBackMenu()
    {
        hakkindaEkran.SetActive(true);
        yapimcilarEkran.SetActive(false);
    }

    public void SesAc()
    {
        PlayerPrefs.SetInt("sesDurumu", 1);
        audioSource.PlayOneShot(butonClick);
    }

    public void SesKapat()
    {
        PlayerPrefs.SetInt("sesDurumu", 0);
        audioSource.Stop();
    }

    public void Cikis()
    {
        audioSource.Stop();
        Application.Quit();
    }
}
