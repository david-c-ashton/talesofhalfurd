using UnityEngine;
using System.Collections;

public struct pNPC 
{
	public int pId;
	public int action;
	public GameObject obj;
}

public class NPC
{
	public pNPC npc;

	public void setNpcId(int id)
	{
		this.npc.pId = id;
	}

	public int getNpcId()
	{
		return this.npc.pId;
	}

	public void setNpcAction(int a)
	{
		this.npc.action = a;
	}

	public int getNpcAction()
	{
		return this.npc.action;
	}

	public void setNpcObj(GameObject o)
	{
		this.npc.obj = o;
	}

	public GameObject getNpcObj()
	{
		return this.npc.obj;
	}
}
