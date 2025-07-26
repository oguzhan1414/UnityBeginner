
using UnityEngine;

public class HaraketManager : MonoBehaviour
{
    //Vector3.Lerp(vector3 a,vector3 b , float t) t = 0 iken başlangıç 1 olduğunda hedefe varır movetwordstan farkı soft haraket eder sona doğru yavaşlar yani 

    public Transform hedef;
    public float speed = 1f;

    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, hedef.position, speed * Time.deltaTime);
    }
}
