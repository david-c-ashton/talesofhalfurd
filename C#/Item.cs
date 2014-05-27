using UnityEngine;
using System.Collections;

public struct pItem
{
	public int itemID;
	public int power;
	public int count;
	public string itemName;
	public float durability;
	public GameObject obj;
}

public class Inventory
{
	public pItem[] items = new pItem[48];
}

public struct Equipment
{
	public pItem helmet;
	public pItem chestpiece;
	public pItem belt;
	public pItem leggings;
	public pItem boots;
	public pItem gauntlets;
	public pItem ring1;
	public pItem ring2;
	public pItem ring3;
	public pItem ring4;
	public pItem necklace;
	public pItem weapon;
	public pItem offhand;
	public pItem ammo;
}

public static class getItemBy
{
	public static pItem id(int itemID)
	{
		/*
		 * @TODO
		 * Write method to read file to get item by ID
		 */
		return new pItem();
	}
}

public class Item
{
	public pItem item;

	/* ######### ITEM ID ######### */

	/**
	 ** @PARAM id : int #itemId
	 **/
	public void setItemID(int id)
	{
		this.item.itemID = id;
	}

	public int getItemID()
	{
		return this.item.itemID;
	}

	/* ######### ITEM POWER ######### */

	/**
	 ** @PARAM p : int #power
	 **/
	public void setItemPower(int p)
	{
		this.item.power = p;
	}

	public int getItemPower()
	{
		return this.item.power;
	}

	/* ######### ITEM COUNT ######### */

	/**
	 ** @PARAM c : int #count
	 **/
	public void setItemCount(int c)
	{
		this.item.count = c;
	}

	public int getItemCount()
	{
		return this.item.count;
	}

	/* ######### ITEM NAME ######### */

	/**
	 ** @PARAM name : string #itemName
	 **/
	public void setItemName(string name)
	{
		this.item.itemName = name;
	}

	public string getItemName()
	{
		return this.item.itemName;
	}

	/* ######### ITEM DURABILITY ######### */

	/**
	 ** @PARAM dur : float #durability
	 **/
	public void setItemDurability(float dur)
	{
		this.item.durability = dur;
	}

	public float getItemDurability()
	{
		return this.item.durability;
	}

	/* ######### ITEM OBJECT ######### */

	/**
	 **	@PARAM o : GameObject #itemObject
	 **/
	public void setItemObject(GameObject o)
	{
		this.item.obj = o;
	}
	
	public GameObject getItemObject()
	{
		return this.item.obj;
	}
	
	/* ######### ITEM ######### */

	/**
	 ** @PARAM i : pItem #itemStruct
	 **/
	public void setItem(pItem i)
	{
		this.item = i;
	}

	public pItem getItem()
	{
		return this.item;
	}

	// #### DEBUG SYSTEM #### //
	public void debug()
	{
		Debug.Log (item.durability.ToString ());
		Debug.Log (item.itemID.ToString ());
		Debug.Log (item.itemName);
		Debug.Log (item.obj.tag.ToString ());
		Debug.Log (item.power.ToString ());
	}
}
