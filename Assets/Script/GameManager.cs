using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class GameManager : MonoBehaviour
{
	public Transform[] trashSpawnLocations;
	public Transform[] bookSpawnLocations;
	public GameObject enemyObject;
	public GameObject bookObject;

	float trashBreakTime = 2f;
	float bookBreakTime = 5f;
	int side = 0;
	int spawnLocationIndex = 0;

	// Start is called before the first frame update
	

	void Start()
    {
		StartCoroutine("SpawnTrash");
		StartCoroutine("SpawnBook");
	}

	// Update is called once per frame
	void Update()
    {
        
    }

    IEnumerator SpawnTrash()
	{
		while(true)
		{
			spawnLocationIndex = Random.Range(0, trashSpawnLocations.Length);
			Instantiate(enemyObject, trashSpawnLocations[spawnLocationIndex].position, trashSpawnLocations[spawnLocationIndex].rotation);
			yield return new WaitForSeconds(trashBreakTime);
		}
	}

	IEnumerator SpawnBook()
	{
		while (true)
		{
			Instantiate(bookObject, bookSpawnLocations[spawnLocationIndex].position, bookSpawnLocations[spawnLocationIndex].rotation);
			yield return new WaitForSeconds(bookBreakTime);
		}
	}

	


}
