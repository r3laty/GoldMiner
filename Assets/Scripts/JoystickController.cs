using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class JoystickController : MonoBehaviour
{
    [HideInInspector] public bool TouchBegin;
    [SerializeField] private Movement player;
    [SerializeField] private Image childImage;

    private Image _thisImage;
    
    private Transform _playerTransform;
    private Color _imageColor;
    private void Awake()
    {
        _playerTransform = player.transform;

        _thisImage = GetComponent<Image>();
    }
    private void Start()
    {
        TurnJoystick(false);
    }

    private void Update()
    {
        MoveJoystick();

        ManageTouches();
    }
    private void MoveJoystick()
    {
        transform.position = _playerTransform.position + (Vector3.down * 1.5f);
    }

    private void ManageTouches()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Stationary)
            {
                TurnJoystick(true);
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                TurnJoystick(false);
            }
        }
    }

    private void TurnJoystick(bool variant)
    {
        _thisImage.enabled = variant;

        _imageColor = childImage.color;
        if (variant)
        {
            _imageColor.a = 1;
        }

        else if (!variant)
        {
            _imageColor.a = 0;
        }
        childImage.color = _imageColor;
    }
}
