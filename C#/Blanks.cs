using UnityEngine;
using System.Collections;

public static class Blanks
{
	public static Equipment defaultHumanEQ(int pClass, mSEX gender)
	{
		Equipment equipment = new Equipment();

		switch (pClass) 
		{
		case 0:
			pItem wSword = new pItem();
			wSword.itemID = 1;
			wSword.itemName = "Wooden Sword";
			equipment.weapon = wSword;
			break; 
		default:
			break;
		}
		/*
		 * @TODO
		 * Write method to generate default items
		 */
		return equipment;
	}
	
	public static pStat createStats(int[] s)
	{
		pStat stats = new pStat();
		if(s.Length != 7) {
			stats.intelligence = 10;
			stats.strength = 10;
			stats.constitution = 10;
			stats.agility = 10;
			stats.speed = 10;
			stats.charisma = 10;
			stats.wisdom = 10;
		} else {
			stats.intelligence = s[0];
			stats.strength = s[1];
			stats.constitution = s[2];
			stats.agility = s[3];
			stats.speed = s[4];
			stats.charisma = s[5];
			stats.wisdom = s[6];
		}
		return stats;
	}
}
