using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody MyRb;
    public GameObject referencia;
    public int speed;
    public int maxSpeed;
    public float turnSpeed;
    public Animator anim;

    // Use this for initialization
	void Start () {

        MyRb = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	void Update () {

        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");


        // qye tenga una velocidad maxima
        if(MyRb.velocity.magnitude > maxSpeed)
        {
            MyRb.velocity = MyRb.velocity.normalized * maxSpeed;

        }

        // hace qye se ejecute la animacion
        if (MyRb.velocity.magnitude > 0)
        {
            anim.SetBool("Caminar", true);

        }else
        {
            anim.SetBool("Caminar", false);
        }


        //Rota al personaje
        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
        }


        //mueve al personaje para algun axis
        MyRb.AddForce(Horizontal * referencia.transform.forward * speed);
        MyRb.AddForce(Vertical * referencia.transform.right * speed);

	}
}
