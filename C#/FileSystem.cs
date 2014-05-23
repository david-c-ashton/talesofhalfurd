using UnityEngine;
using System.IO;
using System.Collections;

public static class FS
{	
	/*
	 * @param filePath #path + filename
	 */
	public static string[] readFile(string filePath)
	{
		return File.ReadAllText(filePath).Split(',');
	}

	public static pItem FindItemBy(string[] item, string type)
	{
		return new pItem ();
	}
}
