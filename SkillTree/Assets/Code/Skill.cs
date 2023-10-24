using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
// Imports the SkillTree script.
using static SkillTree;

public class Skill : MonoBehaviour
{
    //Every skill will have an id to track which upgrade it is.
    public int id;

    public TMP_Text SkillTitleText;
    public TMP_Text SkillDescriptionText;

    //For marking which skills are connected to each other.
    public int[] ConnectedSkills;

    // UpdateUI method updates the skill's user interface.
    public void UpdateUI()
    {
        // Set the skill title text to show the current skill level, skill cap, and skill name.
        SkillTitleText.text = $"{skillTree.SkillLevels[id]}/{skillTree.SkillCaps[id]}\n{ SkillTree.skillTree.SkillNames[id]}";
       
        // Set the skill description text to show the skill's description and the cost in skill points.
        SkillDescriptionText.text = $"{skillTree.SkillDescriptions[id]}\nCost: {skillTree.SkillPoints}/1 SP";

        /*Change the skill's UI color based on its level and available skill points.
        Check if the current skill's level (SkillLevels[id]) is greater than or equal to its cap (SkillCaps[id).
        
        If the skill's level is at or exceeds its cap, set the color to yellow.
        If the skill's level is not at its cap, check the skill points available.
        If there is at least 1 skill point available, set the color to green.*/
        GetComponent<Image>().color = skillTree.SkillLevels[id] >= skillTree.SkillCaps[id] ? Color.yellow
            : skillTree.SkillPoints >= 1 ? Color.green : Color.white;
    }


    public void BuySkill()
    {
        // If there are not enough skill points or the skill is at its cap, do nothing and return.
        if (skillTree.SkillPoints < 1 || skillTree.SkillLevels[id] >= skillTree.SkillCaps[id])
        {
            return;
        }
        // Deduct 1 skill point, increase the skill level, and update the skill UI.
        else
        {
            skillTree.SkillPoints -= 1;
            skillTree.SkillLevels[id]++;
            skillTree.UpdateAllSkillUI();
        }
    }
}
