﻿using Directory = Composite.Directory;
using File = Composite.File;

Console.Title = "Composite";

var root = new Directory("root",0);
var topLevelFile = new File("toplevel.txt",100);
var topLevelDirectory1 = new Directory("topleveldirectory1",4);
var topLevelDirectory2 = new Directory("topleveldirectory2", 4);

root.Add(topLevelFile);
root.Add(topLevelDirectory1);
root.Add(topLevelDirectory2);

var subLevelFile1 = new File("sublevel1.txt",200);
var subLevelFile2 = new File("sublevel2.txt", 150);

topLevelDirectory2.Add(subLevelFile1);
topLevelDirectory2.Add(subLevelFile2);

Console.WriteLine($"Size of topleveldirectory1: {topLevelDirectory1.GetSize()}");
Console.WriteLine($"Size of topleveldirectory2: {topLevelDirectory2.GetSize()}");
Console.WriteLine($"Size of root: {root.GetSize()}");

Console.ReadKey();