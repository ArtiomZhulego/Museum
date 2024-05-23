using UnityEngine;

public class Running : MonoBehaviour
{
    public float speed = 40f;

    private Animator animator;

    private GameObject character;

    private Rigidbody characterRigidbody;

    void Start()
    {
        character = GameObject.FindGameObjectWithTag("Player");

        characterRigidbody = character.GetComponent<Rigidbody>();

        if (characterRigidbody == null ) characterRigidbody = character.AddComponent<Rigidbody>();

        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        MovementLogic();
    }

    private void MovementLogic()
    {
        Vector3 move;

        float sensivity = PlayerPrefs.GetFloat("MouseSensitivity") * 5;

        float Horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * speed;

        float Vertical = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        if (Horizontal != 0 || Vertical != 0)
        {
            if (Vertical > 0.1)
            {
                animator.SetBool("IsRun", true);
            }
            else animator.SetBool("IsRun", false);

            if (Vertical < -0.1) animator.SetBool("BackRunning", true);
            else animator.SetBool("BackRunning", false);

            if (Horizontal > 0.1) animator.SetBool("RightRunning", true);
            else animator.SetBool("RightRunning", false);
            
            if (Horizontal < -0.1) animator.SetBool("LeftRunning", true);
            else animator.SetBool("LeftRunning", false);
        }

        move = transform.right * Horizontal + transform.forward * Vertical;

        characterRigidbody.velocity = move * speed;
    }
}
