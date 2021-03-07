using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovientoPJ : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 2.0f;
    private Vector3 offset;
    public GameObject Jugador;

    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
        offset = transform.position - Jugador.transform.position;
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        playerVelocity = Vector3.ClampMagnitude(playerVelocity, 1);
        controller.Move(move * Time.deltaTime * playerSpeed);

        controller.Move(playerVelocity * Time.deltaTime);
    }

    void LateUpdate()
    {
        transform.position = Jugador.transform.position + offset;
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }
}
