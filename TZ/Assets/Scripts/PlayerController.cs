using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private UI ui;
    public float moveSpeed = 4f; 
    public float strafeSpeed = 30f; 

    private float eulerY;
    private bool isMoving = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UI.Instance.UIStart();
            isMoving = true;
        }

        /*if (Input.GetMouseButtonUp(0))
        {
            isMoving = false;
        }*/

        if (isMoving)
        {
            //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
            Vector3 newPosition = transform.position + transform.forward * Time.deltaTime * moveSpeed;
            newPosition.x = Mathf.Clamp(newPosition.x , -2.5f, 2.5f);
            transform.position = newPosition;

            float mouseX = Input.GetAxis("Mouse X"); 
            transform.Translate(Vector3.right * mouseX * strafeSpeed * Time.deltaTime);

            eulerY += mouseX;
            eulerY = Mathf.Clamp(eulerY,-40f,40f);
            transform.eulerAngles = new Vector3(0,eulerY,0);
        }
    }
}