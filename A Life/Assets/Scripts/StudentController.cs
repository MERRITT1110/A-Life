using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentController : MonoBehaviour
{
    public float speed = 3.0f;

    Rigidbody2D rigidbody2d;

    float GradeScale;
    float LinkedonConnection;
    float horizontal;
    float vertical;
    private int maxStamina = 100;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        GradeScale = 0;
        LinkedonConnection = 0;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }
    public int getMaxStamina()
    {
        return this.maxStamina;
    }

    public void setMaxStamina(int a)
    {
        this.maxStamina = a;
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontal * Time.deltaTime;
        position.y = position.y + speed * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
}
