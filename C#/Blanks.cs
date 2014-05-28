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
		List<string> lines = FS.readFile("files/items.csv");

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
			//string objKey = "/items/obj/" + nItem.itemName + ".obj";
			//nItem.obj = (GameObject)Resources.Load (objKey, typeof(GameObject));
			i.Add (nItem.itemName, nItem);
		}
		return i;
	}

	public static pItem getItemByName(string itemName)
	{
		return (pItem)CSV.items[itemName];
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
			equipment.weapon = CSV.getItemByName("Wooden Sword");
			equipment.chestpiece = CSV.getItemByName("Leather Armor");
			equipment.boots = CSV.getItemByName("Leather Boots");
			equipment.belt = CSV.getItemByName("Leather Belt");
			equipment.gauntlets = CSV.getItemByName("Leather Gloves");
			equipment.helmet = CSV.getItemByName("Leather Cap");
			equipment.leggings = CSV.getItemByName("Leather Pants");
			equipment.offhand = CSV.getItemByName("Wooden Shield");
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
