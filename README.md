# Similar-Resolution-Calculator
This calculator finds similar resolutions to the one inputted using the inputted resolution's aspect ratio

![Screenshot1](https://user-images.githubusercontent.com/107563368/198918003-3cc5aaab-d801-4818-8b06-11916987109c.PNG)

![Screenshot2](https://user-images.githubusercontent.com/107563368/198918027-f78f5b9a-ff12-4963-9c08-5133737e223c.PNG)

# How to use it?
You input the Width and Height of your resolution, the other two options are optional and will be defaulted if not chosen,  
You can use "Iterations" to specify how far it should search, you might want to set this number to your Height, as it searches  
one-by-one using the aspect ratio like:

1 * aspect ratio = width  
2 * aspect ratio = width

Over and over until it gets to your specified Iterations, each number would be a height, it checks to see if there's a valid  
width to go with it, which resolutions are valid? Any within the determined aspect ratio that aren't decimal

The default for "Iterations" is your inputted Height

The next input box "Divisible By" is covered in the next section

# How do I filter results?
"Divisible By" will only show you results divisible by your specified number, the number 1 will be used by default if there is no input

So if you only wanted resolutions in the tens, like 480, 720, 1080, 1440, it'll only show resolutions in the tens if you put 10 in "Divisible By"  

# How to modify the code myself?
This project is made within Visual Studio 2022, I do not know how well it will go in other IDEs as I've only really used Visual Studio,  

To get started:
 1. Download [Visual Studio 2022][0]
 2. Download this project as a [zip][1] and extract it to a folder, or clone the repo
 3. Open up the solution (sln file) or vbproj file  

You should now see the designer, if you see nothing once you do, click the "Similar Resolution Calculator" in the solution explorer, then select the "SimilarResCalc.vb" file and open it

The designer is where the UI is made, do not try editing the UI through the "SimilarResCalc.Designer.vb" file directly  
Coding is done in the "SimilarResCalc.vb" file, if you do not know how to access the code, right-click the form and select "View Code"  
No other files need to be changed as they are updated automatically

# How do I just build the code?
I'm not quite sure as I haven't learned that yet, I will update this once I do,  
In the meanwhile ask on online, or just follow the same instructions for modifying the code yourself

If you have any questions please feel free to ask  
Please report any issues using the [GitHub issue tracker][2].

[0]: https://visualstudio.microsoft.com/vs/community/
[1]: https://github.com/WarpZephyr/Similar-Resolution-Calculator/archive/master.zip
[2]: https://github.com/WarpZephyr/Prefabs2Blueprints/issues
