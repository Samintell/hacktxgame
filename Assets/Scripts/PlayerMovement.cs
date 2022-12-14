using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] private float playerSpeed = 5.0f;
    [SerializeField] private float jumpPower = 5.0f;
    [SerializeField] private boolean forceRight = true;
    
    private Rigidbody2D _playerRigidbody;
    private void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody2D>();
        if (_playerRigidbody == null)
        {
            Debug.LogError("Player is missing a Rigidbody2D component");
        }

    }
    private void Update()
    {
        MovePlayer();

        if (Input.GetButton("Jump") && _playerRigidbody.velocity.y == 0){
            Jump();
    }
        /*if(OnCollisionEnter(death)){
            Destroy(_playerRigidbody);
        }*/
    }

    /*private bool OnCollisionEnter(Collision DeathPlane){
        return _playerRigidbody.position.y > DeathPlane + 0.1;
    }*/

    private void MovePlayer()
    {
        if (forceRight) {
            _playerRigidbody.velocity = new Vector2(playerSpeed, _playerRigidbody.velocity.y);
        } else {
            var horizontalInput = Input.GetAxisRaw("Horizontal");
            _playerRigidbody.velocity = new Vector2(horizontalInput * playerSpeed, _playerRigidbody.velocity.y);
        }
        
    }
    private void Jump() => _playerRigidbody.velocity = new Vector2( 0, jumpPower);

    /*private bool IsGrounded()
    {
        var groundCheck = Physics2D.Raycast(transform.position, Vector2.down, 0.7f);
        return groundCheck.collider != null && groundCheck.collider.CompareTag("Ground");
    }*/

   
}
