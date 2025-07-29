using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform hedef;
    Vector3 mesafe = Vector3.zero;
    public float takipHizi = 0.15f;
    void Start()
    {
        mesafe = transform.position - hedef.position;
    }
    void LateUpdate()
    {
        //transform.position = hedef.position + mesafe;
        Vector3 mevcutPos = transform.position;
        Vector3 hedefPos = new Vector3(mevcutPos.x, hedef.position.y + mesafe.y, hedef.position.z + mesafe.z);

        Vector3 yeniPozisyon = Vector3.Lerp(transform.position, hedefPos, takipHizi);
        transform.position = yeniPozisyon;
    }
}
