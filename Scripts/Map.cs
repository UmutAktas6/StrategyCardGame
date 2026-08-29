using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class Map : MonoBehaviour
{
    List<Region> regions = new List<Region>();
    int mapWidth = 100;
    int mapHeight = 100;
    public GameObject regionPrefab;
    public Canvas canvas;
    void Start()
    {
        regions.Add(new Region(0, 0, mapWidth, mapHeight)); // Ana büyük 100x100 lük yeri tek bir bölge ekledim

        SplitArea();
        SplitArea();
        SplitArea();
        SplitArea();
        SplitArea();
        SplitArea();
        SplitArea();
        SplitArea();

        foreach (Region region in regions)
        {
            var regionObject = Instantiate(regionPrefab);
                regionObject.GetComponent<RectTransform>().sizeDelta = new Vector2(region.width, region.height);
                regionObject.transform.SetParent(canvas.transform, false);
                regionObject.GetComponent<RectTransform>().anchoredPosition = new Vector2(region.x, region.y);
                
                //validation
                regionObject.GetComponent<Image>().color = new Color(Random.value, Random.value, Random.value); // Rastgele renk atadým
        }
    }

    void SplitArea()
    {   
        int randomDirection = Random.Range(0, 2); // 0 for vertical, 1 for horizontal        

        if (randomDirection == 0)
        {
            var splitableRegions = regions.Where(r => r.width > 10).ToList();
            if (splitableRegions.Count == 0) return;
            var regionToSplit = splitableRegions[Random.Range(0, splitableRegions.Count)];
            SplitVertically(regionToSplit);
        }
        else
        {
            var splitableRegions = regions.Where(r => r.height > 10).ToList();
            if (splitableRegions.Count == 0) return;
            var regionToSplit = splitableRegions[Random.Range(0, splitableRegions.Count)];
            SplitHorizontally(regionToSplit);
        }
    }

    void SplitVertically(Region region)
    {
        int width = Random.Range(10 ,region.width-9);
        regions.Add(new Region(region.x, region.y, width, region.height));
        regions.Add(new Region(region.x + width, region.y, region.width - width, region.height));
        regions.Remove(region);
    }

    void SplitHorizontally(Region region)
    {
        int height = Random.Range(10, region.height-9);
        regions.Add(new Region(region.x, region.y, region.width, height));
        regions.Add(new Region(region.x, region.y + height, region.width, region.height - height));
        regions.Remove(region);
    }
}

class Region
{
    public int x;
    public int y;
    public int width;
    public int height;

    public Region(int x, int y, int width, int height)
    {
        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }
}
