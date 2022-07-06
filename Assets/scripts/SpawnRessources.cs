using UnityEngine;

public class SpawnRessources : MonoBehaviour
{
    [SerializeField]
    protected GameObject[] prefabs;
    void Start()
    {
        
        for (var i = 0; i < 100; i++)
        {
            foreach (var prefab in prefabs)
            {
                GameObject instance = Instantiate(prefab, transform);

                float rotX = Random.Range(-20f,20f);
                float rotY = Random.Range(0, 360f);
                float rotZ = Random.Range(-20f,20f);
                
                float posX = Random.Range(-5f,5f);
                float posY = 1f;
                float posZ = Random.Range(-5f,5f);

                float scale = Random.Range(.75f, 1f);
                
                instance.transform.rotation = Quaternion.Euler(rotX, rotY, rotZ);            
                instance.transform.position = new Vector3(posX, posY, posZ);
                instance.transform.localScale = Vector3.one * scale;
            }
        }
    }

    
    void Update()
    {
        
    }
}
