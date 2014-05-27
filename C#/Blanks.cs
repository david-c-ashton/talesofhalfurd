using UnityEngine;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public static class CSV
{
	public static Hashtable items;
	public static Hashtable enemies;
	public static Hashtable spells;

	public static Hashtable loadItems()
	{
		Hashtable i = new Hashtable ();
		List<string> lines = File.ReadAllLines ("/files/items.dat").ToList();

		foreach (string item in lines)
		{
			pItem nItem = new pItem();
			char[] splitter = {','};
			string[] data = item.Split(splitter);

			nItem.itemID = int.Parse(data[0]);
			nItem.power = int.Parse(data[1]);
			nItem.count = int.Parse(data[2]);
			nItem.itemName = data[3].ToString();
			nItem.durability = float.Parse(data[4]);
			string objKey = "/items/obj/" + nItem.itemName + ".obj";
			nItem.obj = (GameObject)Resources.Load (objKey, typeof(GameObject));

			i.Add (nItem.itemName, nItem);
		}

		return i;
	}
}

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
