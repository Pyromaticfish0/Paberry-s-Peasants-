using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class AchievmentManager : MonoBehaviour
{

    /// <summary>
    /// A prefab used for creating a new achievment
    /// </summary>
    public GameObject achievmentPrefab;

    // Use this for initialization
    void Start()
    {
        //CreateAchievment("General", "Press W", "Press W to unlock this achievment", 10);
        // commented out because it creates the bug... To be fixed later...
    }

    // Update is called once per frame
    void Update()
    {

    }

    /// <summary>
    /// Creates an achievment
    /// </summary>
    public void CreateAchievment(string category, string title, string description, int points)
    {
        //Creates the achievment gameobject
        GameObject achievment = (GameObject)Instantiate(achievmentPrefab);

        //Makes sure that the achievment contains the correct info
        SetAchievmentInfo(category, achievment, title, description, points);

    }

    /// <summary>
    /// Fills the onscreen achievment with information
    /// </summary>
    public void SetAchievmentInfo(string category, GameObject achievment, string title, string description, int points)
    {
        //Sets the parent of the achievments
        achievment.transform.SetParent(GameObject.Find(category).transform);

        //Makes sure that it has the correct size
        achievment.transform.localScale = new Vector3(1, 1, 1);

        //Sets the information of the achievment
        achievment.transform.GetChild(0).GetComponent<Text>().text = title;
        achievment.transform.GetChild(1).GetComponent<Text>().text = description;
        achievment.transform.GetChild(2).GetComponent<Text>().text = points.ToString();

    }


}