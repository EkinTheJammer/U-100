using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f; // hareket hýzý
    [SerializeField] private float maxPositionX = 2f; // maksimum konum X ekseni deðeri
    private Vector2 _position;

    Vector3 firstPos, endPos;
    public float playerSpeed;
    public float forwardSpeed;
    Vector3 direction;

    private void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal"); // yatay girdi okunur
        float displacementX = inputX * moveSpeed * Time.deltaTime; // hareket mesafesi hesaplanýr

        Vector3 newPosition = transform.localPosition + new Vector3(displacementX, 0f, 0f); // yeni konum hesaplanýr

        newPosition.x = Mathf.Clamp(newPosition.x, -maxPositionX, maxPositionX); // konum X ekseni deðeri sýnýrlanýr

        transform.localPosition = newPosition; // nesne konumu güncellenir
    
        direction.z = forwardSpeed;

        if (Input.GetMouseButtonDown(0))
        {
            firstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float farkX = endPos.x - firstPos.x;
            transform.Translate(farkX * Time.deltaTime * playerSpeed /100, 0, 0);
        }
        if (Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;   
        }
    }

    private void FixedUpdate()
    {
        transform.Translate(0, 0, forwardSpeed * Time.fixedDeltaTime);
    }
}