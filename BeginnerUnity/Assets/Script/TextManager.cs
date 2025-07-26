using UnityEngine;

public class TextManager : MonoBehaviour
{
    int gecenSure = 0;

    void Start()
    {
        InvokeRepeating("UpdateTimer", 1f, 1f);
    }
    void UpdateTimer()
    {
        gecenSure++;
        Debug.Log("Gecen Süre : " + gecenSure + "saniye");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopTimer();
        }
    }

    void StopTimer()
    {
        CancelInvoke("UpdateTimer");
        Debug.Log("Sayaç Durduruldu");
    }

}
