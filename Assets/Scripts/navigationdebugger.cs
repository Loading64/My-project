using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    [RequireComponent(typeof(LineRenderer))]
public class navigationdebugger : MonoBehaviour
{
    [SerializeField]
    public UnityEngine.AI.NavMeshAgent agenttodebug;
    private LineRenderer lineRenderer;
    // Start is called before the first frame update
    void Start()
    {
        agenttodebug = GameObject.FindGameObjectWithTag("follower").GetComponent<UnityEngine.AI.NavMeshAgent>();
        lineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (agenttodebug.hasPath)
        {
            lineRenderer.positionCount = agenttodebug.path.corners.Length;
            lineRenderer.SetPositions(agenttodebug.path.corners);
            lineRenderer.enabled = true;
        }
        else
        {
            lineRenderer.enabled = false;
        }
        
    }
}
