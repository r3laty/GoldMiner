using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class JoystickController : MonoBehaviour
{
    [HideInInspector] public bool TouchBegin;
    [SerializeField] private Movement player;
    [SerializeField] private Image childImage;

    private Transform _playerTransform;
    private Image _thisImage;
    private Color _imageColor;
    private RectTransform _rectTransform;
    private void Awake()
    {
        _playerTransform = player.transform;

        _thisImage = GetComponent<Image>();
        _rectTransform = GetComponent<RectTransform>();
    }
    private void Start()
    {
        //TurnJoystick(false);
    }

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Stationary)
            {
                print("touch phase stationary");
                //TurnJoystick(true);
            }
            else if (touch.phase == TouchPhase.Began)
            {
                print("touch phase began");
                Vector2 touchPosition = touch.position;

                //Vector2 screenPosition = Camera.main.WorldToScreenPoint(touchPosition);

                //Vector2 worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);

                _rectTransform.localPosition = touchPosition;
                print("Touch position: " + touch.position);
                print("RectTransform position: " + _rectTransform.localPosition);



            }
            else if (touch.phase == TouchPhase.Ended)
            {
                print("touch phase ended");

                //TurnJoystick(false);
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
