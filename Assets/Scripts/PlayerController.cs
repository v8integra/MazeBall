using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float maxRotation = 30f;
    public float rotationSpeed;
    public float mouseX, mouseY;
    
    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            RotateMaze();
        }
    }

    private void RotateMaze()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y");

        float rotateX = mouseX * rotationSpeed;
        float rotateZ = mouseY * rotationSpeed;

        rotateX = Mathf.Clamp(rotateX, -maxRotation, maxRotation);
        rotateZ = Mathf.Clamp(rotateZ, -maxRotation, maxRotation);

        transform.eulerAngles = new Vector3(rotateZ, transform.rotation.y, -rotateX);
    }
}
