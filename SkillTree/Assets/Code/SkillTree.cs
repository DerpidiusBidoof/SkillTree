using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTree : MonoBehaviour
{
    public static SkillTree skillTree;
    private void Awake() => skillTree = this;

    public int[] SkillLevels;
    public int[] SkillCaps;
    public string[] SkillNames;
    public string[] SkillDescriptions;

    public List<Skill> SkillList;
    public GameObject SkillHolder;


    public float SkillPoints;

    private void Start()
    {
        // At the start of the game, initialize the player's skill points to 20.
        SkillPoints = 20;

        // Create an array named SkillLevels to keep track of the levels of skills. It has 6 slots.
        SkillLevels = new int[6];

        // SkillCaps sets the maximum level each skill can reach (e.g., skill 1 can only reach level 1, skill 2 can go up to level 5).
        SkillCaps = new int[] {1,5,5,2,10,10 };

        SkillNames = new[] {"Upgrade 1", "Upgrade 2", "Upgrade 3", "Upgrade 4", "Booster 5", "Booster 6", };
        SkillDescriptions = new[]
        {
            "Does a  thing",
            "Does a cool thing",
            "Does an awesome thing",
            "Does this math thing",
            "Does this compounding thing",
        };

        // This loop goes through all the "Skill" objects found within the "SkillHolder" game object and adds them to the SkillList.
        foreach (var skill in SkillHolder.GetComponentsInChildren<Skill>()) SkillList.Add(skill);
    }
}