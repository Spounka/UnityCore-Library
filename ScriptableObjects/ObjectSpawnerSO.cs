using UnityEngine;

namespace Spounka.Core
{
    [CreateAssetMenu(fileName = "ObjectSpawner", menuName = "Systems/Spawner")]
    public class ObjectSpawnerSO : ScriptableObject
    {
        public GameObject SpawnObject(GameObject model, Vector3 location)
        {
            var obj = Instantiate(model);
            obj.transform.position = new Vector3(location.x, location.y, location.z);
            return obj;
        }
    }
}