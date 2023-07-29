# Observer Pattern
It defines a one to many (1:N) dependency between objects so that when one object changes state, all of its dependents are notifies and updated accordingly.

# When to use
- When the state of a class (say class A) object is changing and there are some objects who want to observe the changes made in class A everytime.
- When some objects in your app must observe others, but only for a limited time or in specific cases.
- When we want to push the every new state of class A to multiple classes

# Example
- Notification System (Publisher Subscriber Method)
- Broadcast a message to a chat group for all users or all online users.

# Sources
- Book: Head First Design Pattern
- Youtube: Design Pattern series by [Christopher Okhravi](https://www.youtube.com/watch?v=v9ejT8FO-7I&list=PLrhzvIcii6GNjpARdnO4ueTUAVR9eMBpc)
