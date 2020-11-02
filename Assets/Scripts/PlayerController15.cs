using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class PlayerController15 : MonoBehaviour
{
    bool isOnGround = true;

    float jumpForce = 10.0f;
    float gravityModifier = 2.0f;

    Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;

        playerRb = GetComponent<Rigidbody>();
        playerRdr = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerJump;
    }

    private void OnCllisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("GamePlane"))
        {
            isOnGround = true;

            playerRdr.material.color = playerMtrs[4].color;
        }
    }

    private void PlayerJump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;

            playerRdr.material.color = playerMtrs[2].color;
        }
    }
}
