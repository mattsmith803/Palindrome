# Palindrone

## Description
Palindrome is a console application that takes an input of a paragraph and prints the following to the console:
- Number of palindrome words in paragraph
- Number of palindrome sentences in paragraph
- List of unique words in the paragraph and their respective counts
- Finds the words in a paragraph that contain a given letter

## Dependencies:
- [.NET 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Powershell](https://docs.microsoft.com/en-us/powershell/scripting/install/installing-powershell?view=powershell-7.2)

## Assumptions:
- A Sentence is defined as a combination of strings that is terminated by a period and a space
- A unique word is defined as a string with only alphanumeric symbols (no questions marks, periods, quotes, etc)
- A palindrone sentence is defined as the letters without whitespace and non-alphanumeric symbols are the same forwards and backwards

## Setup
- Install [Dependencies](#Dependencies)
- clone repo via your preferred method. IE.
    - `git clone https://github.com/mattsmith803/Palindrome.git`
    - `git clone git@github.com:mattsmith803/Palindrome.git`

## Building and running program from Powershell
- `cd Palindrome/`
- `./PalindromeScript.ps1`

## Running unit tests
- `cd Palindrome/Palindrome.Test`
- `dotnet test`
