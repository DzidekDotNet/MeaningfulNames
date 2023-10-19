# Methods containing loops inside
![Methods containing loops inside](https://github.com/DzidekDotNet/MeaningfulNames/blob/main/MethodsWithLoopsInside/MethodsWithLoopsInside.jpg?raw=true)
Refactoring each loop statement to method/function is one of the easiest way to improve readability.

## Why readability is so important for us?
Many publications show that programmers spend much more time reading code than writing. If that's true, it's crucial to speed things up. This is the main reason why we should care about readability.

## How extracting a loop into separate methods can improve readability?
### While adding or modifying functions
Consider that you need to add some feature or change something...

First, you will look at where to add or change something, but you may not need to focus on the loop itself. You need to know whether this is the place you are interested in (where you will add or change something). 

If your code has methods or functions that describe how this loop works, it will be much easier for the next programmer to do their job.
### While finding bugs
If you have to fix the bugs and read the code with loops (without a description of what the intention was), it is hard to figure out whether it is good code.

But if you have a method that describes the intention and the loop, the inside has some mistakes - it is easy to fix.

## How to write code faster (refactoring to private methods)
### Rider
![ExtractMethod](https://github.com/DzidekDotNet/MeaningfulNames/blob/main/ExtractMethod2.jpg?raw=true)
