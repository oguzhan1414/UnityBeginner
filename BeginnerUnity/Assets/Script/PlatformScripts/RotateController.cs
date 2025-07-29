
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public Vector3 donusHizi = new Vector3(0, 45, 0);

    public Transform donecekTransform;

    void Update()
    {
        donecekTransform.Rotate(donusHizi * Time.deltaTime);
    }
}
