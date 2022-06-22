using UnityEngine;

public class Footsteps : MonoBehaviour

{
    [SerializeField] private Transform _leftFoot;
    [SerializeField] private Transform _rightFoot;
    [SerializeField] private float _maxRayDistance = 1f;

    [SerializeField] private LayerMask _cementLayerMask;
    [SerializeField] private LayerMask _woodLayerMask;
    [SerializeField] private LayerMask _defaultLayer;

    private void Start()
    {
        if (gameObject.layer == _defaultLayer)
        {
            Debug.Log("Layer detected");
        }
    }

    // private void FixedUpdate()
    // {
    //     Ray leftFootRay = new Ray(_leftFoot.position, Vector3.down);
    //     Ray rightFootRay = new Ray(_rightFoot.position, Vector3.down);
    //
    //     RaycastHit hit;
    //     
    //     Debug.DrawRay(_leftFoot.position, Vector3.down * _maxRayDistance);
    //     Debug.DrawRay(_rightFoot.position, Vector3.down * _maxRayDistance);
    //     
    //     if (Physics.Raycast(leftFootRay, out hit, _maxRayDistance))
    //     {
    //         if (hit.collider.gameObject.layer == _cementLayerMask)
    //         {
    //             //cement sound event;
    //         }
    //
    //         if (hit.collider.gameObject.layer == _woodLayerMask)
    //         {
    //             //wood sound event;
    //         }
    //     }
    //
    //     if (Physics.Raycast(rightFootRay, out hit, _maxRayDistance))
    //     {
    //         if (hit.collider.gameObject.layer == _cementLayerMask)
    //         {
    //             //cement sound event;
    //         }
    //
    //         if (hit.collider.gameObject.layer == _woodLayerMask)
    //         {
    //             //wood sound event;
    //         }
    //     }
    // }
}