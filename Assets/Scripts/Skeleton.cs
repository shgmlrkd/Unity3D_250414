using UnityEngine;

public class Skeleton : MonoBehaviour
{
    public Transform player;
    private float skeletonMoveSpeed = 3.0f;
    private float skeletonRotateSpeed = 5.0f;

    void Start()
    {
        
    }

    void Update()
    {
        if (player != null)
        {
            Vector3 direction = player.position - transform.position;
            direction.y = 0;

            if (direction.sqrMagnitude > 0.01f)
            {
                transform.position += direction.normalized * skeletonMoveSpeed * Time.deltaTime;

                Quaternion targetRotation = Quaternion.LookRotation(direction);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * skeletonRotateSpeed);
            }
        }
    }
}
