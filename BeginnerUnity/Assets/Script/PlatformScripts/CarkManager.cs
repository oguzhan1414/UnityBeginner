using UnityEngine;

public class CarkManager : MonoBehaviour
{
    public Transform carkObjesi;

    public float donusHizi = 100f;

    public float haraketHizi = 2f;

    public float maxPosition = 1.3f;
    public float minPosition = -1.3f;
    void Update()
    {
        carkObjesi.Rotate(Vector3.right * donusHizi * Time.deltaTime);

        float haraketYonu = Mathf.PingPong(Time.time * haraketHizi, maxPosition - minPosition) + minPosition;

        carkObjesi.transform.localPosition = new Vector3(carkObjesi.transform.localPosition.x, carkObjesi.transform.localPosition.y, haraketYonu);
    }
}
