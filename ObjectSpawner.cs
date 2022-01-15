using System.Collections.Generic;
using UnityEngine;

namespace Spounka
{
    public class ObjectSpawner
    {
        private readonly Vector2 xBounds, yBounds;

        public ObjectSpawner(Vector2 xBounds, Vector2 yBounds)
        {
            this.xBounds = xBounds;
            this.yBounds = yBounds;
        }

        public List<GameObject> Spawn(GameObject model, int numberToSpawn, bool randomLocation = true)
        {
            var fishes = new List<GameObject>();
            for (var i = 0; i < numberToSpawn; i++)
            {
                var position = randomLocation ? GenerateRandomLocation() : Vector2.zero;
                var @obj = Object.Instantiate(model, position, Quaternion.identity);
                fishes.Add(@obj);
            }

            return fishes;
        }

        public GameObject Spawn(GameObject model, Vector3 position)
        {
            var obj = Spawn(model, 1, false)[0];
            obj.transform.position = position;
            return obj;
        }

        private Vector2 GenerateRandomLocation()
        {
            var randomX = Random.Range(xBounds.x, xBounds.y);
            var randomY = Random.Range(yBounds.x, yBounds.y);

            return new Vector2(randomX, randomY);
        }
    }
}