using UnityEngine;


public class InputController : MonoBehaviour
{
    private CharacterController controller;

    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        // If Oculus present
        //OVRInput.Update();
        //Vector3 movement = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);
        
        Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);
        controller.Move( Time.deltaTime * speed * movement);
    }
}
