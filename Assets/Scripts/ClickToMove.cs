using UnityEngine;

public class ClickToMove : MonoBehaviour 
{
	RaycastHit hitInfo;
	public UnityEngine.AI.NavMeshAgent agent;

	void Start () 
	{
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	void Update () 
	{
		if(Input.GetMouseButtonDown(0)) 
		{
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo))
			{
				agent.destination = hitInfo.point;
			}
		}
	}
}