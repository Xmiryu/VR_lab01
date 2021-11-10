using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    private GameObject currentSpawnedObject;
    private List<GameObject> objectsOnScene = new List<GameObject>();
    
    public void Spawn()
    {
        currentSpawnedObject = Instantiate(prefabToSpawn,
        new Vector3(Random.Range(180, 920), Random.Range(112, 322), 110),
        Quaternion.identity);
        objectsOnScene.Add(currentSpawnedObject);
    }

    public void SetAsBlue()
    {
        currentSpawnedObject.GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    public void SetAsGreen()
    {
        currentSpawnedObject.GetComponent<MeshRenderer>().material.color = Color.green;
    }


    public void Update() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (var sceneObject in objectsOnScene)
            {
                Destroy(sceneObject);
            }
            objectsOnScene.Clear();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }


}
