using UnityEngine;

public class EngelManager : MonoBehaviour
{
    [SerializeField] int hasarMiktari;

    //İKİ NESNE ÇARPIŞTIĞI ANDA GERÇEKLEŞİR oncollisionda
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<CanController>().HasarAl(hasarMiktari);
        }
    }





    //iki nesnenin çarpışması devam ederken gerçekleşir
    void OnCollisionStay(Collision collision)
    {
        

    }

    //çarpışma bittikten sonra gerçekleşir
    void OnCollisionExit(Collision collision)
    {
        

    }

    //Box collider içinde triggerı açık olan içinden geçer ve trigger çalışır dost daha çok puan sistemlerinde kullanılır
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
        }
    }

}
