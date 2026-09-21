using UnityEngine;
using UnityEngine.InputSystem;

public class Hit : MonoBehaviour
{ 
    [SerializeField] private Animator _animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (_animator == null)
            _animator = GetComponent<Animator>();
    }

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    public void OnHit(InputValue value)
    {
        _animator.SetTrigger("hit");
    }

    public void OnChange(InputValue value)
    {
        _animator.SetTrigger("change");
    }
}
