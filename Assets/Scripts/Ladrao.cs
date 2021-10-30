using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Ladrao : MonoBehaviour
{
    private Rigidbody _rigidbody;
    [SerializeField]
    protected float _speed = 7.5f;
    [SerializeField]
    protected Vector3 _direction;
    [SerializeField]
    protected LadraoType _type;

    private const float FREQUENCY = 8f;
    private const float AMPLITUDE = 150f;
    private float _faseChange = 0;
    private float _timer = 0;
    private float _perpendicular = 0;




    public Rigidbody GetRigidbody => _rigidbody ? _rigidbody : _rigidbody = gameObject.GetComponent<Rigidbody>();
    public Vector3 GetDirection { get => _direction.normalized; set { _direction = value.normalized; } }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    virtual protected void FixedUpdate()
    {
        switch (_type) {
            case LadraoType.BOBO:
                //That's all folks
                break;
            case LadraoType.USUAL:
                _timer += Time.fixedDeltaTime;
                _perpendicular = AMPLITUDE * Mathf.Cos(_timer * FREQUENCY + _faseChange);
                GetDirection = ((Vector2)GetDirection + Vector2.Perpendicular(GetDirection) * _perpendicular).normalized;
                break;
            case LadraoType.ASTUTO:
                break;
        }
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

public enum LadraoType : short
{
    BOBO, USUAL, ASTUTO
}