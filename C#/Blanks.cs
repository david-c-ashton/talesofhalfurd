using UnityEngine;
using System.Collections;

public static class Blanks
{
	public static Equipment defaultWarriorEQ(int pClass)
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
}
