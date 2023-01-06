using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : MonoBehaviour
{
    private Rigidbody rbd;
    private float moveSpeed = 100f;

    public IPlayerInput PlayerInput { get; set; }

    private void Awake()
    {
        rbd = GetComponent<Rigidbody>();
        rbd.useGravity= false;
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = PlayerInput.Vertical;
        rbd.AddForce(0,0,vertical* moveSpeed);
    }
}
