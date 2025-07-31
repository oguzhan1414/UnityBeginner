using UnityEngine;

public class CoinManager : MonoBehaviour
{
    [SerializeField] int puanMiktari = 5;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<CanController>().PuanAl(puanMiktari);
            Destroy(gameObject);
        }
    }
}
