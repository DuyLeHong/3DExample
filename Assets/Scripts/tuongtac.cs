using UnityEngine;

public class tuongtac : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        // Lấy giá trị đầu vào từ bàn phím
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        // Tính toán hướng di chuyển
        Vector3 movement = new Vector3(horizontal, 0f, vertical).normalized;

        // Tính toán vị trí mới
        Vector3 newPosition = transform.position + movement * speed * Time.deltaTime;

        // Di chuyển đối tượng đến vị trí mới
        transform.position = newPosition;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "cay")
        {
            Debug.Log("Va cham cay");
        }
        else if (collision.gameObject.tag == "nui")
        {
            Debug.Log("Va cham nui");
        }
        else if (collision.gameObject.tag == "dat")
        {
            Debug.Log("Va cham dat");
        }
        else
        {
            Debug.Log("va cham");
        }
    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "cay")
        {
            Debug.Log("Trigger - Va cham cay");
        }
        else if (other.tag == "nui")
        {
            Debug.Log("Trigger - Va cham nui");
        }
        else if (other.tag == "dat")
        {
            Debug.Log("Trigger - Va cham dat");
        }
        else
        {
            Debug.Log("Trigger - va cham");
        }
    }
}
