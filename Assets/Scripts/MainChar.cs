using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class MainChar : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField]
    protected float _maxSpeed = 10;
    [SerializeField]
    protected float _speed;
    [SerializeField]
    protected Vector3 _direction;
    private MC _controls;


    public Rigidbody GetRigidbody => _rigidbody ? _rigidbody : _rigidbody = gameObject.GetComponent<Rigidbody>();
    public Vector3 GetDirection { get => _direction.normalized; set { _direction = value.normalized; } }

    public void Awake()
    {
        _controls = new MC();
        _controls.Reporter.Move.performed += ctx => { OnMove(); };
        _controls.Reporter.Move.canceled += ctx => { OnMoveStop(); };
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    void OnMove()
    {
        GetDirection = (Vector3)_controls.Reporter.Move.ReadValue<Vector2>();
        _speed = _controls.Reporter.Move.ReadValue<Vector2>().magnitude * _maxSpeed;
    }
    void OnMoveStop()
    {
        _speed = 0;
    }

    // Update is called once per frame
    virtual protected void Update()
    {
        GetRigidbody.MovePosition(GetRigidbody.position + transform.TransformDirection(GetDirection * Time.fixedDeltaTime * _speed));
        transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.y);
    }

    public void OnEnable()
    {
        _controls.Enable();
    }

    public void OnDisable()
    {
        _controls.Disable();
    }


#if UNITY_EDITOR
    public void Validate() => OnValidate();
    public virtual void OnValidate()
    {
        _direction = _direction.normalized;
    }
#endif
}
