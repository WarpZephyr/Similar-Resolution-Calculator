# Similar-Resolution-Calculator
This calculator finds similar resolutions to the one inputted using the inputted resolution's aspect ratio

# How to use it?
You input the Width and Height of your resolution, the other two options are optional and will be defaulted if not chosen,
You can use "Iterations" to specify how far it should search, you might want to set this number to your Height, as it searches
one-by-one using the aspect ratio like:

1 * aspect ratio = width
2 * aspect ratio = width

Over and over until it gets to your specified Iterations, each number would be a height, it checks to see if there's a valid
width to go with it, which resolutions are valid? Any within the determined aspect ratio that aren't decimal

The next input box "Divisible By" is covered in the next section

# How do I filter results?
"Divisible By" will only show you results divisible by your specified number, the number 1 will be used by default or in the case you input
an invalid number like 0,

So if you only wanted resolutions in the tens, like 480, 720, 1080, 1440, it'll only show resolutions in the tens if you put 10 in "Divisible By"
If you have any questions please feel free to ask
