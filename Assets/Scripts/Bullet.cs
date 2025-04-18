using Unit;
using UnityEngine;
public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _lifeTime;
    [SerializeField] private float _thrust;
    [SerializeField] private int _damage;
    
    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Destroy(gameObject, _lifeTime);
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(transform.forward * _thrust);
    }

    private void OnCollisionEnter(Collision other)
    {
        var unit = other.gameObject.GetComponent<UnitView>();

        if (unit != null)
            unit.TakeDamage(_damage);
        Destroy(gameObject);
    }
}