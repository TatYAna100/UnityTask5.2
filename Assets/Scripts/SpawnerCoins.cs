using UnityEngine;

public class SpawnerCoins : MonoBehaviour
{
    [SerializeField] private Coin _coin;
    [SerializeField] private Transform _spawnPoint;

    private Transform[] _points;

    private void Start()
    {
        _points = new Transform[_spawnPoint.childCount];

        for (int i = 0; i < _spawnPoint.childCount; i++)
        {
            _points[i] = _spawnPoint.GetChild(i);
        }

        Spawn();
    }

    private void Spawn()
    {
        for (int i = 0; i < _points.Length; i++)
        {
            var spawnLocation = new Vector3(_points[i].position.x, _points[i].position.y, 0);

            Instantiate(_coin, spawnLocation, Quaternion.identity);
        }
    }
}