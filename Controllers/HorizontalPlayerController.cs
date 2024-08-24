using UnityEngine;

public class HorizontalPlayerController : MonoBehaviour
{
    private float horizontalInput;
    
    public float speed;
    
    void Update()
    {
        // Get horizontal from keyboard
        horizontalInput = Input.GetAxis("Horizontal");
        
        // Move player right and left
        transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
    }
}
