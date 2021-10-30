using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ladrao : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField]
    protected float _speed;
    [SerializeField]
    protected Vector3 _direction;


    public Rigidbody GetRigidbody => _rigidbody ? _rigidbody : _rigidbody = gameObject.GetComponent<Rigidbody>();
    public Vector3 GetDirection { get => _direction.normalized; set { _direction = value.normalized; } }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    virtual protected void Update()
    {
        GetRigidbody.MovePosition(GetRigidbody.position + transform.TransformDirection(GetDirection * Time.fixedDeltaTime * _speed));
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
    }


#if UNITY_EDITOR
    public void Validate() => OnValidate();
    public virtual void OnValidate()
    {
        _direction = _direction.normalized;
    }
#endif
}
