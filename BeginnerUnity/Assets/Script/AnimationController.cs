using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            anim.SetBool("isWalking", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("isJump");
        }
    }
}
