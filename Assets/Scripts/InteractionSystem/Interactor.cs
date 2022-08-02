using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Interactor : MonoBehaviour
{
    public KeyCode UseKey = KeyCode.E;

    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRadius = 0.5f;
    [SerializeField] private LayerMask _interactionMask;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;

    private void Update() {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _colliders, _interactionMask);
        if (_numFound > 0)
        {
            var interactable = _colliders[0].GetComponent<IInteractable>();
            if (interactable != null && Input.GetKeyDown(UseKey))
            {
                interactable.Interact(this);
            }
        }
    }
    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
    }

}
