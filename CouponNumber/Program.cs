// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
var stringChars = new char[6];
var random = new Random();

for (int i = 0; i < stringChars.Length; i++)
{
    stringChars[i] = chars[random.Next(chars.Length)];
}

var finalString = new String(stringChars);
Console.WriteLine(finalString);
