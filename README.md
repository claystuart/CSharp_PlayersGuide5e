# C#PlayersGuide5e
A Walkthrough of the "C# Player's Guide, Fifth Edition" by RB Whitaker.

## Projects
### Level 1: Intro to .Net - n/a
### Level 2: Intro to Visual Studio - n/a
### Level 3: Compiling "Hello World"
1. Consolas and Telim (p26): Basic I/O
### Level 4: Comments
1. The Thing Namer 3000 (p31): Comments and code cleanup
### Level 5: Basic variable usage - n/a
### Level 6: C# Types - substitute project (convert string -> int)
1. Clay's Converter (no page#): Convert string->int with multiple methods
### Level 7: Math
1. The Triangle Farmer (p53): calculate area of triangle
1. The Four Sisters and the Duckbear (p56): Using modulo operator
1. The Dominion of Kings (p57): Multiple inputs
### Level 8: Console Input (Advanced)
1. Defense of Consolas (p68): Text game to surround Blimp attacking city
### Level 9: Conditionals
1. Repairing the Clocktower (p75): "Tick/Tock" on even/odd numbers.
1. Watchtower (p78): Calculate coordinates for (x,y) from 3x3 grid.
### Level 10: Switches
1. Buying Inventory (p82): Use Switch to display Inventory prices
1. Discounted Inventory (p83): Ask user their name and apply 50% discount if name==user

## Lessons Learned for [dotnet cli](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-new)
1. `dotnet new console -n <new projct name>` - create new project
1. `dotnet sln list` - list all projects
1. `dotnet run` - runs project in current directory
1. `dotnet run --project <project name> (e.g. helloWorld)` - run specific project
1. `dotnet sln add <new_project.csproj` - add new project to solution (e.g. `dotnet sln add .\Lvl10_Switches\Lvl10_Switches.csproj`) from main Solution Directory
## Lessons learned Syncronizing code in Git
1. If I make a new project is VSCode and push it to Github, I must still add it as a new (existing) 
project in Visual Studio using `Add -> Existing Project...` in Solution Explorer.




