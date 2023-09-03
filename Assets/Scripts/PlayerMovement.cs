using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    

    public CharacterController2D controller;
    
    
    public float speed = 20f ;
    public bool jump = false ;
    private float horizontalMove = 0f;
    public Animator animator;
    
    
    private void Update()
    {
        //Logic of movement and jump
        horizontalMove = Input.GetAxisRaw("Horizontal") * speed;
        
        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            animator.SetBool("isJumping",true);
        }
        
    }

    public void OnLanding() => animator.SetBool("isJumping", false); //Playing animation when jumping

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;    //The logic in which it is impossible to jump again during the jump
    }
    
}
