using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
         float moveX = Input.GetAxis("Horizontal"); // ← →
        float moveZ = Input.GetAxis("Vertical");   // ↑ ↓

        Debug.Log(moveX);

        Vector3 move = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;
        transform.Translate(move, Space.World);
    }
}
