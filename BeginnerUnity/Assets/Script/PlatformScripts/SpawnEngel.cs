using System.Collections;
using UnityEngine;

public class SpawnEngel : MonoBehaviour
{
    public GameObject objePrefab; //spwan edilecek nesne prefab klasöründen alcaz
    public float spawnAraligi = 4f;

    public float yokEtmeSuresi = 2f;

    private void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine() //belli araliklarla belli işlemler için IeNUMERATOR kullanılır
    {
        while (true)
        {
            SpawnObje();
            yield return new WaitForSeconds(spawnAraligi);
        }
    }


    void SpawnObje()
    {
        GameObject yeniEngel = Instantiate(objePrefab, transform.position, Quaternion.identity); //nesneyi oluşturmak için
        Destroy(yeniEngel, yokEtmeSuresi); //yok etmek için
    } 
}
