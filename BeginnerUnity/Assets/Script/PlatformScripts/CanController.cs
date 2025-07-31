using UnityEngine;

public class CanController : MonoBehaviour
{
    public int maxCan = 100;
    public int gecerliCan;

    public int toplamPuan = 0;
    void Start()
    {
        gecerliCan = maxCan;
    }

    public void HasarAl(int hasarMiktari)
    {
        gecerliCan -= hasarMiktari;
        if (gecerliCan <= 0)
        {
            gecerliCan = 0;
            gameObject.SetActive(false); //görünürlüğünü kapatıyoruz
        }
    }

    public void PuanAl(int puanMiktari)
    {
        toplamPuan += puanMiktari;
    }
}
