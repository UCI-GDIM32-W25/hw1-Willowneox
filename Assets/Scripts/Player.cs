using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private GameObject _plantPrefab;
    [SerializeField] private int _numSeeds = 5; 
    [SerializeField] private PlantCountUI _plantCountUI;

    private int _numSeedsLeft = 5;
    private int _numSeedsPlanted = 0;

    private void Start ()
    {
        _numSeedsLeft = _numSeeds;
        _numSeedsPlanted = 0;
        if (_playerTransform == null)
        {
            _playerTransform = this.transform;
        }
        
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f) * _speed * Time.deltaTime;
        _playerTransform.position += movement;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlantSeed();
        }

    }

    public void PlantSeed ()
    
    {
        if (_numSeedsLeft <= 0)
        {
            return;
        }

        if  (_numSeedsLeft>0)
            Instantiate(_plantPrefab, _playerTransform.position, Quaternion.identity);
       
        _numSeedsLeft--;
        _numSeedsPlanted++;
       
        _plantCountUI.UpdateSeeds(_numSeedsLeft, _numSeedsPlanted);

        Debug.Log($"Seeds Left: {_numSeedsLeft}, Seeds Planted: {_numSeedsPlanted}");
       
    }
}
