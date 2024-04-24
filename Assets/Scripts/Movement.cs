using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float speed = 5;

    [SerializeField] private Joystick joystick;

    private bool _canStep;

    private JoystickController _joystickController;
    private Rigidbody2D _rb;
    private void Awake()
    {
        _joystickController = joystick.GetComponent<JoystickController>();
        _rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _canStep = true;
    }
    private void FixedUpdate()
    {
        Move();
    }
    private void Move()
    {
        Vector2 moveMobile = new Vector3(joystick.Horizontal * speed, joystick.Vertical * speed);
        _rb.velocity = moveMobile * Time.fixedDeltaTime;
    }
}
