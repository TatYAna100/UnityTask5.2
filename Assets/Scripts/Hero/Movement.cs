using UnityEngine;

public class Movement : MonoBehaviour
{
    private const string RunRight = "RunRight";
    private const string RunLeft = "RunLeft";

    [SerializeField] private Rigidbody2D _rigidbody2D;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(_speed * Time.deltaTime, 0, 0);
            _animator.SetTrigger(RunRight);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(_speed * Time.deltaTime * -1, 0, 0);
            _animator.SetTrigger(RunLeft);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x * Time.deltaTime, _jumpForce);
        }
    }
}