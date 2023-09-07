# Strategy Pattern
Lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable. Thus Strategy lets the algorithm vary independently from the client that used it.

# When to use
- When child class doesn't want to inherit each function of Parent class.
- When child class wants to have seperate implmentations for Parent class functions and wants to override it.
- When child class wants to override parent functions and in terms of doing so, they are creating duplicate codes.
- When ading a new function to parent class breaks the Open Close Principle. Example, adding a new function to Duck class will make all the child class inherit the same function or all child classes need to override that new method.

# Sources
- Book: Head First Design Pattern
- Youtube: Design Pattern series by [Christopher Okhravi](https://www.youtube.com/watch?v=v9ejT8FO-7I&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc)
