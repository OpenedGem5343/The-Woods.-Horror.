using UnityEngine;

public class MonsterBoundary : MonoBehaviour
{
    private Terrain terrain;

    private void Start()
    {
        // Получаем компонент террейна
        terrain = Terrain.activeTerrain;
    }

    private void LateUpdate()
    {
        // Получаем текущую позицию монстра
        Vector3 monsterPosition = transform.position;

        // Получаем высоту террейна в данной точке
        float terrainHeight = terrain.SampleHeight(monsterPosition);

        // Если высота монстра меньше высоты террейна, устанавливаем его на высоту террейна
        if (monsterPosition.y < terrainHeight)
        {
            monsterPosition.y = terrainHeight;
        }

        // Устанавливаем позицию монстра
        transform.position = monsterPosition;
    }
}
