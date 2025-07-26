using UnityEngine;

public class RobotController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        Vector3 move = Vector3.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            move += Vector3.forward;
            //transform.Translate(0, 0, moveSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            move -= Vector3.forward; //burda += Vector3.back de diyebilridik
            //transform.Translate(0, 0, -moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            move += Vector3.right;
            //transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {

            move += Vector3.left;
            //transform.Translate(- moveSpeed * Time.deltaTime, 0, 0);
        }

        transform.Translate(move * moveSpeed * Time.deltaTime);
    }
}
