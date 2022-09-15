using UnityEngine;

public class WayPointMovement : MonoBehaviour
{
    [SerializeField] private Transform _path;
    [SerializeField] private float _speed;

    private Transform[] _points;
    private Animator _animator;
    private const string _walkRight = "WalkRight";
    private const string _walkLeft = "WalkLeft";
    private int _currentPoint;

    private void Start()
    {
        _points = new Transform[_path.childCount];

        for (int i = 0; i < _path.childCount; i++)
        {
            _points[i] = _path.GetChild(i);
        }

        _animator = GetComponent<Animator>();
        _animator.SetTrigger(_walkRight);
    }

    private void Update()
    {
        Transform target = _points[_currentPoint];

        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _animator.ResetTrigger(_walkRight);
            _animator.SetTrigger(_walkLeft);

            _currentPoint++;

            if (_currentPoint >= _points.Length)
            {
                _currentPoint = 0;
            }

            _animator.SetTrigger(_walkRight);
        }
    }
}