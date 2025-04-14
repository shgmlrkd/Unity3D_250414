using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    private float playerMoveSpeed = 6.0f;
    private float playerRotateSpeed = 12.0f;

    void Start()
    {
        
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(moveHorizontal, 0, moveVertical);

        if(dir.sqrMagnitude > 0 )
        {
            transform.position += dir * playerMoveSpeed * Time.deltaTime;

            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(dir), Time.deltaTime * playerRotateSpeed);
        }
    }
}
