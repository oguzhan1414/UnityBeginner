using UnityEngine;

public class HVCharacterController : MonoBehaviour
{
    public float speed = 5f;
    Vector3 movement;
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal"); // 0-1 arasında -0-1 arasında sayı üretir
        float verticalInput = Input.GetAxis("Vertical");

        movement = new Vector3(horizontalInput, transform.position.y, verticalInput);
        transform.Translate(movement * speed * Time.deltaTime);
    }
}
