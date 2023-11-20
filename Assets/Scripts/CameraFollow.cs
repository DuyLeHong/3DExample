using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;  // Độ chênh lệch giữa camera và đối tượng mục tiêu

    void LateUpdate()
    {
        if (target != null)
        {
            // Tính toán vị trí mới của camera dựa trên vị trí của đối tượng mục tiêu và offset
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;

            // Camera nhìn về đối tượng mục tiêu
            transform.LookAt(target);
        }
    }
}
