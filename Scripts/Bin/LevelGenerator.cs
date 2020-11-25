using UnityEngine;

public class LevelGenerator : MonoBehaviour {

	public Texture2D map;
	public Texture2D map2;
	public Texture2D map3;
	public Texture2D map4;
	public Texture2D map5;


	public ColorToPrefab[] colorMappings;

	void Start () {
		GenerateLevel();
		AstarPath.active.Scan();
	
	}

	void GenerateLevel ()
	{
		for (int x = 0; x < map.width; x++)
		{
			for (int y = 0; y < map.height; y++)
			{
				GenerateTile(x, y);
			}
		}
	}

	void GenerateTile (int x, int y)
	{
		Color pixelColor = map.GetPixel(x, y);

		if (pixelColor.a == 0) // checks if the pixel is transparant 
		{
			
			return;
		}

		foreach (ColorToPrefab colorMapping in colorMappings)
		{
			if (colorMapping.color.Equals(pixelColor))
			{
				Vector2 position = new Vector2(x, y);
				Instantiate(colorMapping.prefab, position, Quaternion.identity, transform);
			}
		}
	}
}
