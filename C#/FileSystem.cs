using UnityEngine;
using System.IO;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public static class FS
{	
	/*
	 * @param filePath #path + filename
	 */
	public static List<string> readFile(string filePath)
	{
		List<string> lines = File.ReadAllLines (filePath).ToList();
		lines.RemoveAt (0);
		return lines;
	}

	public static pItem FindItemBy(string[] item, string type)
	{
		return new pItem ();
	}
}
