using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using static SkillTree;

public class Skill : MonoBehaviour
{
    //Every skill will have an id to track which upgrade it is.
    public int id;

    public TMP_Text SkillTitleText;
    public TMP_Text SkillDescriptionText;

    //For marking which skills are connected to each other.
    public int[] ConnectedSkills;

    public 

    void Start()
    {
        
    }

    void Update()
    {
        
    }


    public void UpdateUI()
    {
        SkillTitleText.text = $"{skillTree.SkillLevels[id]}/{skillTree.SkillCaps[id]}\n{ SkillTree.skillTree.SkillNames[id]}";
        SkillDescriptionText.text = $"{skillTree.SkillDescriptions[id]}\nCost: {skillTree.SkillPoints}/1 SP";

        GetComponent<Image>().color = skillTree.SkillLevels[id] >= skillTree.SkillCaps[id] ? Color.yellow
            : skillTree.SkillPoints >= 1 ? Color.green : Color.white;
    }

    public void BuySkill()
    {

    }
}
