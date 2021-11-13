# Palindrone

## Description
to do

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

## Building and running program from Powerhshell
- open powershell
- `cd Palindrome/`
- `./PalindromeScript.ps1`

## Runing unit tests
- open console
- `cd Palindrome/Palindrome.Test`
- `dotnet test`
