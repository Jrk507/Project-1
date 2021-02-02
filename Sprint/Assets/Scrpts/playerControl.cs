using UnityEngine;

public class playerControl : MonoBehaviour

{
    public float MovementSpeed = 1;
    private void Start()
    {
    }
    private void Update()
    {
        var moveHorizontal = Input.GetAxis("Horizontal");
        var moveVertical = Input.GetAxis("Vertical");
        transform.position += new Vector3(moveHorizontal, 0, 0) * Time.deltaTime * MovementSpeed;
        transform.position += new Vector3(0, moveVertical, 0) * Time.deltaTime * MovementSpeed;
    }
}

