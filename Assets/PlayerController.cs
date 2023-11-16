using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Animator thisAnim;
    public float groundDistance = .3f;
    private Rigidbody rigid;
    public LayerMask whatIsGround;
    public float JumpForce = 50;
    // Start is called before the first frame update
    void Start()
    {
        thisAnim = GetComponent<Animator>();
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var h = Input.GetAxis("Horizontal");
        var v = Input.GetAxis("Vertical");
        thisAnim.SetFloat("Speed", v);
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * JumpForce);
            thisAnim.SetTrigger("Jump");
        }
    }
}
