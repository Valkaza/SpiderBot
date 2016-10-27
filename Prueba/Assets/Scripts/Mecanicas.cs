using UnityEngine;
using System.Collections;

public class Mecanicas : MonoBehaviour 
{
	private CharacterController controller;
	public float speed = 6.0f;
	public float jumpSpeed = 2.0f;
    public float turnSpeed = 60.0f;
	private Vector3 moveDirection = Vector3.zero;
	public float gravity = 20.0f;

	private Animator animacion;

	// Use this for initialization
	void Start () 
	{
		controller = GetComponent <CharacterController>();
		animacion = GetComponentInChildren<Animator>();
	}

	// Update is called once per frame
	void Update () 
	{
		float turn = Input.GetAxis("Horizontal");
		transform.Rotate(0, turn * turnSpeed * Time.deltaTime, 0);

		if(controller.isGrounded)
		{
			moveDirection = transform.forward * Input.GetAxis("Vertical") * speed; //Player Input
            float setSpeed = controller.velocity.magnitude + Mathf.Abs(turn);
            animacion.SetFloat("speed", setSpeed);

        }
		if (Input.GetButtonDown("Jump"))
			moveDirection.y = jumpSpeed;

		if (Input.GetButtonDown ("Jump"))
			animacion.SetTrigger("saltito");
		




		controller.Move(moveDirection * Time.deltaTime);

		//Apply gravity
		moveDirection.y -= gravity * Time.deltaTime;
	}




}
