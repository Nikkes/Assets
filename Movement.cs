using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{

    public float speed = 6.0F;
    public float speedDampTime = 0.1F;
    public float gravity = 20.0F;

    private Vector3 moveDirection = Vector3.zero;

    

    void Update(){
        CharacterController controller = GetComponent<CharacterController>();
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")); //No rigidbody only player controller
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= speed;

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    

}
