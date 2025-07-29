using UnityEngine;

public class CanController : MonoBehaviour
{
    public int maxCan = 100;
    public int gecerliCan;


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
}
