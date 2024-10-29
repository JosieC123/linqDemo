﻿using System.Text.Json;

// deserialize mario json from file into List<Mario>
List<Character> dks = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("dk.json"))!;
// deserialize mario json from file into List<Mario>
List<Character> marios = JsonSerializer.Deserialize<List<Character>>(File.ReadAllText("mario.json"))!;
// combine all characters into 1 list
List<Character> characters = [];
characters.AddRange(dks);
characters.AddRange(marios);

// display all characters
// foreach(Character character in characters)
// {
//   Console.WriteLine(character.Display());
// }
Console.Clear();

// display first character
// Console.WriteLine(characters.First().Display());
// display the first 5 characters
// foreach(Character character in characters.Take(5))
// {
//   Console.WriteLine(character.Display());
// }
// // display every character except the first 5
// foreach(Character character in characters.Skip(5))
// {
//   Console.WriteLine(character.Display());
// }
// // display characters 6-10
// foreach(Character character in characters.Skip(5).Take(5))
// {
//   Console.WriteLine(character.Display());
// }
// display last character
// Console.WriteLine(characters.Last().Display());
// first year character created
// Console.WriteLine(characters.Min(c => c.YearCreated));
// oldest character
// Console.WriteLine(characters.First(c => c.YearCreated == characters.Min(c => c.YearCreated)).Display());

// are there any characters created in 1995?
// bool Character1995 = characters.Any(c => c.YearCreated == 1995);
// Console.WriteLine($"Are there characters created in 1995: {Character1995}");
// // how many characters were created in 1995
// Console.WriteLine($"How many? {characters.Count(c => c.YearCreated == 1995)}");
// // which characters were created in 1995 (name only)
// foreach(String? name in characters.Where(c => c.YearCreated == 1995).Select(c => c.Name))
// {
//   Console.WriteLine(name);
// }
// which characters were created in 1995 (name & description only)
// foreach(var obj in characters.Where(c => c.YearCreated == 1995).Select(c => new { c.Name, c.Description }))
// {
//   Console.WriteLine($"{obj.Name} - {obj.Description}");
// }
// // which characters were created in 1995 (name & description only)
// foreach(var obj in characters.Where(c => c.YearCreated == 1995).Select(c => new { c.Name, c.Description }).OrderBy(c => c.Name))
// {
//   Console.WriteLine($"{obj.Name} - {obj.Description}");
// }
// which characters were created in 1995
// foreach(CharacterDTO characterDTO in characters.Where(c => c.YearCreated == 1995).Select(c => new CharacterDTO{ Id = c.Id, Name = c.Name, Series = c.Series }).OrderBy(c => c.Name))
// {
//   Console.WriteLine(characterDTO.Display());
// }

// how many characters in total (all series)?
// int CharacterCount = characters.Count();
// Console.WriteLine($"There are {CharacterCount} characters in all series");
// // how many characters appear in the Mario series?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {MarioCount} characters in the Mario series");
// // how many characters appear in the Donkey Kong series?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count();
// Console.WriteLine($"There are {DkCount} characters in the Donkey Kong series");
// // how many characters appear in the Mario & Donkey Kong series?
// int DkMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkMarioCount} characters that appear in Mario and Donkey Kong series");
// // which characters (name only) appear in Mario and Donkey Kong?
// foreach(String? name in characters.Where(c => c.Series.Contains("Donkey Kong") && c.Series.Contains("Mario")).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }
// // how many characters appear in Donkey Kong and not in Mario?
// int DkNotMarioCount = characters.Where(c => c.Series.Contains("Donkey Kong") && !c.Series.Contains("Mario")).Count();
// Console.WriteLine($"There are {DkNotMarioCount} characters that appear in Donkey Kong and Not in Mario series");


// // which character(s) has/have the most alias's?
// foreach(var obj in characters.Where(c => c.Alias.Count() == characters.Max(c => c.Alias.Count())).Select(c => new {c.Name, c.Alias})){
//   Console.WriteLine($"{obj.Name} has {obj.Alias.Count()} alias(s):\n\t{String.Join(", ", obj.Alias)}");
// }
// how many letters make up the longest character name(s)
// int LengthOfName = characters.Max(c => c.Name!.Length);
// Console.WriteLine($"There are {characters.Max(c => c.Name!.Length)} letters in the longest character's name");
// // which characters have the longest name?
// foreach(string? name in characters.Where(c => c.Name!.Length == LengthOfName).Select(c => c.Name))
// {
//   Console.WriteLine($"\t{name}");
// }

// // all characters grouped by year created
// var CharactersByYearCreated = characters.GroupBy(c => c.YearCreated);
// foreach(var characterByYearCreated in CharactersByYearCreated)
// {
//   Console.WriteLine(characterByYearCreated.Key);
//   foreach(var character in characterByYearCreated) {
//     Console.WriteLine($"\t{character.Name}");
//   }
// }

// //How many character(s) were created in 1981 (all series)?
// Console.WriteLine($"How many characters were created in 1981 (all series)? {characters.Count(c => c.YearCreated == 1981)}");
// //[1.19b] List the character(s) created in that 1981 (all series) - return character name and series only.
// foreach(var obj in characters.Where(c => c.YearCreated == 1981).Select(c => new { c.Name, c.Series }))
// {
//     Console.WriteLine($"{obj.Name} - {String.Join(", ", obj.Series)}");
// }
// //[1.19c] How many character(s) were created in 1981 (Mario series)?
// int MarioCount = characters.Where(c => c.Series.Contains("Mario")).Count(c => c.YearCreated == 1981);
// Console.WriteLine($"How many characters were created in 1981 (Mario series)? {MarioCount}");
// //[1.19d] List the character(s) created in that 1981 (Mario series) - return character name only.
// foreach(var obj in characters.Where(c => c.Series.Contains("Mario") && c.YearCreated == 1981).Select(c => new {c.Name}))
// {
//     Console.WriteLine($"{obj.Name}");
// }
// //[1.19e] How many character(s) were created in 1981 (Donkey Kong series)?
// int DkCount = characters.Where(c => c.Series.Contains("Donkey Kong")).Count(c => c.YearCreated == 1981);
// Console.WriteLine($"How many characters were created in 1981 (Donkey Kong series)? {DkCount}");
// //[1.19f] List the character(s) created in that 1981 (Donkey Kong series) - return character name only.
// foreach(var obj in characters.Where(c => c.Series.Contains("Donkey Kong") && c.YearCreated == 1981).Select(c => new {c.Name}))
// {
//     Console.WriteLine($"{obj.Name}");
// }


//[1.20a] How many character(s) made their first appearance in Donkey Kong 64?
int DK64Count = characters.Where(c => c.FirstAppearance.Contains("Donkey Kong 64")).Count();
Console.WriteLine($"How many character(s) made their first appearance in Donkey Kong 64? {DK64Count}");

//[1.20b] List the character(s) that made their first appearance in Donkey Kong 64 - return character name only.
foreach(var obj in characters.Where(c => c.FirstAppearance.Contains("Donkey Kong 64")).Select(c => new {c.Name}))
{
    Console.WriteLine($"{obj.Name}");
}