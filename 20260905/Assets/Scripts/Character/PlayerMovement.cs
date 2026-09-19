using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;
    private PlayerControls _controls;

    private void Awake()
    {
        _controls = new PlayerControls();
    }

    private void OnEnable()
    {
        _controls.Player.Enable();
    }

    private void OnDisable()
    {
        _controls.Player.Disable();
    }

    private void Update()
    {
        Vector2 input = _controls.Player.Move.ReadValue<Vector2>();
        Vector3 move = new Vector3(input.x, input.y, 0).normalized;
        transform.position += move * _speed * Time.deltaTime;
    }
}
