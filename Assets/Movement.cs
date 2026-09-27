using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;
        transform.position += movement * moveSpeed * Time.deltaTime;

    }
}
