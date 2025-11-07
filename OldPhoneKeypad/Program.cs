using OldPhoneKeypad.Services;

Console.WriteLine("Enter keypad input (end with #):");
string? input = Console.ReadLine();

string output = OldPhoneService.ConvertInput(input ?? "");
Console.WriteLine($"Output: {output}");
