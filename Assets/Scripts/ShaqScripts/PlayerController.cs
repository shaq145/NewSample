using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;

    private Rigidbody2D rgbd2d;
    private Vector2 movements;
    
    // Start is called before the first frame update
    void Start() {
        rgbd2d = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update() {
        movements.x = Input.GetAxisRaw ( "Horizontal" );
        rgbd2d.velocity = new Vector2 ( movements.x * moveSpeed, rgbd2d.velocity.y );
    }

}
