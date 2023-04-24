using UnityEngine; 
using System.Collections;

public class Move : MonoBehaviour
{
	void Update()
	{
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, 200, transform.position.z), -0.05f);

    }
}