// See https://aka.ms/new-console-template for more information
string alicePar = "Alice was beginning to get very tired of sitting by her sister on the\r\nbank, and of having nothing to do: once or twice she had peeped into the\r\nbook her sister was reading, but it had no pictures or conversations in\r\nit, 'and what is the use of a book,' thought Alice 'without pictures or\r\nconversation?'";
Console.WriteLine(alicePar);
Console.WriteLine("Enter a term to search within the paragraph.");
string searchTerm = Console.ReadLine();
string searchTermLower = searchTerm.ToLower();
string aliceLower = alicePar.ToLower();
int searchIndex = aliceLower.IndexOf(searchTermLower);
string editedPar;

if (searchIndex != -1)
{
    Console.WriteLine($"Yes, {searchTerm} was found in the text at {searchIndex} and is {searchTerm.Length} characters long.\n");
    Console.WriteLine($"Here's how it looks with {searchTerm} removed: ");
    editedPar = alicePar.ToLower().Remove(searchIndex, searchTerm.Length);
    Console.WriteLine(editedPar);
}
else
{
    Console.WriteLine($"No, {searchTerm} was not found in the text.");
}