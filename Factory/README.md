# Factory Pattern
It defines an interface for creating an object, but let subclass decide which class to instantiate.
Factory Methos lets a class defer instantiation to subclass. 

# When to use
- When we don't know which class (exactly subclass) to instantiate. If we would have known at the compile time, we would have passed the Interfaces as dependency injection like we have done in Strategy pattern.
- When class initialization is complex and depends on multiple outside factor. 
- Encapsulate the whole logic of subclass initialization into a factory class so that we can use the same logic everywhere. Hence eliminate potential duplicate code.


# Example
- Instantiate a command type class in SRMS
- Pizza factory
- Randomise generation of obstacles in games for different levels


# Sources
- Book: Head First Design Pattern
- Youtube: Design Pattern series by [Christopher Okhravi](https://www.youtube.com/watch?v=v9ejT8FO-7I&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc)
